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
namespace InterfataUtilizator_WindowsForms.Forms
{
    public partial class FormCars : Form
    {
        AdministrareMasini_FisierText adminCar;
        private const int DIMENSIUNE_PAS_Y = 200;
        private const int DIMENSIUNE_PAS_X = 150;

        private Panel[] pnlCars1;
        private Label[] lblsID;
        private Label[] lblsSold;
       
        private Label lblTitlu;

        private PictureBox[] pbCars;


        public FormCars()
        {
            InitializeComponent();
           
            string locatieFisierSolutie = Path.Combine(Application.StartupPath, "NumeFisier.txt");
            adminCar = new AdministrareMasini_FisierText(locatieFisierSolutie);
            Car[] cars = adminCar.GetCars(out int nrCars);
           

           
        }
        private void InitializePanels()
        {
            
            Car[] cars = adminCar.GetCars(out int nrCars);
            pnlCars1 = new Panel[nrCars];
            lblsID = new Label[nrCars];
            lblsSold = new Label[nrCars];
            pbCars = new PictureBox[nrCars];
            for (int i = 0; i < nrCars; i++)
            {

                int j = i % 4;
                lblsID[i] = new Label();
                lblsID[i].AutoSize = true;
                lblsID[i].Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblsID[i].Location = new System.Drawing.Point(12, 176);
                lblsID[i].Name = "lblID";
                lblsID[i].Size = new System.Drawing.Size(121, 24);
                lblsID[i].TabIndex = 2;
                lblsID[i].Text = cars[i].ID.ToString();

                lblsID[i].ForeColor = Color.White;
                this.Controls.Add(lblsID[i]);

                lblsSold[i] = new Label();
                lblsSold[i].AutoSize = true;
                lblsSold[i].Font = new System.Drawing.Font("Algerian", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblsSold[i].Location = new System.Drawing.Point(80, 210);
                lblsSold[i].Name = "lblSold";
                lblsSold[i].Size = new System.Drawing.Size(31, 15);
                lblsSold[i].TabIndex = 3;
                lblsSold[i].Text = cars[i].Balance.ToString()+" LEI";
                lblsSold[i].ForeColor = Color.White;

                lblTitlu = new Label();
                lblTitlu.AutoSize = true;
                lblTitlu.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblTitlu.Location = new System.Drawing.Point(13, 0);
                lblTitlu.Name = "lblNUME";
                lblTitlu.Size = new System.Drawing.Size(115, 16);
                lblTitlu.TabIndex = 0;
                lblTitlu.Text = "Locul de paracre " + (i + 1);
                lblTitlu.ForeColor = Color.White;

                pbCars[i] = new PictureBox();
                pbCars[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pbCars[i].Size = new Size(217, 140);
                pbCars[i].SizeMode=PictureBoxSizeMode.Zoom;
                pbCars[i].Location = new Point(0,33);// Ajustați poziționarea imaginii în funcție de designul dvs.
                pbCars[i].ImageLocation = "C:\\Users\\grati\\Desktop\\PIU\\PROIECT\\Parcare\\pozecars\\" + lblsID[i].Text+ ".jpg"; // Încărcați imaginea din fișierul specificat


                pnlCars1[i] = new Panel();
                pnlCars1[i].Anchor = System.Windows.Forms.AnchorStyles.None;
                pnlCars1[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                pnlCars1[i].AutoScroll = true;

                pnlCars1[i].Controls.Add(this.lblsID[i]);
                pnlCars1[i].Controls.Add(this.lblsSold[i]);
                pnlCars1[i].Controls.Add(this.lblTitlu);
                pnlCars1[i].Controls.Add(this.pbCars[i]);
                pnlCars1[i].Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + (250 * j), DIMENSIUNE_PAS_Y + (425 * (i / 4))); // Ajustarea valorii DIMENSIUNE_PAS_Y și a împărțirii la 4


                pnlCars1[i].Name = "pnlCars";
                pnlCars1[i].Size = new System.Drawing.Size(220, 396);
                pnlCars1[i].TabIndex = 0;
                this.Controls.Add(pnlCars1[i]);
                UpdateScrollBar();

            }
        }
      

        private void LoadTheme()
        {
            
            InitializePanels();
            Car[] cars = adminCar.GetCars(out int nrCars);
            for (int i = 0; i < nrCars; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    pnlCars1[i].BackColor = ThemeColor.primaryColor;
                }
            }

        }
        private int previousScrollValue = 0; // Variabila pentru a stoca valoarea anterioară a scrollerului
        private int scrollSpeed = 2; // Factor de viteză pentru deplasare

        private void AdjustScrollBar()
        {
            int totalHeight = pnlCars1.Length * pnlCars1[0].Height/2; // Calculați înălțimea totală a elementelor pnlCars1

            int scrollRange = totalHeight - pnlCars1[0].Height; // Calculați intervalul deplasării scrollerului
            int scrollValue = Math.Min(vScrollBar1.Value, scrollRange); // Asigurați-vă că valoarea scrollerului nu depășește intervalul
            
            vScrollBar1.Maximum = scrollRange; // Setați valoarea maximă a scrollerului
            vScrollBar1.LargeChange = pnlCars1[0].Height; // Setați dimensiunea "paginii" scrollerului

            // Actualizați valoarea scrollerului în funcție de noile setări
            vScrollBar1.Value = scrollValue;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollValue = vScrollBar1.Value; // Stocați valoarea curentă a scrollerului

            int distanceToMove = (scrollValue - previousScrollValue) * scrollSpeed; // Calculați distanța de deplasare înmulțind cu factorul de viteză

            for (int i = 0; i < pnlCars1.Length; i++)
            {
                pnlCars1[i].Location = new Point(pnlCars1[i].Location.X, pnlCars1[i].Location.Y - distanceToMove); // Modificați coordonata Y a fiecărui element

                // Alte modificări specifice fiecărui element pnlCars1[i] pot fi aplicate aici
            }

            previousScrollValue = scrollValue; // Actualizați valoarea anterioară a scrollerului
        }

        // Apelați această funcție ori de câte ori se schimbă numărul de elemente pnlCars1
        private void UpdateScrollBar()
        {
            AdjustScrollBar();
        }

        private void FormCars_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
