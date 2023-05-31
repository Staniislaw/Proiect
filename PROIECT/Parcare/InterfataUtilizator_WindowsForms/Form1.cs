using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

using Parcare;

using static Parcare.Car;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        AdministrareMasini_FisierText adminCar;

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        public Form1()
        {
            InitializeComponent();
            random=new Random();
            btnCLOSE.Visible = false;
            
            //pentru a sterge bordura
            
            //deschidere fullscreen
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        //Am selectat o culoare aleatorie din lista de culori: "random color".
        private Color SelecThemeColor()
        {
            int index=random.Next(ThemeColor.ColorList.Count);
            while(tempIndex==index)
            {
                //Dacă culoarea a fost deja selectată, vom selecta din nou pentru a alege una diferită.
                index=random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton !=(Button)btnSender)
                {
                    DisableButton();
                    Color color= SelecThemeColor();
                    currentButton =(Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeBrightness(color,-0.3);
                    ThemeColor.primaryColor = color;
                    ThemeColor.secondaryColor = ThemeColor.ChangeBrightness(color, -0.3) ;
                    btnCLOSE.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.SlateBlue;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }    
        }



        //cream o metoda de a deschide form in containerul panel
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void btnCars_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCars(), sender);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            OpenChildForm(new Forms.FormADD(), sender);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRemove(), sender);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCauta(), sender);
        }
        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            if (activeForm!=null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.DarkCyan;
            panelLogo.BackColor = Color.DarkSlateBlue;
            currentButton = null;
            btnCLOSE.Visible = false;
        }

        //adăugăm funcția de "drag(de a muta unde vrem noi)" a formularului
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
