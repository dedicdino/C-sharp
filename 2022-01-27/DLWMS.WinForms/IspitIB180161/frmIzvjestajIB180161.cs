using DLWMS.Data;
using Microsoft.Reporting.WinForms;
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
    public partial class frmIzvjestajIB180161 : Form
    {
        List<StudentiPredmetiIB180161> _studentiPredmeti;
        DLWMSDbContext _db = KonekcijaNaBazu.Baza;
        public frmIzvjestajIB180161(List<StudentiPredmetiIB180161> studentiPredmeti)
        {
            InitializeComponent();
            _studentiPredmeti= studentiPredmeti;
        }

        private void frmIzvjestajIB180161_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();

            var tabelaStudenti = new dsStudentiPredmeti.StudentiPredmetiDataTable();
            for (int i = 0; i < _studentiPredmeti.Count(); i++)
            {
                var red = tabelaStudenti.NewStudentiPredmetiRow();
                red.Rb = (i + 1).ToString();
                red.ImePrezime = _studentiPredmeti[i].Student.ToString();
                red.Predmet = _studentiPredmeti[i].Predmet.ToString();
                red.Datum = _studentiPredmeti[i].Datum.ToString();
                red.Ocjena = _studentiPredmeti[i].Ocjena.ToString();
                tabelaStudenti.AddStudentiPredmetiRow(red);
            }
            rds.Name = "DataSet1";
            rds.Value = tabelaStudenti;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
