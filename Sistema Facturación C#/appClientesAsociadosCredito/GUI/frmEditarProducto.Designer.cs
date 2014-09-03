namespace GUI
{
    partial class frmEditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarProducto));
            this.grbProducto = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.numPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.numPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.ckbExistencia = new System.Windows.Forms.CheckBox();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.grbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbProducto
            // 
            this.grbProducto.Controls.Add(this.btnLimpiar);
            this.grbProducto.Controls.Add(this.btnBuscar);
            this.grbProducto.Controls.Add(this.numPrecioVenta);
            this.grbProducto.Controls.Add(this.numPrecioCompra);
            this.grbProducto.Controls.Add(this.label15);
            this.grbProducto.Controls.Add(this.numPorcentaje);
            this.grbProducto.Controls.Add(this.label16);
            this.grbProducto.Controls.Add(this.numCantidad);
            this.grbProducto.Controls.Add(this.label13);
            this.grbProducto.Controls.Add(this.ckbExistencia);
            this.grbProducto.Controls.Add(this.txtCodigoArticulo);
            this.grbProducto.Controls.Add(this.label5);
            this.grbProducto.Controls.Add(this.label3);
            this.grbProducto.Controls.Add(this.lblNombreProveedor);
            this.grbProducto.Controls.Add(this.txtNombreProducto);
            this.grbProducto.Controls.Add(this.label2);
            this.grbProducto.Controls.Add(this.txtDescripcion);
            this.grbProducto.Controls.Add(this.label4);
            this.grbProducto.Controls.Add(this.txtMarca);
            this.grbProducto.Controls.Add(this.lblMarca);
            this.grbProducto.Controls.Add(this.lblCodigoProducto);
            this.grbProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbProducto.Location = new System.Drawing.Point(0, 0);
            this.grbProducto.Name = "grbProducto";
            this.grbProducto.Size = new System.Drawing.Size(580, 265);
            this.grbProducto.TabIndex = 0;
            this.grbProducto.TabStop = false;
            this.grbProducto.Text = "Producto";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(533, 57);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(38, 32);
            this.btnLimpiar.TabIndex = 61;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(533, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 32);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // numPrecioVenta
            // 
            this.numPrecioVenta.Location = new System.Drawing.Point(149, 189);
            this.numPrecioVenta.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numPrecioVenta.Name = "numPrecioVenta";
            this.numPrecioVenta.ReadOnly = true;
            this.numPrecioVenta.Size = new System.Drawing.Size(376, 21);
            this.numPrecioVenta.TabIndex = 59;
            // 
            // numPrecioCompra
            // 
            this.numPrecioCompra.Location = new System.Drawing.Point(149, 159);
            this.numPrecioCompra.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numPrecioCompra.Name = "numPrecioCompra";
            this.numPrecioCompra.Size = new System.Drawing.Size(376, 21);
            this.numPrecioCompra.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(443, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 15);
            this.label15.TabIndex = 57;
            this.label15.Text = "%";
            // 
            // numPorcentaje
            // 
            this.numPorcentaje.DecimalPlaces = 1;
            this.numPorcentaje.Location = new System.Drawing.Point(368, 219);
            this.numPorcentaje.Name = "numPorcentaje";
            this.numPorcentaje.Size = new System.Drawing.Size(66, 21);
            this.numPorcentaje.TabIndex = 56;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(293, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 55;
            this.label16.Text = "Porcentaje:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(149, 219);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 21);
            this.numCantidad.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(471, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 53;
            this.label13.Text = "Existencia:";
            // 
            // ckbExistencia
            // 
            this.ckbExistencia.AutoSize = true;
            this.ckbExistencia.Location = new System.Drawing.Point(543, 223);
            this.ckbExistencia.Name = "ckbExistencia";
            this.ckbExistencia.Size = new System.Drawing.Size(15, 14);
            this.ckbExistencia.TabIndex = 52;
            this.ckbExistencia.UseVisualStyleBackColor = true;
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(149, 23);
            this.txtCodigoArticulo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.ReadOnly = true;
            this.txtCodigoArticulo.Size = new System.Drawing.Size(375, 21);
            this.txtCodigoArticulo.TabIndex = 42;
            this.txtCodigoArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoArticulo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "Precio de venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cantidad:";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(12, 61);
            this.lblNombreProveedor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(126, 15);
            this.lblNombreProveedor.TabIndex = 49;
            this.lblNombreProveedor.Text = "Nombre del producto:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(149, 58);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(375, 21);
            this.txtNombreProducto.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(149, 127);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(375, 21);
            this.txtDescripcion.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Precio de compra:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(149, 92);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(6);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(375, 21);
            this.txtMarca.TabIndex = 45;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(93, 96);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 15);
            this.lblMarca.TabIndex = 43;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(17, 27);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(120, 15);
            this.lblCodigoProducto.TabIndex = 0;
            this.lblCodigoProducto.Text = "Código del producto:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnAplicar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 265);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(580, 59);
            this.pnlBotones.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(347, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 39);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicar.Image")));
            this.btnAplicar.Location = new System.Drawing.Point(138, 6);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(91, 39);
            this.btnAplicar.TabIndex = 0;
            this.btnAplicar.Text = "Editar";
            this.btnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // frmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(580, 324);
            this.Controls.Add(this.grbProducto);
            this.Controls.Add(this.pnlBotones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarProducto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar producto";
            this.grbProducto.ResumeLayout(false);
            this.grbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProducto;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.NumericUpDown numPrecioVenta;
        private System.Windows.Forms.NumericUpDown numPrecioCompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numPorcentaje;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ckbExistencia;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}