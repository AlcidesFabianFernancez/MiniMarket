using Microsoft.Reporting.WinForms;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket.Reportes
{
    public partial class Frm_Ciudad : Form
    {
        public Frm_Ciudad()
        {
            InitializeComponent();
        }

        private void Frm_Ciudad_Load(object sender, EventArgs e)
        {
            cargarReporte();
            this.reportViewer1.RefreshReport();
        }

        private void cargarReporte()
        {
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rp = new ReportDataSource("DataSet1", N_Ciudad.listado());

            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();
        }
    }
}
