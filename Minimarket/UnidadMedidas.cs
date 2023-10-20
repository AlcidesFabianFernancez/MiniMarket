using Datos;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket
{
    public partial class UnidadMedidas : Form
    {
        int opcion =1;
        public UnidadMedidas()
        {
            InitializeComponent();
            
        }

        private void UnidadMedidas_Load(object sender, EventArgs e)
        {
            limpliar();
            listado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Unidad_Medida reporte = new Reportes.Frm_Unidad_Medida();
            reporte.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            opcion= 0;

            activarMantenimiento();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
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
            limpliar();
        }




        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            selectionItems();
        }



        /// <summary>
        /// Metodos Privados
        /// </summary>
        #region "Metodos Privados"

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
                this.txtDescripcion.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[2].Value);
                this.txtAbreviatura.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[1].Value);
                this.tbp_principal.SelectedIndex = 1;
                opcion = 1;
                activarMantenimiento();

            }
        }



        //Metodo Validar
        private void validar()
        {
            if (txtAbreviatura.Text == String.Empty)
            {
                MessageBox.Show("No se ha cargado Abreviatura", "Aviso del Sistema", MessageBoxButtons.OK);
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("No se ha cargado Descripcion", "Aviso del Sistema", MessageBoxButtons.OK);
            }
        }

        //Cargar siguiente codigo Categoria
        private void cargarCod()
        {
            
            if(N_UnidadMedidas.sgteCod() == "")
            {
                txtCodigo.Text = "1";
            }
            else
            {
                txtCodigo.Text = N_UnidadMedidas.sgteCod();
            }
        }

        //limpiar
        private void limpliar()
        {
            cargarCod();
            this.txtAbreviatura.Text = "";
            this.txtDescripcion.Text = "";
            this.txtDescripcion.Enabled= false;
            this.txtAbreviatura.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnNuevo.Enabled = true;
        }
        //Activar botones y campo de texto
        private void activarMantenimiento()
        {
            this.txtAbreviatura.Enabled = true;
            this.txtDescripcion.Enabled= true;
            this.txtAbreviatura.Focus();
            this.btnGuardar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnNuevo.Enabled = false;
        }


        //buscar 
        private void buscar()
        {

            try
            {
                dgv_principal.DataSource = N_UnidadMedidas.listarxDecripcion(this.txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void listado()
        {
            try
            {
                dgv_principal.DataSource = N_UnidadMedidas.listado_um();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void guardar()
        {
            validar();
            E_UnidadMedidas entidades = new E_UnidadMedidas();
            entidades.codigo = int.Parse(txtCodigo.Text.Trim());
            entidades.abreviatura= txtAbreviatura.Text.Trim();
            entidades.descripcion = txtDescripcion.Text.Trim();
            String mensaje = N_UnidadMedidas.guardarActualizar(this.opcion, entidades);
            limpliar();
            MessageBox.Show(mensaje);

        }

        private void eliminar()
        {
            DialogResult option;
            option = MessageBox.Show("¿ELIMINAR REISTRO?", "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(N_UnidadMedidas.eliminar(int.Parse(txtCodigo.Text)));
            } 
        }


        private void cancelar()
        {
            this.tbp_principal.SelectedIndex = 0;
        }

        #endregion

        
    }
}
