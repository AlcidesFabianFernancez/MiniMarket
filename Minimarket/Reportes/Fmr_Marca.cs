using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Negocio;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Minimarket.Reportes
{
    public partial class Fmr_Marca : Form
    {

        public Fmr_Marca()
        {
            InitializeComponent();
        }

        private void Fmr_Marca_Load(object sender, EventArgs e)
        {
            cargarReporte();
            this.reportViewer1.RefreshReport();
        }

        private void cargarReporte()
        {
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rp = new ReportDataSource("DataSet1", N_Marca.listarMarca());

            reportViewer1.LocalReport.DataSources.Add(rp);

        }
    }
}
