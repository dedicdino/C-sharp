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
        Student _student;
        List<StudentiKonsultacijeIB180161> _konsultacije;
        DLWMSDbContext _db = KonekcijaNaBazu.Baza;
        public frmIzvjestajIB180161(Student student, List<StudentiKonsultacijeIB180161> konsultacije)
        {
            InitializeComponent();
            _student = student;
            _konsultacije = konsultacije;
        }

        private void frmIzvjestajIB180161_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("pImePrezime",$"{_student}"));

            var tabela = new dsKonsultacije.KonsultacijeDataTable();
            for (int i = 0; i < _konsultacije.Count(); i++)
            {
                var konsultacija = _konsultacije[i];
                var red = tabela.NewKonsultacijeRow();
                red.Rb = (i + 1).ToString();
                red.Predmet = konsultacija.Predmet.ToString();
                red.Vrijeme = konsultacija.VrijemeOdrzavanja.ToString();
                red.Napomena = konsultacija.Napomena.ToString();
                tabela.AddKonsultacijeRow(red);
            }
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
