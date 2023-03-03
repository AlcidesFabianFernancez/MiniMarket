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
    public partial class Frm_Almacenes : Form
    {
        public Frm_Almacenes()
        {
            InitializeComponent();
        }

        private void Frm_Almacenes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            cargarReporte();
        }


        private void cargarReporte()
        {
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rp = new ReportDataSource("DataSet1", N_Almacenes.listado());

            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();
        }

    }
}
