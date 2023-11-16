
namespace Minimarket
{
    partial class Entrada_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada_Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbp_principal = new System.Windows.Forms.TabControl();
            this.tbp_listado = new System.Windows.Forms.TabPage();
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbp_mantenimiento = new System.Windows.Forms.TabPage();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoDocEmi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroDocEmi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoEntrProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnProvee = new System.Windows.Forms.Button();
            this.btnBarrio = new System.Windows.Forms.Button();
            this.btnTipoDoc = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateFechaEP = new System.Windows.Forms.DateTimePicker();
            this.dgv_StockProducto = new System.Windows.Forms.DataGridView();
            this.textIva10 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textIva5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.tbp_principal.SuspendLayout();
            this.tbp_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            this.tbp_mantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Entrada Productos";
            // 
            // tbp_principal
            // 
            this.tbp_principal.Controls.Add(this.tbp_listado);
            this.tbp_principal.Controls.Add(this.tbp_mantenimiento);
            this.tbp_principal.Location = new System.Drawing.Point(6, 36);
            this.tbp_principal.Name = "tbp_principal";
            this.tbp_principal.SelectedIndex = 0;
            this.tbp_principal.Size = new System.Drawing.Size(600, 586);
            this.tbp_principal.TabIndex = 20;
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
            this.tbp_listado.Size = new System.Drawing.Size(592, 560);
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
            this.dgv_principal.Size = new System.Drawing.Size(580, 508);
            this.dgv_principal.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(86, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(255, 20);
            this.txtBuscar.TabIndex = 2;
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
            // tbp_mantenimiento
            // 
            this.tbp_mantenimiento.Controls.Add(this.btnQuitar);
            this.tbp_mantenimiento.Controls.Add(this.btnAgregar);
            this.tbp_mantenimiento.Controls.Add(this.textIva5);
            this.tbp_mantenimiento.Controls.Add(this.label12);
            this.tbp_mantenimiento.Controls.Add(this.textSubtotal);
            this.tbp_mantenimiento.Controls.Add(this.label9);
            this.tbp_mantenimiento.Controls.Add(this.textTotal);
            this.tbp_mantenimiento.Controls.Add(this.label8);
            this.tbp_mantenimiento.Controls.Add(this.textIva10);
            this.tbp_mantenimiento.Controls.Add(this.label7);
            this.tbp_mantenimiento.Controls.Add(this.dgv_StockProducto);
            this.tbp_mantenimiento.Controls.Add(this.dateFechaEP);
            this.tbp_mantenimiento.Controls.Add(this.label11);
            this.tbp_mantenimiento.Controls.Add(this.txtObservacion);
            this.tbp_mantenimiento.Controls.Add(this.label18);
            this.tbp_mantenimiento.Controls.Add(this.txtProveedor);
            this.tbp_mantenimiento.Controls.Add(this.label10);
            this.tbp_mantenimiento.Controls.Add(this.txtBarrio);
            this.tbp_mantenimiento.Controls.Add(this.label6);
            this.tbp_mantenimiento.Controls.Add(this.txtTipoDocEmi);
            this.tbp_mantenimiento.Controls.Add(this.label5);
            this.tbp_mantenimiento.Controls.Add(this.txtNumeroDocEmi);
            this.tbp_mantenimiento.Controls.Add(this.label4);
            this.tbp_mantenimiento.Controls.Add(this.txtCodigoEntrProd);
            this.tbp_mantenimiento.Controls.Add(this.label3);
            this.tbp_mantenimiento.Controls.Add(this.btnProvee);
            this.tbp_mantenimiento.Controls.Add(this.btnBarrio);
            this.tbp_mantenimiento.Controls.Add(this.btnTipoDoc);
            this.tbp_mantenimiento.Controls.Add(this.btnEliminar);
            this.tbp_mantenimiento.Controls.Add(this.btnCancelar);
            this.tbp_mantenimiento.Controls.Add(this.btnGuardar);
            this.tbp_mantenimiento.Controls.Add(this.btnNuevo);
            this.tbp_mantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tbp_mantenimiento.Name = "tbp_mantenimiento";
            this.tbp_mantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_mantenimiento.Size = new System.Drawing.Size(592, 560);
            this.tbp_mantenimiento.TabIndex = 1;
            this.tbp_mantenimiento.Text = "Mantenimiento";
            this.tbp_mantenimiento.UseVisualStyleBackColor = true;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(102, 183);
            this.txtObservacion.MaxLength = 30;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(474, 44);
            this.txtObservacion.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Observacion";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(102, 108);
            this.txtProveedor.MaxLength = 30;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(418, 20);
            this.txtProveedor.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Proveedor(*)";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Enabled = false;
            this.txtBarrio.Location = new System.Drawing.Point(102, 141);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(212, 20);
            this.txtBarrio.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Almacen(*)";
            // 
            // txtTipoDocEmi
            // 
            this.txtTipoDocEmi.Enabled = false;
            this.txtTipoDocEmi.Location = new System.Drawing.Point(274, 21);
            this.txtTipoDocEmi.Name = "txtTipoDocEmi";
            this.txtTipoDocEmi.Size = new System.Drawing.Size(246, 20);
            this.txtTipoDocEmi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo Doc(*)";
            // 
            // txtNumeroDocEmi
            // 
            this.txtNumeroDocEmi.Location = new System.Drawing.Point(102, 64);
            this.txtNumeroDocEmi.MaxLength = 30;
            this.txtNumeroDocEmi.Name = "txtNumeroDocEmi";
            this.txtNumeroDocEmi.Size = new System.Drawing.Size(246, 20);
            this.txtNumeroDocEmi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero Doc.(*)";
            // 
            // txtCodigoEntrProd
            // 
            this.txtCodigoEntrProd.Enabled = false;
            this.txtCodigoEntrProd.Location = new System.Drawing.Point(102, 21);
            this.txtCodigoEntrProd.Name = "txtCodigoEntrProd";
            this.txtCodigoEntrProd.Size = new System.Drawing.Size(85, 20);
            this.txtCodigoEntrProd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporte.Location = new System.Drawing.Point(368, 629);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(124, 62);
            this.btnReporte.TabIndex = 22;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(500, 629);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 61);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
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
            // 
            // btnProvee
            // 
            this.btnProvee.Image = ((System.Drawing.Image)(resources.GetObject("btnProvee.Image")));
            this.btnProvee.Location = new System.Drawing.Point(526, 101);
            this.btnProvee.Name = "btnProvee";
            this.btnProvee.Size = new System.Drawing.Size(50, 32);
            this.btnProvee.TabIndex = 8;
            this.btnProvee.UseVisualStyleBackColor = true;
            // 
            // btnBarrio
            // 
            this.btnBarrio.Image = ((System.Drawing.Image)(resources.GetObject("btnBarrio.Image")));
            this.btnBarrio.Location = new System.Drawing.Point(320, 134);
            this.btnBarrio.Name = "btnBarrio";
            this.btnBarrio.Size = new System.Drawing.Size(50, 32);
            this.btnBarrio.TabIndex = 6;
            this.btnBarrio.UseVisualStyleBackColor = true;
            // 
            // btnTipoDoc
            // 
            this.btnTipoDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoDoc.Image")));
            this.btnTipoDoc.Location = new System.Drawing.Point(526, 14);
            this.btnTipoDoc.Name = "btnTipoDoc";
            this.btnTipoDoc.Size = new System.Drawing.Size(50, 32);
            this.btnTipoDoc.TabIndex = 4;
            this.btnTipoDoc.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(234, 500);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 54);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(345, 500);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 54);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(122, 500);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 54);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(7, 500);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 54);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(355, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Fecha Doc(*)";
            // 
            // dateFechaEP
            // 
            this.dateFechaEP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaEP.Location = new System.Drawing.Point(431, 64);
            this.dateFechaEP.Name = "dateFechaEP";
            this.dateFechaEP.Size = new System.Drawing.Size(144, 20);
            this.dateFechaEP.TabIndex = 48;
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
            this.dgv_StockProducto.Location = new System.Drawing.Point(7, 260);
            this.dgv_StockProducto.Name = "dgv_StockProducto";
            this.dgv_StockProducto.ReadOnly = true;
            this.dgv_StockProducto.Size = new System.Drawing.Size(577, 190);
            this.dgv_StockProducto.TabIndex = 49;
            // 
            // textIva10
            // 
            this.textIva10.Enabled = false;
            this.textIva10.Location = new System.Drawing.Point(370, 460);
            this.textIva10.Name = "textIva10";
            this.textIva10.Size = new System.Drawing.Size(85, 20);
            this.textIva10.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "IVA 10%";
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Location = new System.Drawing.Point(499, 460);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(85, 20);
            this.textTotal.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Total";
            // 
            // textSubtotal
            // 
            this.textSubtotal.Enabled = false;
            this.textSubtotal.Location = new System.Drawing.Point(75, 459);
            this.textSubtotal.Name = "textSubtotal";
            this.textSubtotal.Size = new System.Drawing.Size(85, 20);
            this.textSubtotal.TabIndex = 55;
            this.textSubtotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Sub Total ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textIva5
            // 
            this.textIva5.Enabled = false;
            this.textIva5.Location = new System.Drawing.Point(218, 459);
            this.textIva5.Name = "textIva5";
            this.textIva5.Size = new System.Drawing.Size(85, 20);
            this.textIva5.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "IVA 5%";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(32, 233);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 58;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitar.Location = new System.Drawing.Point(113, 233);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 59;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // Entrada_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(615, 698);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbp_principal);
            this.Name = "Entrada_Productos";
            this.Text = "Entrada_Productos";
            this.tbp_principal.ResumeLayout(false);
            this.tbp_listado.ResumeLayout(false);
            this.tbp_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            this.tbp_mantenimiento.ResumeLayout(false);
            this.tbp_mantenimiento.PerformLayout();
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
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTipoDocEmi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroDocEmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoEntrProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProvee;
        private System.Windows.Forms.Button btnBarrio;
        private System.Windows.Forms.Button btnTipoDoc;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker dateFechaEP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textIva10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_StockProducto;
        private System.Windows.Forms.TextBox textIva5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
    }
}