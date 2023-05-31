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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfataUtilizator_WindowsForms.Forms
{
    public partial class FormCauta : Form
    {
        AdministrareMasini_FisierText adminCar;
        private string IDcars;
 
        public FormCauta()
        {
            InitializeComponent();
            string locatieFisierSolutie = Path.Combine(Application.StartupPath, "NumeFisier.txt");
            adminCar = new AdministrareMasini_FisierText(locatieFisierSolutie);
            Car[] cars = adminCar.GetCars(out int nrCars);
        }
        private void LoadTheme()
        {
            panel1.BackColor = ThemeColor.secondaryColor;
            dataGridView1.BackgroundColor = ThemeColor.secondaryColor;
            
        }

        private void FormCauta_Load(object sender, EventArgs e)
        {
            ckcAlegere.CheckedChanged += CheckBox_CheckedChanged;
            ckcScriere.CheckedChanged += CheckBox_CheckedChanged;
            Car[] cars = adminCar.GetCars(out int nrCars);
            cmbID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbID.Items.Clear();
            cmbID.Text = "Alegeti ID-ul";
            foreach (Car car in cars)
            {
                cmbID.Items.Add(car.ID);
            }
            LoadTheme();
        }
        private void btnCautare_Click(object sender, EventArgs e)
        { 
            Car[] cars = adminCar.GetCars(out int nrCars);
            Car foundCar = null;

            if (ckcScriere.Checked)
            {
                IDcars = txtID.Text.ToUpper();
                foreach (Car car in cars)
                {
                    if (car.ID == IDcars)
                    {
                        foundCar = car;
                        break;
                    }
                }

            }
            else
            {
                string selectedID = cmbID.SelectedItem.ToString().ToUpper();
                foreach (Car car in cars)
                {
                    if (car.ID == selectedID)
                    {
                        foundCar = car;
                        break;
                    }
                }
            }

                if (foundCar == null)
                {
                    MessageBox.Show("Mașina nu a fost găsită.");
                    return;
                }
                dataGridView1.Rows.Clear(); // Curăță rândurile existente în DataGridView
                // Adaugă un nou rând în DataGridView cu datele mașinii
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells["ID"].Value = foundCar.ID;
                row.Cells["Balance"].Value = foundCar.Balance;
                row.Cells["TypeofCar"].Value = foundCar.TypeofCar;
                // Continuă adăugarea celorlalte proprietăți ale mașinii
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ResetareControale();
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                if (checkBox == ckcAlegere)
                {
                    ckcScriere.Checked = false;
                    txtID.Enabled = false;
                    cmbID.Enabled = true;
                }
                else if (checkBox == ckcScriere)
                {
                    ckcAlegere.Checked = false;
                    cmbID.Enabled = false;
                    txtID.Enabled = true;
                }
            }
            else
            {
                // Deselectează ambele CheckBox-uri
                ckcScriere.Checked = false;
                ckcAlegere.Checked = false;
                cmbID.Enabled = false;
                txtID.Enabled = false;
            }
        }
        private void ResetareControale()
        {
            cmbID.DataSource = null;
            txtID.Text= string.Empty;
        }

    }
}
