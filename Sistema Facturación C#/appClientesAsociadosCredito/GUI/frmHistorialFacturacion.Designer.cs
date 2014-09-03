namespace GUI
{
    partial class frmHistorialFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialFacturacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbClinete = new System.Windows.Forms.ComboBox();
            this.btnBorrarHistorial = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocuemnto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTablaHistorial = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grBoxFacturas = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cheBoxCedula = new System.Windows.Forms.RadioButton();
            this.cheBoxTipoVenta = new System.Windows.Forms.RadioButton();
            this.cheBoxPorFechas = new System.Windows.Forms.RadioButton();
            this.cheBoxPorEstado = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAbonos = new System.Windows.Forms.Button();
            this.btnAnularVenta = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.cmbBoxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbBoxTipoVenta = new System.Windows.Forms.ComboBox();
            this.lblTipoVenta = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCantidadItemsBusqueda = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInfoBusqueda = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNumeroRegistro = new System.Windows.Forms.ToolStripStatusLabel();
            this.clmSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumeroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstadoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaHistorial)).BeginInit();
            this.panel3.SuspendLayout();
            this.grBoxFacturas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbClinete);
            this.panel1.Controls.Add(this.btnBorrarHistorial);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtDocumento);
            this.panel1.Controls.Add(this.lblDocuemnto);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 78);
            this.panel1.TabIndex = 0;
            // 
            // cmbClinete
            // 
            this.cmbClinete.FormattingEnabled = true;
            this.cmbClinete.Location = new System.Drawing.Point(959, 17);
            this.cmbClinete.Name = "cmbClinete";
            this.cmbClinete.Size = new System.Drawing.Size(121, 24);
            this.cmbClinete.TabIndex = 6;
            // 
            // btnBorrarHistorial
            // 
            this.btnBorrarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarHistorial.Image")));
            this.btnBorrarHistorial.Location = new System.Drawing.Point(832, 17);
            this.btnBorrarHistorial.Name = "btnBorrarHistorial";
            this.btnBorrarHistorial.Size = new System.Drawing.Size(90, 41);
            this.btnBorrarHistorial.TabIndex = 4;
            this.btnBorrarHistorial.Text = "Borra historial";
            this.btnBorrarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarHistorial.UseVisualStyleBackColor = true;
            this.btnBorrarHistorial.Click += new System.EventHandler(this.btnBorrarHistorial_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(733, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 41);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(540, 29);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(178, 22);
            this.txtDocumento.TabIndex = 2;
            // 
            // lblDocuemnto
            // 
            this.lblDocuemnto.AutoSize = true;
            this.lblDocuemnto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocuemnto.Location = new System.Drawing.Point(537, 10);
            this.lblDocuemnto.Name = "lblDocuemnto";
            this.lblDocuemnto.Size = new System.Drawing.Size(78, 16);
            this.lblDocuemnto.TabIndex = 5;
            this.lblDocuemnto.Text = "Documento:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(311, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(308, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(163, 29);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(133, 22);
            this.txtCedula.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(10, 10);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(131, 54);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(160, 10);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(52, 16);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cédula:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvTablaHistorial);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 570);
            this.panel2.TabIndex = 1;
            // 
            // dgvTablaHistorial
            // 
            this.dgvTablaHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTablaHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSeleccion,
            this.clmNumeroFactura,
            this.clmNumeroCliente,
            this.clmCedula,
            this.clmNombreCliente,
            this.clmDireccionCliente,
            this.clmTelefonoCliente,
            this.clmTipoVenta,
            this.clmDescuento,
            this.clmTotalNeto,
            this.clmFechaCompra,
            this.clmEstadoFactura});
            this.dgvTablaHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaHistorial.Location = new System.Drawing.Point(143, 0);
            this.dgvTablaHistorial.Name = "dgvTablaHistorial";
            this.dgvTablaHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaHistorial.Size = new System.Drawing.Size(942, 546);
            this.dgvTablaHistorial.TabIndex = 1;
            this.dgvTablaHistorial.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvTablaHistorial_NewRowNeeded);
            this.dgvTablaHistorial.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTablaHistorial_RowsAdded);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.grBoxFacturas);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnAbonos);
            this.panel3.Controls.Add(this.btnAnularVenta);
            this.panel3.Controls.Add(this.dtpHasta);
            this.panel3.Controls.Add(this.lblHasta);
            this.panel3.Controls.Add(this.dtpDesde);
            this.panel3.Controls.Add(this.lblDesde);
            this.panel3.Controls.Add(this.cmbBoxEstado);
            this.panel3.Controls.Add(this.lblEstado);
            this.panel3.Controls.Add(this.cmbBoxTipoVenta);
            this.panel3.Controls.Add(this.lblTipoVenta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 546);
            this.panel3.TabIndex = 0;
            // 
            // grBoxFacturas
            // 
            this.grBoxFacturas.Controls.Add(this.panel6);
            this.grBoxFacturas.Controls.Add(this.panel5);
            this.grBoxFacturas.Controls.Add(this.panel4);
            this.grBoxFacturas.Controls.Add(this.label3);
            this.grBoxFacturas.Controls.Add(this.label2);
            this.grBoxFacturas.Controls.Add(this.label1);
            this.grBoxFacturas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxFacturas.Location = new System.Drawing.Point(6, 275);
            this.grBoxFacturas.Name = "grBoxFacturas";
            this.grBoxFacturas.Size = new System.Drawing.Size(132, 126);
            this.grBoxFacturas.TabIndex = 10;
            this.grBoxFacturas.TabStop = false;
            this.grBoxFacturas.Text = "Facturas";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Olive;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(6, 98);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(12, 16);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(6, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 14);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(6, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 14);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Abonadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Canceladas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anuladas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cheBoxCedula);
            this.groupBox1.Controls.Add(this.cheBoxTipoVenta);
            this.groupBox1.Controls.Add(this.cheBoxPorFechas);
            this.groupBox1.Controls.Add(this.cheBoxPorEstado);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 133);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de busqueda";
            // 
            // cheBoxCedula
            // 
            this.cheBoxCedula.AutoSize = true;
            this.cheBoxCedula.Location = new System.Drawing.Point(6, 106);
            this.cheBoxCedula.Name = "cheBoxCedula";
            this.cheBoxCedula.Size = new System.Drawing.Size(124, 18);
            this.cheBoxCedula.TabIndex = 16;
            this.cheBoxCedula.TabStop = true;
            this.cheBoxCedula.Text = "Número de cédula";
            this.cheBoxCedula.UseVisualStyleBackColor = true;
            // 
            // cheBoxTipoVenta
            // 
            this.cheBoxTipoVenta.AutoSize = true;
            this.cheBoxTipoVenta.Location = new System.Drawing.Point(6, 82);
            this.cheBoxTipoVenta.Name = "cheBoxTipoVenta";
            this.cheBoxTipoVenta.Size = new System.Drawing.Size(99, 18);
            this.cheBoxTipoVenta.TabIndex = 15;
            this.cheBoxTipoVenta.TabStop = true;
            this.cheBoxTipoVenta.Text = "Tipo de venta";
            this.cheBoxTipoVenta.UseVisualStyleBackColor = true;
            // 
            // cheBoxPorFechas
            // 
            this.cheBoxPorFechas.AutoSize = true;
            this.cheBoxPorFechas.Location = new System.Drawing.Point(6, 58);
            this.cheBoxPorFechas.Name = "cheBoxPorFechas";
            this.cheBoxPorFechas.Size = new System.Drawing.Size(116, 18);
            this.cheBoxPorFechas.TabIndex = 14;
            this.cheBoxPorFechas.TabStop = true;
            this.cheBoxPorFechas.Text = "Rango de fechas";
            this.cheBoxPorFechas.UseVisualStyleBackColor = true;
            // 
            // cheBoxPorEstado
            // 
            this.cheBoxPorEstado.AutoSize = true;
            this.cheBoxPorEstado.Location = new System.Drawing.Point(6, 34);
            this.cheBoxPorEstado.Name = "cheBoxPorEstado";
            this.cheBoxPorEstado.Size = new System.Drawing.Size(119, 18);
            this.cheBoxPorEstado.TabIndex = 13;
            this.cheBoxPorEstado.TabStop = true;
            this.cheBoxPorEstado.Text = "Estado de cuenta";
            this.cheBoxPorEstado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(6, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAbonos
            // 
            this.btnAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbonos.Location = new System.Drawing.Point(6, 217);
            this.btnAbonos.Name = "btnAbonos";
            this.btnAbonos.Size = new System.Drawing.Size(123, 23);
            this.btnAbonos.TabIndex = 11;
            this.btnAbonos.Text = "Abonos";
            this.btnAbonos.UseVisualStyleBackColor = true;
            this.btnAbonos.Click += new System.EventHandler(this.btnAbonos_Click);
            // 
            // btnAnularVenta
            // 
            this.btnAnularVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnularVenta.Location = new System.Drawing.Point(6, 188);
            this.btnAnularVenta.Name = "btnAnularVenta";
            this.btnAnularVenta.Size = new System.Drawing.Size(123, 23);
            this.btnAnularVenta.TabIndex = 10;
            this.btnAnularVenta.Text = "Anular venta";
            this.btnAnularVenta.UseVisualStyleBackColor = true;
            this.btnAnularVenta.Click += new System.EventHandler(this.btnAnularVenta_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(6, 162);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(123, 22);
            this.dtpHasta.TabIndex = 9;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(43, 141);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(48, 18);
            this.lblHasta.TabIndex = 6;
            this.lblHasta.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(6, 118);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(123, 22);
            this.dtpDesde.TabIndex = 8;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(43, 97);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(58, 18);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Text = "Desde:";
            // 
            // cmbBoxEstado
            // 
            this.cmbBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxEstado.FormattingEnabled = true;
            this.cmbBoxEstado.Items.AddRange(new object[] {
            "Anuladas",
            "Canceladas",
            "Abonadas"});
            this.cmbBoxEstado.Location = new System.Drawing.Point(6, 70);
            this.cmbBoxEstado.Name = "cmbBoxEstado";
            this.cmbBoxEstado.Size = new System.Drawing.Size(123, 24);
            this.cmbBoxEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(3, 49);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 18);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbBoxTipoVenta
            // 
            this.cmbBoxTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTipoVenta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxTipoVenta.FormattingEnabled = true;
            this.cmbBoxTipoVenta.Items.AddRange(new object[] {
            "Todos",
            "Contado",
            "Crédito"});
            this.cmbBoxTipoVenta.Location = new System.Drawing.Point(6, 22);
            this.cmbBoxTipoVenta.Name = "cmbBoxTipoVenta";
            this.cmbBoxTipoVenta.Size = new System.Drawing.Size(123, 24);
            this.cmbBoxTipoVenta.TabIndex = 6;
            // 
            // lblTipoVenta
            // 
            this.lblTipoVenta.AutoSize = true;
            this.lblTipoVenta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVenta.Location = new System.Drawing.Point(3, 1);
            this.lblTipoVenta.Name = "lblTipoVenta";
            this.lblTipoVenta.Size = new System.Drawing.Size(110, 18);
            this.lblTipoVenta.TabIndex = 0;
            this.lblTipoVenta.Text = "Tipo de venta:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCantidadItemsBusqueda,
            this.toolStripStatusLabel2,
            this.lblInfoBusqueda,
            this.toolStripStatusLabel3,
            this.lblNumeroRegistro});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(145, 17);
            this.toolStripStatusLabel1.Text = "Resultado de la búsqueda:";
            // 
            // lblCantidadItemsBusqueda
            // 
            this.lblCantidadItemsBusqueda.Name = "lblCantidadItemsBusqueda";
            this.lblCantidadItemsBusqueda.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadItemsBusqueda.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // lblInfoBusqueda
            // 
            this.lblInfoBusqueda.Name = "lblInfoBusqueda";
            this.lblInfoBusqueda.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "Número de registros:";
            // 
            // lblNumeroRegistro
            // 
            this.lblNumeroRegistro.Name = "lblNumeroRegistro";
            this.lblNumeroRegistro.Size = new System.Drawing.Size(13, 17);
            this.lblNumeroRegistro.Text = "0";
            // 
            // clmSeleccion
            // 
            this.clmSeleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmSeleccion.HeaderText = "Seleccionar";
            this.clmSeleccion.Name = "clmSeleccion";
            this.clmSeleccion.Width = 69;
            // 
            // clmNumeroFactura
            // 
            this.clmNumeroFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNumeroFactura.DataPropertyName = "id_NumeroFactura";
            this.clmNumeroFactura.HeaderText = "N° Factura";
            this.clmNumeroFactura.Name = "clmNumeroFactura";
            this.clmNumeroFactura.ReadOnly = true;
            this.clmNumeroFactura.Width = 83;
            // 
            // clmNumeroCliente
            // 
            this.clmNumeroCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNumeroCliente.DataPropertyName = "numeroCliente";
            this.clmNumeroCliente.HeaderText = "N° Cliente";
            this.clmNumeroCliente.Name = "clmNumeroCliente";
            this.clmNumeroCliente.ReadOnly = true;
            this.clmNumeroCliente.Width = 79;
            // 
            // clmCedula
            // 
            this.clmCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCedula.DataPropertyName = "cedula";
            this.clmCedula.HeaderText = "Cédula";
            this.clmCedula.Name = "clmCedula";
            this.clmCedula.ReadOnly = true;
            this.clmCedula.Width = 65;
            // 
            // clmNombreCliente
            // 
            this.clmNombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombreCliente.DataPropertyName = "nombreCliente";
            this.clmNombreCliente.HeaderText = "Nombre del cliente";
            this.clmNombreCliente.Name = "clmNombreCliente";
            this.clmNombreCliente.ReadOnly = true;
            this.clmNombreCliente.Width = 82;
            // 
            // clmDireccionCliente
            // 
            this.clmDireccionCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDireccionCliente.DataPropertyName = "direccionCliente";
            this.clmDireccionCliente.HeaderText = "Dirección";
            this.clmDireccionCliente.Name = "clmDireccionCliente";
            this.clmDireccionCliente.ReadOnly = true;
            this.clmDireccionCliente.Width = 77;
            // 
            // clmTelefonoCliente
            // 
            this.clmTelefonoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTelefonoCliente.DataPropertyName = "telefonoCliente";
            this.clmTelefonoCliente.HeaderText = "Teléfono";
            this.clmTelefonoCliente.Name = "clmTelefonoCliente";
            this.clmTelefonoCliente.ReadOnly = true;
            this.clmTelefonoCliente.Width = 74;
            // 
            // clmTipoVenta
            // 
            this.clmTipoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTipoVenta.DataPropertyName = "tipoVenta";
            this.clmTipoVenta.HeaderText = "Tipo de venta";
            this.clmTipoVenta.Name = "clmTipoVenta";
            this.clmTipoVenta.ReadOnly = true;
            this.clmTipoVenta.Width = 90;
            // 
            // clmDescuento
            // 
            this.clmDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDescuento.DataPropertyName = "descuento";
            this.clmDescuento.HeaderText = "Descuento";
            this.clmDescuento.Name = "clmDescuento";
            this.clmDescuento.ReadOnly = true;
            this.clmDescuento.Width = 84;
            // 
            // clmTotalNeto
            // 
            this.clmTotalNeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTotalNeto.DataPropertyName = "totalNeto";
            this.clmTotalNeto.HeaderText = "Total neto";
            this.clmTotalNeto.Name = "clmTotalNeto";
            this.clmTotalNeto.ReadOnly = true;
            this.clmTotalNeto.Width = 74;
            // 
            // clmFechaCompra
            // 
            this.clmFechaCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaCompra.DataPropertyName = "fechaCompra";
            this.clmFechaCompra.HeaderText = "Fecha de compra";
            this.clmFechaCompra.Name = "clmFechaCompra";
            this.clmFechaCompra.ReadOnly = true;
            this.clmFechaCompra.Width = 105;
            // 
            // clmEstadoFactura
            // 
            this.clmEstadoFactura.HeaderText = "Estado factura";
            this.clmEstadoFactura.Name = "clmEstadoFactura";
            // 
            // frmHistorialFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 648);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHistorialFacturacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas de mercaderia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaHistorial)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grBoxFacturas.ResumeLayout(false);
            this.grBoxFacturas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocuemnto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbBoxTipoVenta;
        private System.Windows.Forms.Label lblTipoVenta;
        private System.Windows.Forms.DataGridView dgvTablaHistorial;
        private System.Windows.Forms.GroupBox grBoxFacturas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbonos;
        private System.Windows.Forms.Button btnAnularVenta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ComboBox cmbBoxEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCantidadItemsBusqueda;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblInfoBusqueda;
        private System.Windows.Forms.Button btnBorrarHistorial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton cheBoxCedula;
        private System.Windows.Forms.RadioButton cheBoxTipoVenta;
        private System.Windows.Forms.RadioButton cheBoxPorFechas;
        private System.Windows.Forms.RadioButton cheBoxPorEstado;
        private System.Windows.Forms.ComboBox cmbClinete;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroRegistro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumeroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccionCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstadoFactura;

    }
}