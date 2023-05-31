using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{
    static class Settings
    {

        public static int Timeout { get; } = 3;
        //dictionar pentru stocarea pretului pentru 1 loc de  parcare
        public static Dictionary<Car.CarType, int> Tarif { get; } = new Dictionary<Car.CarType, int>
            {
               { Car.CarType.Truck ,       5 },
               { Car.CarType.Family,       2 },
               { Car.CarType.Bus ,         3 },
               { Car.CarType.Moto ,        1 }
            };

        // ParkingSpace- Nr total de locuri in parcare
        public static int ParkingSpace { get; } = 100;


    }
}
