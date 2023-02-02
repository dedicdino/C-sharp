using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB180161
{
    public partial class frmNovaKonsultacijaIB180161 : Form
    {
        Student _student;
        DLWMSDbContext _db = KonekcijaNaBazu.Baza;
        ErrorProvider _err = new ErrorProvider();
        public frmNovaKonsultacijaIB180161(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmNovaKonsultacijaIB180161_Load(object sender, EventArgs e)
        {
            cmbPredmet.DataSource = _db.Predmeti.ToList();
            dtpVrijemeOdrzavanja.MinDate = DateTime.Now;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            StudentiKonsultacijeIB180161 novaKonsultacija = new StudentiKonsultacijeIB180161
            {
                Student = _student,
                Predmet = cmbPredmet.SelectedItem as PredmetiIB180161,
                VrijemeOdrzavanja = dtpVrijemeOdrzavanja.Value.Date,
                Napomena = txtNapomena.Text
            };
            _db.StudentiKonsultacije.Add(novaKonsultacija);
            _db.SaveChanges();
            KonsultacijaDodana();
            Close();
        }

        public bool KonsultacijaDodana()
        {
            return true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

    
    }
}
