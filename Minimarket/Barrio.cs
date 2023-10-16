using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Minimarket
{
    public partial class Barrio : Form
    {

        int opcion = 1;
        E_Barrio entidades = new E_Barrio();

        public Barrio()
        {
            InitializeComponent();
        }

        private void Barrio_Load(object sender, EventArgs e)
        {
            limpiar();
            cargarCod();
            listado();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
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
            Reportes.Fmr_Barrio rbarrio = new Reportes.Fmr_Barrio();
            rbarrio.ShowDialog();
        }

        private void dgv_principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            selectionItems();
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Generico buscar = new Frm_Buscar_Generico();
            AddOwnedForm(buscar);
            buscar.valores(7);
            buscar.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            opcion = 0;
            activarMantenimiento();            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            listado();
            cargarCod();
            cancelar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            limpiar();
            cancelar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }


        #region "Metodos Privados"

        //Metodo Validar
        private bool validar()
        {
            bool valor = true;
            if (txtDescripcion.Text == String.Empty || txtCiudad.Text == String.Empty)
            {
                MessageBox.Show("Debe cargar los datos (*)", "Aviso del Sistema", MessageBoxButtons.OK);
                valor = false;
            }
            return valor;
        }

        //Cargar siguiente codigo Categoria
        private void cargarCod()
        {
            if (N_Barrio.sgteCod() == "")
            {
                txtCodigo.Text = "1";
            }
            else
            {
                txtCodigo.Text = N_Barrio.sgteCod();
            }

        }

        //limpiar
        private void limpiar()
        {
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Text = "";
            this.txtCiudad.Text = "";
            this.btnCiudad.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnNuevo.Enabled = true;
        }
        //Activar botones y campo de texto
        private void activarMantenimiento()
        {
            this.txtDescripcion.Enabled = true;
            this.txtDescripcion.Focus();
            this.btnCiudad.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnNuevo.Enabled = false;
        }


        //buscar 
        private void buscar()
        {

            try
            {
                dgv_principal.DataSource = N_Barrio.listar_Decripcion(this.txtBuscar.Text.Trim());
                dgv_principal.Columns[3].Visible = false; ///no se ve la ultima columna
                dgv_principal.Columns[4].Visible = false;
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
                entidades.cod_barrio = int.Parse(txtCodigo.Text);
                entidades.descripcion = txtDescripcion.Text;
                String mensaje = N_Barrio.guardarActualizar(this.opcion, entidades);
                limpiar();
                MessageBox.Show(mensaje);
            }
            txtDescripcion.Focus();


        }

        private void eliminar()
        {
            DialogResult option;
            option = MessageBox.Show("¿ELIMINAR REGISTRO?", "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(N_Barrio.eliminar(int.Parse(txtCodigo.Text)));
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
                this.txtCiudad.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[2].Value);
                this.entidades.cod_ciudad = Convert.ToInt32(dgv_principal.CurrentRow.Cells[3].Value);
                this.entidades.estado = Convert.ToBoolean(dgv_principal.CurrentRow.Cells[4].Value);
                this.tbp_principal.SelectedIndex = 1;
                opcion = 1;
                activarMantenimiento();

            }
        }

        private void listado()
        {
            try
            {
                dgv_principal.DataSource = N_Barrio.listado();
                dgv_principal.Columns[3].Visible = false; ///no se ve la ultima columna
                dgv_principal.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cancelar()
        {
            this.tbp_principal.SelectedIndex = 0;
            //this.txtDescripcion.ReadOnly = true;
        }

        #endregion


        #region "Metodos Publicos"

        public void cargarTxt(int opcion, String valor, Decimal codigo)
        {

            if (opcion == 7)
            {
                txtCiudad.Text = valor;
                this.entidades.cod_ciudad = Convert.ToInt32(codigo);
            }
        }


        #endregion

       
    }

}
