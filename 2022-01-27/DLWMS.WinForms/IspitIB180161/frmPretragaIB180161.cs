using DLWMS.Data;
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
    public partial class frmPretragaIB180161 : Form
    {
        DLWMSDbContext _db = KonekcijaNaBazu.Baza;
        int _ocjenaFilter;
        List<StudentiPredmetiIB180161> _studentiPredmeti;
        List<Student> _studenti;
        public frmPretragaIB180161()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
            cmbStudenti.DataSource = _db.Studenti.ToList();
        }


        private void UcitajPodatke()
        {
            _ocjenaFilter = int.Parse(cmbMinOcjena.SelectedItem.ToString());
            _studentiPredmeti = _db.StudentiPredmeti.Include(s => s.Student).Include(p => p.Predmet).Where(o => o.Ocjena 
            >= _ocjenaFilter).ToList();

            DataTable tblStudenti = new DataTable();
            tblStudenti.Columns.Add("Rb");
            tblStudenti.Columns.Add("Student");
            tblStudenti.Columns.Add("Predmet");
            tblStudenti.Columns.Add("DatumPolaganja");
            tblStudenti.Columns.Add("Ocjena");

            if (_studentiPredmeti != null)
            {
                for (int i = 0; i < _studentiPredmeti.Count(); i++)
                {
                    var studentPredmet = _studentiPredmeti[i];

                    DataRow red = tblStudenti.NewRow();
                    red["Rb"] = (i + 1).ToString();
                    red["Student"] = studentPredmet.Student;
                    red["Predmet"] = studentPredmet.Predmet;
                    red["DatumPolaganja"] = studentPredmet.Datum;
                    red["Ocjena"] = studentPredmet.Ocjena;
                    tblStudenti.Rows.Add(red);
                }

                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = tblStudenti;
            }
            else
            {
                dgvPretraga.DataSource = null;
            }
        }
        private void btnPretraga_Click(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            int brojPolozenih = int.Parse(txtBrojPolozenih.Text);
            Random r = new Random();
            var student = cmbStudenti.SelectedItem as Student;

            await Task.Run(() => 
            {
                for (int i = 0; i < brojPolozenih; i++)
                {
                    Thread.Sleep(50);
                    var noviPolozeni = new StudentiPredmetiIB180161
                    {
                        Student = student,
                        Predmet = _db.Predmeti.ToList().ElementAt(r.Next(0,3)),
                        Ocjena = r.Next(6,10),
                        Datum = DateTime.Now
                    };
                    _db.StudentiPredmeti.Add(noviPolozeni);
                    var info = $"Za {student} dodat polozeni -> {noviPolozeni.Predmet}({noviPolozeni.Ocjena.ToString()}){Environment.NewLine}";
                    Action akcija = () => txtInfo.Text += info;
                    BeginInvoke(akcija);
                }
                _db.SaveChanges();
            });
            UcitajPodatke();

        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==5)
            {
                var indeks = e.RowIndex;
                var _student = _studentiPredmeti[indeks];
                var frmSeminarski = new frmStudentSeminarskiIB180161(_student);
                frmSeminarski.ShowDialog();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var frmIzvjestaj = new frmIzvjestajIB180161(_studentiPredmeti);
            frmIzvjestaj.ShowDialog();
        }
    }
}
