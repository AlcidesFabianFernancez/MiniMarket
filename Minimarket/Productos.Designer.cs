namespace Minimarket
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbp_principal = new System.Windows.Forms.TabControl();
            this.tbp_listado = new System.Windows.Forms.TabPage();
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbp_mantenimiento = new System.Windows.Forms.TabPage();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.dgv_StockProducto = new System.Windows.Forms.DataGridView();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMedida = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbp_principal.SuspendLayout();
            this.tbp_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            this.tbp_mantenimiento.SuspendLayout();
            this.gbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Productos";
            // 
            // tbp_principal
            // 
            this.tbp_principal.Controls.Add(this.tbp_listado);
            this.tbp_principal.Controls.Add(this.tbp_mantenimiento);
            this.tbp_principal.Location = new System.Drawing.Point(7, 34);
            this.tbp_principal.Name = "tbp_principal";
            this.tbp_principal.SelectedIndex = 0;
            this.tbp_principal.Size = new System.Drawing.Size(660, 393);
            this.tbp_principal.TabIndex = 12;
            // 
            // tbp_listado
            // 
            this.tbp_listado.Controls.Add(this.dgv_principal);
            this.tbp_listado.Controls.Add(this.txtBuscar);
            this.tbp_listado.Controls.Add(this.label2);
            this.tbp_listado.Controls.Add(this.btnBuscar);
            this.tbp_listado.Location = new System.Drawing.Point(4, 22);
            this.tbp_listado.Name = "tbp_listado";
            this.tbp_listado.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_listado.Size = new System.Drawing.Size(652, 367);
            this.tbp_listado.TabIndex = 0;
            this.tbp_listado.Text = "Listado";
            this.tbp_listado.UseVisualStyleBackColor = true;
            // 
            // dgv_principal
            // 
            this.dgv_principal.AllowUserToAddRows = false;
            this.dgv_principal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_principal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_principal.Location = new System.Drawing.Point(6, 46);
            this.dgv_principal.Name = "dgv_principal";
            this.dgv_principal.ReadOnly = true;
            this.dgv_principal.Size = new System.Drawing.Size(640, 315);
            this.dgv_principal.TabIndex = 3;
            this.dgv_principal.DoubleClick += new System.EventHandler(this.dgv_principal_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(86, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(255, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Productos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(357, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 40);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbp_mantenimiento
            // 
            this.tbp_mantenimiento.Controls.Add(this.gbStock);
            this.tbp_mantenimiento.Controls.Add(this.txtStockMinimo);
            this.tbp_mantenimiento.Controls.Add(this.label8);
            this.tbp_mantenimiento.Controls.Add(this.txtCategoria);
            this.tbp_mantenimiento.Controls.Add(this.label7);
            this.tbp_mantenimiento.Controls.Add(this.txtMedida);
            this.tbp_mantenimiento.Controls.Add(this.label6);
            this.tbp_mantenimiento.Controls.Add(this.txtMarca);
            this.tbp_mantenimiento.Controls.Add(this.label5);
            this.tbp_mantenimiento.Controls.Add(this.txtDescripcion);
            this.tbp_mantenimiento.Controls.Add(this.label4);
            this.tbp_mantenimiento.Controls.Add(this.txtCodigo);
            this.tbp_mantenimiento.Controls.Add(this.label3);
            this.tbp_mantenimiento.Controls.Add(this.btnCategoria);
            this.tbp_mantenimiento.Controls.Add(this.btnMedida);
            this.tbp_mantenimiento.Controls.Add(this.btnMarca);
            this.tbp_mantenimiento.Controls.Add(this.btnEliminar);
            this.tbp_mantenimiento.Controls.Add(this.btnCancelar);
            this.tbp_mantenimiento.Controls.Add(this.btnGuardar);
            this.tbp_mantenimiento.Controls.Add(this.btnNuevo);
            this.tbp_mantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tbp_mantenimiento.Name = "tbp_mantenimiento";
            this.tbp_mantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_mantenimiento.Size = new System.Drawing.Size(652, 367);
            this.tbp_mantenimiento.TabIndex = 1;
            this.tbp_mantenimiento.Text = "Mantenimiento";
            this.tbp_mantenimiento.UseVisualStyleBackColor = true;
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.dgv_StockProducto);
            this.gbStock.Location = new System.Drawing.Point(313, 21);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(318, 263);
            this.gbStock.TabIndex = 24;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "Stock Producto";
            this.gbStock.Visible = false;
            // 
            // dgv_StockProducto
            // 
            this.dgv_StockProducto.AllowUserToAddRows = false;
            this.dgv_StockProducto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_StockProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_StockProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StockProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_StockProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StockProducto.Enabled = false;
            this.dgv_StockProducto.Location = new System.Drawing.Point(6, 19);
            this.dgv_StockProducto.Name = "dgv_StockProducto";
            this.dgv_StockProducto.ReadOnly = true;
            this.dgv_StockProducto.Size = new System.Drawing.Size(303, 229);
            this.dgv_StockProducto.TabIndex = 24;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(69, 249);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(76, 20);
            this.txtStockMinimo.TabIndex = 9;
            this.txtStockMinimo.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Stock Minimo(*)";
            // 
            // txtCategoria
            // 
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(86, 194);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(155, 20);
            this.txtCategoria.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Categoria(*)";
            // 
            // txtMedida
            // 
            this.txtMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedida.Enabled = false;
            this.txtMedida.Location = new System.Drawing.Point(86, 147);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(155, 20);
            this.txtMedida.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "U. Medida(*)";
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(86, 100);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(155, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Marca(*)";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(86, 57);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(182, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripcion(*)";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(86, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(85, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.Location = new System.Drawing.Point(247, 187);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(50, 32);
            this.btnCategoria.TabIndex = 8;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnMedida
            // 
            this.btnMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnMedida.Image")));
            this.btnMedida.Location = new System.Drawing.Point(247, 140);
            this.btnMedida.Name = "btnMedida";
            this.btnMedida.Size = new System.Drawing.Size(50, 32);
            this.btnMedida.TabIndex = 6;
            this.btnMedida.UseVisualStyleBackColor = true;
            this.btnMedida.Click += new System.EventHandler(this.btnMedida_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnMarca.Image")));
            this.btnMarca.Location = new System.Drawing.Point(247, 93);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(50, 32);
            this.btnMarca.TabIndex = 4;
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(237, 290);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 54);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(348, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 54);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(125, 290);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 54);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(10, 290);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 54);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporte.Location = new System.Drawing.Point(387, 433);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(124, 62);
            this.btnReporte.TabIndex = 14;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(540, 434);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 61);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(683, 501);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbp_principal);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.tbp_principal.ResumeLayout(false);
            this.tbp_listado.ResumeLayout(false);
            this.tbp_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            this.tbp_mantenimiento.ResumeLayout(false);
            this.tbp_mantenimiento.PerformLayout();
            this.gbStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbp_principal;
        private System.Windows.Forms.TabPage tbp_listado;
        private System.Windows.Forms.DataGridView dgv_principal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tbp_mantenimiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtMedida;
        public System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.DataGridView dgv_StockProducto;
    }
}