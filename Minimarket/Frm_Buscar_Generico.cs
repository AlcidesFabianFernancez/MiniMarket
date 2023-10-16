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
    public partial class Frm_Buscar_Generico : Form
    {
        int opcion = 0;
        public Frm_Buscar_Generico()
        {
            InitializeComponent();
        }

        private void Frm_Buscar_Generico_Load(object sender, EventArgs e)
        {
            presentacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            buscar();
        }

        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            selectionItems();                     
            
            
        }


        #region "Metodos"

        public void valores(int valor)
        {
            opcion = valor;
        }

        private void presentacion()
        {
            switch (opcion)
            {
                case 0:
                    lblTitulo.Text = "Marcas";
                    lblTitulo.Location = new Point(180, 10);
                    try
                    {
                        dgv_principal.DataSource = N_Producto.listar_Decripcion_mar("");
                        dgv_principal.Columns[1].Visible = false;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;
                    
                case 1:
                    lblTitulo.Text = "Unidad de Medida";
                    lblTitulo.Location = new Point(135, 10);
                    try
                    {
                        dgv_principal.DataSource = N_Producto.listar_Decripcion_uni("");
                        dgv_principal.Columns[1].Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;

                case 2:
                    lblTitulo.Text = "Categoria";
                    lblTitulo.Location = new Point(170, 10);
                    try
                    {
                        dgv_principal.DataSource = N_Producto.listar_Decripcion_ca("");
                        dgv_principal.Columns[1].Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;
                case 3:
                    lblTitulo.Text = "Departamento";
                    lblTitulo.Location = new Point(170, 10);
                    try
                    {
                        dgv_principal.DataSource = N_Ciudad.listado_Descripcion_edpa("");
                        dgv_principal.Columns[1].Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;
                case 4:
                    lblTitulo.Text = "Tipo Documento";
                    lblTitulo.Location = new Point(170, 10);
                    try
                    {
                        dgv_principal.DataSource = N_Proveedor.listado_Tipo_Doc("");
                        dgv_principal.Columns[1].Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;
                case 5:
                    lblTitulo.Text = "Ciudad";
                    lblTitulo.Location = new Point(170, 10);
                    try
                    {
                        dgv_principal.DataSource = N_Proveedor.listado_ciudad("");
                        dgv_principal.Columns[1].Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;
                case 6:
                    lblTitulo.Text = "Rubro";
                    lblTitulo.Location = new Point(170, 10);
                    try
                    {
                        dgv_principal.DataSource = N_Proveedor.listado_rubro("");
                        dgv_principal.Columns[1].Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;
                case 7:
                    lblTitulo.Text = "Ciudad";
                    lblTitulo.Location = new Point(170, 10);
                    try
                    {
                        dgv_principal.DataSource = N_Barrio.listado_Descripcion_edpa("");
                        dgv_principal.Columns[1].Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    break;
            }
           
        }


        private  void buscar()
        {
            if(opcion== 0)
            {
                try
                {
                    dgv_principal.DataSource = N_Producto.listar_Decripcion_mar(this.txtBuscar.Text.Trim());
                    dgv_principal.Columns[1].Visible = false;
                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if(opcion== 1)
            {
                try
                {
                    dgv_principal.DataSource = N_Producto.listar_Decripcion_uni(this.txtBuscar.Text.Trim());
                    dgv_principal.Columns[1].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if(opcion==2)
            {
                try
                {
                    dgv_principal.DataSource = N_Producto.listar_Decripcion_ca(this.txtBuscar.Text.Trim());
                    dgv_principal.Columns[1].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if(opcion== 3)
            {
                try
                {
                    dgv_principal.DataSource = N_Ciudad.listado_Descripcion_edpa(this.txtBuscar.Text.Trim());
                    dgv_principal.Columns[1].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (opcion == 4)
            {
                try
                {
                    dgv_principal.DataSource = N_Proveedor.listado_Tipo_Doc(this.txtBuscar.Text.Trim());
                    dgv_principal.Columns[1].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (opcion == 5)
            {
                try
                {
                    dgv_principal.DataSource = N_Proveedor.listado_ciudad(this.txtBuscar.Text.Trim());
                    dgv_principal.Columns[1].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (opcion == 6)
            {
                try
                {
                    dgv_principal.DataSource = N_Proveedor.listado_rubro(this.txtBuscar.Text.Trim());
                    dgv_principal.Columns[1].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (opcion == 7)
            {
                try
                {
                    dgv_principal.DataSource = N_Barrio.listado_Descripcion_edpa(this.txtBuscar.Text.Trim());
                    dgv_principal.Columns[1].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
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
                if (opcion == 0 || opcion ==1 || opcion == 2)
                {
                    Productos producto = Owner as Productos;
                    producto.cargarTxt(opcion, Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value), Convert.ToDecimal(dgv_principal.CurrentRow.Cells[1].Value));
                    this.Close();
                }
                else if (opcion == 3)
                {
                    Ciudad ciudad = Owner as Ciudad;
                    ciudad.cargarTxt(opcion, Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value), Convert.ToDecimal(dgv_principal.CurrentRow.Cells[1].Value));
                    this.Close();
                }
                else if (opcion == 4 || opcion == 5 || opcion == 6)
                {
                    Proveedores proveedor = Owner as Proveedores;
                    proveedor.cargarTxt(opcion, Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value), Convert.ToInt32(dgv_principal.CurrentRow.Cells[1].Value));
                    this.Close();
                }
                else if (opcion == 7 )
                {
                    Barrio barrio = Owner as Barrio;
                    barrio.cargarTxt(opcion, Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value), Convert.ToInt32(dgv_principal.CurrentRow.Cells[1].Value));
                    this.Close();
                }


            }
        }



        #endregion

       
    }
}
