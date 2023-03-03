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
    public partial class Frm_Categoria : Form
    {
        public Frm_Categoria()
        {
            InitializeComponent();
        }

        private void Frm_Categoria_Load(object sender, EventArgs e)
        {
            cargarReporte();
            this.reportViewer1.RefreshReport();
        }

        private void cargarReporte()
        {
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rp = new ReportDataSource("DataSet1", N_Categoria.listarCategoria());

            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();
        }
    }
}
