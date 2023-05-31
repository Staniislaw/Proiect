using Parcare.Parcare;

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Parcare
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string numeFisier = "NumeFisier.txt";
            AdministrareMasini_FisierText adminCar = new AdministrareMasini_FisierText(numeFisier);
            Parking parking = new Parking();
            Car car = new Car();
            Car[] car1 = adminCar.GetCars(out int nrcars);
            string optiune;
            do
            {
                Console.Clear();
                Console.WriteLine("I.Citire o masina si introducerea in parcare");
                Console.WriteLine("R.Ridicare masina din parcare");
                Console.WriteLine("K.Afisare tuturor masinilor!!");
                Console.WriteLine("N.Afisare sold-ul unei masini");
                Console.WriteLine("E.Reincarcare sold-ul unei masini");
                Console.WriteLine("Q.Afisare venitul  Parcarii");
                Console.WriteLine("A.Afișăm numărul de locuri disponibile si ocupate");
                Console.WriteLine("S.Salvare in fisier");
                Console.WriteLine("O.Cautare masina dupa Nr de inmatriculare din fisier");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        if (parking.ParkingSpace >= 1)
                        {
                            ConsoleKeyInfo keyPressed;
                            Console.Clear();
                            Console.WriteLine("Alegeti tipul:");
                            Console.WriteLine("==========================");
                            Console.WriteLine("1.Family car");
                            Console.WriteLine("2.Motorcycle");
                            Console.WriteLine("3.Bus");
                            Console.WriteLine("4.Truck");
                            Console.WriteLine("==========================");
                            keyPressed = Console.ReadKey();
                            Car.CarType cartype = Car.CarType.Undefined;
                            switch (keyPressed.Key)
                            {
                                case ConsoleKey.D1:
                                    cartype = Car.CarType.Family;
                                    break;
                                case ConsoleKey.D2:
                                    cartype = Car.CarType.Moto;
                                    break;
                                case ConsoleKey.D3:
                                    cartype = Car.CarType.Bus;
                                    break;
                                case ConsoleKey.D4:
                                    cartype = Car.CarType.Truck;
                                    break;
                                case ConsoleKey.Escape:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Din păcate, acest tip de mașină nu există");
                                    Console.WriteLine("apasa orice tasta");
                                    Console.ReadKey();
                                    continue;
                            }
                            Console.WriteLine("Introduceți numărul de înmatriculare al mașinii:ex:SV98GTM");
                            string id = Console.ReadLine().ToUpper();
                            Console.WriteLine("Introduceți suma de bani disponibilă pe contul mașinii:");
                            double balance = Convert.ToDouble(Console.ReadLine());
                            car = new Car(id, balance, cartype);

                            parking.AddCar(car);
                            Console.WriteLine("Mașina a fost adăugată cu succes!");
                        }
                        else { Console.WriteLine("Nu exista Spatiu!!!"); Console.ReadLine(); }
                        break;
                    case "K":
                        Console.Clear();
                        List<string> carList = parking.DisplayCars();
                        foreach (string carInfo in carList)
                        {
                            Console.WriteLine(carInfo);
                        }
                        //Console.WriteLine(car1[0].ID);
                        Console.ReadLine();
                        break;
                    case "R":
                        Console.Clear();
                        Console.WriteLine("Care este numărul mașinii tale :Ex SV98GTM?");
                        string userInput = Console.ReadLine().ToUpper();
                        int removeSuccess = parking.RemoveCar(userInput);
                        if (removeSuccess == 1)
                        {
                            Console.WriteLine("Mașina a fost eliminată din parcare cu succes!");
                        }
                        else if (removeSuccess == 2)
                        {
                            Console.WriteLine("Nu vă puteți ridica mașina din lipsă de fonduri la sold!");
                            Console.WriteLine("Mai întâi, completați soldul mașinii și încercați din nou");
                        }
                        else
                        {
                            Console.WriteLine("O astfel de mașină nu este în parcare");
                        }
                        Console.ReadLine();
                        break;

                    case "Q":
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("În acest moment, venitul din parcare este de {0} Lei.", parking.ShowParkingBalance());
                        Console.ReadLine();
                        break;
                    case "N":
                        Console.Clear();
                        Console.WriteLine("Care este numarul automobilului dumnvoastra ex:SV98GTM?");
                        string balanceStr;
                        string userInput2 = Console.ReadLine().ToUpper();
                        Car _Car1 = parking.Cars.Find(x => x.ID.Equals(userInput2));
                        bool showSuccess = parking.ShowCarBalance(out balanceStr, _Car1);
                        if (showSuccess)
                        {
                            Console.WriteLine("Soldul automobilului dumneavostra este {0} Lei.", balanceStr);
                        }
                        else
                        {
                            Console.WriteLine("Din păcate, nu avem o astfel de mașină parcata aici");

                        }
                        Console.Read();
                        break;
                    case "E":
                        Console.Clear();
                        Console.WriteLine("Care este numarul automobilului dumneavoastra: exemplu 98GTM?");
                        string userInput1 = Console.ReadLine().ToUpper();
                        Car _Car = parking.Cars.Find(x => x.ID.Equals(userInput1));
                        Console.WriteLine("Introduceti suma de reîncărcare:");
                        int refillSum = Int32.Parse(Console.ReadLine());
                        string refillSumSTR;
                        string balanceStr1;
                        if (parking.RefillCarBalance(out refillSumSTR, out balanceStr1, _Car, refillSum))
                        {
                            Console.WriteLine("Ati introdus {0} Lei. ", refillSumSTR);
                            Console.WriteLine("Soldul mașinii tale {0} Lei. ", balanceStr1);
                        }
                        else
                        {
                            Console.WriteLine("Din păcate, nu avem o astfel de mașină parcata aici");
                            Console.WriteLine("Apasati orice tasta..");
                            Console.ReadLine();
                        }
                        break;
                    case "A":
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Există în prezent {0} locuri libere disponibile", parking.ShowParkingSpace());
                        Console.WriteLine("Nr locuri ocupate: {0}", Settings.ParkingSpace - parking.ParkingSpace);
                        Console.ReadKey();
                        break;
                    case "S":
                        //parking.Addfisier(id, balance, cartype);
                        adminCar.AddCarFisier(car);
                        break;
                    case "Z":
                        adminCar.DeleteCarFisier("sv98gtm");
                        break;
                    case "O":
                        Console.WriteLine("Introduceti Nr de inmatriculare a masinii:");
                        string ID1 = Console.ReadLine().ToUpper();
                        Car masinacautata = adminCar.GetCar(ID1);
                        if (masinacautata != null)
                        {
                            Console.WriteLine("Masina cautat este:");
                            Console.WriteLine(masinacautata.Info());
                        }
                        else
                        {
                            Console.WriteLine("Nu exista niciun masina cu numarul de inmatriculare:  {0} ", ID1);
                        }
                        Console.Read();
                        break;
                }
            } while (optiune.ToUpper() != "X");
        }
    }
}
