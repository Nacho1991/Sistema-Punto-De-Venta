namespace GUI
{
    partial class frmControlGeneralInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlGeneralInventario));
            this.stpEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInfoCantidad = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDisponible = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNoDisponible = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbRegistros = new System.Windows.Forms.GroupBox();
            this.dgvProductosInventario = new System.Windows.Forms.DataGridView();
            this.clmCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExistencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblBuscarEmpleado = new System.Windows.Forms.ToolStripButton();
            this.txtFiltrarDatos = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbOpcionesBusqueda = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.tpgEditar = new System.Windows.Forms.TabPage();
            this.grbDatosEditar = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.numPorcentajeEditar = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.numCantidadEditar = new System.Windows.Forms.NumericUpDown();
            this.ckbExistenciaEditar = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigoProductoEditar = new System.Windows.Forms.TextBox();
            this.txtMarcaEditar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioVentaEditar = new System.Windows.Forms.TextBox();
            this.txtPrecioCompraEditar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcionEditar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.tpgAgregar = new System.Windows.Forms.TabPage();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.numPrecioVentaAgregar = new System.Windows.Forms.NumericUpDown();
            this.numPrecioCompraAgregar = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numPorcentajeAgregar = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numCantidadAgregar = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarAgregar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ckbExistenciaAgregar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoArticuloAgregar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.txtNombreProductoAgregar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionAgregar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarcaAgregar = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tbcInventario = new System.Windows.Forms.TabControl();
            this.menuClickDerecho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itmCopiarCelda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itmDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.stpEstado.SuspendLayout();
            this.grbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosInventario)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tpgEditar.SuspendLayout();
            this.grbDatosEditar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentajeEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadEditar)).BeginInit();
            this.tpgAgregar.SuspendLayout();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVentaAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompraAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentajeAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAgregar)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbcInventario.SuspendLayout();
            this.menuClickDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // stpEstado
            // 
            this.stpEstado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.stpEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblInfoCantidad,
            this.toolStripStatusLabel2,
            this.lblDisponible,
            this.lblNoDisponible});
            this.stpEstado.Location = new System.Drawing.Point(0, 525);
            this.stpEstado.Name = "stpEstado";
            this.stpEstado.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.stpEstado.Size = new System.Drawing.Size(770, 22);
            this.stpEstado.SizingGrip = false;
            this.stpEstado.TabIndex = 1;
            this.stpEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "Cantidad de productos:";
            // 
            // lblInfoCantidad
            // 
            this.lblInfoCantidad.Name = "lblInfoCantidad";
            this.lblInfoCantidad.Size = new System.Drawing.Size(13, 17);
            this.lblInfoCantidad.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel2.Text = "Disponibilidad:";
            // 
            // lblDisponible
            // 
            this.lblDisponible.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblDisponible.Image = ((System.Drawing.Image)(resources.GetObject("lblDisponible.Image")));
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(16, 17);
            this.lblDisponible.Text = "\"\"";
            // 
            // lblNoDisponible
            // 
            this.lblNoDisponible.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblNoDisponible.Image = ((System.Drawing.Image)(resources.GetObject("lblNoDisponible.Image")));
            this.lblNoDisponible.Name = "lblNoDisponible";
            this.lblNoDisponible.Size = new System.Drawing.Size(16, 17);
            this.lblNoDisponible.Text = "\"\"";
            // 
            // grbRegistros
            // 
            this.grbRegistros.Controls.Add(this.dgvProductosInventario);
            this.grbRegistros.Controls.Add(this.toolStrip1);
            this.grbRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbRegistros.Location = new System.Drawing.Point(0, 301);
            this.grbRegistros.Name = "grbRegistros";
            this.grbRegistros.Size = new System.Drawing.Size(770, 224);
            this.grbRegistros.TabIndex = 35;
            this.grbRegistros.TabStop = false;
            this.grbRegistros.Text = "Registros";
            // 
            // dgvProductosInventario
            // 
            this.dgvProductosInventario.AllowUserToAddRows = false;
            this.dgvProductosInventario.AllowUserToDeleteRows = false;
            this.dgvProductosInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductosInventario.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvProductosInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductosInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigoProducto,
            this.clmNombre,
            this.clmMarca,
            this.clmDescripcion,
            this.clmPrecioCompra,
            this.clmPrecioVenta,
            this.clmExistencia,
            this.clmCantidad,
            this.clmFechaEntrada});
            this.dgvProductosInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductosInventario.Location = new System.Drawing.Point(3, 55);
            this.dgvProductosInventario.Margin = new System.Windows.Forms.Padding(5);
            this.dgvProductosInventario.MultiSelect = false;
            this.dgvProductosInventario.Name = "dgvProductosInventario";
            this.dgvProductosInventario.ReadOnly = true;
            this.dgvProductosInventario.RowHeadersVisible = false;
            this.dgvProductosInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosInventario.Size = new System.Drawing.Size(764, 166);
            this.dgvProductosInventario.TabIndex = 20;
            this.dgvProductosInventario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRegistros_CellMouseClick);
            this.dgvProductosInventario.SelectionChanged += new System.EventHandler(this.dgvProductosInventario_SelectionChanged);
            // 
            // clmCodigoProducto
            // 
            this.clmCodigoProducto.DataPropertyName = "id_producto";
            this.clmCodigoProducto.HeaderText = "Código";
            this.clmCodigoProducto.Name = "clmCodigoProducto";
            this.clmCodigoProducto.ReadOnly = true;
            this.clmCodigoProducto.Width = 71;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "nombre";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 77;
            // 
            // clmMarca
            // 
            this.clmMarca.DataPropertyName = "marca";
            this.clmMarca.HeaderText = "Marca";
            this.clmMarca.Name = "clmMarca";
            this.clmMarca.ReadOnly = true;
            this.clmMarca.Width = 67;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.DataPropertyName = "descripcion";
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            this.clmDescripcion.Width = 97;
            // 
            // clmPrecioCompra
            // 
            this.clmPrecioCompra.DataPropertyName = "precio_compra";
            this.clmPrecioCompra.HeaderText = "Precio de compra";
            this.clmPrecioCompra.Name = "clmPrecioCompra";
            this.clmPrecioCompra.ReadOnly = true;
            this.clmPrecioCompra.Width = 118;
            // 
            // clmPrecioVenta
            // 
            this.clmPrecioVenta.DataPropertyName = "precio_venta";
            this.clmPrecioVenta.HeaderText = "Precio de venta";
            this.clmPrecioVenta.Name = "clmPrecioVenta";
            this.clmPrecioVenta.ReadOnly = true;
            this.clmPrecioVenta.Width = 80;
            // 
            // clmExistencia
            // 
            this.clmExistencia.DataPropertyName = "existencia";
            this.clmExistencia.HeaderText = "Existencia";
            this.clmExistencia.Name = "clmExistencia";
            this.clmExistencia.ReadOnly = true;
            this.clmExistencia.Width = 69;
            // 
            // clmCantidad
            // 
            this.clmCantidad.DataPropertyName = "cantidad";
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            this.clmCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCantidad.Width = 62;
            // 
            // clmFechaEntrada
            // 
            this.clmFechaEntrada.DataPropertyName = "fecha_entrada";
            this.clmFechaEntrada.HeaderText = "Fecha de entrada";
            this.clmFechaEntrada.Name = "clmFechaEntrada";
            this.clmFechaEntrada.ReadOnly = true;
            this.clmFechaEntrada.Width = 117;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBuscarEmpleado,
            this.txtFiltrarDatos,
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.cmbOpcionesBusqueda,
            this.toolStripSeparator5,
            this.btnEliminar,
            this.toolStripSeparator4,
            this.btnActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 38);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblBuscarEmpleado
            // 
            this.lblBuscarEmpleado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblBuscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("lblBuscarEmpleado.Image")));
            this.lblBuscarEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lblBuscarEmpleado.Name = "lblBuscarEmpleado";
            this.lblBuscarEmpleado.Size = new System.Drawing.Size(107, 35);
            this.lblBuscarEmpleado.Text = "Buescar producto:";
            // 
            // txtFiltrarDatos
            // 
            this.txtFiltrarDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarDatos.Name = "txtFiltrarDatos";
            this.txtFiltrarDatos.Size = new System.Drawing.Size(100, 38);
            this.txtFiltrarDatos.TextChanged += new System.EventHandler(this.txtFiltrarDatos_TextChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
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
            "Por código",
            "Por descripción",
            "Por marca"});
            this.cmbOpcionesBusqueda.Name = "cmbOpcionesBusqueda";
            this.cmbOpcionesBusqueda.Size = new System.Drawing.Size(121, 38);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::appClientesAsociadosCredito.Properties.Resources.forbidden_159816_640;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 35);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::appClientesAsociadosCredito.Properties.Resources.Refresh;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(63, 35);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tpgEditar
            // 
            this.tpgEditar.Controls.Add(this.grbDatosEditar);
            this.tpgEditar.Location = new System.Drawing.Point(4, 24);
            this.tpgEditar.Name = "tpgEditar";
            this.tpgEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEditar.Size = new System.Drawing.Size(762, 273);
            this.tpgEditar.TabIndex = 2;
            this.tpgEditar.Text = "Editar productos";
            this.tpgEditar.UseVisualStyleBackColor = true;
            // 
            // grbDatosEditar
            // 
            this.grbDatosEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbDatosEditar.Controls.Add(this.panel2);
            this.grbDatosEditar.Controls.Add(this.label17);
            this.grbDatosEditar.Controls.Add(this.numPorcentajeEditar);
            this.grbDatosEditar.Controls.Add(this.label18);
            this.grbDatosEditar.Controls.Add(this.numCantidadEditar);
            this.grbDatosEditar.Controls.Add(this.ckbExistenciaEditar);
            this.grbDatosEditar.Controls.Add(this.label14);
            this.grbDatosEditar.Controls.Add(this.label6);
            this.grbDatosEditar.Controls.Add(this.label12);
            this.grbDatosEditar.Controls.Add(this.txtCodigoProductoEditar);
            this.grbDatosEditar.Controls.Add(this.txtMarcaEditar);
            this.grbDatosEditar.Controls.Add(this.label7);
            this.grbDatosEditar.Controls.Add(this.label11);
            this.grbDatosEditar.Controls.Add(this.txtPrecioVentaEditar);
            this.grbDatosEditar.Controls.Add(this.txtPrecioCompraEditar);
            this.grbDatosEditar.Controls.Add(this.label8);
            this.grbDatosEditar.Controls.Add(this.txtDescripcionEditar);
            this.grbDatosEditar.Controls.Add(this.label10);
            this.grbDatosEditar.Controls.Add(this.label9);
            this.grbDatosEditar.Controls.Add(this.txtNombreEditar);
            this.grbDatosEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDatosEditar.Location = new System.Drawing.Point(3, 3);
            this.grbDatosEditar.Name = "grbDatosEditar";
            this.grbDatosEditar.Size = new System.Drawing.Size(756, 267);
            this.grbDatosEditar.TabIndex = 47;
            this.grbDatosEditar.TabStop = false;
            this.grbDatosEditar.Text = "Datos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(625, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 247);
            this.panel2.TabIndex = 55;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(5, 12);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 51);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(398, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 15);
            this.label17.TabIndex = 54;
            this.label17.Text = "%";
            // 
            // numPorcentajeEditar
            // 
            this.numPorcentajeEditar.DecimalPlaces = 1;
            this.numPorcentajeEditar.Location = new System.Drawing.Point(336, 206);
            this.numPorcentajeEditar.Name = "numPorcentajeEditar";
            this.numPorcentajeEditar.Size = new System.Drawing.Size(57, 21);
            this.numPorcentajeEditar.TabIndex = 53;
            this.numPorcentajeEditar.ValueChanged += new System.EventHandler(this.numPorcentajeEditar_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(261, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 15);
            this.label18.TabIndex = 52;
            this.label18.Text = "Porcentaje:";
            // 
            // numCantidadEditar
            // 
            this.numCantidadEditar.Location = new System.Drawing.Point(155, 206);
            this.numCantidadEditar.Name = "numCantidadEditar";
            this.numCantidadEditar.Size = new System.Drawing.Size(95, 21);
            this.numCantidadEditar.TabIndex = 51;
            // 
            // ckbExistenciaEditar
            // 
            this.ckbExistenciaEditar.AutoSize = true;
            this.ckbExistenciaEditar.Location = new System.Drawing.Point(494, 211);
            this.ckbExistenciaEditar.Name = "ckbExistenciaEditar";
            this.ckbExistenciaEditar.Size = new System.Drawing.Size(15, 14);
            this.ckbExistenciaEditar.TabIndex = 50;
            this.ckbExistenciaEditar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(422, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "Existencia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Código de producto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 87);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "Marca:";
            // 
            // txtCodigoProductoEditar
            // 
            this.txtCodigoProductoEditar.Location = new System.Drawing.Point(155, 22);
            this.txtCodigoProductoEditar.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigoProductoEditar.Name = "txtCodigoProductoEditar";
            this.txtCodigoProductoEditar.ReadOnly = true;
            this.txtCodigoProductoEditar.Size = new System.Drawing.Size(322, 21);
            this.txtCodigoProductoEditar.TabIndex = 34;
            // 
            // txtMarcaEditar
            // 
            this.txtMarcaEditar.Location = new System.Drawing.Point(155, 84);
            this.txtMarcaEditar.Margin = new System.Windows.Forms.Padding(5);
            this.txtMarcaEditar.Name = "txtMarcaEditar";
            this.txtMarcaEditar.Size = new System.Drawing.Size(322, 21);
            this.txtMarcaEditar.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Precio de venta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 149);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 15);
            this.label11.TabIndex = 40;
            this.label11.Text = "Precio de compra:";
            // 
            // txtPrecioVentaEditar
            // 
            this.txtPrecioVentaEditar.Location = new System.Drawing.Point(154, 177);
            this.txtPrecioVentaEditar.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecioVentaEditar.Name = "txtPrecioVentaEditar";
            this.txtPrecioVentaEditar.Size = new System.Drawing.Size(322, 21);
            this.txtPrecioVentaEditar.TabIndex = 42;
            this.txtPrecioVentaEditar.Text = "0";
            // 
            // txtPrecioCompraEditar
            // 
            this.txtPrecioCompraEditar.Location = new System.Drawing.Point(154, 146);
            this.txtPrecioCompraEditar.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecioCompraEditar.Name = "txtPrecioCompraEditar";
            this.txtPrecioCompraEditar.Size = new System.Drawing.Size(322, 21);
            this.txtPrecioCompraEditar.TabIndex = 41;
            this.txtPrecioCompraEditar.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Cantidad:";
            // 
            // txtDescripcionEditar
            // 
            this.txtDescripcionEditar.Location = new System.Drawing.Point(155, 115);
            this.txtDescripcionEditar.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcionEditar.Name = "txtDescripcionEditar";
            this.txtDescripcionEditar.Size = new System.Drawing.Size(322, 21);
            this.txtDescripcionEditar.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Nombre del producto:";
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(155, 53);
            this.txtNombreEditar.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(322, 21);
            this.txtNombreEditar.TabIndex = 36;
            // 
            // tpgAgregar
            // 
            this.tpgAgregar.Controls.Add(this.grbDatos);
            this.tpgAgregar.Location = new System.Drawing.Point(4, 24);
            this.tpgAgregar.Name = "tpgAgregar";
            this.tpgAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAgregar.Size = new System.Drawing.Size(762, 273);
            this.tpgAgregar.TabIndex = 0;
            this.tpgAgregar.Text = "Agregar productos";
            this.tpgAgregar.UseVisualStyleBackColor = true;
            // 
            // grbDatos
            // 
            this.grbDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbDatos.Controls.Add(this.numPrecioVentaAgregar);
            this.grbDatos.Controls.Add(this.numPrecioCompraAgregar);
            this.grbDatos.Controls.Add(this.label15);
            this.grbDatos.Controls.Add(this.numPorcentajeAgregar);
            this.grbDatos.Controls.Add(this.label16);
            this.grbDatos.Controls.Add(this.numCantidadAgregar);
            this.grbDatos.Controls.Add(this.panel1);
            this.grbDatos.Controls.Add(this.label13);
            this.grbDatos.Controls.Add(this.ckbExistenciaAgregar);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Controls.Add(this.txtCodigoArticuloAgregar);
            this.grbDatos.Controls.Add(this.label5);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.lblNombreProveedor);
            this.grbDatos.Controls.Add(this.txtNombreProductoAgregar);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.txtDescripcionAgregar);
            this.grbDatos.Controls.Add(this.label4);
            this.grbDatos.Controls.Add(this.txtMarcaAgregar);
            this.grbDatos.Controls.Add(this.lblMarca);
            this.grbDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDatos.Location = new System.Drawing.Point(3, 3);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(756, 267);
            this.grbDatos.TabIndex = 33;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // numPrecioVentaAgregar
            // 
            this.numPrecioVentaAgregar.Location = new System.Drawing.Point(153, 171);
            this.numPrecioVentaAgregar.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numPrecioVentaAgregar.Name = "numPrecioVentaAgregar";
            this.numPrecioVentaAgregar.ReadOnly = true;
            this.numPrecioVentaAgregar.Size = new System.Drawing.Size(322, 21);
            this.numPrecioVentaAgregar.TabIndex = 41;
            // 
            // numPrecioCompraAgregar
            // 
            this.numPrecioCompraAgregar.Location = new System.Drawing.Point(153, 144);
            this.numPrecioCompraAgregar.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numPrecioCompraAgregar.Name = "numPrecioCompraAgregar";
            this.numPrecioCompraAgregar.Size = new System.Drawing.Size(322, 21);
            this.numPrecioCompraAgregar.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(405, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 15);
            this.label15.TabIndex = 39;
            this.label15.Text = "%";
            // 
            // numPorcentajeAgregar
            // 
            this.numPorcentajeAgregar.DecimalPlaces = 1;
            this.numPorcentajeAgregar.Location = new System.Drawing.Point(342, 198);
            this.numPorcentajeAgregar.Name = "numPorcentajeAgregar";
            this.numPorcentajeAgregar.Size = new System.Drawing.Size(57, 21);
            this.numPorcentajeAgregar.TabIndex = 38;
            this.numPorcentajeAgregar.ValueChanged += new System.EventHandler(this.numPorcentajeAgregar_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "Porcentaje:";
            // 
            // numCantidadAgregar
            // 
            this.numCantidadAgregar.Location = new System.Drawing.Point(153, 198);
            this.numCantidadAgregar.Name = "numCantidadAgregar";
            this.numCantidadAgregar.Size = new System.Drawing.Size(103, 21);
            this.numCantidadAgregar.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelarAgregar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(625, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 247);
            this.panel1.TabIndex = 35;
            // 
            // btnCancelarAgregar
            // 
            this.btnCancelarAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAgregar.Image")));
            this.btnCancelarAgregar.Location = new System.Drawing.Point(6, 5);
            this.btnCancelarAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelarAgregar.Name = "btnCancelarAgregar";
            this.btnCancelarAgregar.Size = new System.Drawing.Size(118, 49);
            this.btnCancelarAgregar.TabIndex = 29;
            this.btnCancelarAgregar.Text = "Cancelar";
            this.btnCancelarAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarAgregar.UseVisualStyleBackColor = true;
            this.btnCancelarAgregar.Click += new System.EventHandler(this.btnCancelarAgregar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(7, 64);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 49);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(429, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "Existencia:";
            // 
            // ckbExistenciaAgregar
            // 
            this.ckbExistenciaAgregar.AutoSize = true;
            this.ckbExistenciaAgregar.Location = new System.Drawing.Point(501, 201);
            this.ckbExistenciaAgregar.Name = "ckbExistenciaAgregar";
            this.ckbExistenciaAgregar.Size = new System.Drawing.Size(15, 14);
            this.ckbExistenciaAgregar.TabIndex = 33;
            this.ckbExistenciaAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código de producto:";
            // 
            // txtCodigoArticuloAgregar
            // 
            this.txtCodigoArticuloAgregar.Location = new System.Drawing.Point(153, 22);
            this.txtCodigoArticuloAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigoArticuloAgregar.Name = "txtCodigoArticuloAgregar";
            this.txtCodigoArticuloAgregar.Size = new System.Drawing.Size(322, 21);
            this.txtCodigoArticuloAgregar.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Precio de venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad:";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(19, 56);
            this.lblNombreProveedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(126, 15);
            this.lblNombreProveedor.TabIndex = 30;
            this.lblNombreProveedor.Text = "Nombre del producto:";
            // 
            // txtNombreProductoAgregar
            // 
            this.txtNombreProductoAgregar.Location = new System.Drawing.Point(153, 53);
            this.txtNombreProductoAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreProductoAgregar.Name = "txtNombreProductoAgregar";
            this.txtNombreProductoAgregar.Size = new System.Drawing.Size(322, 21);
            this.txtNombreProductoAgregar.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descripción:";
            // 
            // txtDescripcionAgregar
            // 
            this.txtDescripcionAgregar.Location = new System.Drawing.Point(153, 115);
            this.txtDescripcionAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcionAgregar.Name = "txtDescripcionAgregar";
            this.txtDescripcionAgregar.Size = new System.Drawing.Size(322, 21);
            this.txtDescripcionAgregar.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Precio de compra:";
            // 
            // txtMarcaAgregar
            // 
            this.txtMarcaAgregar.Location = new System.Drawing.Point(153, 84);
            this.txtMarcaAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.txtMarcaAgregar.Name = "txtMarcaAgregar";
            this.txtMarcaAgregar.Size = new System.Drawing.Size(322, 21);
            this.txtMarcaAgregar.TabIndex = 21;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(100, 87);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 15);
            this.lblMarca.TabIndex = 18;
            this.lblMarca.Text = "Marca:";
            // 
            // tbcInventario
            // 
            this.tbcInventario.Controls.Add(this.tpgAgregar);
            this.tbcInventario.Controls.Add(this.tpgEditar);
            this.tbcInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcInventario.Location = new System.Drawing.Point(0, 0);
            this.tbcInventario.Name = "tbcInventario";
            this.tbcInventario.SelectedIndex = 0;
            this.tbcInventario.Size = new System.Drawing.Size(770, 301);
            this.tbcInventario.TabIndex = 0;
            // 
            // menuClickDerecho
            // 
            this.menuClickDerecho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmCopiarCelda,
            this.toolStripSeparator1,
            this.itmEliminar,
            this.toolStripSeparator2,
            this.itmEditar,
            this.toolStripSeparator3,
            this.itmDetalles});
            this.menuClickDerecho.Name = "menuClickDerecho";
            this.menuClickDerecho.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuClickDerecho.Size = new System.Drawing.Size(196, 110);
            this.menuClickDerecho.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuClickDerecho_ItemClicked);
            // 
            // itmCopiarCelda
            // 
            this.itmCopiarCelda.Image = ((System.Drawing.Image)(resources.GetObject("itmCopiarCelda.Image")));
            this.itmCopiarCelda.Name = "itmCopiarCelda";
            this.itmCopiarCelda.Size = new System.Drawing.Size(195, 22);
            this.itmCopiarCelda.Text = "Copiar dato de la celda";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // itmEliminar
            // 
            this.itmEliminar.Image = ((System.Drawing.Image)(resources.GetObject("itmEliminar.Image")));
            this.itmEliminar.Name = "itmEliminar";
            this.itmEliminar.Size = new System.Drawing.Size(195, 22);
            this.itmEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // itmEditar
            // 
            this.itmEditar.Image = global::appClientesAsociadosCredito.Properties.Resources.Refresh1;
            this.itmEditar.Name = "itmEditar";
            this.itmEditar.Size = new System.Drawing.Size(195, 22);
            this.itmEditar.Text = "Editar producto";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // itmDetalles
            // 
            this.itmDetalles.Image = global::appClientesAsociadosCredito.Properties.Resources.View_Details_;
            this.itmDetalles.Name = "itmDetalles";
            this.itmDetalles.Size = new System.Drawing.Size(195, 22);
            this.itmDetalles.Text = "Ver detalles";
            // 
            // frmControlGeneralInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 547);
            this.Controls.Add(this.grbRegistros);
            this.Controls.Add(this.tbcInventario);
            this.Controls.Add(this.stpEstado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmControlGeneralInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control general del inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.stpEstado.ResumeLayout(false);
            this.stpEstado.PerformLayout();
            this.grbRegistros.ResumeLayout(false);
            this.grbRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosInventario)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tpgEditar.ResumeLayout(false);
            this.grbDatosEditar.ResumeLayout(false);
            this.grbDatosEditar.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentajeEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadEditar)).EndInit();
            this.tpgAgregar.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVentaAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompraAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentajeAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAgregar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tbcInventario.ResumeLayout(false);
            this.menuClickDerecho.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stpEstado;
        private System.Windows.Forms.GroupBox grbRegistros;
        private System.Windows.Forms.DataGridView dgvProductosInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioVenta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaEntrada;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblInfoCantidad;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblDisponible;
        private System.Windows.Forms.ToolStripStatusLabel lblNoDisponible;
        private System.Windows.Forms.TabPage tpgEditar;
        private System.Windows.Forms.GroupBox grbDatosEditar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numPorcentajeEditar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numCantidadEditar;
        private System.Windows.Forms.CheckBox ckbExistenciaEditar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigoProductoEditar;
        private System.Windows.Forms.TextBox txtMarcaEditar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioVentaEditar;
        private System.Windows.Forms.TextBox txtPrecioCompraEditar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcionEditar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.TabPage tpgAgregar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numPorcentajeAgregar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numCantidadAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelarAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ckbExistenciaAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoArticuloAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TextBox txtNombreProductoAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarcaAgregar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TabControl tbcInventario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton lblBuscarEmpleado;
        private System.Windows.Forms.ToolStripTextBox txtFiltrarDatos;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolStripComboBox cmbOpcionesBusqueda;
        private System.Windows.Forms.NumericUpDown numPrecioCompraAgregar;
        private System.Windows.Forms.NumericUpDown numPrecioVentaAgregar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ContextMenuStrip menuClickDerecho;
        private System.Windows.Forms.ToolStripMenuItem itmCopiarCelda;
        private System.Windows.Forms.ToolStripMenuItem itmEliminar;
        private System.Windows.Forms.ToolStripMenuItem itmEditar;
        private System.Windows.Forms.ToolStripMenuItem itmDetalles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}