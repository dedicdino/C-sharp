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
    public partial class frmKonsultacijeIB180161 : Form
    {
        DLWMSDbContext _db = KonekcijaNaBazu.Baza;
        Student _student;
        List<StudentiKonsultacijeIB180161> _konsultacije;
        public frmKonsultacijeIB180161(Student student)
        {
            InitializeComponent();
            _student = student;
            dgvKonsultacije.AutoGenerateColumns = false;
            lblNatpis.Text = $"Lista zahtjeva za konsultacije studenta {student}";
            cmbPredmet.DataSource = _db.Predmeti.ToList();
        }

        private void frmKonsultacijeIB180161_Load(object sender, EventArgs e)
        {
            UcitajKonsultacije();
        }

        private void UcitajKonsultacije()
        {
            _konsultacije = _db.StudentiKonsultacije.Where(s=>s.Student.Id == _student.Id).ToList();
            dgvKonsultacije.DataSource = null;
            dgvKonsultacije.DataSource = _konsultacije;
            this.Text = _konsultacije.Count().ToString();
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            frmNovaKonsultacijaIB180161 frmNovaKonsultacija = new frmNovaKonsultacijaIB180161(_student);
            frmNovaKonsultacija.ShowDialog();
            if(frmNovaKonsultacija.KonsultacijaDodana())
            {
                UcitajKonsultacije();
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            int brojZahtjeva = int.Parse(txtBrojZahtjeva.Text);
            string info;
            var odabraniPredmet = cmbPredmet.SelectedItem as PredmetiIB180161;
            await Task.Run(() => 
            {
                for (int i = 0; i <= brojZahtjeva; i++)
                {
                    Thread.Sleep(50);
                    StudentiKonsultacijeIB180161 novaKonsultacija = new StudentiKonsultacijeIB180161
                    {
                        Student = _student,
                        Predmet = odabraniPredmet,
                        VrijemeOdrzavanja = DateTime.Now,
                        Napomena = $"Konsultacija dodana u thread-u {i + 1}"
                    };
                    _db.StudentiKonsultacije.Add(novaKonsultacija);
                    info = $"Za {_student} dodan zahtjev za konsultacijama na {odabraniPredmet} | {DateTime.Now} {Environment.NewLine}";
                    Action akcija =()=> txtInfo.Text += info;
                    BeginInvoke(akcija);
                }
                _db.SaveChanges();
            });
            txtBrojZahtjeva.Clear();
            UcitajKonsultacije();
        }

        private void dgvKonsultacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                var indeks = e.RowIndex;
                var konsultacija = _konsultacije[indeks];
                var upozorenje = MessageBox.Show("Da li ste sigurni da zelite obrisati odabranu konsultaciju?", 
                    "Obavijest", MessageBoxButtons.YesNo);
                if(upozorenje == DialogResult.Yes && (DateTime.Now > konsultacija.VrijemeOdrzavanja))
                {
                    _db.StudentiKonsultacije.Remove(konsultacija);
                    _db.SaveChanges();
                    UcitajKonsultacije();
                }
                else
                {
                    MessageBox.Show("Ne mozete obrisati konsultaciju koja nije zavrsena!", "Upozorenje!");
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var frmIzvjestaj = new frmIzvjestajIB180161(_student, _konsultacije);
            frmIzvjestaj.ShowDialog();
        }
    }
}
