using Datos;
using Entidades;
using Google.Protobuf.WellKnownTypes;
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

namespace Minimarket
{
    public partial class Almacenes : Form
    {
        int opcion = 1;
        public Almacenes()
        {
            InitializeComponent();
            
        }

        private void Almacenes_Load(object sender, EventArgs e)
        {
            listado();
            cargarCod();
            limpliar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            //buscar();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            opcion= 0;
            activarMantenimiento();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            limpliar();
            cancelar();
            listado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            limpliar();
            cancelar();
            listado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
            listado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            selectionItems();
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Almacenes reporte= new Reportes.Frm_Almacenes();
            reporte.ShowDialog();
        }





        #region "Metodos Privados"
        //Metodo Validar
        private bool validar()
        {
            bool valor = true;
            if (txtDescripcion.Text == String.Empty)
            {
                MessageBox.Show("Debe cargar los datos (*)", "Aviso del Sistema", MessageBoxButtons.OK);
                valor = false;
            }
            return valor;
        }

        //Cargar siguiente codigo Categoria
        private void cargarCod()
        {
            txtCodigo.Text = N_Almacenes.sgteCod();
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
                dgv_principal.DataSource = N_Almacenes.listar_Decripcion(this.txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void guardar()
        {
            if (validar())
            {
                E_Almacen entidades = new E_Almacen();
                entidades.cod_almacen = int.Parse(txtCodigo.Text);
                entidades.descripcion = txtDescripcion.Text;
                String mensaje = N_Almacenes.guardarActualizar(this.opcion, entidades);
                limpliar();
                MessageBox.Show(mensaje);
            }
            txtDescripcion.Focus() ;
           

        }

        private void eliminar()
        {
            DialogResult option;
            option = MessageBox.Show("¿ELIMINAR REISTRO?", "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(N_Almacenes.eliminar(int.Parse(txtCodigo.Text)));
            }
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

        private void listado()
        {
            try
            {
                dgv_principal.DataSource = N_Almacenes.listado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cancelar()
        {
            this.tbp_principal.SelectedIndex = 0;
            this.txtDescripcion.ReadOnly = true;
        }




        #endregion

       
    }
}
