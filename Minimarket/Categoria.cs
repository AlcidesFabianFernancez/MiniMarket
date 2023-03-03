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
    public partial class Categoria : Form
    {
        int opcion = 1;
        N_Categoria negocio = new N_Categoria();

        //Inicio del formulario
        public Categoria()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            
        }
        private void Categoria_Load(object sender, EventArgs e)
        {
            
            listadoCategoria();
            cargarCod();
        }

        #region "Mis Variables"
        int Codigo_ca = 0;
        #endregion


        #region "Listado"      
        //boton salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //boble clic sobre una fila en el datagridview
        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            selectionItems();
        }

        //Boton Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.opcion = 0;//nuevo registro
            activarMantenimiento();

        }

        //Boton Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                E_Categoria entidades = new E_Categoria();
                string rsta = "";
                entidades.cod_categoria = int.Parse(txtCodigo.Text.Trim());
                entidades.descripcion = txtDescripcion.Text.Trim();

                rsta = N_Categoria.guardarActualizar(this.opcion, entidades);
                MessageBox.Show(rsta);
                limpliar();
                this.tbp_principal.SelectedIndex = 0;
                listadoCategoria();
                this.tbp_principal.SelectedIndex = 0;
                this.txtDescripcion.ReadOnly = true;
            }
            txtDescripcion.Focus(); 
           
        }
        //Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tbp_principal.SelectedIndex = 0;
            this.txtDescripcion.ReadOnly = true;

        }

        //Boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult option;
            option = MessageBox.Show("¿ELIMINAR REISTRO?", "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {

                MessageBox.Show(N_Categoria.eliminar(this.Codigo_ca));
                listadoCategoria();
                this.tbp_principal.SelectedIndex = 0;
                this.tbp_principal.SelectedIndex = 0;
                this.txtDescripcion.ReadOnly = true;
                limpliar();
            }

        }

        //Cargamos el datagridView
        private void listadoCategoria()
        {

            try
            {
                this.dgv_principal.DataSource = N_Categoria.listarCategoria();
                //this.dgv_principal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
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
                this.Codigo_ca= int.Parse(Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value));
                this.tbp_principal.SelectedIndex = 1;
                opcion = 1;
                activarMantenimiento();
                
            }
        }

       

        //Boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();

        }

        //enter en txtBuscar
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

        //hacer reporte
        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Categoria reporte = new Reportes.Frm_Categoria();
            reporte.ShowDialog();
        }
        #endregion

        #region"Mantenimiento"

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
            txtCodigo.Text = N_Categoria.sgteCod();
        }

        //limpiar
        private void limpliar()
        {
            cargarCod();
            this.txtDescripcion.Text = "";
            this.txtDescripcion.Enabled = false;           
            this.btnGuardar.Enabled = false;
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
                dgv_principal.DataSource = N_Categoria.listarCategoriaxDecripcion(this.txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }




        #endregion


    }
}