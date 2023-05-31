namespace InterfataUtilizator_WindowsForms.Forms
{
    partial class FormCauta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckcScriere = new System.Windows.Forms.CheckBox();
            this.ckcAlegere = new System.Windows.Forms.CheckBox();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.btnCautare = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ckcAlegere);
            this.panel1.Controls.Add(this.ckcScriere);
            this.panel1.Controls.Add(this.cmbID);
            this.panel1.Controls.Add(this.btnCautare);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(435, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 396);
            this.panel1.TabIndex = 0;
            // 
            // ckcScriere
            // 
            this.ckcScriere.AutoSize = true;
            this.ckcScriere.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ckcScriere.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckcScriere.Location = new System.Drawing.Point(86, 142);
            this.ckcScriere.Name = "ckcScriere";
            this.ckcScriere.Size = new System.Drawing.Size(86, 22);
            this.ckcScriere.TabIndex = 8;
            this.ckcScriere.Text = "Scriere";
            this.ckcScriere.UseVisualStyleBackColor = true;
            // 
            // ckcAlegere
            // 
            this.ckcAlegere.AutoSize = true;
            this.ckcAlegere.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ckcAlegere.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckcAlegere.Location = new System.Drawing.Point(178, 142);
            this.ckcAlegere.Name = "ckcAlegere";
            this.ckcAlegere.Size = new System.Drawing.Size(90, 22);
            this.ckcAlegere.TabIndex = 3;
            this.ckcAlegere.Text = "Alegere";
            this.ckcAlegere.UseVisualStyleBackColor = true;
            // 
            // cmbID
            // 
            this.cmbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbID.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbID.Enabled = false;
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(80, 170);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(188, 21);
            this.cmbID.TabIndex = 4;
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(130, 351);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(88, 42);
            this.btnCautare.TabIndex = 3;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(80, 197);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(188, 20);
            this.txtID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Balance,
            this.TypeOfCar});
            this.dataGridView1.Location = new System.Drawing.Point(438, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 100);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Sold";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // TypeOfCar
            // 
            this.TypeOfCar.HeaderText = "Tipul Masinii";
            this.TypeOfCar.Name = "TypeOfCar";
            this.TypeOfCar.ReadOnly = true;
            // 
            // FormCauta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1184, 619);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormCauta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCauta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfCar;
        private System.Windows.Forms.CheckBox ckcScriere;
        private System.Windows.Forms.CheckBox ckcAlegere;
    }
}