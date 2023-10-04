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
            if (N_Ciudad.sgteCod() == "")
            {
                txtCodigo.Text = "1";
            }
            else
            {
                txtCodigo.Text = N_Ciudad.sgteCod();
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
                dgv_principal.DataSource = N_Ciudad.listar_Decripcion(this.txtBuscar.Text.Trim());
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
                entidades.cod_ciudad = int.Parse(txtCodigo.Text);
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
                MessageBox.Show(N_Ciudad.eliminar(int.Parse(txtCodigo.Text)));
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
                this.entidades.cod_ciudad = Convert.ToDecimal(dgv_principal.CurrentRow.Cells[3].Value);
                this.tbp_principal.SelectedIndex = 1;
                opcion = 2;
                activarMantenimiento();

            }
        }

        private void listado()
        {
            try
            {
                dgv_principal.DataSource = N_Barrio.listado();
                dgv_principal.Columns[3].Visible = false; ///no se ve la ultima columna
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

            if (opcion == 5)
            {
                txtCiudad.Text = valor;
                this.entidades.cod_ciudad = codigo;
            }
        }

        #endregion


    }
}
}
