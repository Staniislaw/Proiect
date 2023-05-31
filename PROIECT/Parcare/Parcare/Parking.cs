using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime;
    using System.Security.AccessControl;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    namespace Parcare
    {
        class Parking
        {

            public List<Car> Cars { get; set; }//lista masinii
            public List<Tranzactii> Trans { get; private set; }//lista Tranzactii
            public int ParkingBalance { get; private set; }//fondul parcare
           
            public int TimeOut { get; }
            public Dictionary<Car.CarType, int> Tarif { get; }//tarif
            public int ParkingSpace { get; set; }//nr de locuri

            public Parking()
            {
                this.Cars = new List<Car>();
                this.Trans = new List<Tranzactii>();
                this.TimeOut = Settings.Timeout;
                this.Tarif = Settings.Tarif;
                this.ParkingSpace = Settings.ParkingSpace;

                //începem să scădem fonduri la fiecare 3 minute
                //Incepem
                Task.Run(() => WithdrawTransaction(1 * 1 * TimeOut));
                //Task.Run()" asigura că această metoda va fi apelată periodic la intervale specificate de 3 minute
                //scade fondurile de la fiecare masina parcata dupa un anumit interval de timp
            }

            //adăugăm mașina la parcare
            public void AddCar(Car car)
            {

                if (ParkingSpace >= 1)
                {
                    Cars.Add(car);
                    ParkingSpace--;
                }
            }
            //ridicm mașina din parcare
            public int RemoveCar(string userInput)
            {
                try
                {
                    Car removeCar = Cars.Find(x => x.ID.Equals(userInput));
                    if (removeCar.Balance > 0)
                    {
                        Cars.Remove(removeCar);
                        ParkingSpace++;
                        return 1;
                    }
                    else
                    {

                        return 2;
                    }
                }
                catch
                {

                    return 3;
                }
            }
            //retragerea fondurilor
            public async void WithdrawTransaction(int delay)

            {
                while (true)
                {
                    if (Cars.Count > 0)

                    {
                        foreach (var car in Cars)
                        {
                            int tarif = 0;
                            switch (car.TypeofCar)
                            {
                                case Car.CarType.Family:
                                    tarif = Tarif[Car.CarType.Family];
                                    break;
                                case Car.CarType.Bus:
                                    tarif = Tarif[Car.CarType.Bus];
                                    break;
                                case Car.CarType.Truck:
                                    tarif = Tarif[Car.CarType.Truck];
                                    break;
                                case Car.CarType.Moto:
                                    tarif = Tarif[Car.CarType.Moto];
                                    break;

                                default:
                                    break;
                            }
                            car.Balance = car.Balance - tarif;
                            ParkingBalance = ParkingBalance + tarif;

                            Tranzactii transaction = new Tranzactii(DateTime.Now, car.ID, tarif);
                            Trans.Add(transaction);
                        }
                    }
                    await Task.Delay(delay);
                    //aștepta un anumit interval de timp specificat de variabila "delay"
                    //utilizând "await" împreună cu "Task.Delay()"vom asigura că fondurile pentru fiecare mașină parcată în parcare vor fi actualizate periodic în mod asincron
                }
              

            }
            public bool ShowCarBalance(out string balanceStr, Car _Car)
            {
                try
                {

                    balanceStr = _Car.Balance.ToString();
                    return true;
                }
                catch
                {
                    balanceStr = "";
                    return false;
                }
            }
            //incarcare soldul mașinii
            public bool RefillCarBalance(out string refillSumSTR, out string balanceStr, Car _Car, int refillSum)
            {
                try
                {
                    _Car.Balance += refillSum;
                    refillSumSTR = refillSum.ToString();
                    balanceStr = _Car.Balance.ToString();
                    return true;
                }
                catch
                {
                    refillSumSTR = "";
                    balanceStr = "";
                    return false;
                }
            }

            //Soldul parcarii
            public int ShowParkingBalance()
            {
                return this.ParkingBalance;
            }
            //Locuri in parcare
            public int ShowParkingSpace()

            {

                return this.ParkingSpace;
            }
            public List<string> DisplayCars()
            {
                List<string> carList = new List<string>();

                if (Cars.Count == 0)
                {
                    carList.Add("Nu sunt masini Parcate.");
                }
                else
                {
                    foreach (var car in Cars)
                    {
                        string carInfo = $"-{car.TypeofCar} {car.ID} {car.Balance}";
                        carList.Add(carInfo);
                    }
                }
                return carList;
            }
        }
    }
}
