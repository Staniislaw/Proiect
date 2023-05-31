namespace InterfataUtilizator_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblParking = new System.Windows.Forms.Label();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.panelMenu.Controls.Add(this.BtnRefresh);
            this.panelMenu.Controls.Add(this.btnRemove);
            this.panelMenu.Controls.Add(this.btnAdauga);
            this.panelMenu.Controls.Add(this.btnCars);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 449);
            this.panelMenu.TabIndex = 0;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefresh.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.search__3_;
            this.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefresh.Location = new System.Drawing.Point(0, 260);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.BtnRefresh.Size = new System.Drawing.Size(220, 60);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "         Search";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(0, 200);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRemove.Size = new System.Drawing.Size(220, 60);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "         Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAdauga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdauga.FlatAppearance.BorderSize = 0;
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdauga.Image = ((System.Drawing.Image)(resources.GetObject("btnAdauga.Image")));
            this.btnAdauga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdauga.Location = new System.Drawing.Point(0, 140);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnAdauga.Size = new System.Drawing.Size(220, 60);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "        Add";
            this.btnAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdauga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCars
            // 
            this.btnCars.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCars.FlatAppearance.BorderSize = 0;
            this.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCars.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCars.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.car__2__removebg_preview;
            this.btnCars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCars.Location = new System.Drawing.Point(0, 80);
            this.btnCars.Name = "btnCars";
            this.btnCars.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCars.Size = new System.Drawing.Size(220, 60);
            this.btnCars.TabIndex = 0;
            this.btnCars.Text = " Cars";
            this.btnCars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCars.UseVisualStyleBackColor = false;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelLogo.Controls.Add(this.lblParking);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblParking
            // 
            this.lblParking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParking.AutoSize = true;
            this.lblParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParking.ForeColor = System.Drawing.Color.White;
            this.lblParking.Location = new System.Drawing.Point(62, 28);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(86, 26);
            this.lblParking.TabIndex = 0;
            this.lblParking.Text = "Parking";
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlDesktop.Controls.Add(this.pctLogo);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 80);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(642, 369);
            this.pnlDesktop.TabIndex = 1;
            // 
            // pctLogo
            // 
            this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctLogo.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.TopCars1;
            this.pctLogo.Location = new System.Drawing.Point(18, -29);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(612, 408);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(58, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.FlatAppearance.BorderSize = 0;
            this.btnCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLOSE.Image = ((System.Drawing.Image)(resources.GetObject("btnCLOSE.Image")));
            this.btnCLOSE.Location = new System.Drawing.Point(3, 3);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(49, 46);
            this.btnCLOSE.TabIndex = 4;
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkCyan;
            this.panelTitleBar.Controls.Add(this.btnCLOSE);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(642, 80);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 449);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblParking;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.FlowLayoutPanel panelTitleBar;
    }
}

