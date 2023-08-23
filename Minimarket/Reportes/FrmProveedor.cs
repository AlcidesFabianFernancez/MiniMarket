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
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            ReportDataSource rp = new ReportDataSource("DataSet1", N_Proveedor.listado());

            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();
        }
    }
}
