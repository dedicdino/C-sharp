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
    public partial class frmPretragaIB180161 : Form
    {
        DLWMSDbContext _db = KonekcijaNaBazu.Baza;
        string _filter;
        int _godinaFilter;
        List<Student> _studenti;
        public frmPretragaIB180161()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }
        private void UcitajPodatke()
        {
            _filter = string.IsNullOrEmpty(txtPretraga.Text) ? "" : txtPretraga.Text;
            _godinaFilter = string.IsNullOrEmpty(cmbGodinaStudija.Text) ? 0 : int.Parse(cmbGodinaStudija.SelectedItem.ToString());
            _studenti = _db.Studenti.Where(s => s.GodinaStudija == _godinaFilter && (s.Ime.ToLower().Contains(_filter) ||
            s.Prezime.ToLower().Contains(_filter) || _filter == "")).ToList();
            if(_studenti!=null)
            {
                DataTable tblStudenti = new DataTable();
                tblStudenti.Columns.Add("ImePrezime");
                tblStudenti.Columns.Add("GodinaStudija");
                tblStudenti.Columns.Add("Prosjek");

                for (int i = 0; i <_studenti.Count(); i++)
                {
                    var student = _studenti[i];
                    List<StudentiPredmetiIB180161> listaStudenti = _db.StudentiPredmeti.Where(s=>s.Student.Id == student.Id).ToList();
                    DataRow red = tblStudenti.NewRow();
                    red["ImePrezime"] = student;
                    red["GodinaStudija"] = student.GodinaStudija;
                    red["Prosjek"] = listaStudenti.Average(o => o.Ocjena);
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

        private void cmbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                int indeks = e.RowIndex;
                var student = _studenti[indeks];
                frmKonsultacijeIB180161 frmKonsultacije = new frmKonsultacijeIB180161(student);
                frmKonsultacije.ShowDialog();
            }
        }
    }
}
