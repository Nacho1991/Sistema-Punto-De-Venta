namespace GUI
{
    partial class frmControlGeneralEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlGeneralEmpleado));
            this.grbRegistros = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.clmDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContrasenna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFotoPerfil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModificadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tstpOpciones = new System.Windows.Forms.ToolStrip();
            this.txtFiltrarDatos = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbOpcionesBusqueda = new System.Windows.Forms.ToolStripComboBox();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.stpEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCantidadEmpleados = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbpEditar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCambiarContrasenna = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.chkAdministrarClientesEditar = new System.Windows.Forms.CheckBox();
            this.chkAdministrarEmpleadoEditar = new System.Windows.Forms.CheckBox();
            this.chkAdministrarInventarioEditar = new System.Windows.Forms.CheckBox();
            this.chkAdministrarCajasEditar = new System.Windows.Forms.CheckBox();
            this.chkAdministrarFacturasEditar = new System.Windows.Forms.CheckBox();
            this.txtCedulaEditar = new System.Windows.Forms.TextBox();
            this.txtNombreUsuarioEditar = new System.Windows.Forms.TextBox();
            this.txtEdadEditar = new System.Windows.Forms.TextBox();
            this.cmbDepartamentoEditar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSexoEditar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoEditar = new System.Windows.Forms.TextBox();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCelularEditar = new System.Windows.Forms.TextBox();
            this.txtApellidosEditar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefonoEditar = new System.Windows.Forms.TextBox();
            this.txtContrasennaEditar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFechaNacimientoEditar = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.tbpAgregar = new System.Windows.Forms.TabPage();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnTomarFoto = new System.Windows.Forms.Button();
            this.ckbVerCaracteresAgregar = new System.Windows.Forms.CheckBox();
            this.grbPrivilegios = new System.Windows.Forms.GroupBox();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.chkAdministrarClientesAgregar = new System.Windows.Forms.CheckBox();
            this.chkAdministrarEmpleadosAgregar = new System.Windows.Forms.CheckBox();
            this.chkAdministrarInventarioAgregar = new System.Windows.Forms.CheckBox();
            this.chkAdministrarCajasAgregar = new System.Windows.Forms.CheckBox();
            this.chkAdministracionFacturasAgregar = new System.Windows.Forms.CheckBox();
            this.txtCedulaAgregar = new System.Windows.Forms.TextBox();
            this.txtNombreUsuarioAgregar = new System.Windows.Forms.TextBox();
            this.txtEdadAgregar = new System.Windows.Forms.TextBox();
            this.cmbDepartamentoAgregar = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbSexoAgregar = new System.Windows.Forms.ComboBox();
            this.txtVerificadorContrasennaAgregar = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtCorreoElectronicoAgregar = new System.Windows.Forms.TextBox();
            this.txtNombreAgregar = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblVerifcarContraseña = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblContrasenna = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCelularAgregar = new System.Windows.Forms.TextBox();
            this.txtApellidosAgregar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonoAgregar = new System.Windows.Forms.TextBox();
            this.txtContraseñaAgregar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaNacimientoAgregar = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpEliminar = new System.Windows.Forms.TabControl();
            this.menuClickDerecho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itmCopiarCelda = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.itmDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.itmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.itmPrivilegios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.grbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.tstpOpciones.SuspendLayout();
            this.stpEstado.SuspendLayout();
            this.tbpEditar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbpAgregar.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.grbPrivilegios.SuspendLayout();
            this.tbpEliminar.SuspendLayout();
            this.menuClickDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegistros
            // 
            this.grbRegistros.Controls.Add(this.dgvRegistros);
            this.grbRegistros.Controls.Add(this.tstpOpciones);
            this.grbRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbRegistros.Location = new System.Drawing.Point(0, 262);
            this.grbRegistros.Name = "grbRegistros";
            this.grbRegistros.Size = new System.Drawing.Size(941, 272);
            this.grbRegistros.TabIndex = 21;
            this.grbRegistros.TabStop = false;
            this.grbRegistros.Text = "Registros";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDepartamento,
            this.clmCedula,
            this.clmNombre,
            this.clmApellidos,
            this.clmFechaNacimiento,
            this.clmTelefono,
            this.clmCelular,
            this.clmContrasenna,
            this.clmFotoPerfil,
            this.clmNombreUsuario,
            this.clmEmail,
            this.clmEdad,
            this.clmSexo,
            this.clmFechaCreacion,
            this.clmFechaModificacion,
            this.clmCreadoPor,
            this.clmModificadoPor});
            this.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistros.Location = new System.Drawing.Point(3, 55);
            this.dgvRegistros.MultiSelect = false;
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(935, 214);
            this.dgvRegistros.TabIndex = 24;
            this.dgvRegistros.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRegistros_CellMouseClick);
            this.dgvRegistros.SelectionChanged += new System.EventHandler(this.dgvRegistros_SelectionChanged);
            // 
            // clmDepartamento
            // 
            this.clmDepartamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDepartamento.DataPropertyName = "Deártamento_Id_Departamento";
            this.clmDepartamento.HeaderText = "Departamento";
            this.clmDepartamento.Name = "clmDepartamento";
            this.clmDepartamento.ReadOnly = true;
            this.clmDepartamento.Width = 111;
            // 
            // clmCedula
            // 
            this.clmCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCedula.DataPropertyName = "id_cedula";
            this.clmCedula.HeaderText = "Cédula";
            this.clmCedula.Name = "clmCedula";
            this.clmCedula.ReadOnly = true;
            this.clmCedula.Width = 71;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombre.DataPropertyName = "nombre";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 77;
            // 
            // clmApellidos
            // 
            this.clmApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmApellidos.DataPropertyName = "apellidos";
            this.clmApellidos.HeaderText = "Apellidos";
            this.clmApellidos.Name = "clmApellidos";
            this.clmApellidos.ReadOnly = true;
            this.clmApellidos.Width = 82;
            // 
            // clmFechaNacimiento
            // 
            this.clmFechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaNacimiento.DataPropertyName = "fecha_nacimiento";
            this.clmFechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.clmFechaNacimiento.Name = "clmFechaNacimiento";
            this.clmFechaNacimiento.ReadOnly = true;
            this.clmFechaNacimiento.Width = 134;
            // 
            // clmTelefono
            // 
            this.clmTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTelefono.DataPropertyName = "telefono";
            this.clmTelefono.HeaderText = "Teléfono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.ReadOnly = true;
            this.clmTelefono.Width = 80;
            // 
            // clmCelular
            // 
            this.clmCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCelular.DataPropertyName = "celular";
            this.clmCelular.HeaderText = "Celular";
            this.clmCelular.Name = "clmCelular";
            this.clmCelular.ReadOnly = true;
            this.clmCelular.Width = 71;
            // 
            // clmContrasenna
            // 
            this.clmContrasenna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmContrasenna.DataPropertyName = "contrasenna";
            this.clmContrasenna.HeaderText = "Contraseña";
            this.clmContrasenna.Name = "clmContrasenna";
            this.clmContrasenna.ReadOnly = true;
            this.clmContrasenna.Visible = false;
            // 
            // clmFotoPerfil
            // 
            this.clmFotoPerfil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFotoPerfil.DataPropertyName = "Dir_Foto_Perfil";
            this.clmFotoPerfil.HeaderText = "Foto de perfil";
            this.clmFotoPerfil.Name = "clmFotoPerfil";
            this.clmFotoPerfil.ReadOnly = true;
            this.clmFotoPerfil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmFotoPerfil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmFotoPerfil.Width = 95;
            // 
            // clmNombreUsuario
            // 
            this.clmNombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombreUsuario.DataPropertyName = "nombre_usuario";
            this.clmNombreUsuario.HeaderText = "Nombre de usuario";
            this.clmNombreUsuario.Name = "clmNombreUsuario";
            this.clmNombreUsuario.ReadOnly = true;
            this.clmNombreUsuario.Width = 126;
            // 
            // clmEmail
            // 
            this.clmEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmEmail.DataPropertyName = "email";
            this.clmEmail.HeaderText = "Correo electronico";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Width = 121;
            // 
            // clmEdad
            // 
            this.clmEdad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmEdad.DataPropertyName = "edad";
            this.clmEdad.HeaderText = "Edad";
            this.clmEdad.Name = "clmEdad";
            this.clmEdad.ReadOnly = true;
            this.clmEdad.Width = 61;
            // 
            // clmSexo
            // 
            this.clmSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmSexo.DataPropertyName = "sexo";
            this.clmSexo.HeaderText = "Sexo";
            this.clmSexo.Name = "clmSexo";
            this.clmSexo.ReadOnly = true;
            this.clmSexo.Width = 60;
            // 
            // clmFechaCreacion
            // 
            this.clmFechaCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaCreacion.DataPropertyName = "fecha_creacion";
            this.clmFechaCreacion.HeaderText = "Fecha de creación";
            this.clmFechaCreacion.Name = "clmFechaCreacion";
            this.clmFechaCreacion.ReadOnly = true;
            this.clmFechaCreacion.Width = 122;
            // 
            // clmFechaModificacion
            // 
            this.clmFechaModificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaModificacion.DataPropertyName = "fecha_modificacion";
            this.clmFechaModificacion.HeaderText = "Fecha de modificación";
            this.clmFechaModificacion.Name = "clmFechaModificacion";
            this.clmFechaModificacion.ReadOnly = true;
            this.clmFechaModificacion.Width = 142;
            // 
            // clmCreadoPor
            // 
            this.clmCreadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCreadoPor.DataPropertyName = "creado_por";
            this.clmCreadoPor.HeaderText = "Creado por";
            this.clmCreadoPor.Name = "clmCreadoPor";
            this.clmCreadoPor.ReadOnly = true;
            this.clmCreadoPor.Width = 86;
            // 
            // clmModificadoPor
            // 
            this.clmModificadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmModificadoPor.DataPropertyName = "modificado_por";
            this.clmModificadoPor.HeaderText = "Modificado por";
            this.clmModificadoPor.Name = "clmModificadoPor";
            this.clmModificadoPor.ReadOnly = true;
            this.clmModificadoPor.Width = 105;
            // 
            // tstpOpciones
            // 
            this.tstpOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstpOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.txtFiltrarDatos,
            this.toolStripLabel1,
            this.cmbOpcionesBusqueda,
            this.btnEliminar,
            this.btnActualizar});
            this.tstpOpciones.Location = new System.Drawing.Point(3, 17);
            this.tstpOpciones.Name = "tstpOpciones";
            this.tstpOpciones.Size = new System.Drawing.Size(935, 38);
            this.tstpOpciones.TabIndex = 23;
            this.tstpOpciones.Text = "toolStrip1";
            // 
            // txtFiltrarDatos
            // 
            this.txtFiltrarDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarDatos.Name = "txtFiltrarDatos";
            this.txtFiltrarDatos.Size = new System.Drawing.Size(100, 38);
            this.txtFiltrarDatos.TextChanged += new System.EventHandler(this.txtFiltrarDatos_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(131, 35);
            this.toolStripLabel1.Text = "Opciones de búsqueda:";
            // 
            // cmbOpcionesBusqueda
            // 
            this.cmbOpcionesBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbOpcionesBusqueda.Items.AddRange(new object[] {
            "Por cédula",
            "Por nombre",
            "Por apellido"});
            this.cmbOpcionesBusqueda.Name = "cmbOpcionesBusqueda";
            this.cmbOpcionesBusqueda.Size = new System.Drawing.Size(141, 38);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 35);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(63, 35);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // stpEstado
            // 
            this.stpEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCantidadEmpleados});
            this.stpEstado.Location = new System.Drawing.Point(0, 534);
            this.stpEstado.Name = "stpEstado";
            this.stpEstado.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.stpEstado.Size = new System.Drawing.Size(941, 22);
            this.stpEstado.SizingGrip = false;
            this.stpEstado.TabIndex = 2;
            this.stpEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "Número de empleados:";
            // 
            // lblCantidadEmpleados
            // 
            this.lblCantidadEmpleados.Name = "lblCantidadEmpleados";
            this.lblCantidadEmpleados.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadEmpleados.Text = "0";
            // 
            // tbpEditar
            // 
            this.tbpEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpEditar.Controls.Add(this.groupBox1);
            this.tbpEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbpEditar.Location = new System.Drawing.Point(4, 24);
            this.tbpEditar.Name = "tbpEditar";
            this.tbpEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEditar.Size = new System.Drawing.Size(933, 234);
            this.tbpEditar.TabIndex = 2;
            this.tbpEditar.Text = "Editar empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCambiarContrasenna);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCedulaEditar);
            this.groupBox1.Controls.Add(this.txtNombreUsuarioEditar);
            this.groupBox1.Controls.Add(this.txtEdadEditar);
            this.groupBox1.Controls.Add(this.cmbDepartamentoEditar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbSexoEditar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCorreoEditar);
            this.groupBox1.Controls.Add(this.txtNombreEditar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCelularEditar);
            this.groupBox1.Controls.Add(this.txtApellidosEditar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtTelefonoEditar);
            this.groupBox1.Controls.Add(this.txtContrasennaEditar);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dtpFechaNacimientoEditar);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnCambiarContrasenna
            // 
            this.btnCambiarContrasenna.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarContrasenna.Image")));
            this.btnCambiarContrasenna.Location = new System.Drawing.Point(639, 116);
            this.btnCambiarContrasenna.Name = "btnCambiarContrasenna";
            this.btnCambiarContrasenna.Size = new System.Drawing.Size(79, 25);
            this.btnCambiarContrasenna.TabIndex = 125;
            this.btnCambiarContrasenna.Text = "Cambiar";
            this.btnCambiarContrasenna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarContrasenna.UseVisualStyleBackColor = true;
            this.btnCambiarContrasenna.Click += new System.EventHandler(this.btnCambiarContrasenna_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditarEmpleado);
            this.groupBox2.Controls.Add(this.chkAdministrarClientesEditar);
            this.groupBox2.Controls.Add(this.chkAdministrarEmpleadoEditar);
            this.groupBox2.Controls.Add(this.chkAdministrarInventarioEditar);
            this.groupBox2.Controls.Add(this.chkAdministrarCajasEditar);
            this.groupBox2.Controls.Add(this.chkAdministrarFacturasEditar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(748, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 208);
            this.groupBox2.TabIndex = 124;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Privilegios";
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarEmpleado.Image")));
            this.btnEditarEmpleado.Location = new System.Drawing.Point(6, 161);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(168, 41);
            this.btnEditarEmpleado.TabIndex = 5;
            this.btnEditarEmpleado.Text = "Editar empleado";
            this.btnEditarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEmpleado.UseVisualStyleBackColor = true;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // chkAdministrarClientesEditar
            // 
            this.chkAdministrarClientesEditar.AutoSize = true;
            this.chkAdministrarClientesEditar.Location = new System.Drawing.Point(20, 136);
            this.chkAdministrarClientesEditar.Name = "chkAdministrarClientesEditar";
            this.chkAdministrarClientesEditar.Size = new System.Drawing.Size(133, 19);
            this.chkAdministrarClientesEditar.TabIndex = 4;
            this.chkAdministrarClientesEditar.Text = "Administrar clientes";
            this.chkAdministrarClientesEditar.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarEmpleadoEditar
            // 
            this.chkAdministrarEmpleadoEditar.AutoSize = true;
            this.chkAdministrarEmpleadoEditar.Location = new System.Drawing.Point(20, 110);
            this.chkAdministrarEmpleadoEditar.Name = "chkAdministrarEmpleadoEditar";
            this.chkAdministrarEmpleadoEditar.Size = new System.Drawing.Size(153, 19);
            this.chkAdministrarEmpleadoEditar.TabIndex = 3;
            this.chkAdministrarEmpleadoEditar.Text = "Administrar empleados";
            this.chkAdministrarEmpleadoEditar.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarInventarioEditar
            // 
            this.chkAdministrarInventarioEditar.AutoSize = true;
            this.chkAdministrarInventarioEditar.Location = new System.Drawing.Point(20, 83);
            this.chkAdministrarInventarioEditar.Name = "chkAdministrarInventarioEditar";
            this.chkAdministrarInventarioEditar.Size = new System.Drawing.Size(144, 19);
            this.chkAdministrarInventarioEditar.TabIndex = 2;
            this.chkAdministrarInventarioEditar.Text = "Administrar inventario";
            this.chkAdministrarInventarioEditar.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarCajasEditar
            // 
            this.chkAdministrarCajasEditar.AutoSize = true;
            this.chkAdministrarCajasEditar.Location = new System.Drawing.Point(20, 57);
            this.chkAdministrarCajasEditar.Name = "chkAdministrarCajasEditar";
            this.chkAdministrarCajasEditar.Size = new System.Drawing.Size(120, 19);
            this.chkAdministrarCajasEditar.TabIndex = 1;
            this.chkAdministrarCajasEditar.Text = "Administrar cajas";
            this.chkAdministrarCajasEditar.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarFacturasEditar
            // 
            this.chkAdministrarFacturasEditar.AutoSize = true;
            this.chkAdministrarFacturasEditar.Location = new System.Drawing.Point(20, 30);
            this.chkAdministrarFacturasEditar.Name = "chkAdministrarFacturasEditar";
            this.chkAdministrarFacturasEditar.Size = new System.Drawing.Size(134, 19);
            this.chkAdministrarFacturasEditar.TabIndex = 0;
            this.chkAdministrarFacturasEditar.Text = "Administrar facturas";
            this.chkAdministrarFacturasEditar.UseVisualStyleBackColor = true;
            // 
            // txtCedulaEditar
            // 
            this.txtCedulaEditar.Location = new System.Drawing.Point(146, 28);
            this.txtCedulaEditar.Name = "txtCedulaEditar";
            this.txtCedulaEditar.ReadOnly = true;
            this.txtCedulaEditar.Size = new System.Drawing.Size(151, 21);
            this.txtCedulaEditar.TabIndex = 102;
            // 
            // txtNombreUsuarioEditar
            // 
            this.txtNombreUsuarioEditar.Location = new System.Drawing.Point(483, 145);
            this.txtNombreUsuarioEditar.Name = "txtNombreUsuarioEditar";
            this.txtNombreUsuarioEditar.Size = new System.Drawing.Size(150, 21);
            this.txtNombreUsuarioEditar.TabIndex = 123;
            // 
            // txtEdadEditar
            // 
            this.txtEdadEditar.Location = new System.Drawing.Point(483, 28);
            this.txtEdadEditar.Name = "txtEdadEditar";
            this.txtEdadEditar.ReadOnly = true;
            this.txtEdadEditar.Size = new System.Drawing.Size(108, 21);
            this.txtEdadEditar.TabIndex = 104;
            this.txtEdadEditar.Text = "0";
            // 
            // cmbDepartamentoEditar
            // 
            this.cmbDepartamentoEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentoEditar.FormattingEnabled = true;
            this.cmbDepartamentoEditar.Items.AddRange(new object[] {
            "Administración",
            "Área de cajas",
            "Área de bodegas"});
            this.cmbDepartamentoEditar.Location = new System.Drawing.Point(483, 89);
            this.cmbDepartamentoEditar.Name = "cmbDepartamentoEditar";
            this.cmbDepartamentoEditar.Size = new System.Drawing.Size(150, 23);
            this.cmbDepartamentoEditar.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 98;
            this.label5.Text = "Nombre:";
            // 
            // cmbSexoEditar
            // 
            this.cmbSexoEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexoEditar.FormattingEnabled = true;
            this.cmbSexoEditar.Items.AddRange(new object[] {
            "Másculino",
            "Femenino"});
            this.cmbSexoEditar.Location = new System.Drawing.Point(483, 58);
            this.cmbSexoEditar.Name = "cmbSexoEditar";
            this.cmbSexoEditar.Size = new System.Drawing.Size(109, 23);
            this.cmbSexoEditar.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 101;
            this.label6.Text = "Apellidos:";
            // 
            // txtCorreoEditar
            // 
            this.txtCorreoEditar.Location = new System.Drawing.Point(483, 172);
            this.txtCorreoEditar.Name = "txtCorreoEditar";
            this.txtCorreoEditar.Size = new System.Drawing.Size(185, 21);
            this.txtCorreoEditar.TabIndex = 119;
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(146, 58);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(231, 21);
            this.txtNombreEditar.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 121;
            this.label7.Text = "Nombre de usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 105;
            this.label8.Text = "Teléfono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 108;
            this.label10.Text = "Sexo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 15);
            this.label11.TabIndex = 118;
            this.label11.Text = "Correo electrónico:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 110;
            this.label12.Text = "Contraseña:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(388, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 15);
            this.label13.TabIndex = 112;
            this.label13.Text = "Departamento:";
            // 
            // txtCelularEditar
            // 
            this.txtCelularEditar.Location = new System.Drawing.Point(146, 172);
            this.txtCelularEditar.Name = "txtCelularEditar";
            this.txtCelularEditar.Size = new System.Drawing.Size(151, 21);
            this.txtCelularEditar.TabIndex = 109;
            // 
            // txtApellidosEditar
            // 
            this.txtApellidosEditar.Location = new System.Drawing.Point(146, 88);
            this.txtApellidosEditar.Name = "txtApellidosEditar";
            this.txtApellidosEditar.Size = new System.Drawing.Size(231, 21);
            this.txtApellidosEditar.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 117;
            this.label14.Text = "Celular:";
            // 
            // txtTelefonoEditar
            // 
            this.txtTelefonoEditar.Location = new System.Drawing.Point(146, 145);
            this.txtTelefonoEditar.Name = "txtTelefonoEditar";
            this.txtTelefonoEditar.Size = new System.Drawing.Size(151, 21);
            this.txtTelefonoEditar.TabIndex = 107;
            // 
            // txtContrasennaEditar
            // 
            this.txtContrasennaEditar.Location = new System.Drawing.Point(483, 118);
            this.txtContrasennaEditar.Name = "txtContrasennaEditar";
            this.txtContrasennaEditar.PasswordChar = '●';
            this.txtContrasennaEditar.ReadOnly = true;
            this.txtContrasennaEditar.Size = new System.Drawing.Size(150, 21);
            this.txtContrasennaEditar.TabIndex = 111;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(434, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 116;
            this.label15.Text = "Edad:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(91, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 15);
            this.label16.TabIndex = 114;
            this.label16.Text = "Cédula:";
            // 
            // dtpFechaNacimientoEditar
            // 
            this.dtpFechaNacimientoEditar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimientoEditar.Location = new System.Drawing.Point(146, 118);
            this.dtpFechaNacimientoEditar.Name = "dtpFechaNacimientoEditar";
            this.dtpFechaNacimientoEditar.Size = new System.Drawing.Size(151, 21);
            this.dtpFechaNacimientoEditar.TabIndex = 103;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 15);
            this.label17.TabIndex = 115;
            this.label17.Text = "Fecha de nacimiento:";
            // 
            // tbpAgregar
            // 
            this.tbpAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpAgregar.Controls.Add(this.grbDatos);
            this.tbpAgregar.Location = new System.Drawing.Point(4, 24);
            this.tbpAgregar.Name = "tbpAgregar";
            this.tbpAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgregar.Size = new System.Drawing.Size(933, 234);
            this.tbpAgregar.TabIndex = 0;
            this.tbpAgregar.Text = "Agregar empleado";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.btnTomarFoto);
            this.grbDatos.Controls.Add(this.ckbVerCaracteresAgregar);
            this.grbDatos.Controls.Add(this.grbPrivilegios);
            this.grbDatos.Controls.Add(this.txtCedulaAgregar);
            this.grbDatos.Controls.Add(this.txtNombreUsuarioAgregar);
            this.grbDatos.Controls.Add(this.txtEdadAgregar);
            this.grbDatos.Controls.Add(this.cmbDepartamentoAgregar);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Controls.Add(this.cmbSexoAgregar);
            this.grbDatos.Controls.Add(this.txtVerificadorContrasennaAgregar);
            this.grbDatos.Controls.Add(this.lblApellidos);
            this.grbDatos.Controls.Add(this.txtCorreoElectronicoAgregar);
            this.grbDatos.Controls.Add(this.txtNombreAgregar);
            this.grbDatos.Controls.Add(this.lblNombreUsuario);
            this.grbDatos.Controls.Add(this.lblTelefono);
            this.grbDatos.Controls.Add(this.lblVerifcarContraseña);
            this.grbDatos.Controls.Add(this.lblSexo);
            this.grbDatos.Controls.Add(this.lblCorreoElectronico);
            this.grbDatos.Controls.Add(this.lblContrasenna);
            this.grbDatos.Controls.Add(this.lblCargo);
            this.grbDatos.Controls.Add(this.txtCelularAgregar);
            this.grbDatos.Controls.Add(this.txtApellidosAgregar);
            this.grbDatos.Controls.Add(this.label4);
            this.grbDatos.Controls.Add(this.txtTelefonoAgregar);
            this.grbDatos.Controls.Add(this.txtContraseñaAgregar);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Controls.Add(this.dtpFechaNacimientoAgregar);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDatos.Location = new System.Drawing.Point(3, 3);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(927, 228);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnTomarFoto.Image")));
            this.btnTomarFoto.Location = new System.Drawing.Point(327, 16);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.Size = new System.Drawing.Size(49, 36);
            this.btnTomarFoto.TabIndex = 68;
            this.btnTomarFoto.UseVisualStyleBackColor = true;
            this.btnTomarFoto.Click += new System.EventHandler(this.btnTomarFoto_Click);
            // 
            // ckbVerCaracteresAgregar
            // 
            this.ckbVerCaracteresAgregar.AutoSize = true;
            this.ckbVerCaracteresAgregar.Location = new System.Drawing.Point(638, 147);
            this.ckbVerCaracteresAgregar.Name = "ckbVerCaracteresAgregar";
            this.ckbVerCaracteresAgregar.Size = new System.Drawing.Size(104, 19);
            this.ckbVerCaracteresAgregar.TabIndex = 13;
            this.ckbVerCaracteresAgregar.Text = "Ver caracteres";
            this.ckbVerCaracteresAgregar.UseVisualStyleBackColor = true;
            this.ckbVerCaracteresAgregar.CheckedChanged += new System.EventHandler(this.ckbVerCaracteresAgregar_CheckedChanged);
            // 
            // grbPrivilegios
            // 
            this.grbPrivilegios.Controls.Add(this.btnAgregarEmpleado);
            this.grbPrivilegios.Controls.Add(this.chkAdministrarClientesAgregar);
            this.grbPrivilegios.Controls.Add(this.chkAdministrarEmpleadosAgregar);
            this.grbPrivilegios.Controls.Add(this.chkAdministrarInventarioAgregar);
            this.grbPrivilegios.Controls.Add(this.chkAdministrarCajasAgregar);
            this.grbPrivilegios.Controls.Add(this.chkAdministracionFacturasAgregar);
            this.grbPrivilegios.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbPrivilegios.Location = new System.Drawing.Point(748, 17);
            this.grbPrivilegios.Name = "grbPrivilegios";
            this.grbPrivilegios.Size = new System.Drawing.Size(176, 208);
            this.grbPrivilegios.TabIndex = 14;
            this.grbPrivilegios.TabStop = false;
            this.grbPrivilegios.Text = "Privilegios";
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEmpleado.Image")));
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(6, 161);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(167, 39);
            this.btnAgregarEmpleado.TabIndex = 20;
            this.btnAgregarEmpleado.Text = "Registrar empleado";
            this.btnAgregarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // chkAdministrarClientesAgregar
            // 
            this.chkAdministrarClientesAgregar.AutoSize = true;
            this.chkAdministrarClientesAgregar.Location = new System.Drawing.Point(20, 136);
            this.chkAdministrarClientesAgregar.Name = "chkAdministrarClientesAgregar";
            this.chkAdministrarClientesAgregar.Size = new System.Drawing.Size(133, 19);
            this.chkAdministrarClientesAgregar.TabIndex = 19;
            this.chkAdministrarClientesAgregar.Text = "Administrar clientes";
            this.chkAdministrarClientesAgregar.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarEmpleadosAgregar
            // 
            this.chkAdministrarEmpleadosAgregar.AutoSize = true;
            this.chkAdministrarEmpleadosAgregar.Location = new System.Drawing.Point(20, 110);
            this.chkAdministrarEmpleadosAgregar.Name = "chkAdministrarEmpleadosAgregar";
            this.chkAdministrarEmpleadosAgregar.Size = new System.Drawing.Size(153, 19);
            this.chkAdministrarEmpleadosAgregar.TabIndex = 18;
            this.chkAdministrarEmpleadosAgregar.Text = "Administrar empleados";
            this.chkAdministrarEmpleadosAgregar.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarInventarioAgregar
            // 
            this.chkAdministrarInventarioAgregar.AutoSize = true;
            this.chkAdministrarInventarioAgregar.Location = new System.Drawing.Point(20, 83);
            this.chkAdministrarInventarioAgregar.Name = "chkAdministrarInventarioAgregar";
            this.chkAdministrarInventarioAgregar.Size = new System.Drawing.Size(144, 19);
            this.chkAdministrarInventarioAgregar.TabIndex = 17;
            this.chkAdministrarInventarioAgregar.Text = "Administrar inventario";
            this.chkAdministrarInventarioAgregar.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarCajasAgregar
            // 
            this.chkAdministrarCajasAgregar.AutoSize = true;
            this.chkAdministrarCajasAgregar.Location = new System.Drawing.Point(20, 57);
            this.chkAdministrarCajasAgregar.Name = "chkAdministrarCajasAgregar";
            this.chkAdministrarCajasAgregar.Size = new System.Drawing.Size(120, 19);
            this.chkAdministrarCajasAgregar.TabIndex = 16;
            this.chkAdministrarCajasAgregar.Text = "Administrar cajas";
            this.chkAdministrarCajasAgregar.UseVisualStyleBackColor = true;
            // 
            // chkAdministracionFacturasAgregar
            // 
            this.chkAdministracionFacturasAgregar.AutoSize = true;
            this.chkAdministracionFacturasAgregar.Location = new System.Drawing.Point(20, 30);
            this.chkAdministracionFacturasAgregar.Name = "chkAdministracionFacturasAgregar";
            this.chkAdministracionFacturasAgregar.Size = new System.Drawing.Size(134, 19);
            this.chkAdministracionFacturasAgregar.TabIndex = 15;
            this.chkAdministracionFacturasAgregar.Text = "Administrar facturas";
            this.chkAdministracionFacturasAgregar.UseVisualStyleBackColor = true;
            // 
            // txtCedulaAgregar
            // 
            this.txtCedulaAgregar.Location = new System.Drawing.Point(145, 28);
            this.txtCedulaAgregar.Name = "txtCedulaAgregar";
            this.txtCedulaAgregar.Size = new System.Drawing.Size(151, 21);
            this.txtCedulaAgregar.TabIndex = 1;
            // 
            // txtNombreUsuarioAgregar
            // 
            this.txtNombreUsuarioAgregar.Location = new System.Drawing.Point(482, 172);
            this.txtNombreUsuarioAgregar.Name = "txtNombreUsuarioAgregar";
            this.txtNombreUsuarioAgregar.Size = new System.Drawing.Size(150, 21);
            this.txtNombreUsuarioAgregar.TabIndex = 12;
            // 
            // txtEdadAgregar
            // 
            this.txtEdadAgregar.Location = new System.Drawing.Point(482, 28);
            this.txtEdadAgregar.Name = "txtEdadAgregar";
            this.txtEdadAgregar.ReadOnly = true;
            this.txtEdadAgregar.Size = new System.Drawing.Size(108, 21);
            this.txtEdadAgregar.TabIndex = 7;
            this.txtEdadAgregar.Text = "0";
            // 
            // cmbDepartamentoAgregar
            // 
            this.cmbDepartamentoAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentoAgregar.FormattingEnabled = true;
            this.cmbDepartamentoAgregar.Items.AddRange(new object[] {
            "Administración",
            "Área de cajas",
            "Área de bodegas"});
            this.cmbDepartamentoAgregar.Location = new System.Drawing.Point(482, 89);
            this.cmbDepartamentoAgregar.Name = "cmbDepartamentoAgregar";
            this.cmbDepartamentoAgregar.Size = new System.Drawing.Size(150, 23);
            this.cmbDepartamentoAgregar.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(84, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmbSexoAgregar
            // 
            this.cmbSexoAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexoAgregar.FormattingEnabled = true;
            this.cmbSexoAgregar.Items.AddRange(new object[] {
            "Másculino",
            "Femenino"});
            this.cmbSexoAgregar.Location = new System.Drawing.Point(482, 58);
            this.cmbSexoAgregar.Name = "cmbSexoAgregar";
            this.cmbSexoAgregar.Size = new System.Drawing.Size(109, 23);
            this.cmbSexoAgregar.TabIndex = 8;
            // 
            // txtVerificadorContrasennaAgregar
            // 
            this.txtVerificadorContrasennaAgregar.Location = new System.Drawing.Point(482, 145);
            this.txtVerificadorContrasennaAgregar.Name = "txtVerificadorContrasennaAgregar";
            this.txtVerificadorContrasennaAgregar.PasswordChar = '●';
            this.txtVerificadorContrasennaAgregar.Size = new System.Drawing.Size(150, 21);
            this.txtVerificadorContrasennaAgregar.TabIndex = 11;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(79, 91);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(60, 15);
            this.lblApellidos.TabIndex = 40;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtCorreoElectronicoAgregar
            // 
            this.txtCorreoElectronicoAgregar.Location = new System.Drawing.Point(482, 199);
            this.txtCorreoElectronicoAgregar.Name = "txtCorreoElectronicoAgregar";
            this.txtCorreoElectronicoAgregar.Size = new System.Drawing.Size(185, 21);
            this.txtCorreoElectronicoAgregar.TabIndex = 14;
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.Location = new System.Drawing.Point(145, 58);
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(231, 21);
            this.txtNombreAgregar.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(357, 175);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(116, 15);
            this.lblNombreUsuario.TabIndex = 67;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(81, 148);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 15);
            this.lblTelefono.TabIndex = 45;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblVerifcarContraseña
            // 
            this.lblVerifcarContraseña.AutoSize = true;
            this.lblVerifcarContraseña.Location = new System.Drawing.Point(355, 148);
            this.lblVerifcarContraseña.Name = "lblVerifcarContraseña";
            this.lblVerifcarContraseña.Size = new System.Drawing.Size(118, 15);
            this.lblVerifcarContraseña.TabIndex = 66;
            this.lblVerifcarContraseña.Text = "Verificar contraseña:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(434, 61);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 15);
            this.lblSexo.TabIndex = 48;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(363, 202);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(110, 15);
            this.lblCorreoElectronico.TabIndex = 64;
            this.lblCorreoElectronico.Text = "Correo electrónico:";
            // 
            // lblContrasenna
            // 
            this.lblContrasenna.AutoSize = true;
            this.lblContrasenna.Location = new System.Drawing.Point(400, 121);
            this.lblContrasenna.Name = "lblContrasenna";
            this.lblContrasenna.Size = new System.Drawing.Size(73, 15);
            this.lblContrasenna.TabIndex = 51;
            this.lblContrasenna.Text = "Contraseña:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(387, 92);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(89, 15);
            this.lblCargo.TabIndex = 57;
            this.lblCargo.Text = "Departamento:";
            // 
            // txtCelularAgregar
            // 
            this.txtCelularAgregar.Location = new System.Drawing.Point(145, 172);
            this.txtCelularAgregar.Name = "txtCelularAgregar";
            this.txtCelularAgregar.Size = new System.Drawing.Size(151, 21);
            this.txtCelularAgregar.TabIndex = 6;
            // 
            // txtApellidosAgregar
            // 
            this.txtApellidosAgregar.Location = new System.Drawing.Point(145, 88);
            this.txtApellidosAgregar.Name = "txtApellidosAgregar";
            this.txtApellidosAgregar.Size = new System.Drawing.Size(231, 21);
            this.txtApellidosAgregar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Celular:";
            // 
            // txtTelefonoAgregar
            // 
            this.txtTelefonoAgregar.Location = new System.Drawing.Point(145, 145);
            this.txtTelefonoAgregar.Name = "txtTelefonoAgregar";
            this.txtTelefonoAgregar.Size = new System.Drawing.Size(151, 21);
            this.txtTelefonoAgregar.TabIndex = 5;
            // 
            // txtContraseñaAgregar
            // 
            this.txtContraseñaAgregar.Location = new System.Drawing.Point(482, 118);
            this.txtContraseñaAgregar.Name = "txtContraseñaAgregar";
            this.txtContraseñaAgregar.PasswordChar = '●';
            this.txtContraseñaAgregar.Size = new System.Drawing.Size(150, 21);
            this.txtContraseñaAgregar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 61;
            this.label3.Text = "Edad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "Cédula:";
            // 
            // dtpFechaNacimientoAgregar
            // 
            this.dtpFechaNacimientoAgregar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimientoAgregar.Location = new System.Drawing.Point(145, 118);
            this.dtpFechaNacimientoAgregar.Name = "dtpFechaNacimientoAgregar";
            this.dtpFechaNacimientoAgregar.Size = new System.Drawing.Size(151, 21);
            this.dtpFechaNacimientoAgregar.TabIndex = 4;
            this.dtpFechaNacimientoAgregar.ValueChanged += new System.EventHandler(this.dtpFechaNacimientoAgregar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // tbpEliminar
            // 
            this.tbpEliminar.Controls.Add(this.tbpAgregar);
            this.tbpEliminar.Controls.Add(this.tbpEditar);
            this.tbpEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbpEliminar.Location = new System.Drawing.Point(0, 0);
            this.tbpEliminar.Name = "tbpEliminar";
            this.tbpEliminar.SelectedIndex = 0;
            this.tbpEliminar.Size = new System.Drawing.Size(941, 262);
            this.tbpEliminar.TabIndex = 23;
            // 
            // menuClickDerecho
            // 
            this.menuClickDerecho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmCopiarCelda,
            this.itmEliminar,
            this.itmDetalles,
            this.itmModificar,
            this.itmPrivilegios});
            this.menuClickDerecho.Name = "menuClickDerecho";
            this.menuClickDerecho.Size = new System.Drawing.Size(196, 114);
            this.menuClickDerecho.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuClickDerecho_ItemClicked);
            // 
            // itmCopiarCelda
            // 
            this.itmCopiarCelda.Image = ((System.Drawing.Image)(resources.GetObject("itmCopiarCelda.Image")));
            this.itmCopiarCelda.Name = "itmCopiarCelda";
            this.itmCopiarCelda.Size = new System.Drawing.Size(195, 22);
            this.itmCopiarCelda.Text = "Copiar dato de la celda";
            // 
            // itmEliminar
            // 
            this.itmEliminar.Image = ((System.Drawing.Image)(resources.GetObject("itmEliminar.Image")));
            this.itmEliminar.Name = "itmEliminar";
            this.itmEliminar.Size = new System.Drawing.Size(195, 22);
            this.itmEliminar.Text = "Eliminar";
            // 
            // itmDetalles
            // 
            this.itmDetalles.Image = ((System.Drawing.Image)(resources.GetObject("itmDetalles.Image")));
            this.itmDetalles.Name = "itmDetalles";
            this.itmDetalles.Size = new System.Drawing.Size(195, 22);
            this.itmDetalles.Text = "Ver detalles";
            // 
            // itmModificar
            // 
            this.itmModificar.Image = ((System.Drawing.Image)(resources.GetObject("itmModificar.Image")));
            this.itmModificar.Name = "itmModificar";
            this.itmModificar.Size = new System.Drawing.Size(195, 22);
            this.itmModificar.Text = "Modificar empleado";
            // 
            // itmPrivilegios
            // 
            this.itmPrivilegios.Image = global::appClientesAsociadosCredito.Properties.Resources.padlock_24051_640;
            this.itmPrivilegios.Name = "itmPrivilegios";
            this.itmPrivilegios.Size = new System.Drawing.Size(195, 22);
            this.itmPrivilegios.Text = "Cambiar privilegios";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 35);
            this.toolStripButton1.Text = "Buescar empleado:";
            // 
            // frmControlGeneralEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 556);
            this.Controls.Add(this.grbRegistros);
            this.Controls.Add(this.tbpEliminar);
            this.Controls.Add(this.stpEstado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmControlGeneralEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control general de empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbRegistros.ResumeLayout(false);
            this.grbRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.tstpOpciones.ResumeLayout(false);
            this.tstpOpciones.PerformLayout();
            this.stpEstado.ResumeLayout(false);
            this.stpEstado.PerformLayout();
            this.tbpEditar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbpAgregar.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbPrivilegios.ResumeLayout(false);
            this.grbPrivilegios.PerformLayout();
            this.tbpEliminar.ResumeLayout(false);
            this.menuClickDerecho.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegistros;
        private System.Windows.Forms.StatusStrip stpEstado;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCantidadEmpleados;
        private System.Windows.Forms.ToolStrip tstpOpciones;
        private System.Windows.Forms.ToolStripTextBox txtFiltrarDatos;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripComboBox cmbOpcionesBusqueda;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabPage tbpEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.CheckBox chkAdministrarClientesEditar;
        private System.Windows.Forms.CheckBox chkAdministrarEmpleadoEditar;
        private System.Windows.Forms.CheckBox chkAdministrarInventarioEditar;
        private System.Windows.Forms.CheckBox chkAdministrarCajasEditar;
        private System.Windows.Forms.CheckBox chkAdministrarFacturasEditar;
        private System.Windows.Forms.TextBox txtCedulaEditar;
        private System.Windows.Forms.TextBox txtNombreUsuarioEditar;
        private System.Windows.Forms.TextBox txtEdadEditar;
        private System.Windows.Forms.ComboBox cmbDepartamentoEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSexoEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoEditar;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCelularEditar;
        private System.Windows.Forms.TextBox txtApellidosEditar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTelefonoEditar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoEditar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tbpAgregar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.CheckBox ckbVerCaracteresAgregar;
        private System.Windows.Forms.GroupBox grbPrivilegios;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.CheckBox chkAdministrarClientesAgregar;
        private System.Windows.Forms.CheckBox chkAdministrarEmpleadosAgregar;
        private System.Windows.Forms.CheckBox chkAdministrarInventarioAgregar;
        private System.Windows.Forms.CheckBox chkAdministrarCajasAgregar;
        private System.Windows.Forms.CheckBox chkAdministracionFacturasAgregar;
        private System.Windows.Forms.TextBox txtCedulaAgregar;
        private System.Windows.Forms.TextBox txtNombreUsuarioAgregar;
        private System.Windows.Forms.TextBox txtEdadAgregar;
        private System.Windows.Forms.ComboBox cmbDepartamentoAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbSexoAgregar;
        private System.Windows.Forms.TextBox txtVerificadorContrasennaAgregar;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtCorreoElectronicoAgregar;
        private System.Windows.Forms.TextBox txtNombreAgregar;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblVerifcarContraseña;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblContrasenna;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCelularAgregar;
        private System.Windows.Forms.TextBox txtApellidosAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonoAgregar;
        private System.Windows.Forms.TextBox txtContraseñaAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tbpEliminar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtContrasennaEditar;
        private System.Windows.Forms.Button btnCambiarContrasenna;
        private System.Windows.Forms.ContextMenuStrip menuClickDerecho;
        private System.Windows.Forms.ToolStripMenuItem itmCopiarCelda;
        private System.Windows.Forms.ToolStripMenuItem itmEliminar;
        private System.Windows.Forms.ToolStripMenuItem itmDetalles;
        private System.Windows.Forms.ToolStripMenuItem itmModificar;
        private System.Windows.Forms.ToolStripMenuItem itmPrivilegios;
        private System.Windows.Forms.Button btnTomarFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContrasenna;
        private System.Windows.Forms.DataGridViewButtonColumn clmFotoPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModificadoPor;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
    }
}