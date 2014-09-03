namespace GUI
{
    partial class frmControlGeneralClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlGeneralClientes));
            this.grbRegsitros = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.clmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModificadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlsBusqueda = new System.Windows.Forms.ToolStrip();
            this.lblBuscarEditar = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltrarDatos = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stbtnVerOpcionesBusqueda = new System.Windows.Forms.ToolStripLabel();
            this.cmbOpcionesBusqueda = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.stbEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNumeroClientes = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuClickDerecho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarDatoDeLaCeldaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcDatos = new System.Windows.Forms.TabControl();
            this.tbpAgregar = new System.Windows.Forms.TabPage();
            this.grbDatosAgregar = new System.Windows.Forms.GroupBox();
            this.txtTelefonoAgregar = new System.Windows.Forms.TextBox();
            this.txtCelularAgregar = new System.Windows.Forms.TextBox();
            this.cmbTipoClienteAgregar = new System.Windows.Forms.ComboBox();
            this.txtDireccionAgregar = new System.Windows.Forms.TextBox();
            this.btnRegistrarAgregar = new System.Windows.Forms.Button();
            this.lblCelularAgregar = new System.Windows.Forms.Label();
            this.lblTelefonoAgregar = new System.Windows.Forms.Label();
            this.lblTipoClienteAgregar = new System.Windows.Forms.Label();
            this.lblDireccionAgregar = new System.Windows.Forms.Label();
            this.txtApellidosAgregar = new System.Windows.Forms.TextBox();
            this.txtNombreAgregar = new System.Windows.Forms.TextBox();
            this.txtCedulaAgregar = new System.Windows.Forms.TextBox();
            this.lblApellidosAgregar = new System.Windows.Forms.Label();
            this.lblNombreAgregar = new System.Windows.Forms.Label();
            this.lblCedulaAgregar = new System.Windows.Forms.Label();
            this.grbCreditoAgregar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroRegistroAgregar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoActualAgregar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeriodoPagoAgregar = new System.Windows.Forms.Label();
            this.cmbEstadoAgregar = new System.Windows.Forms.ComboBox();
            this.lblMontoAcreditarAgregar = new System.Windows.Forms.Label();
            this.lblEstadoAgregar = new System.Windows.Forms.Label();
            this.txtMontoAcreditarAgregar = new System.Windows.Forms.TextBox();
            this.cmbPeriodoPagoAgregar = new System.Windows.Forms.ComboBox();
            this.tbpEditar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumRegistro = new System.Windows.Forms.Label();
            this.lblMontoCreditoEditar = new System.Windows.Forms.Label();
            this.lblFechaEstablecidaEditar = new System.Windows.Forms.Label();
            this.lblMontoDisponibleEditar = new System.Windows.Forms.Label();
            this.lblPeriodoPagoEditar = new System.Windows.Forms.Label();
            this.lblProximoCobroEditar = new System.Windows.Forms.Label();
            this.lblEstadoClienteEditar = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbDatosEditar = new System.Windows.Forms.GroupBox();
            this.btnEditarDatosEditar = new System.Windows.Forms.Button();
            this.txtTelefonoEditar = new System.Windows.Forms.TextBox();
            this.txtCelularEditar = new System.Windows.Forms.TextBox();
            this.cmbTipoClienteEditar = new System.Windows.Forms.ComboBox();
            this.txtDireccionEditar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtApellidosEditar = new System.Windows.Forms.TextBox();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.txtCedulaEditar = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaInicioCreditoEditar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroRegistroEditar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoActualEditar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEstadoEditar = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMontoAcreditarEditar = new System.Windows.Forms.TextBox();
            this.cmbPeriodoPagoEditar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grbRegsitros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.tlsBusqueda.SuspendLayout();
            this.stbEstado.SuspendLayout();
            this.menuClickDerecho.SuspendLayout();
            this.tbcDatos.SuspendLayout();
            this.tbpAgregar.SuspendLayout();
            this.grbDatosAgregar.SuspendLayout();
            this.grbCreditoAgregar.SuspendLayout();
            this.tbpEditar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbDatosEditar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegsitros
            // 
            this.grbRegsitros.Controls.Add(this.dgvRegistros);
            this.grbRegsitros.Controls.Add(this.tlsBusqueda);
            this.grbRegsitros.Controls.Add(this.stbEstado);
            this.grbRegsitros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbRegsitros.Location = new System.Drawing.Point(0, 263);
            this.grbRegsitros.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegsitros.Name = "grbRegsitros";
            this.grbRegsitros.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegsitros.Size = new System.Drawing.Size(1098, 229);
            this.grbRegsitros.TabIndex = 14;
            this.grbRegsitros.TabStop = false;
            this.grbRegsitros.Text = "Regsitros";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCedula,
            this.clmNombre,
            this.clmApellidos,
            this.clmEstadoCliente,
            this.clmDireccion,
            this.clmTipoCliente,
            this.clmCelular,
            this.clmTelefono,
            this.clmFechaCreacion,
            this.clmFechaModificacion,
            this.clmModificadoPor,
            this.clmCreadoPor});
            this.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistros.Location = new System.Drawing.Point(4, 57);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(1090, 146);
            this.dgvRegistros.TabIndex = 16;
            this.dgvRegistros.SelectionChanged += new System.EventHandler(this.dgvRegistros_SelectionChanged);
            // 
            // clmCedula
            // 
            this.clmCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCedula.DataPropertyName = "ID_CEDULA";
            this.clmCedula.HeaderText = "Cédula";
            this.clmCedula.Name = "clmCedula";
            this.clmCedula.ReadOnly = true;
            this.clmCedula.Width = 76;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombre.DataPropertyName = "NOMBRE";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 82;
            // 
            // clmApellidos
            // 
            this.clmApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmApellidos.DataPropertyName = "APELLIDOS";
            this.clmApellidos.HeaderText = "Apellidos";
            this.clmApellidos.Name = "clmApellidos";
            this.clmApellidos.ReadOnly = true;
            this.clmApellidos.Width = 90;
            // 
            // clmEstadoCliente
            // 
            this.clmEstadoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmEstadoCliente.DataPropertyName = "Estado_Cliente";
            this.clmEstadoCliente.HeaderText = "Estado";
            this.clmEstadoCliente.Name = "clmEstadoCliente";
            this.clmEstadoCliente.ReadOnly = true;
            this.clmEstadoCliente.Width = 76;
            // 
            // clmDireccion
            // 
            this.clmDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDireccion.DataPropertyName = "Direccion";
            this.clmDireccion.HeaderText = "Dirección";
            this.clmDireccion.Name = "clmDireccion";
            this.clmDireccion.ReadOnly = true;
            this.clmDireccion.Width = 90;
            // 
            // clmTipoCliente
            // 
            this.clmTipoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTipoCliente.DataPropertyName = "Tipo_Cliente_Id_Tipo_Cliente";
            this.clmTipoCliente.HeaderText = "Tipo de cliente";
            this.clmTipoCliente.Name = "clmTipoCliente";
            this.clmTipoCliente.ReadOnly = true;
            this.clmTipoCliente.Width = 112;
            // 
            // clmCelular
            // 
            this.clmCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCelular.DataPropertyName = "celular";
            this.clmCelular.HeaderText = "Celular";
            this.clmCelular.Name = "clmCelular";
            this.clmCelular.ReadOnly = true;
            this.clmCelular.Width = 75;
            // 
            // clmTelefono
            // 
            this.clmTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTelefono.DataPropertyName = "telefono";
            this.clmTelefono.HeaderText = "Télefono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.ReadOnly = true;
            this.clmTelefono.Width = 87;
            // 
            // clmFechaCreacion
            // 
            this.clmFechaCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaCreacion.DataPropertyName = "Fcha_Creacion";
            this.clmFechaCreacion.HeaderText = "Fecha de creación";
            this.clmFechaCreacion.Name = "clmFechaCreacion";
            this.clmFechaCreacion.ReadOnly = true;
            this.clmFechaCreacion.Width = 132;
            // 
            // clmFechaModificacion
            // 
            this.clmFechaModificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaModificacion.DataPropertyName = "Fecha_Modificacion";
            this.clmFechaModificacion.HeaderText = "Fecha de modificación";
            this.clmFechaModificacion.Name = "clmFechaModificacion";
            this.clmFechaModificacion.ReadOnly = true;
            this.clmFechaModificacion.Width = 154;
            // 
            // clmModificadoPor
            // 
            this.clmModificadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmModificadoPor.DataPropertyName = "Modificado_Por";
            this.clmModificadoPor.HeaderText = "Modificado por";
            this.clmModificadoPor.Name = "clmModificadoPor";
            this.clmModificadoPor.ReadOnly = true;
            this.clmModificadoPor.Width = 113;
            // 
            // clmCreadoPor
            // 
            this.clmCreadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCreadoPor.DataPropertyName = "Creado_Por";
            this.clmCreadoPor.HeaderText = "Creado por";
            this.clmCreadoPor.Name = "clmCreadoPor";
            this.clmCreadoPor.ReadOnly = true;
            this.clmCreadoPor.Width = 93;
            // 
            // tlsBusqueda
            // 
            this.tlsBusqueda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlsBusqueda.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlsBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBuscarEditar,
            this.txtFiltrarDatos,
            this.toolStripSeparator1,
            this.stbtnVerOpcionesBusqueda,
            this.cmbOpcionesBusqueda,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.btnActualizar});
            this.tlsBusqueda.Location = new System.Drawing.Point(4, 19);
            this.tlsBusqueda.Name = "tlsBusqueda";
            this.tlsBusqueda.Size = new System.Drawing.Size(1090, 38);
            this.tlsBusqueda.TabIndex = 15;
            this.tlsBusqueda.Text = "toolStrip1";
            // 
            // lblBuscarEditar
            // 
            this.lblBuscarEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblBuscarEditar.Image = ((System.Drawing.Image)(resources.GetObject("lblBuscarEditar.Image")));
            this.lblBuscarEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lblBuscarEditar.Name = "lblBuscarEditar";
            this.lblBuscarEditar.Size = new System.Drawing.Size(45, 35);
            this.lblBuscarEditar.Text = "Buscar:";
            // 
            // txtFiltrarDatos
            // 
            this.txtFiltrarDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarDatos.Name = "txtFiltrarDatos";
            this.txtFiltrarDatos.Size = new System.Drawing.Size(100, 38);
            this.txtFiltrarDatos.TextChanged += new System.EventHandler(this.txtBuscarEditar_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // stbtnVerOpcionesBusqueda
            // 
            this.stbtnVerOpcionesBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stbtnVerOpcionesBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("stbtnVerOpcionesBusqueda.Image")));
            this.stbtnVerOpcionesBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbtnVerOpcionesBusqueda.Name = "stbtnVerOpcionesBusqueda";
            this.stbtnVerOpcionesBusqueda.Size = new System.Drawing.Size(131, 35);
            this.stbtnVerOpcionesBusqueda.Text = "Opciones de búsqueda:";
            // 
            // cmbOpcionesBusqueda
            // 
            this.cmbOpcionesBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbOpcionesBusqueda.Items.AddRange(new object[] {
            "Por cédula",
            "Por apellidos",
            "Por estado"});
            this.cmbOpcionesBusqueda.Name = "cmbOpcionesBusqueda";
            this.cmbOpcionesBusqueda.Size = new System.Drawing.Size(121, 38);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 35);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // stbEstado
            // 
            this.stbEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblNumeroClientes});
            this.stbEstado.Location = new System.Drawing.Point(4, 203);
            this.stbEstado.Name = "stbEstado";
            this.stbEstado.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stbEstado.Size = new System.Drawing.Size(1090, 22);
            this.stbEstado.SizingGrip = false;
            this.stbEstado.TabIndex = 1;
            this.stbEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel1.Text = "Número de clientes:";
            // 
            // lblNumeroClientes
            // 
            this.lblNumeroClientes.Name = "lblNumeroClientes";
            this.lblNumeroClientes.Size = new System.Drawing.Size(13, 17);
            this.lblNumeroClientes.Text = "0";
            // 
            // menuClickDerecho
            // 
            this.menuClickDerecho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarDatoDeLaCeldaToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.editarProductoToolStripMenuItem,
            this.verDetallesToolStripMenuItem});
            this.menuClickDerecho.Name = "menuClickDerecho";
            this.menuClickDerecho.Size = new System.Drawing.Size(196, 92);
            // 
            // copiarDatoDeLaCeldaToolStripMenuItem
            // 
            this.copiarDatoDeLaCeldaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarDatoDeLaCeldaToolStripMenuItem.Image")));
            this.copiarDatoDeLaCeldaToolStripMenuItem.Name = "copiarDatoDeLaCeldaToolStripMenuItem";
            this.copiarDatoDeLaCeldaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.copiarDatoDeLaCeldaToolStripMenuItem.Text = "Copiar dato de la celda";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarProductoToolStripMenuItem.Image")));
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.editarProductoToolStripMenuItem.Text = "Editar producto";
            // 
            // verDetallesToolStripMenuItem
            // 
            this.verDetallesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verDetallesToolStripMenuItem.Image")));
            this.verDetallesToolStripMenuItem.Name = "verDetallesToolStripMenuItem";
            this.verDetallesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.verDetallesToolStripMenuItem.Text = "Ver detalles";
            // 
            // tbcDatos
            // 
            this.tbcDatos.Controls.Add(this.tbpAgregar);
            this.tbcDatos.Controls.Add(this.tbpEditar);
            this.tbcDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcDatos.Location = new System.Drawing.Point(0, 0);
            this.tbcDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tbcDatos.Name = "tbcDatos";
            this.tbcDatos.SelectedIndex = 0;
            this.tbcDatos.Size = new System.Drawing.Size(1098, 263);
            this.tbcDatos.TabIndex = 15;
            // 
            // tbpAgregar
            // 
            this.tbpAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpAgregar.Controls.Add(this.grbDatosAgregar);
            this.tbpAgregar.Controls.Add(this.grbCreditoAgregar);
            this.tbpAgregar.Location = new System.Drawing.Point(4, 25);
            this.tbpAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.tbpAgregar.Name = "tbpAgregar";
            this.tbpAgregar.Padding = new System.Windows.Forms.Padding(4);
            this.tbpAgregar.Size = new System.Drawing.Size(1090, 234);
            this.tbpAgregar.TabIndex = 0;
            this.tbpAgregar.Text = "Agregar";
            // 
            // grbDatosAgregar
            // 
            this.grbDatosAgregar.Controls.Add(this.txtTelefonoAgregar);
            this.grbDatosAgregar.Controls.Add(this.txtCelularAgregar);
            this.grbDatosAgregar.Controls.Add(this.cmbTipoClienteAgregar);
            this.grbDatosAgregar.Controls.Add(this.txtDireccionAgregar);
            this.grbDatosAgregar.Controls.Add(this.btnRegistrarAgregar);
            this.grbDatosAgregar.Controls.Add(this.lblCelularAgregar);
            this.grbDatosAgregar.Controls.Add(this.lblTelefonoAgregar);
            this.grbDatosAgregar.Controls.Add(this.lblTipoClienteAgregar);
            this.grbDatosAgregar.Controls.Add(this.lblDireccionAgregar);
            this.grbDatosAgregar.Controls.Add(this.txtApellidosAgregar);
            this.grbDatosAgregar.Controls.Add(this.txtNombreAgregar);
            this.grbDatosAgregar.Controls.Add(this.txtCedulaAgregar);
            this.grbDatosAgregar.Controls.Add(this.lblApellidosAgregar);
            this.grbDatosAgregar.Controls.Add(this.lblNombreAgregar);
            this.grbDatosAgregar.Controls.Add(this.lblCedulaAgregar);
            this.grbDatosAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbDatosAgregar.Location = new System.Drawing.Point(4, 4);
            this.grbDatosAgregar.Name = "grbDatosAgregar";
            this.grbDatosAgregar.Size = new System.Drawing.Size(466, 226);
            this.grbDatosAgregar.TabIndex = 45;
            this.grbDatosAgregar.TabStop = false;
            this.grbDatosAgregar.Text = "Datos del cliente";
            // 
            // txtTelefonoAgregar
            // 
            this.txtTelefonoAgregar.Location = new System.Drawing.Point(353, 51);
            this.txtTelefonoAgregar.Name = "txtTelefonoAgregar";
            this.txtTelefonoAgregar.Size = new System.Drawing.Size(105, 22);
            this.txtTelefonoAgregar.TabIndex = 7;
            // 
            // txtCelularAgregar
            // 
            this.txtCelularAgregar.Location = new System.Drawing.Point(353, 23);
            this.txtCelularAgregar.Name = "txtCelularAgregar";
            this.txtCelularAgregar.Size = new System.Drawing.Size(105, 22);
            this.txtCelularAgregar.TabIndex = 6;
            // 
            // cmbTipoClienteAgregar
            // 
            this.cmbTipoClienteAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoClienteAgregar.FormattingEnabled = true;
            this.cmbTipoClienteAgregar.Items.AddRange(new object[] {
            "Crédito"});
            this.cmbTipoClienteAgregar.Location = new System.Drawing.Point(113, 135);
            this.cmbTipoClienteAgregar.Name = "cmbTipoClienteAgregar";
            this.cmbTipoClienteAgregar.Size = new System.Drawing.Size(136, 24);
            this.cmbTipoClienteAgregar.TabIndex = 5;
            // 
            // txtDireccionAgregar
            // 
            this.txtDireccionAgregar.Location = new System.Drawing.Point(113, 107);
            this.txtDireccionAgregar.Name = "txtDireccionAgregar";
            this.txtDireccionAgregar.Size = new System.Drawing.Size(345, 22);
            this.txtDireccionAgregar.TabIndex = 4;
            // 
            // btnRegistrarAgregar
            // 
            this.btnRegistrarAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarAgregar.Image")));
            this.btnRegistrarAgregar.Location = new System.Drawing.Point(353, 137);
            this.btnRegistrarAgregar.Name = "btnRegistrarAgregar";
            this.btnRegistrarAgregar.Size = new System.Drawing.Size(105, 38);
            this.btnRegistrarAgregar.TabIndex = 13;
            this.btnRegistrarAgregar.Text = "Registrar";
            this.btnRegistrarAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarAgregar.UseVisualStyleBackColor = true;
            // 
            // lblCelularAgregar
            // 
            this.lblCelularAgregar.AutoSize = true;
            this.lblCelularAgregar.Location = new System.Drawing.Point(294, 26);
            this.lblCelularAgregar.Name = "lblCelularAgregar";
            this.lblCelularAgregar.Size = new System.Drawing.Size(53, 16);
            this.lblCelularAgregar.TabIndex = 29;
            this.lblCelularAgregar.Text = "Celular:";
            // 
            // lblTelefonoAgregar
            // 
            this.lblTelefonoAgregar.AutoSize = true;
            this.lblTelefonoAgregar.Location = new System.Drawing.Point(282, 54);
            this.lblTelefonoAgregar.Name = "lblTelefonoAgregar";
            this.lblTelefonoAgregar.Size = new System.Drawing.Size(65, 16);
            this.lblTelefonoAgregar.TabIndex = 28;
            this.lblTelefonoAgregar.Text = "Teléfono:";
            // 
            // lblTipoClienteAgregar
            // 
            this.lblTipoClienteAgregar.AutoSize = true;
            this.lblTipoClienteAgregar.Location = new System.Drawing.Point(7, 138);
            this.lblTipoClienteAgregar.Name = "lblTipoClienteAgregar";
            this.lblTipoClienteAgregar.Size = new System.Drawing.Size(100, 16);
            this.lblTipoClienteAgregar.TabIndex = 27;
            this.lblTipoClienteAgregar.Text = "Tipo de cliente:";
            // 
            // lblDireccionAgregar
            // 
            this.lblDireccionAgregar.AutoSize = true;
            this.lblDireccionAgregar.Location = new System.Drawing.Point(39, 110);
            this.lblDireccionAgregar.Name = "lblDireccionAgregar";
            this.lblDireccionAgregar.Size = new System.Drawing.Size(68, 16);
            this.lblDireccionAgregar.TabIndex = 26;
            this.lblDireccionAgregar.Text = "Dirección:";
            // 
            // txtApellidosAgregar
            // 
            this.txtApellidosAgregar.Location = new System.Drawing.Point(113, 79);
            this.txtApellidosAgregar.Name = "txtApellidosAgregar";
            this.txtApellidosAgregar.Size = new System.Drawing.Size(163, 22);
            this.txtApellidosAgregar.TabIndex = 3;
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.Location = new System.Drawing.Point(113, 51);
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(163, 22);
            this.txtNombreAgregar.TabIndex = 2;
            // 
            // txtCedulaAgregar
            // 
            this.txtCedulaAgregar.Location = new System.Drawing.Point(113, 23);
            this.txtCedulaAgregar.Name = "txtCedulaAgregar";
            this.txtCedulaAgregar.Size = new System.Drawing.Size(163, 22);
            this.txtCedulaAgregar.TabIndex = 1;
            // 
            // lblApellidosAgregar
            // 
            this.lblApellidosAgregar.AutoSize = true;
            this.lblApellidosAgregar.Location = new System.Drawing.Point(39, 82);
            this.lblApellidosAgregar.Name = "lblApellidosAgregar";
            this.lblApellidosAgregar.Size = new System.Drawing.Size(68, 16);
            this.lblApellidosAgregar.TabIndex = 22;
            this.lblApellidosAgregar.Text = "Apellidos:";
            // 
            // lblNombreAgregar
            // 
            this.lblNombreAgregar.AutoSize = true;
            this.lblNombreAgregar.Location = new System.Drawing.Point(47, 54);
            this.lblNombreAgregar.Name = "lblNombreAgregar";
            this.lblNombreAgregar.Size = new System.Drawing.Size(60, 16);
            this.lblNombreAgregar.TabIndex = 21;
            this.lblNombreAgregar.Text = "Nombre:";
            // 
            // lblCedulaAgregar
            // 
            this.lblCedulaAgregar.AutoSize = true;
            this.lblCedulaAgregar.Location = new System.Drawing.Point(53, 26);
            this.lblCedulaAgregar.Name = "lblCedulaAgregar";
            this.lblCedulaAgregar.Size = new System.Drawing.Size(54, 16);
            this.lblCedulaAgregar.TabIndex = 20;
            this.lblCedulaAgregar.Text = "Cédula:";
            // 
            // grbCreditoAgregar
            // 
            this.grbCreditoAgregar.Controls.Add(this.label5);
            this.grbCreditoAgregar.Controls.Add(this.txtNumeroRegistroAgregar);
            this.grbCreditoAgregar.Controls.Add(this.label2);
            this.grbCreditoAgregar.Controls.Add(this.txtMontoActualAgregar);
            this.grbCreditoAgregar.Controls.Add(this.label1);
            this.grbCreditoAgregar.Controls.Add(this.lblPeriodoPagoAgregar);
            this.grbCreditoAgregar.Controls.Add(this.cmbEstadoAgregar);
            this.grbCreditoAgregar.Controls.Add(this.lblMontoAcreditarAgregar);
            this.grbCreditoAgregar.Controls.Add(this.lblEstadoAgregar);
            this.grbCreditoAgregar.Controls.Add(this.txtMontoAcreditarAgregar);
            this.grbCreditoAgregar.Controls.Add(this.cmbPeriodoPagoAgregar);
            this.grbCreditoAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbCreditoAgregar.Location = new System.Drawing.Point(784, 4);
            this.grbCreditoAgregar.Name = "grbCreditoAgregar";
            this.grbCreditoAgregar.Size = new System.Drawing.Size(302, 226);
            this.grbCreditoAgregar.TabIndex = 44;
            this.grbCreditoAgregar.TabStop = false;
            this.grbCreditoAgregar.Text = "Asignación de crédito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "días";
            // 
            // txtNumeroRegistroAgregar
            // 
            this.txtNumeroRegistroAgregar.Location = new System.Drawing.Point(138, 142);
            this.txtNumeroRegistroAgregar.Name = "txtNumeroRegistroAgregar";
            this.txtNumeroRegistroAgregar.ReadOnly = true;
            this.txtNumeroRegistroAgregar.Size = new System.Drawing.Size(121, 22);
            this.txtNumeroRegistroAgregar.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Número de registro:";
            // 
            // txtMontoActualAgregar
            // 
            this.txtMontoActualAgregar.Location = new System.Drawing.Point(138, 114);
            this.txtMontoActualAgregar.Name = "txtMontoActualAgregar";
            this.txtMontoActualAgregar.ReadOnly = true;
            this.txtMontoActualAgregar.Size = new System.Drawing.Size(121, 22);
            this.txtMontoActualAgregar.TabIndex = 11;
            this.txtMontoActualAgregar.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Monto actual:";
            // 
            // lblPeriodoPagoAgregar
            // 
            this.lblPeriodoPagoAgregar.AutoSize = true;
            this.lblPeriodoPagoAgregar.Location = new System.Drawing.Point(19, 29);
            this.lblPeriodoPagoAgregar.Name = "lblPeriodoPagoAgregar";
            this.lblPeriodoPagoAgregar.Size = new System.Drawing.Size(113, 16);
            this.lblPeriodoPagoAgregar.TabIndex = 16;
            this.lblPeriodoPagoAgregar.Text = "Periodo de pago:";
            // 
            // cmbEstadoAgregar
            // 
            this.cmbEstadoAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoAgregar.FormattingEnabled = true;
            this.cmbEstadoAgregar.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.cmbEstadoAgregar.Location = new System.Drawing.Point(138, 84);
            this.cmbEstadoAgregar.Name = "cmbEstadoAgregar";
            this.cmbEstadoAgregar.Size = new System.Drawing.Size(121, 24);
            this.cmbEstadoAgregar.TabIndex = 10;
            // 
            // lblMontoAcreditarAgregar
            // 
            this.lblMontoAcreditarAgregar.AutoSize = true;
            this.lblMontoAcreditarAgregar.Location = new System.Drawing.Point(25, 59);
            this.lblMontoAcreditarAgregar.Name = "lblMontoAcreditarAgregar";
            this.lblMontoAcreditarAgregar.Size = new System.Drawing.Size(107, 16);
            this.lblMontoAcreditarAgregar.TabIndex = 10;
            this.lblMontoAcreditarAgregar.Text = "Monto a creditar:";
            // 
            // lblEstadoAgregar
            // 
            this.lblEstadoAgregar.AutoSize = true;
            this.lblEstadoAgregar.Location = new System.Drawing.Point(78, 87);
            this.lblEstadoAgregar.Name = "lblEstadoAgregar";
            this.lblEstadoAgregar.Size = new System.Drawing.Size(54, 16);
            this.lblEstadoAgregar.TabIndex = 42;
            this.lblEstadoAgregar.Text = "Estado:";
            // 
            // txtMontoAcreditarAgregar
            // 
            this.txtMontoAcreditarAgregar.Location = new System.Drawing.Point(138, 56);
            this.txtMontoAcreditarAgregar.Name = "txtMontoAcreditarAgregar";
            this.txtMontoAcreditarAgregar.Size = new System.Drawing.Size(121, 22);
            this.txtMontoAcreditarAgregar.TabIndex = 9;
            // 
            // cmbPeriodoPagoAgregar
            // 
            this.cmbPeriodoPagoAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodoPagoAgregar.FormattingEnabled = true;
            this.cmbPeriodoPagoAgregar.Items.AddRange(new object[] {
            "8",
            "15",
            "30"});
            this.cmbPeriodoPagoAgregar.Location = new System.Drawing.Point(138, 26);
            this.cmbPeriodoPagoAgregar.Name = "cmbPeriodoPagoAgregar";
            this.cmbPeriodoPagoAgregar.Size = new System.Drawing.Size(121, 24);
            this.cmbPeriodoPagoAgregar.TabIndex = 8;
            // 
            // tbpEditar
            // 
            this.tbpEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpEditar.Controls.Add(this.groupBox1);
            this.tbpEditar.Controls.Add(this.grbDatosEditar);
            this.tbpEditar.Controls.Add(this.groupBox2);
            this.tbpEditar.Location = new System.Drawing.Point(4, 25);
            this.tbpEditar.Margin = new System.Windows.Forms.Padding(4);
            this.tbpEditar.Name = "tbpEditar";
            this.tbpEditar.Padding = new System.Windows.Forms.Padding(4);
            this.tbpEditar.Size = new System.Drawing.Size(1090, 234);
            this.tbpEditar.TabIndex = 2;
            this.tbpEditar.Text = "Editar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(467, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 226);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del crédito";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 195);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(126, 16);
            this.label24.TabIndex = 13;
            this.label24.Text = "Número de registro:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNumRegistro);
            this.panel1.Controls.Add(this.lblMontoCreditoEditar);
            this.panel1.Controls.Add(this.lblFechaEstablecidaEditar);
            this.panel1.Controls.Add(this.lblMontoDisponibleEditar);
            this.panel1.Controls.Add(this.lblPeriodoPagoEditar);
            this.panel1.Controls.Add(this.lblProximoCobroEditar);
            this.panel1.Controls.Add(this.lblEstadoClienteEditar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(156, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 205);
            this.panel1.TabIndex = 12;
            // 
            // lblNumRegistro
            // 
            this.lblNumRegistro.AutoSize = true;
            this.lblNumRegistro.Location = new System.Drawing.Point(3, 177);
            this.lblNumRegistro.Name = "lblNumRegistro";
            this.lblNumRegistro.Size = new System.Drawing.Size(15, 16);
            this.lblNumRegistro.TabIndex = 12;
            this.lblNumRegistro.Text = "0";
            // 
            // lblMontoCreditoEditar
            // 
            this.lblMontoCreditoEditar.AutoSize = true;
            this.lblMontoCreditoEditar.Location = new System.Drawing.Point(3, 14);
            this.lblMontoCreditoEditar.Name = "lblMontoCreditoEditar";
            this.lblMontoCreditoEditar.Size = new System.Drawing.Size(15, 16);
            this.lblMontoCreditoEditar.TabIndex = 6;
            this.lblMontoCreditoEditar.Text = "0";
            // 
            // lblFechaEstablecidaEditar
            // 
            this.lblFechaEstablecidaEditar.AutoSize = true;
            this.lblFechaEstablecidaEditar.Location = new System.Drawing.Point(3, 150);
            this.lblFechaEstablecidaEditar.Name = "lblFechaEstablecidaEditar";
            this.lblFechaEstablecidaEditar.Size = new System.Drawing.Size(72, 16);
            this.lblFechaEstablecidaEditar.TabIndex = 11;
            this.lblFechaEstablecidaEditar.Text = "00/00/0000";
            // 
            // lblMontoDisponibleEditar
            // 
            this.lblMontoDisponibleEditar.AutoSize = true;
            this.lblMontoDisponibleEditar.Location = new System.Drawing.Point(3, 37);
            this.lblMontoDisponibleEditar.Name = "lblMontoDisponibleEditar";
            this.lblMontoDisponibleEditar.Size = new System.Drawing.Size(15, 16);
            this.lblMontoDisponibleEditar.TabIndex = 7;
            this.lblMontoDisponibleEditar.Text = "0";
            // 
            // lblPeriodoPagoEditar
            // 
            this.lblPeriodoPagoEditar.AutoSize = true;
            this.lblPeriodoPagoEditar.Location = new System.Drawing.Point(3, 120);
            this.lblPeriodoPagoEditar.Name = "lblPeriodoPagoEditar";
            this.lblPeriodoPagoEditar.Size = new System.Drawing.Size(15, 16);
            this.lblPeriodoPagoEditar.TabIndex = 10;
            this.lblPeriodoPagoEditar.Text = "0";
            // 
            // lblProximoCobroEditar
            // 
            this.lblProximoCobroEditar.AutoSize = true;
            this.lblProximoCobroEditar.Location = new System.Drawing.Point(3, 64);
            this.lblProximoCobroEditar.Name = "lblProximoCobroEditar";
            this.lblProximoCobroEditar.Size = new System.Drawing.Size(15, 16);
            this.lblProximoCobroEditar.TabIndex = 8;
            this.lblProximoCobroEditar.Text = "0";
            // 
            // lblEstadoClienteEditar
            // 
            this.lblEstadoClienteEditar.AutoSize = true;
            this.lblEstadoClienteEditar.Location = new System.Drawing.Point(3, 94);
            this.lblEstadoClienteEditar.Name = "lblEstadoClienteEditar";
            this.lblEstadoClienteEditar.Size = new System.Drawing.Size(18, 16);
            this.lblEstadoClienteEditar.TabIndex = 9;
            this.lblEstadoClienteEditar.Text = "\"\"";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 171);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(123, 16);
            this.label23.TabIndex = 5;
            this.label23.Text = "Fecha establecida:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 16);
            this.label22.TabIndex = 4;
            this.label22.Text = "Monto disponible:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Periodos de pago:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Estado del cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Días para el próximo cobro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Monto del crédito:";
            // 
            // grbDatosEditar
            // 
            this.grbDatosEditar.Controls.Add(this.btnEditarDatosEditar);
            this.grbDatosEditar.Controls.Add(this.txtTelefonoEditar);
            this.grbDatosEditar.Controls.Add(this.txtCelularEditar);
            this.grbDatosEditar.Controls.Add(this.cmbTipoClienteEditar);
            this.grbDatosEditar.Controls.Add(this.txtDireccionEditar);
            this.grbDatosEditar.Controls.Add(this.label14);
            this.grbDatosEditar.Controls.Add(this.label15);
            this.grbDatosEditar.Controls.Add(this.label16);
            this.grbDatosEditar.Controls.Add(this.label17);
            this.grbDatosEditar.Controls.Add(this.txtApellidosEditar);
            this.grbDatosEditar.Controls.Add(this.txtNombreEditar);
            this.grbDatosEditar.Controls.Add(this.txtCedulaEditar);
            this.grbDatosEditar.Controls.Add(this.label18);
            this.grbDatosEditar.Controls.Add(this.label19);
            this.grbDatosEditar.Controls.Add(this.label20);
            this.grbDatosEditar.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbDatosEditar.Location = new System.Drawing.Point(4, 4);
            this.grbDatosEditar.Name = "grbDatosEditar";
            this.grbDatosEditar.Size = new System.Drawing.Size(463, 226);
            this.grbDatosEditar.TabIndex = 50;
            this.grbDatosEditar.TabStop = false;
            this.grbDatosEditar.Text = "Datos";
            // 
            // btnEditarDatosEditar
            // 
            this.btnEditarDatosEditar.Location = new System.Drawing.Point(367, 138);
            this.btnEditarDatosEditar.Name = "btnEditarDatosEditar";
            this.btnEditarDatosEditar.Size = new System.Drawing.Size(90, 28);
            this.btnEditarDatosEditar.TabIndex = 44;
            this.btnEditarDatosEditar.Text = "Editar datos";
            this.btnEditarDatosEditar.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoEditar
            // 
            this.txtTelefonoEditar.Location = new System.Drawing.Point(350, 54);
            this.txtTelefonoEditar.Name = "txtTelefonoEditar";
            this.txtTelefonoEditar.Size = new System.Drawing.Size(106, 22);
            this.txtTelefonoEditar.TabIndex = 36;
            // 
            // txtCelularEditar
            // 
            this.txtCelularEditar.Location = new System.Drawing.Point(350, 26);
            this.txtCelularEditar.Name = "txtCelularEditar";
            this.txtCelularEditar.Size = new System.Drawing.Size(106, 22);
            this.txtCelularEditar.TabIndex = 35;
            // 
            // cmbTipoClienteEditar
            // 
            this.cmbTipoClienteEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoClienteEditar.FormattingEnabled = true;
            this.cmbTipoClienteEditar.Items.AddRange(new object[] {
            "CRÉDITO"});
            this.cmbTipoClienteEditar.Location = new System.Drawing.Point(116, 138);
            this.cmbTipoClienteEditar.Name = "cmbTipoClienteEditar";
            this.cmbTipoClienteEditar.Size = new System.Drawing.Size(132, 24);
            this.cmbTipoClienteEditar.TabIndex = 34;
            // 
            // txtDireccionEditar
            // 
            this.txtDireccionEditar.Location = new System.Drawing.Point(116, 110);
            this.txtDireccionEditar.Name = "txtDireccionEditar";
            this.txtDireccionEditar.Size = new System.Drawing.Size(340, 22);
            this.txtDireccionEditar.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(292, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 43;
            this.label14.Text = "Celular:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Teléfono:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Tipo de cliente:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 16);
            this.label17.TabIndex = 40;
            this.label17.Text = "Dirección:";
            // 
            // txtApellidosEditar
            // 
            this.txtApellidosEditar.Location = new System.Drawing.Point(116, 82);
            this.txtApellidosEditar.Name = "txtApellidosEditar";
            this.txtApellidosEditar.Size = new System.Drawing.Size(158, 22);
            this.txtApellidosEditar.TabIndex = 32;
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(116, 54);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(158, 22);
            this.txtNombreEditar.TabIndex = 31;
            // 
            // txtCedulaEditar
            // 
            this.txtCedulaEditar.Location = new System.Drawing.Point(116, 26);
            this.txtCedulaEditar.Name = "txtCedulaEditar";
            this.txtCedulaEditar.ReadOnly = true;
            this.txtCedulaEditar.Size = new System.Drawing.Size(158, 22);
            this.txtCedulaEditar.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 16);
            this.label18.TabIndex = 39;
            this.label18.Text = "Apellidos:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(50, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 16);
            this.label19.TabIndex = 38;
            this.label19.Text = "Nombre:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(56, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 16);
            this.label20.TabIndex = 37;
            this.label20.Text = "Cédula:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaInicioCreditoEditar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNumeroRegistroEditar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMontoActualEditar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbEstadoEditar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtMontoAcreditarEditar);
            this.groupBox2.Controls.Add(this.cmbPeriodoPagoEditar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(783, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 226);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignación de crédito";
            // 
            // dtpFechaInicioCreditoEditar
            // 
            this.dtpFechaInicioCreditoEditar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioCreditoEditar.Location = new System.Drawing.Point(140, 171);
            this.dtpFechaInicioCreditoEditar.Name = "dtpFechaInicioCreditoEditar";
            this.dtpFechaInicioCreditoEditar.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaInicioCreditoEditar.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Inicio del crédito:";
            // 
            // txtNumeroRegistroEditar
            // 
            this.txtNumeroRegistroEditar.Location = new System.Drawing.Point(140, 143);
            this.txtNumeroRegistroEditar.Name = "txtNumeroRegistroEditar";
            this.txtNumeroRegistroEditar.ReadOnly = true;
            this.txtNumeroRegistroEditar.Size = new System.Drawing.Size(121, 22);
            this.txtNumeroRegistroEditar.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Número de registro:";
            // 
            // txtMontoActualEditar
            // 
            this.txtMontoActualEditar.Location = new System.Drawing.Point(140, 115);
            this.txtMontoActualEditar.Name = "txtMontoActualEditar";
            this.txtMontoActualEditar.ReadOnly = true;
            this.txtMontoActualEditar.Size = new System.Drawing.Size(121, 22);
            this.txtMontoActualEditar.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Monto actual:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "Periodo de pago:";
            // 
            // cmbEstadoEditar
            // 
            this.cmbEstadoEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEditar.FormattingEnabled = true;
            this.cmbEstadoEditar.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.cmbEstadoEditar.Location = new System.Drawing.Point(140, 85);
            this.cmbEstadoEditar.Name = "cmbEstadoEditar";
            this.cmbEstadoEditar.Size = new System.Drawing.Size(121, 24);
            this.cmbEstadoEditar.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Monto a creditar:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(80, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 16);
            this.label21.TabIndex = 40;
            this.label21.Text = "Estado:";
            // 
            // txtMontoAcreditarEditar
            // 
            this.txtMontoAcreditarEditar.Location = new System.Drawing.Point(140, 57);
            this.txtMontoAcreditarEditar.Name = "txtMontoAcreditarEditar";
            this.txtMontoAcreditarEditar.Size = new System.Drawing.Size(121, 22);
            this.txtMontoAcreditarEditar.TabIndex = 8;
            // 
            // cmbPeriodoPagoEditar
            // 
            this.cmbPeriodoPagoEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodoPagoEditar.FormattingEnabled = true;
            this.cmbPeriodoPagoEditar.Items.AddRange(new object[] {
            "8",
            "15",
            "30"});
            this.cmbPeriodoPagoEditar.Location = new System.Drawing.Point(140, 27);
            this.cmbPeriodoPagoEditar.Name = "cmbPeriodoPagoEditar";
            this.cmbPeriodoPagoEditar.Size = new System.Drawing.Size(121, 24);
            this.cmbPeriodoPagoEditar.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "días";
            // 
            // frmControlGeneralClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 492);
            this.Controls.Add(this.grbRegsitros);
            this.Controls.Add(this.tbcDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmControlGeneralClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control general de clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbRegsitros.ResumeLayout(false);
            this.grbRegsitros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.tlsBusqueda.ResumeLayout(false);
            this.tlsBusqueda.PerformLayout();
            this.stbEstado.ResumeLayout(false);
            this.stbEstado.PerformLayout();
            this.menuClickDerecho.ResumeLayout(false);
            this.tbcDatos.ResumeLayout(false);
            this.tbpAgregar.ResumeLayout(false);
            this.grbDatosAgregar.ResumeLayout(false);
            this.grbDatosAgregar.PerformLayout();
            this.grbCreditoAgregar.ResumeLayout(false);
            this.grbCreditoAgregar.PerformLayout();
            this.tbpEditar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbDatosEditar.ResumeLayout(false);
            this.grbDatosEditar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegsitros;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.StatusStrip stbEstado;
        private System.Windows.Forms.ToolStrip tlsBusqueda;
        private System.Windows.Forms.ToolStripLabel lblBuscarEditar;
        private System.Windows.Forms.ToolStripTextBox txtFiltrarDatos;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel stbtnVerOpcionesBusqueda;
        private System.Windows.Forms.ToolStripComboBox cmbOpcionesBusqueda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstadoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModificadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreadoPor;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ContextMenuStrip menuClickDerecho;
        private System.Windows.Forms.ToolStripMenuItem copiarDatoDeLaCeldaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem;
        private System.Windows.Forms.TabControl tbcDatos;
        private System.Windows.Forms.TabPage tbpAgregar;
        private System.Windows.Forms.GroupBox grbDatosAgregar;
        private System.Windows.Forms.TextBox txtTelefonoAgregar;
        private System.Windows.Forms.TextBox txtCelularAgregar;
        private System.Windows.Forms.ComboBox cmbTipoClienteAgregar;
        private System.Windows.Forms.TextBox txtDireccionAgregar;
        private System.Windows.Forms.Button btnRegistrarAgregar;
        private System.Windows.Forms.Label lblCelularAgregar;
        private System.Windows.Forms.Label lblTelefonoAgregar;
        private System.Windows.Forms.Label lblTipoClienteAgregar;
        private System.Windows.Forms.Label lblDireccionAgregar;
        private System.Windows.Forms.TextBox txtApellidosAgregar;
        private System.Windows.Forms.TextBox txtNombreAgregar;
        private System.Windows.Forms.TextBox txtCedulaAgregar;
        private System.Windows.Forms.Label lblApellidosAgregar;
        private System.Windows.Forms.Label lblNombreAgregar;
        private System.Windows.Forms.Label lblCedulaAgregar;
        private System.Windows.Forms.GroupBox grbCreditoAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroRegistroAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoActualAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeriodoPagoAgregar;
        private System.Windows.Forms.ComboBox cmbEstadoAgregar;
        private System.Windows.Forms.Label lblMontoAcreditarAgregar;
        private System.Windows.Forms.Label lblEstadoAgregar;
        private System.Windows.Forms.TextBox txtMontoAcreditarAgregar;
        private System.Windows.Forms.ComboBox cmbPeriodoPagoAgregar;
        private System.Windows.Forms.TabPage tbpEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumRegistro;
        private System.Windows.Forms.Label lblMontoCreditoEditar;
        private System.Windows.Forms.Label lblFechaEstablecidaEditar;
        private System.Windows.Forms.Label lblMontoDisponibleEditar;
        private System.Windows.Forms.Label lblPeriodoPagoEditar;
        private System.Windows.Forms.Label lblProximoCobroEditar;
        private System.Windows.Forms.Label lblEstadoClienteEditar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbDatosEditar;
        private System.Windows.Forms.Button btnEditarDatosEditar;
        private System.Windows.Forms.TextBox txtTelefonoEditar;
        private System.Windows.Forms.TextBox txtCelularEditar;
        private System.Windows.Forms.ComboBox cmbTipoClienteEditar;
        private System.Windows.Forms.TextBox txtDireccionEditar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtApellidosEditar;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.TextBox txtCedulaEditar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioCreditoEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroRegistroEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoActualEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbEstadoEditar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMontoAcreditarEditar;
        private System.Windows.Forms.ComboBox cmbPeriodoPagoEditar;
        private System.Windows.Forms.Label label11;
    }
}