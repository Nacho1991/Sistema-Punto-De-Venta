namespace GUI
{
    partial class frmVerProductosInventario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProductosInventario = new System.Windows.Forms.DataGridView();
            this.clmCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 447);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(123, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 88);
            this.panel2.TabIndex = 1;
            // 
            // dgvProductosInventario
            // 
            this.dgvProductosInventario.AllowUserToOrderColumns = true;
            this.dgvProductosInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductosInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigoProducto,
            this.clmDescripcion,
            this.clmCantidad,
            this.clmCostoUnitario,
            this.clmNombreProveedor,
            this.clmFechaEntrada,
            this.clmCostoTotal});
            this.dgvProductosInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductosInventario.Location = new System.Drawing.Point(123, 88);
            this.dgvProductosInventario.Name = "dgvProductosInventario";
            this.dgvProductosInventario.ReadOnly = true;
            this.dgvProductosInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosInventario.Size = new System.Drawing.Size(717, 359);
            this.dgvProductosInventario.TabIndex = 2;
            // 
            // clmCodigoProducto
            // 
            this.clmCodigoProducto.DataPropertyName = "id_CodigoProducto";
            this.clmCodigoProducto.HeaderText = "Código";
            this.clmCodigoProducto.Name = "clmCodigoProducto";
            this.clmCodigoProducto.ReadOnly = true;
            this.clmCodigoProducto.Width = 65;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.DataPropertyName = "descripcionProducto";
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            this.clmDescripcion.Width = 88;
            // 
            // clmCantidad
            // 
            this.clmCantidad.DataPropertyName = "cantidadProductoInventario";
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            this.clmCantidad.Width = 74;
            // 
            // clmCostoUnitario
            // 
            this.clmCostoUnitario.DataPropertyName = "costoProductoUnitario";
            this.clmCostoUnitario.HeaderText = "Costo Unitario";
            this.clmCostoUnitario.Name = "clmCostoUnitario";
            this.clmCostoUnitario.ReadOnly = true;
            this.clmCostoUnitario.Width = 90;
            // 
            // clmNombreProveedor
            // 
            this.clmNombreProveedor.DataPropertyName = "nombreProveedor";
            this.clmNombreProveedor.HeaderText = "Nombre del proveedor";
            this.clmNombreProveedor.Name = "clmNombreProveedor";
            this.clmNombreProveedor.ReadOnly = true;
            this.clmNombreProveedor.Width = 125;
            // 
            // clmFechaEntrada
            // 
            this.clmFechaEntrada.DataPropertyName = "fechaEntrada";
            this.clmFechaEntrada.HeaderText = "Fecha de entrada";
            this.clmFechaEntrada.Name = "clmFechaEntrada";
            this.clmFechaEntrada.ReadOnly = true;
            this.clmFechaEntrada.Width = 106;
            // 
            // clmCostoTotal
            // 
            this.clmCostoTotal.DataPropertyName = "costoTotal";
            this.clmCostoTotal.HeaderText = "Costo total:";
            this.clmCostoTotal.Name = "clmCostoTotal";
            this.clmCostoTotal.ReadOnly = true;
            this.clmCostoTotal.Width = 78;
            // 
            // frmVerProductosInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 447);
            this.Controls.Add(this.dgvProductosInventario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmVerProductosInventario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos en inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProductosInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostoTotal;
    }
}