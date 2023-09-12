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
    public partial class Ciudad : Form
    {
        int opcion = 2;
        E_Ciudad entidades = new E_Ciudad();        

        public Ciudad()
        {
            InitializeComponent();
        }

        private void Ciudad_Load(object sender, EventArgs e)
        {
            limpiar();
            cargarCod();
            listado();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                buscar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            opcion= 1;
            txtDescripcion.Enabled = true;
            activarMantenimiento();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            limpiar();
            cargarCod();
            //listado();
            cancelar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            limpiar();
            cargarCod();
            //listado();
            cancelar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            cancelar();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Ciudad ciudad= new Reportes.Frm_Ciudad();
            ciudad.ShowDialog();    
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {

            Frm_Buscar_Generico buscar = new Frm_Buscar_Generico();
            AddOwnedForm(buscar);
            buscar.valores(3);
            buscar.ShowDialog();
        }

        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            selectionItems();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region "Metodos Privados"

        //Metodo Validar
        private bool validar()
        {
            bool valor = true;
            if (txtDescripcion.Text == String.Empty || txtDepartamento.Text == String.Empty)
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
            this.txtDepartamento.Text = "";
            this.btnDepartamento.Enabled= false;
            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnNuevo.Enabled = true;
        }
        //Activar botones y campo de texto
        private void activarMantenimiento()
        {
            this.txtDescripcion.Enabled = true;
            this.txtDescripcion.Focus();
            this.btnDepartamento.Enabled = true;
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
            if (validar()) { 
                entidades.cod_ciudad = int.Parse(txtCodigo.Text);
                entidades.descripcion = txtDescripcion.Text;
                String mensaje = N_Ciudad.guardarActualizar(this.opcion, entidades);
                limpiar();
                MessageBox.Show(mensaje);
            }
            txtDescripcion.Focus();


        }

        private void eliminar()
        {
            DialogResult option;
            option = MessageBox.Show("¿ELIMINAR REGISTRO?", "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes){
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
                this.txtDepartamento.Text= Convert.ToString(dgv_principal.CurrentRow.Cells[2].Value);
                this.entidades.cod_departamento = Convert.ToDecimal(dgv_principal.CurrentRow.Cells[3].Value);
                this.tbp_principal.SelectedIndex = 1;
                opcion = 2;
                activarMantenimiento();

            }
        }

        private void listado()
        {
            try
            {
                dgv_principal.DataSource = N_Ciudad.listado();
                dgv_principal.Columns[3].Visible= false; ///no se ve la ultima columna
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

            if (opcion == 3)
            {
                txtDepartamento.Text = valor;
                this.entidades.cod_departamento = codigo;

            }
        }

        #endregion

        
    }
}
