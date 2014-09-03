namespace GUI
{
    partial class frmBuscarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarProductos));
            this.grbRegistros = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExistencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmFechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblBuscarProductos = new System.Windows.Forms.Label();
            this.menuClickDerecho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itmAgregarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.grbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuClickDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegistros
            // 
            this.grbRegistros.Controls.Add(this.dgvProductos);
            resources.ApplyResources(this.grbRegistros, "grbRegistros");
            this.grbRegistros.Name = "grbRegistros";
            this.grbRegistros.TabStop = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmMarca,
            this.clmDescripcion,
            this.clmPrecioCompra,
            this.clmExistencia,
            this.clmFechaEntrada,
            this.clmCantidad,
            this.clmPrecio});
            resources.ApplyResources(this.dgvProductos, "dgvProductos");
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_CellMouseClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCodigo.DataPropertyName = "Id_Producto";
            resources.ApplyResources(this.clmCodigo, "clmCodigo");
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombre.DataPropertyName = "nombre";
            resources.ApplyResources(this.clmNombre, "clmNombre");
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmMarca
            // 
            this.clmMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmMarca.DataPropertyName = "marca";
            resources.ApplyResources(this.clmMarca, "clmMarca");
            this.clmMarca.Name = "clmMarca";
            this.clmMarca.ReadOnly = true;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDescripcion.DataPropertyName = "Descripcion";
            resources.ApplyResources(this.clmDescripcion, "clmDescripcion");
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            // 
            // clmPrecioCompra
            // 
            this.clmPrecioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmPrecioCompra.DataPropertyName = "Precio_Compra";
            resources.ApplyResources(this.clmPrecioCompra, "clmPrecioCompra");
            this.clmPrecioCompra.Name = "clmPrecioCompra";
            this.clmPrecioCompra.ReadOnly = true;
            // 
            // clmExistencia
            // 
            this.clmExistencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmExistencia.DataPropertyName = "Existencia";
            resources.ApplyResources(this.clmExistencia, "clmExistencia");
            this.clmExistencia.Name = "clmExistencia";
            this.clmExistencia.ReadOnly = true;
            // 
            // clmFechaEntrada
            // 
            this.clmFechaEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaEntrada.DataPropertyName = "fecha_entrada";
            resources.ApplyResources(this.clmFechaEntrada, "clmFechaEntrada");
            this.clmFechaEntrada.Name = "clmFechaEntrada";
            this.clmFechaEntrada.ReadOnly = true;
            this.clmFechaEntrada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmFechaEntrada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmCantidad
            // 
            this.clmCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCantidad.DataPropertyName = "Cantidad";
            resources.ApplyResources(this.clmCantidad, "clmCantidad");
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            // 
            // clmPrecio
            // 
            this.clmPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmPrecio.DataPropertyName = "Precio_Venta";
            resources.ApplyResources(this.clmPrecio, "clmPrecio");
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Controls.Add(this.lblBuscarProductos);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtFiltro
            // 
            resources.ApplyResources(this.txtFiltro, "txtFiltro");
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblBuscarProductos
            // 
            resources.ApplyResources(this.lblBuscarProductos, "lblBuscarProductos");
            this.lblBuscarProductos.Name = "lblBuscarProductos";
            // 
            // menuClickDerecho
            // 
            this.menuClickDerecho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmAgregarProducto});
            this.menuClickDerecho.Name = "menuClickDerecho";
            resources.ApplyResources(this.menuClickDerecho, "menuClickDerecho");
            this.menuClickDerecho.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuClickDerecho_ItemClicked);
            // 
            // itmAgregarProducto
            // 
            resources.ApplyResources(this.itmAgregarProducto, "itmAgregarProducto");
            this.itmAgregarProducto.Name = "itmAgregarProducto";
            // 
            // frmBuscarProductos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbRegistros);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarProductos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.grbRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuClickDerecho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegistros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBuscarProductos;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ContextMenuStrip menuClickDerecho;
        private System.Windows.Forms.ToolStripMenuItem itmAgregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioCompra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}