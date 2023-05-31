using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{
    public class Car
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        public string ID { set; get; } //Indetifcator global unic
        public double Balance { set; get; }
        public CarType TypeofCar { set; get; } //TIpul masinei
        public enum CarType { Undefined, Family, Bus, Truck, Moto }
        public Car()
        {
            this.ID = null;
            this.Balance = 0;
            this.TypeofCar = CarType.Undefined;
        }
        public Car(string ID, double balance, CarType type)
        {
            this.ID = ID;
            this.Balance = balance;
            this.TypeofCar = type;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectCARPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                ID,
                Balance.ToString(),
                (TypeofCar));

            return obiectCARPentruFisier;
        }
        public Car(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            ID = dateFisier[0];
            Balance = Double.Parse(dateFisier[1]); ;
            TypeofCar = (CarType)Enum.Parse(typeof(CarType), dateFisier[2]);
        }
        public string Info()
        {
            string info = $"Id:{ID,5} :{Balance} TIpul: {TypeofCar}";
            return info;
        }
    }
}
