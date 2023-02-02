namespace DLWMS.WinForms.IspitIB180161
{
    partial class frmKonsultacijeIB180161
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
            this.dgvKonsultacije = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNatpis = new System.Windows.Forms.Label();
            this.btnDodajZahtjev = new System.Windows.Forms.Button();
            this.txtBrojZahtjeva = new System.Windows.Forms.TextBox();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKonsultacije
            // 
            this.dgvKonsultacije.AllowUserToAddRows = false;
            this.dgvKonsultacije.AllowUserToDeleteRows = false;
            this.dgvKonsultacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonsultacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Vrijeme,
            this.Napomena,
            this.Brisi});
            this.dgvKonsultacije.Location = new System.Drawing.Point(12, 49);
            this.dgvKonsultacije.Name = "dgvKonsultacije";
            this.dgvKonsultacije.ReadOnly = true;
            this.dgvKonsultacije.RowTemplate.Height = 25;
            this.dgvKonsultacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKonsultacije.Size = new System.Drawing.Size(776, 226);
            this.dgvKonsultacije.TabIndex = 0;
            this.dgvKonsultacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonsultacije_CellContentClick);
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Vrijeme
            // 
            this.Vrijeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vrijeme.DataPropertyName = "VrijemeOdrzavanja";
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.ReadOnly = true;
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "";
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // lblNatpis
            // 
            this.lblNatpis.AutoSize = true;
            this.lblNatpis.Location = new System.Drawing.Point(12, 22);
            this.lblNatpis.Name = "lblNatpis";
            this.lblNatpis.Size = new System.Drawing.Size(0, 15);
            this.lblNatpis.TabIndex = 1;
            // 
            // btnDodajZahtjev
            // 
            this.btnDodajZahtjev.Location = new System.Drawing.Point(694, 18);
            this.btnDodajZahtjev.Name = "btnDodajZahtjev";
            this.btnDodajZahtjev.Size = new System.Drawing.Size(94, 23);
            this.btnDodajZahtjev.TabIndex = 2;
            this.btnDodajZahtjev.Text = "Dodaj zahtjev";
            this.btnDodajZahtjev.UseVisualStyleBackColor = true;
            this.btnDodajZahtjev.Click += new System.EventHandler(this.btnDodajZahtjev_Click);
            // 
            // txtBrojZahtjeva
            // 
            this.txtBrojZahtjeva.Location = new System.Drawing.Point(12, 313);
            this.txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            this.txtBrojZahtjeva.Size = new System.Drawing.Size(100, 23);
            this.txtBrojZahtjeva.TabIndex = 3;
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(12, 365);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(121, 23);
            this.cmbPredmet.TabIndex = 4;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(190, 313);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(456, 121);
            this.txtInfo.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(97, 411);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj -->";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(713, 292);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 7;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Broj zahtjeva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Predmet";
            // 
            // frmKonsultacijeIB180161
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.cmbPredmet);
            this.Controls.Add(this.txtBrojZahtjeva);
            this.Controls.Add(this.btnDodajZahtjev);
            this.Controls.Add(this.lblNatpis);
            this.Controls.Add(this.dgvKonsultacije);
            this.Name = "frmKonsultacijeIB180161";
            this.Text = "frmKonsultacijeIB180161";
            this.Load += new System.EventHandler(this.frmKonsultacijeIB180161_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvKonsultacije;
        private Label lblNatpis;
        private Button btnDodajZahtjev;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Vrijeme;
        private DataGridViewTextBoxColumn Napomena;
        private DataGridViewButtonColumn Brisi;
        private TextBox txtBrojZahtjeva;
        private ComboBox cmbPredmet;
        private TextBox txtInfo;
        private Button btnDodaj;
        private Button btnPrintaj;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}