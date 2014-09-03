namespace GUI
{
    partial class frmAgregarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarProductos));
            this.grbProductos = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.stbEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNumProductos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDisponible = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNoDisponible = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSinProductos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscarProducto = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbOpciones = new System.Windows.Forms.ToolStripComboBox();
            this.grbAgregarProductos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxExistencia = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuClickDerecho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itmCopiarCelda = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.itmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.grbProductos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosInventario)).BeginInit();
            this.stbEstado.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grbAgregarProductos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).BeginInit();
            this.menuClickDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbProductos
            // 
            this.grbProductos.AutoSize = true;
            this.grbProductos.Controls.Add(this.panel2);
            this.grbProductos.Controls.Add(this.toolStrip1);
            this.grbProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbProductos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProductos.Location = new System.Drawing.Point(0, 257);
            this.grbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.grbProductos.Name = "grbProductos";
            this.grbProductos.Padding = new System.Windows.Forms.Padding(4);
            this.grbProductos.Size = new System.Drawing.Size(863, 301);
            this.grbProductos.TabIndex = 3;
            this.grbProductos.TabStop = false;
            this.grbProductos.Text = "Productos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProductosInventario);
            this.panel2.Controls.Add(this.stbEstado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 235);
            this.panel2.TabIndex = 2;
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
            this.dgvProductosInventario.Location = new System.Drawing.Point(0, 0);
            this.dgvProductosInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductosInventario.MultiSelect = false;
            this.dgvProductosInventario.Name = "dgvProductosInventario";
            this.dgvProductosInventario.ReadOnly = true;
            this.dgvProductosInventario.RowHeadersVisible = false;
            this.dgvProductosInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosInventario.Size = new System.Drawing.Size(855, 213);
            this.dgvProductosInventario.TabIndex = 1;
            this.dgvProductosInventario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRegistros_CellMouseClick);
            this.dgvProductosInventario.SelectionChanged += new System.EventHandler(this.dgvProductosInventario_SelectionChanged);
            // 
            // clmCodigoProducto
            // 
            this.clmCodigoProducto.DataPropertyName = "id_producto";
            this.clmCodigoProducto.HeaderText = "Código";
            this.clmCodigoProducto.Name = "clmCodigoProducto";
            this.clmCodigoProducto.ReadOnly = true;
            this.clmCodigoProducto.Width = 79;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "nombre";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 85;
            // 
            // clmMarca
            // 
            this.clmMarca.DataPropertyName = "marca";
            this.clmMarca.HeaderText = "Marca";
            this.clmMarca.Name = "clmMarca";
            this.clmMarca.ReadOnly = true;
            this.clmMarca.Width = 73;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.DataPropertyName = "descripcion";
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            this.clmDescripcion.Width = 111;
            // 
            // clmPrecioCompra
            // 
            this.clmPrecioCompra.DataPropertyName = "precio_compra";
            this.clmPrecioCompra.HeaderText = "Precio de compra";
            this.clmPrecioCompra.Name = "clmPrecioCompra";
            this.clmPrecioCompra.ReadOnly = true;
            this.clmPrecioCompra.Width = 136;
            // 
            // clmPrecioVenta
            // 
            this.clmPrecioVenta.DataPropertyName = "precio_venta";
            this.clmPrecioVenta.HeaderText = "Precio de venta";
            this.clmPrecioVenta.Name = "clmPrecioVenta";
            this.clmPrecioVenta.ReadOnly = true;
            this.clmPrecioVenta.Width = 91;
            // 
            // clmExistencia
            // 
            this.clmExistencia.DataPropertyName = "existencia";
            this.clmExistencia.HeaderText = "Existencia";
            this.clmExistencia.Name = "clmExistencia";
            this.clmExistencia.ReadOnly = true;
            this.clmExistencia.Width = 81;
            // 
            // clmCantidad
            // 
            this.clmCantidad.DataPropertyName = "cantidad";
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            this.clmCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCantidad.Width = 72;
            // 
            // clmFechaEntrada
            // 
            this.clmFechaEntrada.DataPropertyName = "fecha_entrada";
            this.clmFechaEntrada.HeaderText = "Fecha de entrada";
            this.clmFechaEntrada.Name = "clmFechaEntrada";
            this.clmFechaEntrada.ReadOnly = true;
            this.clmFechaEntrada.Width = 134;
            // 
            // stbEstado
            // 
            this.stbEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblNumProductos,
            this.toolStripStatusLabel3,
            this.lblDisponible,
            this.lblNoDisponible,
            this.lblSinProductos});
            this.stbEstado.Location = new System.Drawing.Point(0, 213);
            this.stbEstado.Name = "stbEstado";
            this.stbEstado.Size = new System.Drawing.Size(855, 22);
            this.stbEstado.SizingGrip = false;
            this.stbEstado.TabIndex = 2;
            this.stbEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "Cantidad de productos:";
            // 
            // lblNumProductos
            // 
            this.lblNumProductos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumProductos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNumProductos.Name = "lblNumProductos";
            this.lblNumProductos.Size = new System.Drawing.Size(17, 17);
            this.lblNumProductos.Text = "\"\"";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel3.Text = "Disponibilidad:";
            // 
            // lblDisponible
            // 
            this.lblDisponible.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDisponible.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblDisponible.Image = ((System.Drawing.Image)(resources.GetObject("lblDisponible.Image")));
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(16, 17);
            this.lblDisponible.Text = "\"\"";
            // 
            // lblNoDisponible
            // 
            this.lblNoDisponible.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNoDisponible.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblNoDisponible.Image = ((System.Drawing.Image)(resources.GetObject("lblNoDisponible.Image")));
            this.lblNoDisponible.Name = "lblNoDisponible";
            this.lblNoDisponible.Size = new System.Drawing.Size(16, 17);
            this.lblNoDisponible.Text = "\"\"";
            // 
            // lblSinProductos
            // 
            this.lblSinProductos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSinProductos.Name = "lblSinProductos";
            this.lblSinProductos.Size = new System.Drawing.Size(141, 17);
            this.lblSinProductos.Text = "Sin productos registrados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditar,
            this.btnEliminar,
            this.toolStripSeparator1,
            this.btnActualizar,
            this.toolStripSeparator2,
            this.lblBuscarProducto,
            this.txtBuscar,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.cmbOpciones});
            this.toolStrip1.Location = new System.Drawing.Point(4, 22);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(855, 40);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 37);
            this.btnEditar.Text = "Modificar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::appClientesAsociadosCredito.Properties.Resources.aspa_roja_con_borde_incorrecto;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 37);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::appClientesAsociadosCredito.Properties.Resources.Refresh;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(76, 37);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(120, 37);
            this.lblBuscarProducto.Text = "Buscar producto:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 40);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(171, 37);
            this.toolStripLabel1.Text = "Opciones de búesqueda:";
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpciones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbOpciones.Items.AddRange(new object[] {
            "Código",
            "Descripción",
            "Marca"});
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(75, 40);
            // 
            // grbAgregarProductos
            // 
            this.grbAgregarProductos.Controls.Add(this.panel1);
            this.grbAgregarProductos.Controls.Add(this.cbxExistencia);
            this.grbAgregarProductos.Controls.Add(this.label8);
            this.grbAgregarProductos.Controls.Add(this.numCantidad);
            this.grbAgregarProductos.Controls.Add(this.label7);
            this.grbAgregarProductos.Controls.Add(this.numPorcentaje);
            this.grbAgregarProductos.Controls.Add(this.label6);
            this.grbAgregarProductos.Controls.Add(this.txtPrecioVenta);
            this.grbAgregarProductos.Controls.Add(this.label5);
            this.grbAgregarProductos.Controls.Add(this.txtDescripcion);
            this.grbAgregarProductos.Controls.Add(this.label2);
            this.grbAgregarProductos.Controls.Add(this.txtNombreProducto);
            this.grbAgregarProductos.Controls.Add(this.lblNombreProveedor);
            this.grbAgregarProductos.Controls.Add(this.txtPrecioCompra);
            this.grbAgregarProductos.Controls.Add(this.txtMarca);
            this.grbAgregarProductos.Controls.Add(this.txtCodigoArticulo);
            this.grbAgregarProductos.Controls.Add(this.label4);
            this.grbAgregarProductos.Controls.Add(this.label3);
            this.grbAgregarProductos.Controls.Add(this.lblMarca);
            this.grbAgregarProductos.Controls.Add(this.label1);
            this.grbAgregarProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbAgregarProductos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAgregarProductos.Location = new System.Drawing.Point(0, 0);
            this.grbAgregarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.grbAgregarProductos.Name = "grbAgregarProductos";
            this.grbAgregarProductos.Padding = new System.Windows.Forms.Padding(4);
            this.grbAgregarProductos.Size = new System.Drawing.Size(863, 257);
            this.grbAgregarProductos.TabIndex = 5;
            this.grbAgregarProductos.TabStop = false;
            this.grbAgregarProductos.Text = "Agregar productos:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(741, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 231);
            this.panel1.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(4, 5);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 39);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(4, 47);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 39);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxExistencia
            // 
            this.cbxExistencia.AutoSize = true;
            this.cbxExistencia.Location = new System.Drawing.Point(541, 225);
            this.cbxExistencia.Name = "cbxExistencia";
            this.cbxExistencia.Size = new System.Drawing.Size(15, 14);
            this.cbxExistencia.TabIndex = 21;
            this.cbxExistencia.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Existencia:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(169, 220);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(277, 25);
            this.numCantidad.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "%";
            // 
            // numPorcentaje
            // 
            this.numPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPorcentaje.DecimalPlaces = 1;
            this.numPorcentaje.Location = new System.Drawing.Point(541, 187);
            this.numPorcentaje.Name = "numPorcentaje";
            this.numPorcentaje.Size = new System.Drawing.Size(49, 21);
            this.numPorcentaje.TabIndex = 17;
            this.numPorcentaje.ValueChanged += new System.EventHandler(this.numPorcentaje_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Porcentaje:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Location = new System.Drawing.Point(169, 186);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(277, 25);
            this.txtPrecioVenta.TabIndex = 5;
            this.txtPrecioVenta.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Precio de venta:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(169, 120);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(277, 25);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripción:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(169, 56);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(277, 25);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(13, 59);
            this.lblNombreProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(148, 17);
            this.lblNombreProveedor.TabIndex = 12;
            this.lblNombreProveedor.Text = "Nombre del producto:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(169, 153);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(277, 25);
            this.txtPrecioCompra.TabIndex = 4;
            this.txtPrecioCompra.Text = "0";
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(169, 88);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(277, 25);
            this.txtMarca.TabIndex = 2;
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(169, 27);
            this.txtCodigoArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(277, 25);
            this.txtCodigoArticulo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(109, 91);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 17);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del articulo:";
            // 
            // menuClickDerecho
            // 
            this.menuClickDerecho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmCopiarCelda,
            this.itmEliminar,
            this.toolStripSeparator4,
            this.itmEditar,
            this.toolStripSeparator5});
            this.menuClickDerecho.Name = "menuClickDerecho";
            this.menuClickDerecho.Size = new System.Drawing.Size(196, 82);
            this.menuClickDerecho.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuClickDerecho_ItemClicked);
            // 
            // itmCopiarCelda
            // 
            this.itmCopiarCelda.Image = global::appClientesAsociadosCredito.Properties.Resources.Editing_Copy_icon;
            this.itmCopiarCelda.Name = "itmCopiarCelda";
            this.itmCopiarCelda.Size = new System.Drawing.Size(195, 22);
            this.itmCopiarCelda.Text = "Copiar dato de la celda";
            // 
            // itmEliminar
            // 
            this.itmEliminar.Image = global::appClientesAsociadosCredito.Properties.Resources.forbidden_159816_640;
            this.itmEliminar.Name = "itmEliminar";
            this.itmEliminar.Size = new System.Drawing.Size(195, 22);
            this.itmEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // itmEditar
            // 
            this.itmEditar.Image = ((System.Drawing.Image)(resources.GetObject("itmEditar.Image")));
            this.itmEditar.Name = "itmEditar";
            this.itmEditar.Size = new System.Drawing.Size(195, 22);
            this.itmEditar.Text = "Editar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(192, 6);
            // 
            // frmAgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 558);
            this.Controls.Add(this.grbProductos);
            this.Controls.Add(this.grbAgregarProductos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAgregarProductos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbProductos.ResumeLayout(false);
            this.grbProductos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosInventario)).EndInit();
            this.stbEstado.ResumeLayout(false);
            this.stbEstado.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbAgregarProductos.ResumeLayout(false);
            this.grbAgregarProductos.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).EndInit();
            this.menuClickDerecho.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProductos;
        private System.Windows.Forms.DataGridView dgvProductosInventario;
        private System.Windows.Forms.GroupBox grbAgregarProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioVenta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaEntrada;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblBuscarProducto;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numPorcentaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.StatusStrip stbEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumProductos;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblDisponible;
        private System.Windows.Forms.ToolStripStatusLabel lblNoDisponible;
        private System.Windows.Forms.CheckBox cbxExistencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbOpciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSinProductos;
        private System.Windows.Forms.ContextMenuStrip menuClickDerecho;
        private System.Windows.Forms.ToolStripMenuItem itmCopiarCelda;
        private System.Windows.Forms.ToolStripMenuItem itmEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem itmEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnEditar;
    }
}