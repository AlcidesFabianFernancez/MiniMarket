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
    public partial class Productos : Form
    {
        E_Productos entidades = new E_Productos();
        int opcion = 1;
        public Productos()
        {
            InitializeComponent();
            
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            listado();
            limpiar();
            txtStockMinimo.Text = "0";
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            buscar();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            opcion= 0;
            activarMantenimiento();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            limpiar();
            cancelar();
            listado();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            cancelar();
            listado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
            limpiar();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Generico buscar= new Frm_Buscar_Generico();
            AddOwnedForm(buscar);
            buscar.valores(0);
            buscar.ShowDialog();
        }

        private void btnMedida_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Generico buscar = new Frm_Buscar_Generico();
            AddOwnedForm(buscar);
            buscar.valores(1);
            buscar.ShowDialog();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Generico buscar = new Frm_Buscar_Generico();
            AddOwnedForm(buscar);
            buscar.valores(2);
            buscar.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            selectionItems();
        }


        



        /// <summary>
        /// 
        /// </summary>

        #region "Metodos Privados"
        //Metodo Validar
        private bool validar()
        {
            bool valor = true;
            if (txtDescripcion.Text == String.Empty ||
                txtCategoria.Text == String.Empty ||
                txtMarca.Text == String.Empty ||
                txtMedida.Text == String.Empty ||
                txtStockMinimo.Text == String.Empty)          
            {
                MessageBox.Show("Debe cargar los datos (*)", "Aviso del Sistema", MessageBoxButtons.OK);
                valor= false;
            }
      
            return valor;
        }

        //Cargar siguiente codigo Categoria
        private void cargarCod()
        {
            if (N_Producto.sgteCod() == "")
            {
                txtCodigo.Text ="1";
            }
            else
            {
                txtCodigo.Text = N_Producto.sgteCod();
            }
            
        }

        //limpiar
        private void limpiar()
        {
            cargarCod();
            this.txtDescripcion.Text = "";
            this.txtDescripcion.Enabled = false;
            this.txtStockMinimo.Text = "";
            this.txtStockMinimo.Enabled = false;
            
            this.btnCategoria.Enabled = false;
            this.btnMarca.Enabled = false;
            this.btnMedida.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnNuevo.Enabled = true;
        }
        //Activar botones y campo de texto
        private void activarMantenimiento()
        {
            this.txtDescripcion.Enabled = true;
            this.txtDescripcion.Focus();
            this.txtStockMinimo.Enabled=true;
            this.btnGuardar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnCategoria.Enabled = true;
            this.btnMarca.Enabled = true;
            this.btnMedida.Enabled = true;
            this.btnNuevo.Enabled = false;
        }


        //buscar 
        private void buscar()
        {

            try
            {
                dgv_principal.DataSource = N_Producto.listar_Decripcion(this.txtBuscar.Text.Trim());
                dgv_principal.Columns[6].Visible= false;
                dgv_principal.Columns[7].Visible = false;
                dgv_principal.Columns[8].Visible = false;

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
                dgv_principal.DataSource = N_Producto.listado();
                dgv_principal.Columns[6].Visible = false;
                dgv_principal.Columns[7].Visible = false;
                dgv_principal.Columns[8].Visible = false;

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
                this.entidades.codigo = int.Parse(txtCodigo.Text.Trim());
                this.entidades.descripcion = txtDescripcion.Text.Trim();
                this.entidades.stock_minimo = Convert.ToDecimal(txtStockMinimo.Text.Trim());
                String mensaje = N_Producto.guardarActualizar(this.opcion, entidades);
                limpiar();
                MessageBox.Show(mensaje);
            }
            txtDescripcion.Focus();
           

        }

        private void eliminar()
        {
            DialogResult option;
            option = MessageBox.Show("¿ELIMINAR REISTRO?", "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(N_Producto.eliminar(int.Parse(txtCodigo.Text)));
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
                this.txtMarca.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[2].Value);
                this.txtMedida.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[3].Value);
                this.txtCategoria.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[4].Value);
                this.txtStockMinimo.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[5].Value);
                this.entidades.cod_marcas= Convert.ToDecimal(dgv_principal.CurrentRow.Cells[6].Value);
                this.entidades.cod_medidas= Convert.ToDecimal(dgv_principal.CurrentRow.Cells[7].Value);
                this.entidades.cod_categoria= Convert.ToDecimal(dgv_principal.CurrentRow.Cells[8].Value);
                this.tbp_principal.SelectedIndex = 1;
                opcion = 1;
                activarMantenimiento();
                stockProducto(int.Parse(txtCodigo.Text));
                gbStock.Visible = true;
                

            }
        }


        private void cancelar()
        {
            this.tbp_principal.SelectedIndex = 0;
            this.txtDescripcion.ReadOnly = true;
        }

        private void stockProducto(int valor)
        {
            try
            {
                dgv_StockProducto.DataSource = N_Producto.stock_Producto(valor);              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        #endregion


        #region "Metodo Publico"
        public void cargarTxt(int opcion, String valor, Decimal codigo)
        {
           
            if(opcion== 0)
            {
                txtMarca.Text = valor;
                this.entidades.cod_marcas = codigo;
                
            }
            else if(opcion== 1)
            {
                txtMedida.Text = valor;
                this.entidades.cod_medidas= codigo;
            }
            else
            {
                txtCategoria.Text = valor;
                this.entidades.cod_categoria= codigo;
            }
        }



        #endregion

      
    }
}
