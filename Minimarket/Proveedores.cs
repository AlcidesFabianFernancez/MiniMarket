using Entidades;
using Minimarket.Reportes;
using MySql.Data.MySqlClient;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket
{
    public partial class Proveedores : Form
    {
        string texto = "";
        //MySqlCommand command = null;
        E_Proveedores entidades= new E_Proveedores();
        int opcion = 1;

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            loadBuscar();
            listado();
            cargarSexo();
            sigteCod();
            desactivar();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            enterBucar();
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            leaveBuscar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           opcion= 0;
            activar();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Generico buscar = new Frm_Buscar_Generico();
            AddOwnedForm(buscar);
            buscar.valores(4);
            buscar.ShowDialog();
        }

        private void btnMedida_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Generico buscar = new Frm_Buscar_Generico();
            AddOwnedForm(buscar);
            buscar.valores(5);
            buscar.ShowDialog();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Generico buscar = new Frm_Buscar_Generico();
            AddOwnedForm(buscar);
            buscar.valores(6);
            buscar.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarAtualizar();
            limpiar();
            cargarSexo();
            sigteCod();
            cancelar();
            listado();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar() ; 
            limpiar();
            listado();
        }

        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            selectItem();
            opcion = 1;
            activar();
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            limpiar();
            cargarSexo();
            sigteCod();
            cancelar();
            listado();
            eliminar();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmProveedor proveedor= new FrmProveedor();
            proveedor.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Metodos Privado"
        /// <summary>
        /// 
        /// </summary>
        private void loadBuscar()
        {
            txtBuscar.Text = "Introducir Codigo Proveedor o Numero Documento";
            txtBuscar.ForeColor = Color.Gray;
        }


        /// <summary>
        /// 
        /// </summary>
        private void enterBucar()
        {
            txtBuscar.Text = "";
            txtBuscar.ForeColor = Color.Black;
        }


        /// <summary>
        /// 
        /// </summary>
        private void leaveBuscar()
        {
            texto = txtBuscar.Text;
            if (texto.Equals("Introducir Codigo Proveedor o Numero Documento"))
            {
                txtBuscar.Text = "Introducir Codigo Proveedor o Numero Documento";
                txtBuscar.ForeColor = Color.Gray;
            }
            else
            {
                if (texto.Equals(""))
                {
                    txtBuscar.Text = "Introducir Codigo Proveedor o Numero Documento";
                    txtBuscar.ForeColor = Color.Gray;
                }
                else
                {
                    txtBuscar.Text = texto;
                    txtBuscar.ForeColor = Color.Black;
                }
            }

        }


        /// <summary>
        /// Cargamos la tabla de datos
        /// </summary>
        private void listado()
        {
            try
            {
                dgv_principal.DataSource = N_Proveedor.listado();
                dgv_principal.Columns[5].Visible = false;
                dgv_principal.Columns[6].Visible = false;
                dgv_principal.Columns[7].Visible = false;
                dgv_principal.Columns[8].Visible = false;
                dgv_principal.Columns[9].Visible = false;
                dgv_principal.Columns[10].Visible = false;
                dgv_principal.Columns[11].Visible = false;
                dgv_principal.Columns[12].Visible = false;
                dgv_principal.Columns[13].Visible = false;
                dgv_principal.Columns[14].Visible = false;
                dgv_principal.Columns[15].Visible = false;
                dgv_principal.Columns[16].Visible= false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cargarSexo()
        {
            //cbbSexo.Items.Clear();
            cbbSexo.DataSource = N_Proveedor.cargarSexo();
            cbbSexo.DisplayMember= "descripcion";
            cbbSexo.ValueMember = "cod_sexo";
            
        }

        private bool validar()
        {
            bool valido = true;
            if(string.IsNullOrEmpty(txtRazonSocial.Text) || string.IsNullOrEmpty(txtNumeroDoc.Text) || string.IsNullOrEmpty(txtTipoDoc.Text))
            {
               valido= false;
            }
            return valido;
        }

        private void guardarAtualizar()
        {
            string sexo = cbbSexo.SelectedValue.ToString();
            entidades.observacion=txtObservacion.Text;
            entidades.razon_social=txtRazonSocial.Text;
            entidades.nro_documento=txtNumeroDoc.Text;
            entidades.nombre=txtNombre.Text;
            entidades.telefono=txtTelefono.Text;
            entidades.movil=txtMovil.Text;
            entidades.direccion = txtDireccion.Text;
            entidades.codigo = int.Parse(txtCodigo.Text);
            entidades.apellido = txtApellido.Text;
            entidades.correo= txtCorreo.Text;
            entidades.cod_sexo = int.Parse(sexo);
            string a= cbbSexo.ValueMember.ToString();
            if (validar())
            {
                MessageBox.Show(N_Proveedor.guardarActualizar(opcion, entidades));
            }
        }


        private void sigteCod()
        {
            string cod = N_Proveedor.sgteCod();
            if(cod == "" || cod== null)
            {
                txtCodigo.Text = "1";
            }
            else
            {
                txtCodigo.Text = cod;
            }
        }

        private void activar()
        {
            btnGuardar.Enabled = true;
            btnBarrio.Enabled = true;
            btnRubro.Enabled = true;
            btnTipoDoc.Enabled = true;
            txtApellido.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccion.Enabled = true;
            txtMovil.Enabled = true;
            txtNombre.Enabled = true;
            txtNumeroDoc.Enabled= true;
            txtObservacion.Enabled = true;
            txtRazonSocial.Enabled = true;
            txtTelefono.Enabled = true;
            cbbSexo.Enabled = true;
            btnNuevo.Enabled = false;

        }
        
        private void desactivar()
        {
            btnGuardar.Enabled = false;
            btnBarrio.Enabled = false;  
            btnRubro.Enabled = false;
            btnTipoDoc.Enabled = false;
            txtApellido.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            txtMovil.Enabled = false;
            txtNombre.Enabled = false;
            txtNumeroDoc.Enabled = false;
            txtObservacion.Enabled = false;
            txtRazonSocial.Enabled = false;
            txtTelefono.Enabled = false;
            cbbSexo.Enabled = false;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = false;
        }
        
        private void limpiar()
        {
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtDireccion.Text= string.Empty;
            txtMovil.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNumeroDoc.Text = string.Empty;
            txtObservacion.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtRubro.Text = string.Empty;
            txtTelefono.Text = string.Empty;    
            txtTipoDoc.Text = string.Empty;            
        }

        private void cancelar()
        {
            this.tbp_principal.SelectedIndex = 0;
        }

        private void selectItem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("CELDA VACIA");
            }
            else
            {
                this.txtCodigo.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value);
                this.txtNumeroDoc.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[1].Value);
                this.txtRazonSocial.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[2].Value);
                this.txtNombre.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[3].Value);
                this.txtApellido.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[4].Value);
                this.entidades.tipodocumentos = Convert.ToInt32(dgv_principal.CurrentRow.Cells[5].Value);
                this.txtTipoDoc.Text= Convert.ToString(dgv_principal.CurrentRow.Cells[6].Value);
                this.entidades.cod_sexo = Convert.ToInt32(dgv_principal.CurrentRow.Cells[7].Value);
                //this.cbbSexo.SelectedIndex= Convert.ToInt32(dgv_principal.CurrentRow.Cells[8].Value);
                this.entidades.cod_rubro = Convert.ToInt32(dgv_principal.CurrentRow.Cells[9].Value);
                this.txtRubro.Text= Convert.ToString(dgv_principal.CurrentRow.Cells[10].Value);
                this.txtCorreo.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[11].Value);
                this.txtTelefono.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[12].Value);
                this.txtMovil.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[13].Value);
                this.txtDireccion.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[14].Value);
                this.entidades.cod_barrio= Convert.ToInt32(dgv_principal.CurrentRow.Cells[15].Value);
                this.txtCiudad.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[16].Value);
                this.txtObservacion.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[17].Value);
                this.tbp_principal.SelectedIndex = 1;

                if (entidades.cod_sexo == 1)
                {
                    cbbSexo.SelectedIndex= 0;
                } else if (entidades.cod_sexo == 2)
                {
                    cbbSexo.SelectedIndex = 1;
                }else if(entidades.cod_sexo == 3)
                {
                    cbbSexo.SelectedIndex = 2;
                }

                    opcion = 1;                

            }
        }


        private void eliminar()
        {
            DialogResult option = MessageBox.Show("¿ELIMINAR REGISTRO?", "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(N_Proveedor.eliminar(int.Parse(txtCodigo.Text)));
            }
        }

        private void Buscar()
        {
            try
            {
                dgv_principal.DataSource = N_Proveedor.listar_Decripcion(txtBuscar.Text);
                dgv_principal.Columns[5].Visible = false;
                dgv_principal.Columns[6].Visible = false;
                dgv_principal.Columns[7].Visible = false;
                dgv_principal.Columns[8].Visible = false;
                dgv_principal.Columns[9].Visible = false;
                dgv_principal.Columns[10].Visible = false;
                dgv_principal.Columns[11].Visible = false;
                dgv_principal.Columns[12].Visible = false;
                dgv_principal.Columns[13].Visible = false;
                dgv_principal.Columns[14].Visible = false;
                dgv_principal.Columns[15].Visible = false;
                dgv_principal.Columns[16].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        #endregion



        ////////////////////////////////////////////////////////////////////////////////////////////////   
        #region "Publico"
        public void cargarTxt(int opcion, String valor, int codigo)
        {

            if (opcion == 4)
            {
                txtTipoDoc.Text = valor;
                this.entidades.tipodocumentos = codigo;

            }
            else if (opcion == 5)
            {
                txtCiudad.Text = valor;
                this.entidades.cod_barrio = codigo;
            }
            else if(opcion == 6)
            {
                txtRubro.Text = valor;
                this.entidades.cod_rubro = codigo;
            }
        }


        #endregion

        
    }
}
