using Parcare;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Parcare.Car;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InterfataUtilizator_WindowsForms.Forms
{
    public partial class FormADD : Form
    {

        AdministrareMasini_FisierText adminCar;

        private string ID;
        private string Sold;

        public FormADD()
        {
            InitializeComponent();

            string locatieFisierSolutie = Path.Combine(Application.StartupPath, "NumeFisier.txt");
            adminCar = new AdministrareMasini_FisierText(locatieFisierSolutie);
            Car[] cars = adminCar.GetCars(out int nrCars);
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondaryColor;
                }
            }
            btnImage.BackColor = ThemeColor.primaryColor;
            btnImage.ForeColor = Color.White;
            btnImage.FlatAppearance.BorderColor = ThemeColor.secondaryColor;
            panel1.BackColor = ThemeColor.primaryColor;
            panel2.BackColor = ThemeColor.secondaryColor;
            panel3.BackColor = ThemeColor.primaryColor;
            panel4.BackColor = ThemeColor.secondaryColor;

        }
        private void FormCars_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string carId = txtID.Text.ToUpper();
            if (carExista(carId) || carId==string.Empty)
            {
                btnImage.Enabled = false;
            }
            else
            {
                btnImage.Enabled = true;
            }
        }

        private void txtSOLD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ID = txtID.Text.ToUpper();
            Car[] carss = adminCar.GetCars(out int nrCars);
            // Tip = txtTip.Text;
            Sold = txtSOLD.Text;
            double soldValue;
            CarType carType=GetCarTypess();
            Double.TryParse(Sold, out soldValue);
            int errorCode = ValidateInput(ID, Sold);
            if (errorCode == 0 )
            {
                Car c = new Car(ID, soldValue, carType);
                adminCar.AddCarFisier(c);
                ResetareControale();

            }
            else
            {
                MessageBox.Show("Introduceți informațiile corecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SelectedImagePath1 = null;

        }
        private int ValidateInput(string ID, string Sold)
        {
            int errorCode = 0;
           
            if (string.IsNullOrEmpty(ID) || carExista(ID))
            {
                lblID.ForeColor = Color.Red;
                errorCode = 1;
            }
            else if (ID.Length > 7 || ID.Length < 5)
            {
                lblID.ForeColor = Color.Red;
                errorCode = 2;
            }
            else
            {
                lblID.ForeColor = Color.White;
            }

            if (string.IsNullOrEmpty(Sold))
            {
                lblSold.ForeColor = Color.Red;
                errorCode = 5;
            }
            else
            {
                lblSold.ForeColor = Color.White;
            }

            // Verificați dacă imaginea nu a fost selectată
            if (string.IsNullOrEmpty(SelectedImagePath1))
            {
                lblImage.ForeColor = Color.Red;
                errorCode = 6;
            }
            else
            {
                lblImage.ForeColor = Color.White;
            }


            return errorCode;
        }

        private string SelectedImagePath1 { get; set; }
        private void btnImage_Click(object sender, EventArgs e)
        {
            Car[] carss = adminCar.GetCars(out int nrCars);  
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fișiere imagine (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Selectați o imagine";
           
                 if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    string fileName = txtID.Text + ".jpg";
                    string destinationPath = Path.Combine("C:\\Users\\grati\\Desktop\\PIU\\PROIECT\\Parcare\\pozecars\\", fileName);
                    File.Copy(imagePath, destinationPath, true);
                    // Setarea caii imaginii selectate în proprietatea SelectedImagePath
                    SelectedImagePath1 = destinationPath;
                }
            

        }
        private void ResetareControale()
        {

            txtID.Text = txtSOLD.Text = string.Empty;
            rdnBus.Checked = false;
            rdnFamily.Checked = false;
            rdnMoto.Checked = false;
            rdnTruck.Checked = false;
        }
        
            private CarType GetCarTypess()
        {
            if (rdnBus.Checked)
                return CarType.Bus;
            if (rdnFamily.Checked)
                return CarType.Family;
            if (rdnMoto.Checked)
                return CarType.Moto;
            if (rdnTruck.Checked)
                return CarType.Truck;

            return CarType.Undefined;
        }
        private bool carExista(string ID)
        {
            Car[] carss = adminCar.GetCars(out int nrCars);
            foreach (Car car in carss)
            {
                if (car.ID == ID)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
