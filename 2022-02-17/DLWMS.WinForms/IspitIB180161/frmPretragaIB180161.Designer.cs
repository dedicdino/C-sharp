namespace DLWMS.WinForms.IspitIB180161
{
    partial class frmPretragaIB180161
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konsultacije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbGodinaStudija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(102, 14);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(204, 23);
            this.txtPretraga.TabIndex = 0;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.AllowUserToAddRows = false;
            this.dgvPretraga.AllowUserToDeleteRows = false;
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.GodinaStudija,
            this.ProsjecnaOcjena,
            this.Konsultacije});
            this.dgvPretraga.Location = new System.Drawing.Point(6, 46);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.ReadOnly = true;
            this.dgvPretraga.RowTemplate.Height = 25;
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(753, 234);
            this.dgvPretraga.TabIndex = 1;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            // 
            // ProsjecnaOcjena
            // 
            this.ProsjecnaOcjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProsjecnaOcjena.DataPropertyName = "Prosjek";
            this.ProsjecnaOcjena.HeaderText = "Prosjecna ocjena";
            this.ProsjecnaOcjena.Name = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.ReadOnly = true;
            // 
            // Konsultacije
            // 
            this.Konsultacije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Konsultacije.HeaderText = "";
            this.Konsultacije.Name = "Konsultacije";
            this.Konsultacije.ReadOnly = true;
            this.Konsultacije.Text = "Konsultacije";
            this.Konsultacije.UseColumnTextForButtonValue = true;
            // 
            // cmbGodinaStudija
            // 
            this.cmbGodinaStudija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodinaStudija.FormattingEnabled = true;
            this.cmbGodinaStudija.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbGodinaStudija.Location = new System.Drawing.Point(638, 17);
            this.cmbGodinaStudija.Name = "cmbGodinaStudija";
            this.cmbGodinaStudija.Size = new System.Drawing.Size(121, 23);
            this.cmbGodinaStudija.TabIndex = 2;
            this.cmbGodinaStudija.SelectedIndexChanged += new System.EventHandler(this.cmbGodinaStudija_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime ili prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Godina studija";
            // 
            // frmPretragaIB180161
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGodinaStudija);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmPretragaIB180161";
            this.Text = "frmPretragaIB180161";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPretraga;
        private DataGridView dgvPretraga;
        private ComboBox cmbGodinaStudija;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn GodinaStudija;
        private DataGridViewTextBoxColumn ProsjecnaOcjena;
        private DataGridViewButtonColumn Konsultacije;
        private Label label1;
        private Label label2;
    }
}