namespace Minimarket
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.tbp_principal = new System.Windows.Forms.TabControl();
            this.tbp_listado = new System.Windows.Forms.TabPage();
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbp_mantenimiento = new System.Windows.Forms.TabPage();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRubro = new System.Windows.Forms.Button();
            this.btnCiudad = new System.Windows.Forms.Button();
            this.btnTipoDoc = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Proveedores";
            // 
            // tbp_principal
            // 
            this.tbp_principal.Controls.Add(this.tbp_listado);
            this.tbp_principal.Controls.Add(this.tbp_mantenimiento);
            this.tbp_principal.Location = new System.Drawing.Point(9, 33);
            this.tbp_principal.Name = "tbp_principal";
            this.tbp_principal.SelectedIndex = 0;
            this.tbp_principal.Size = new System.Drawing.Size(660, 506);
            this.tbp_principal.TabIndex = 16;
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
            this.tbp_listado.Size = new System.Drawing.Size(652, 480);
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
            this.dgv_principal.Size = new System.Drawing.Size(640, 428);
            this.dgv_principal.TabIndex = 3;
            this.dgv_principal.DoubleClick += new System.EventHandler(this.dgv_principal_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(86, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(255, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
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
            this.tbp_mantenimiento.Controls.Add(this.cbbSexo);
            this.tbp_mantenimiento.Controls.Add(this.txtObservacion);
            this.tbp_mantenimiento.Controls.Add(this.label18);
            this.tbp_mantenimiento.Controls.Add(this.label15);
            this.tbp_mantenimiento.Controls.Add(this.txtDireccion);
            this.tbp_mantenimiento.Controls.Add(this.label9);
            this.tbp_mantenimiento.Controls.Add(this.txtMovil);
            this.tbp_mantenimiento.Controls.Add(this.label8);
            this.tbp_mantenimiento.Controls.Add(this.txtTelefono);
            this.tbp_mantenimiento.Controls.Add(this.label14);
            this.tbp_mantenimiento.Controls.Add(this.txtCorreo);
            this.tbp_mantenimiento.Controls.Add(this.label13);
            this.tbp_mantenimiento.Controls.Add(this.txtApellido);
            this.tbp_mantenimiento.Controls.Add(this.label12);
            this.tbp_mantenimiento.Controls.Add(this.txtNombre);
            this.tbp_mantenimiento.Controls.Add(this.label11);
            this.tbp_mantenimiento.Controls.Add(this.txtRazonSocial);
            this.tbp_mantenimiento.Controls.Add(this.label10);
            this.tbp_mantenimiento.Controls.Add(this.txtRubro);
            this.tbp_mantenimiento.Controls.Add(this.label7);
            this.tbp_mantenimiento.Controls.Add(this.txtCiudad);
            this.tbp_mantenimiento.Controls.Add(this.label6);
            this.tbp_mantenimiento.Controls.Add(this.txtTipoDoc);
            this.tbp_mantenimiento.Controls.Add(this.label5);
            this.tbp_mantenimiento.Controls.Add(this.txtNumeroDoc);
            this.tbp_mantenimiento.Controls.Add(this.label4);
            this.tbp_mantenimiento.Controls.Add(this.txtCodigo);
            this.tbp_mantenimiento.Controls.Add(this.label3);
            this.tbp_mantenimiento.Controls.Add(this.btnRubro);
            this.tbp_mantenimiento.Controls.Add(this.btnCiudad);
            this.tbp_mantenimiento.Controls.Add(this.btnTipoDoc);
            this.tbp_mantenimiento.Controls.Add(this.btnEliminar);
            this.tbp_mantenimiento.Controls.Add(this.btnCancelar);
            this.tbp_mantenimiento.Controls.Add(this.btnGuardar);
            this.tbp_mantenimiento.Controls.Add(this.btnNuevo);
            this.tbp_mantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tbp_mantenimiento.Name = "tbp_mantenimiento";
            this.tbp_mantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_mantenimiento.Size = new System.Drawing.Size(652, 480);
            this.tbp_mantenimiento.TabIndex = 1;
            this.tbp_mantenimiento.Text = "Mantenimiento";
            this.tbp_mantenimiento.UseVisualStyleBackColor = true;
            // 
            // cbbSexo
            // 
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Location = new System.Drawing.Point(420, 244);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(182, 21);
            this.cbbSexo.TabIndex = 46;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(102, 327);
            this.txtObservacion.MaxLength = 30;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(500, 71);
            this.txtObservacion.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 330);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Observacion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(383, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Sexo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(102, 288);
            this.txtDireccion.MaxLength = 30;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(500, 20);
            this.txtDireccion.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Direcccion";
            // 
            // txtMovil
            // 
            this.txtMovil.Location = new System.Drawing.Point(102, 241);
            this.txtMovil.MaxLength = 30;
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(182, 20);
            this.txtMovil.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Movil";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(420, 198);
            this.txtTelefono.MaxLength = 30;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(182, 20);
            this.txtTelefono.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(365, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Telefono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(102, 198);
            this.txtCorreo.MaxLength = 30;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(182, 20);
            this.txtCorreo.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Correo";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(420, 150);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(182, 20);
            this.txtApellido.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 150);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Nombre";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(102, 108);
            this.txtRazonSocial.MaxLength = 30;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(182, 20);
            this.txtRazonSocial.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Razon Social(*)";
            // 
            // txtRubro
            // 
            this.txtRubro.Enabled = false;
            this.txtRubro.Location = new System.Drawing.Point(420, 108);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(155, 20);
            this.txtRubro.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rubro";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Location = new System.Drawing.Point(420, 64);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(155, 20);
            this.txtCiudad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ciudad";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Enabled = false;
            this.txtTipoDoc.Location = new System.Drawing.Point(420, 21);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(155, 20);
            this.txtTipoDoc.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo Doc(*)";
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(102, 64);
            this.txtNumeroDoc.MaxLength = 30;
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(182, 20);
            this.txtNumeroDoc.TabIndex = 2;
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
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(102, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(85, 20);
            this.txtCodigo.TabIndex = 1;
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
            // btnRubro
            // 
            this.btnRubro.Image = ((System.Drawing.Image)(resources.GetObject("btnRubro.Image")));
            this.btnRubro.Location = new System.Drawing.Point(581, 101);
            this.btnRubro.Name = "btnRubro";
            this.btnRubro.Size = new System.Drawing.Size(50, 32);
            this.btnRubro.TabIndex = 8;
            this.btnRubro.UseVisualStyleBackColor = true;
            this.btnRubro.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnCiudad
            // 
            this.btnCiudad.Image = ((System.Drawing.Image)(resources.GetObject("btnCiudad.Image")));
            this.btnCiudad.Location = new System.Drawing.Point(581, 57);
            this.btnCiudad.Name = "btnCiudad";
            this.btnCiudad.Size = new System.Drawing.Size(50, 32);
            this.btnCiudad.TabIndex = 6;
            this.btnCiudad.UseVisualStyleBackColor = true;
            this.btnCiudad.Click += new System.EventHandler(this.btnMedida_Click);
            // 
            // btnTipoDoc
            // 
            this.btnTipoDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoDoc.Image")));
            this.btnTipoDoc.Location = new System.Drawing.Point(581, 14);
            this.btnTipoDoc.Name = "btnTipoDoc";
            this.btnTipoDoc.Size = new System.Drawing.Size(50, 32);
            this.btnTipoDoc.TabIndex = 4;
            this.btnTipoDoc.UseVisualStyleBackColor = true;
            this.btnTipoDoc.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(228, 415);
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
            this.btnCancelar.Location = new System.Drawing.Point(339, 415);
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
            this.btnGuardar.Location = new System.Drawing.Point(116, 415);
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
            this.btnNuevo.Location = new System.Drawing.Point(1, 415);
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
            this.btnReporte.Location = new System.Drawing.Point(399, 544);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(124, 62);
            this.btnReporte.TabIndex = 18;
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
            this.btnSalir.Location = new System.Drawing.Point(552, 545);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 61);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(678, 613);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbp_principal);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.tbp_principal.ResumeLayout(false);
            this.tbp_listado.ResumeLayout(false);
            this.tbp_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            this.tbp_mantenimiento.ResumeLayout(false);
            this.tbp_mantenimiento.PerformLayout();
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
        public System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRubro;
        private System.Windows.Forms.Button btnCiudad;
        private System.Windows.Forms.Button btnTipoDoc;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbSexo;
    }
}