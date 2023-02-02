using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmStudentSeminarskiIB180161 : Form
    {
        StudentiPredmetiIB180161 _student;
        DLWMSDbContext _db = KonekcijaNaBazu.Baza;
        int _brojSlike = 0;
        ErrorProvider _err = new ErrorProvider();
        public frmStudentSeminarskiIB180161(StudentiPredmetiIB180161 student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmStudentSeminarskiIB180161_Load(object sender, EventArgs e)
        {
            lblStudent.Text = _student.Student.ToString();
            lblPredmet.Text = _student.Predmet.ToString();
            UcitajSeminarske();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var noviSeminarski = _db.StudentiSeminarski.Add(new StudentSeminarskiIB180161
                {
                    Student = _student.Student,
                    Predmet = _student.Predmet,
                    Slika = ImageHelper.FromImageToByte(pbGore.Image),
                    Opis = txtOpis.Text,
                    Datum = DateTime.Now
                });
                _db.SaveChanges();
            }
            OcistiSadrzaj();
            UcitajSeminarske();
        }

        private void OcistiSadrzaj()
        {
            pbGore.Image = null;
            txtOpis.Clear();
        }


        private void pbGore_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbGore.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void UcitajSeminarske()
        {
            if(_student.Student.SlikeSeminarski.Count()!=0)
            {
                var prvaSlika = _student.Student.SlikeSeminarski[_brojSlike];
                pbDolje.Image = ImageHelper.FromByteToImage(prvaSlika.Slika);
                txtOpisDolje.Text = _student.Student.SlikeSeminarski[_brojSlike].Opis.ToString();
                lblDatumDolje.Text = _student.Student.SlikeSeminarski[_brojSlike].Datum.ToString();
                lblStranica.Text = $"Stranica {_brojSlike+1}/{_student.Student.SlikeSeminarski.Count()}";
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(pbGore, _err, "Obavezna vrijednost!") &&
                Validator.ValidirajKontrolu(txtOpis, _err, "Obavezna vrijednost!");
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            var brojSlike = _brojSlike;
            if(brojSlike>0)
            {
                _brojSlike--;
                var prvaSlika = _student.Student.SlikeSeminarski[_brojSlike];
                pbDolje.Image = ImageHelper.FromByteToImage(prvaSlika.Slika);
                txtOpisDolje.Text = _student.Student.SlikeSeminarski[_brojSlike].Opis.ToString();
                lblDatumDolje.Text = _student.Student.SlikeSeminarski[_brojSlike].Datum.ToString();
                lblStranica.Text = $"Stranica {_brojSlike + 1}/{_student.Student.SlikeSeminarski.Count()}";
            }
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            var brojSlike = _brojSlike;
            if (brojSlike <_student.Student.SlikeSeminarski.Count()-1)
            {
                _brojSlike++;
                var prvaSlika = _student.Student.SlikeSeminarski[_brojSlike];
                pbDolje.Image = ImageHelper.FromByteToImage(prvaSlika.Slika);
                txtOpisDolje.Text = _student.Student.SlikeSeminarski[_brojSlike].Opis.ToString();
                lblDatumDolje.Text = _student.Student.SlikeSeminarski[_brojSlike].Datum.ToString();
                lblStranica.Text = $"Stranica {_brojSlike + 1}/{_student.Student.SlikeSeminarski.Count()}";
            }
        }
    }
}
