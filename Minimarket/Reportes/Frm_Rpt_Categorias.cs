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
    public partial class Frm_Rpt_Categorias : Form
    {
         
        public Frm_Rpt_Categorias()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Categorias_Load(object sender, EventArgs e)
        {
            report();
            //this.reportViewer1.RefreshReport();
        }

        private void report()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rp= new ReportDataSource("DtCategoria", N_Categoria.listarCategoria());
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();
        }
    }
}
