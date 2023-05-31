using Parcare;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms.Forms
{
    
    public partial class FormRemove : Form
    {
        AdministrareMasini_FisierText adminCar;
        private string ID;
        public FormRemove()
        {
            InitializeComponent();
            string locatieFisierSolutie = Path.Combine(Application.StartupPath, "NumeFisier.txt");
            adminCar = new AdministrareMasini_FisierText(locatieFisierSolutie);
            Car[] cars = adminCar.GetCars(out int nrCars);
            
        }
        private void LoadTheme()
        {
            panel1.BackColor = ThemeColor.secondaryColor;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text.ToUpper();

            // Verifică dacă mașina există în fișier
            Car carToDelete = adminCar.GetCar(ID);
            if (carToDelete != null)
            {
                // Șterge mașina din fișier
                adminCar.DeleteCarFisier(ID);

                // Verifică și șterge fișierul de imagine asociat mașinii
                string imagePath = Path.Combine("C:\\Users\\grati\\Desktop\\PIU\\PROIECT\\Parcare\\pozecars", ID + ".jpg");
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }

                MessageBox.Show("Mașina a fost ștearsă din fișier.", "Ștergere reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Mașina nu a fost găsită în fișier.", "Eroare ștergere", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetareControale();
        }
        private void ResetareControale()
        {
            txtID.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadTheme();
        }
    }
}
