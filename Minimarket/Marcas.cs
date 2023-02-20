using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Entidades;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Datos;
using System.Text.RegularExpressions;

namespace Minimarket
{
    public partial class Marcas : Form
    {
        N_Marca n_marca= new N_Marca();
        int opcion = 1;
        public Marcas()
        {
            InitializeComponent();
            limpliar();
            this.txtCodigo.Enabled= false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Fmr_Marca reporte = new Reportes.Fmr_Marca();
            reporte.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            opcion = 0;
            activarMantenimiento();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tbp_principal.SelectedIndex = 0;
            this.txtDescripcion.ReadOnly = true;
        }


        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            selectionItems();
        }







        #region "Metodos Privados"

        //Metodo Validar
        private void validar()
        {
            if (txtDescripcion.Text == String.Empty)
            {
                MessageBox.Show("No se ha cargado Descripcion", "Aviso del Sistema", MessageBoxButtons.OK);
            }
        }

        //Cargar siguiente codigo Categoria
        private void cargarCod()
        {
            txtCodigo.Text = N_Marca.sgteCod();
        }

        //limpiar
        private void limpliar()
        {
            cargarCod();
            this.txtDescripcion.Text = "";
            this.txtDescripcion.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnNuevo.Enabled = true;
        }
        //Activar botones y campo de texto
        private void activarMantenimiento()
        {
            this.txtDescripcion.Enabled = true;
            this.txtDescripcion.Focus();
            this.btnGuardar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnNuevo.Enabled = false;
        }


        //buscar 
        private void buscar()
        {

            try
            {
                dgv_principal.DataSource = N_Marca.listarMarcaxDecripcion(this.txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void guardar()
        {
            validar();
            E_Marca e_marca = new E_Marca();
            e_marca.cod_marca = int.Parse(txtCodigo.Text);
            e_marca.descripcion = txtDescripcion.Text;
            String mensaje= N_Marca.guardarActualizar(this.opcion, e_marca);
            limpliar();
            MessageBox.Show(mensaje);
            
        }

        private void eliminar()
        {
            MessageBox.Show(N_Marca.eliminar(int.Parse(txtCodigo.Text)));
        }

        //seleccionamos una fila
        private void selectionItems()
        {
            ///int valor = Convert.ToInt64(dgv_principal.CurrentRow.Cells[0].Value);
            if (string.IsNullOrEmpty(Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("CELDA VACIA");
            }
            else
            {
                this.txtCodigo.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value);
                this.txtDescripcion.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[1].Value);
                this.tbp_principal.SelectedIndex = 1;
                opcion = 1;
                activarMantenimiento();

            }
        }

        #endregion

    }
}
