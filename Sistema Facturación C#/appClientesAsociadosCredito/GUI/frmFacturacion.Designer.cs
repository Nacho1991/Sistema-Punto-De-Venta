namespace GUI
{
    partial class frmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalNeto = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblTotalEtiqueta = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCantidadItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.totyTelefono = new System.Windows.Forms.ToolTip(this.components);
            this.lblHoraSistem = new System.Windows.Forms.Label();
            this.dtpMesCredito = new System.Windows.Forms.DateTimePicker();
            this.numCantDias = new System.Windows.Forms.NumericUpDown();
            this.cmBoxTipoCliente = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabOpciones = new System.Windows.Forms.RibbonTab();
            this.pnlBuscarProducto = new System.Windows.Forms.RibbonPanel();
            this.btnBuscar = new System.Windows.Forms.RibbonButton();
            this.pnlProductosVarios = new System.Windows.Forms.RibbonPanel();
            this.btnAgregarProductoVario = new System.Windows.Forms.RibbonButton();
            this.btnModificarProductoVario = new System.Windows.Forms.RibbonButton();
            this.pnlEliminar = new System.Windows.Forms.RibbonPanel();
            this.btnEliminarProducto = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnDescuento = new System.Windows.Forms.RibbonButton();
            this.pnlFacturacion = new System.Windows.Forms.RibbonPanel();
            this.btnEmitirFactura = new System.Windows.Forms.RibbonButton();
            this.btnEliminarFactura = new System.Windows.Forms.RibbonButton();
            this.btnPausar = new System.Windows.Forms.RibbonButton();
            this.btnPendientes = new System.Windows.Forms.RibbonButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ribonMenu = new System.Windows.Forms.Ribbon();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantDias)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 346);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos a facturar:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFactura);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 325);
            this.panel2.TabIndex = 2;
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmDescripcion,
            this.clmCantidad,
            this.clmPrecioUnitario,
            this.clmTotal});
            this.dgvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactura.Location = new System.Drawing.Point(0, 0);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFactura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFactura.Size = new System.Drawing.Size(793, 325);
            this.dgvFactura.TabIndex = 0;
            this.totyTelefono.SetToolTip(this.dgvFactura, "Se muestran los artículos a facturar");
            // 
            // clmCodigo
            // 
            this.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 73;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            this.clmDescripcion.Width = 101;
            // 
            // clmCantidad
            // 
            this.clmCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            this.clmCantidad.Width = 84;
            // 
            // clmPrecioUnitario
            // 
            this.clmPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmPrecioUnitario.HeaderText = "Precio unitario";
            this.clmPrecioUnitario.Name = "clmPrecioUnitario";
            this.clmPrecioUnitario.ReadOnly = true;
            this.clmPrecioUnitario.Width = 116;
            // 
            // clmTotal
            // 
            this.clmTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            this.clmTotal.Width = 60;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtTotalNeto);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.lblSubTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 474);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 53);
            this.panel3.TabIndex = 7;
            // 
            // txtTotalNeto
            // 
            this.txtTotalNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalNeto.Location = new System.Drawing.Point(659, 14);
            this.txtTotalNeto.Name = "txtTotalNeto";
            this.txtTotalNeto.ReadOnly = true;
            this.txtTotalNeto.Size = new System.Drawing.Size(131, 20);
            this.txtTotalNeto.TabIndex = 9;
            this.txtTotalNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(574, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 18);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total Neto:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(315, 13);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(118, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(262, 16);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(47, 18);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "Total:";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(9, 12);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(91, 16);
            this.lblObservacion.TabIndex = 8;
            this.lblObservacion.Text = "Observación:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(104, 11);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(608, 20);
            this.txtObservacion.TabIndex = 9;
            // 
            // lblTotalEtiqueta
            // 
            this.lblTotalEtiqueta.AutoSize = true;
            this.lblTotalEtiqueta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEtiqueta.Location = new System.Drawing.Point(720, 12);
            this.lblTotalEtiqueta.Name = "lblTotalEtiqueta";
            this.lblTotalEtiqueta.Size = new System.Drawing.Size(18, 19);
            this.lblTotalEtiqueta.TabIndex = 10;
            this.lblTotalEtiqueta.Text = "0";
            this.totyTelefono.SetToolTip(this.lblTotalEtiqueta, "Muestar el monto total a pagar por el cliente");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCantidadItems});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(799, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(159, 17);
            this.toolStripStatusLabel1.Text = "Número de items en la tabla:";
            // 
            // lblCantidadItems
            // 
            this.lblCantidadItems.Name = "lblCantidadItems";
            this.lblCantidadItems.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadItems.Text = "0";
            this.lblCantidadItems.ToolTipText = "Muestar la cantidad de ítems o productos agregados a la tabla";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHoraSistem
            // 
            this.lblHoraSistem.AutoSize = true;
            this.lblHoraSistem.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHoraSistem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSistem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraSistem.Location = new System.Drawing.Point(722, 0);
            this.lblHoraSistem.Name = "lblHoraSistem";
            this.lblHoraSistem.Size = new System.Drawing.Size(75, 19);
            this.lblHoraSistem.TabIndex = 22;
            this.lblHoraSistem.Text = "00:00:00";
            this.totyTelefono.SetToolTip(this.lblHoraSistem, "Muestar la hora del sistema");
            // 
            // dtpMesCredito
            // 
            this.dtpMesCredito.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMesCredito.Location = new System.Drawing.Point(99, 55);
            this.dtpMesCredito.Name = "dtpMesCredito";
            this.dtpMesCredito.Size = new System.Drawing.Size(89, 22);
            this.dtpMesCredito.TabIndex = 4;
            this.totyTelefono.SetToolTip(this.dtpMesCredito, "Se establece el límite de pago de la fcatura");
            // 
            // numCantDias
            // 
            this.numCantDias.Location = new System.Drawing.Point(52, 55);
            this.numCantDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numCantDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantDias.Name = "numCantDias";
            this.numCantDias.Size = new System.Drawing.Size(41, 22);
            this.numCantDias.TabIndex = 3;
            this.totyTelefono.SetToolTip(this.numCantDias, "Se establece la cantidad de día hábiles para la cancelación de la facturación");
            this.numCantDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmBoxTipoCliente
            // 
            this.cmBoxTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxTipoCliente.FormattingEnabled = true;
            this.cmBoxTipoCliente.Items.AddRange(new object[] {
            "CONTADO",
            "CREDITO"});
            this.cmBoxTipoCliente.Location = new System.Drawing.Point(67, 19);
            this.cmBoxTipoCliente.Name = "cmBoxTipoCliente";
            this.cmBoxTipoCliente.Size = new System.Drawing.Size(121, 24);
            this.cmBoxTipoCliente.TabIndex = 0;
            this.totyTelefono.SetToolTip(this.cmBoxTipoCliente, "Se establece el tipo de cliente");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtObservacion);
            this.panel4.Controls.Add(this.lblObservacion);
            this.panel4.Controls.Add(this.lblTotalEtiqueta);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 527);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(799, 39);
            this.panel4.TabIndex = 12;
            // 
            // tabOpciones
            // 
            this.tabOpciones.Panels.Add(this.pnlBuscarProducto);
            this.tabOpciones.Panels.Add(this.pnlProductosVarios);
            this.tabOpciones.Panels.Add(this.pnlEliminar);
            this.tabOpciones.Panels.Add(this.ribbonPanel1);
            this.tabOpciones.Panels.Add(this.pnlFacturacion);
            this.tabOpciones.Text = "Opciones de facturación";
            // 
            // pnlBuscarProducto
            // 
            this.pnlBuscarProducto.ButtonMoreVisible = false;
            this.pnlBuscarProducto.Items.Add(this.btnBuscar);
            this.pnlBuscarProducto.Text = "Buscar productos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.SmallImage")));
            this.btnBuscar.Text = "";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlProductosVarios
            // 
            this.pnlProductosVarios.ButtonMoreVisible = false;
            this.pnlProductosVarios.Items.Add(this.btnAgregarProductoVario);
            this.pnlProductosVarios.Items.Add(this.btnModificarProductoVario);
            this.pnlProductosVarios.Text = "Productos varios";
            // 
            // btnAgregarProductoVario
            // 
            this.btnAgregarProductoVario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProductoVario.Image")));
            this.btnAgregarProductoVario.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProductoVario.SmallImage")));
            this.btnAgregarProductoVario.Text = "Agregar";
            // 
            // btnModificarProductoVario
            // 
            this.btnModificarProductoVario.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarProductoVario.Image")));
            this.btnModificarProductoVario.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnModificarProductoVario.SmallImage")));
            this.btnModificarProductoVario.Text = "Modificar";
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.ButtonMoreVisible = false;
            this.pnlEliminar.Items.Add(this.btnEliminarProducto);
            this.pnlEliminar.Text = "Eliminar producto";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.Image")));
            this.btnEliminarProducto.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.SmallImage")));
            this.btnEliminarProducto.Text = "";
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.btnDescuento);
            this.ribbonPanel1.Text = "Descuento";
            // 
            // btnDescuento
            // 
            this.btnDescuento.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuento.Image")));
            this.btnDescuento.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDescuento.SmallImage")));
            this.btnDescuento.Text = "";
            // 
            // pnlFacturacion
            // 
            this.pnlFacturacion.ButtonMoreVisible = false;
            this.pnlFacturacion.Items.Add(this.btnEmitirFactura);
            this.pnlFacturacion.Items.Add(this.btnEliminarFactura);
            this.pnlFacturacion.Items.Add(this.btnPausar);
            this.pnlFacturacion.Items.Add(this.btnPendientes);
            this.pnlFacturacion.Text = "Facturación";
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnEmitirFactura.Image")));
            this.btnEmitirFactura.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEmitirFactura.SmallImage")));
            this.btnEmitirFactura.Text = "Emitir";
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarFactura.Image")));
            this.btnEliminarFactura.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarFactura.SmallImage")));
            this.btnEliminarFactura.Text = "Eliminar";
            // 
            // btnPausar
            // 
            this.btnPausar.Image = ((System.Drawing.Image)(resources.GetObject("btnPausar.Image")));
            this.btnPausar.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPausar.SmallImage")));
            this.btnPausar.Text = "Pausar";
            // 
            // btnPendientes
            // 
            this.btnPendientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPendientes.Image")));
            this.btnPendientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPendientes.SmallImage")));
            this.btnPendientes.Text = "Pendientes";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ribonMenu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(799, 128);
            this.panel5.TabIndex = 3;
            // 
            // ribonMenu
            // 
            this.ribonMenu.CaptionBarVisible = false;
            this.ribonMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribonMenu.Location = new System.Drawing.Point(0, 0);
            this.ribonMenu.Minimized = false;
            this.ribonMenu.Name = "ribonMenu";
            // 
            // 
            // 
            this.ribonMenu.OrbDropDown.BorderRoundness = 8;
            this.ribonMenu.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribonMenu.OrbDropDown.Name = "";
            this.ribonMenu.OrbDropDown.Size = new System.Drawing.Size(527, 119);
            this.ribonMenu.OrbDropDown.TabIndex = 0;
            this.ribonMenu.OrbImage = null;
            this.ribonMenu.OrbText = "";
            this.ribonMenu.OrbVisible = false;
            // 
            // 
            // 
            this.ribonMenu.QuickAcessToolbar.Visible = false;
            this.ribonMenu.Size = new System.Drawing.Size(799, 122);
            this.ribonMenu.TabIndex = 14;
            this.ribonMenu.Tabs.Add(this.tabOpciones);
            this.ribonMenu.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribonMenu.Text = "Opciones";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCodigoEmpleado);
            this.panel1.Controls.Add(this.lblHoraSistem);
            this.panel1.Controls.Add(this.txtNombreEmpleado);
            this.panel1.Controls.Add(this.lblEmpleado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 35);
            this.panel1.TabIndex = 14;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(76, 5);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.ReadOnly = true;
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoEmpleado.TabIndex = 23;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(255, 5);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(263, 22);
            this.txtNombreEmpleado.TabIndex = 21;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(182, 8);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(70, 16);
            this.lblEmpleado.TabIndex = 20;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Códigos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtCedulaCliente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLimiteCredito);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 107);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(498, 18);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 19;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Location = new System.Drawing.Point(84, 17);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(98, 22);
            this.txtCedulaCliente.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cédula:";
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Location = new System.Drawing.Point(382, 73);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.ReadOnly = true;
            this.txtLimiteCredito.Size = new System.Drawing.Size(110, 22);
            this.txtLimiteCredito.TabIndex = 14;
            this.txtLimiteCredito.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Límite de crédito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(84, 72);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(114, 22);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(84, 45);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(408, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(256, 16);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(236, 22);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpMesCredito);
            this.groupBox2.Controls.Add(this.numCantDias);
            this.groupBox2.Controls.Add(this.lblDias);
            this.groupBox2.Controls.Add(this.lblTipoCliente);
            this.groupBox2.Controls.Add(this.cmBoxTipoCliente);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(596, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 86);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de cliente:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(13, 59);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(38, 16);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Días:";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(13, 22);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(36, 16);
            this.lblTipoCliente.TabIndex = 1;
            this.lblTipoCliente.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(799, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmFacturacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de facturación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFacturacion_FormClosing);
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantDias)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtTotalNeto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblTotalEtiqueta;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCantidadItems;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip totyTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.RibbonTab tabOpciones;
        private System.Windows.Forms.RibbonPanel pnlBuscarProducto;
        private System.Windows.Forms.RibbonPanel pnlProductosVarios;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Ribbon ribonMenu;
        private System.Windows.Forms.RibbonPanel pnlEliminar;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel pnlFacturacion;
        private System.Windows.Forms.RibbonButton btnEmitirFactura;
        private System.Windows.Forms.RibbonButton btnEliminarFactura;
        private System.Windows.Forms.RibbonButton btnPausar;
        private System.Windows.Forms.RibbonButton btnPendientes;
        private System.Windows.Forms.RibbonButton btnDescuento;
        private System.Windows.Forms.RibbonButton btnAgregarProductoVario;
        private System.Windows.Forms.RibbonButton btnModificarProductoVario;
        private System.Windows.Forms.RibbonButton btnBuscar;
        private System.Windows.Forms.RibbonButton btnEliminarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.Label lblHoraSistem;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpMesCredito;
        private System.Windows.Forms.NumericUpDown numCantDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cmBoxTipoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}