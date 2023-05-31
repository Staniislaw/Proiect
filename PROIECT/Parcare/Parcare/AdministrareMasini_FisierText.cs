using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{
    public class AdministrareMasini_FisierText
    {
        private int NR_MAX_LOCURI = Settings.ParkingSpace;
        private string numeFisier;
        /*private string caleDirector = @"C:\Users\grati\Desktop\PIU\Proiect Parcare\Parcare\bin\Debug";
        public AdministrareMasini_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(Path.Combine(caleDirector, numeFisier), FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        */

        public AdministrareMasini_FisierText(string numeFisier)
        {
            string caleFisier = Path.Combine(Environment.CurrentDirectory, "C:\\Users\\grati\\Desktop\\PIU\\PROIECT\\Parcare\\InterfataUtilizator_WindowsForms\\bin\\Debug", numeFisier);
            this.numeFisier = caleFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }


        public void AddCarFisier(Car car)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {   
                streamWriterFisierText.WriteLine(car.ConversieLaSir_PentruFisier());
            }
        }
        public void DeleteCarFisier(string ID)
        {
            string[] allLines = File.ReadAllLines(numeFisier);
            List<string> updatedLines = new List<string>();

            foreach (string line in allLines)
            {
                Car car = new Car(line);
                if (car.ID != ID)
                {
                    updatedLines.Add(line);
                }
            }

            File.WriteAllLines(numeFisier, updatedLines);
        }
        public Car[] GetCars(out int nrCars)
        {
            Car[] cars = new Car[NR_MAX_LOCURI];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrCars = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    cars[nrCars++] = new Car(linieFisier);
                }
            }
            // Verificăm dacă nrCars este 0, adică fișierul este gol
            if (nrCars == 0)
            {
                return new Car[0];
            }
            // Dacă nrCars nu este 0, atunci returnăm vectorul cu obiecte Car
            // cu dimensiunea corectă, adică nrCars
            Array.Resize(ref cars, nrCars);
            return cars;
        }
        public Car GetCar(string ID)
        {

            int nrCars;
            Car[] cars = GetCars(out nrCars);


            for (int i = 0; i < nrCars; i++)
            {
                if (cars[i].ID == ID)
                {
                    return cars[i]; // am gasit masina cautata
                }
            }

            return null; // nu am gasit masina cautata
        }
    }
}
