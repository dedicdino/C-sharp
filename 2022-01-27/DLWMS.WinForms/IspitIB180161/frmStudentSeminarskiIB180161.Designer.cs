namespace DLWMS.WinForms.IspitIB180161
{
    partial class frmStudentSeminarskiIB180161
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.pbGore = new System.Windows.Forms.PictureBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pbDolje = new System.Windows.Forms.PictureBox();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.lblDatumDolje = new System.Windows.Forms.Label();
            this.txtOpisDolje = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblStranica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDolje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudent.Location = new System.Drawing.Point(249, 9);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 37);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPredmet.Location = new System.Drawing.Point(258, 46);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(0, 28);
            this.lblPredmet.TabIndex = 1;
            this.lblPredmet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbGore
            // 
            this.pbGore.Location = new System.Drawing.Point(24, 104);
            this.pbGore.Name = "pbGore";
            this.pbGore.Size = new System.Drawing.Size(103, 127);
            this.pbGore.TabIndex = 2;
            this.pbGore.TabStop = false;
            this.pbGore.DoubleClick += new System.EventHandler(this.pbGore_DoubleClick);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(177, 104);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(350, 98);
            this.txtOpis.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(452, 208);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pbDolje
            // 
            this.pbDolje.Location = new System.Drawing.Point(194, 254);
            this.pbDolje.Name = "pbDolje";
            this.pbDolje.Size = new System.Drawing.Size(212, 262);
            this.pbDolje.TabIndex = 5;
            this.pbDolje.TabStop = false;
            // 
            // btnLijevo
            // 
            this.btnLijevo.Location = new System.Drawing.Point(113, 361);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 23);
            this.btnLijevo.TabIndex = 6;
            this.btnLijevo.Text = "<";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Location = new System.Drawing.Point(412, 361);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 23);
            this.btnDesno.TabIndex = 7;
            this.btnDesno.Text = ">";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // lblDatumDolje
            // 
            this.lblDatumDolje.AutoSize = true;
            this.lblDatumDolje.Location = new System.Drawing.Point(283, 519);
            this.lblDatumDolje.Name = "lblDatumDolje";
            this.lblDatumDolje.Size = new System.Drawing.Size(0, 15);
            this.lblDatumDolje.TabIndex = 8;
            // 
            // txtOpisDolje
            // 
            this.txtOpisDolje.Location = new System.Drawing.Point(138, 550);
            this.txtOpisDolje.Multiline = true;
            this.txtOpisDolje.Name = "txtOpisDolje";
            this.txtOpisDolje.Size = new System.Drawing.Size(320, 61);
            this.txtOpisDolje.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblStranica
            // 
            this.lblStranica.AutoSize = true;
            this.lblStranica.Location = new System.Drawing.Point(283, 225);
            this.lblStranica.Name = "lblStranica";
            this.lblStranica.Size = new System.Drawing.Size(0, 15);
            this.lblStranica.TabIndex = 10;
            // 
            // frmStudentSeminarskiIB180161
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 623);
            this.Controls.Add(this.lblStranica);
            this.Controls.Add(this.txtOpisDolje);
            this.Controls.Add(this.lblDatumDolje);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.btnLijevo);
            this.Controls.Add(this.pbDolje);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.pbGore);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.lblStudent);
            this.Name = "frmStudentSeminarskiIB180161";
            this.Text = "frmStudentSeminarskiIB180161";
            this.Load += new System.EventHandler(this.frmStudentSeminarskiIB180161_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDolje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStudent;
        private Label lblPredmet;
        private PictureBox pbGore;
        private TextBox txtOpis;
        private Button btnDodaj;
        private PictureBox pbDolje;
        private Button btnLijevo;
        private Button btnDesno;
        private Label lblDatumDolje;
        private TextBox txtOpisDolje;
        private OpenFileDialog openFileDialog1;
        private Label lblStranica;
    }
}