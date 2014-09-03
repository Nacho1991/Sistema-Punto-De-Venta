namespace GUI
{
    partial class frmGeneradorBarras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneradorBarras));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grbCodBarras = new System.Windows.Forms.GroupBox();
            this.ptbBarras = new System.Windows.Forms.PictureBox();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.rbtnTercerTipo = new System.Windows.Forms.RadioButton();
            this.rbtnSegundoTipo = new System.Windows.Forms.RadioButton();
            this.rbtnPrimerTipo = new System.Windows.Forms.RadioButton();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVerGenerados = new System.Windows.Forms.Button();
            this.numPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.numPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.ckbExistencia = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbCodBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarras)).BeginInit();
            this.grbOpciones.SuspendLayout();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(490, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(166, 51);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar y guardar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(144, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(325, 21);
            this.txtCodigo.TabIndex = 3;
            // 
            // grbCodBarras
            // 
            this.grbCodBarras.Controls.Add(this.ptbBarras);
            this.grbCodBarras.Controls.Add(this.grbOpciones);
            this.grbCodBarras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCodBarras.Location = new System.Drawing.Point(0, 242);
            this.grbCodBarras.Name = "grbCodBarras";
            this.grbCodBarras.Size = new System.Drawing.Size(663, 236);
            this.grbCodBarras.TabIndex = 7;
            this.grbCodBarras.TabStop = false;
            this.grbCodBarras.Text = "Código de barras";
            // 
            // ptbBarras
            // 
            this.ptbBarras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbBarras.Location = new System.Drawing.Point(3, 17);
            this.ptbBarras.Name = "ptbBarras";
            this.ptbBarras.Size = new System.Drawing.Size(514, 216);
            this.ptbBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbBarras.TabIndex = 0;
            this.ptbBarras.TabStop = false;
            // 
            // grbOpciones
            // 
            this.grbOpciones.Controls.Add(this.rbtnTercerTipo);
            this.grbOpciones.Controls.Add(this.rbtnSegundoTipo);
            this.grbOpciones.Controls.Add(this.rbtnPrimerTipo);
            this.grbOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbOpciones.Location = new System.Drawing.Point(517, 17);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(143, 216);
            this.grbOpciones.TabIndex = 1;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // rbtnTercerTipo
            // 
            this.rbtnTercerTipo.AutoSize = true;
            this.rbtnTercerTipo.Location = new System.Drawing.Point(16, 87);
            this.rbtnTercerTipo.Name = "rbtnTercerTipo";
            this.rbtnTercerTipo.Size = new System.Drawing.Size(94, 19);
            this.rbtnTercerTipo.TabIndex = 2;
            this.rbtnTercerTipo.TabStop = true;
            this.rbtnTercerTipo.Text = "Tipo EAN-13";
            this.rbtnTercerTipo.UseVisualStyleBackColor = true;
            // 
            // rbtnSegundoTipo
            // 
            this.rbtnSegundoTipo.AutoSize = true;
            this.rbtnSegundoTipo.Location = new System.Drawing.Point(16, 60);
            this.rbtnSegundoTipo.Name = "rbtnSegundoTipo";
            this.rbtnSegundoTipo.Size = new System.Drawing.Size(104, 19);
            this.rbtnSegundoTipo.TabIndex = 1;
            this.rbtnSegundoTipo.TabStop = true;
            this.rbtnSegundoTipo.Text = "Tipo Datalogic";
            this.rbtnSegundoTipo.UseVisualStyleBackColor = true;
            // 
            // rbtnPrimerTipo
            // 
            this.rbtnPrimerTipo.AutoSize = true;
            this.rbtnPrimerTipo.Location = new System.Drawing.Point(16, 33);
            this.rbtnPrimerTipo.Name = "rbtnPrimerTipo";
            this.rbtnPrimerTipo.Size = new System.Drawing.Size(105, 19);
            this.rbtnPrimerTipo.TabIndex = 0;
            this.rbtnPrimerTipo.TabStop = true;
            this.rbtnPrimerTipo.Text = "Tipo Code 128";
            this.rbtnPrimerTipo.UseVisualStyleBackColor = true;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.btnCancelar);
            this.grbDatos.Controls.Add(this.btnVerGenerados);
            this.grbDatos.Controls.Add(this.numPrecioVenta);
            this.grbDatos.Controls.Add(this.numPrecioCompra);
            this.grbDatos.Controls.Add(this.label15);
            this.grbDatos.Controls.Add(this.numPorcentaje);
            this.grbDatos.Controls.Add(this.label16);
            this.grbDatos.Controls.Add(this.numCantidad);
            this.grbDatos.Controls.Add(this.label13);
            this.grbDatos.Controls.Add(this.ckbExistencia);
            this.grbDatos.Controls.Add(this.label5);
            this.grbDatos.Controls.Add(this.label6);
            this.grbDatos.Controls.Add(this.label7);
            this.grbDatos.Controls.Add(this.label4);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.txtMarca);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.txtDescripcion);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.txtCodigo);
            this.grbDatos.Controls.Add(this.btnGenerar);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDatos.Location = new System.Drawing.Point(0, 0);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(663, 242);
            this.grbDatos.TabIndex = 8;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Producto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(490, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(166, 51);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVerGenerados
            // 
            this.btnVerGenerados.Image = ((System.Drawing.Image)(resources.GetObject("btnVerGenerados.Image")));
            this.btnVerGenerados.Location = new System.Drawing.Point(490, 65);
            this.btnVerGenerados.Name = "btnVerGenerados";
            this.btnVerGenerados.Size = new System.Drawing.Size(166, 51);
            this.btnVerGenerados.TabIndex = 71;
            this.btnVerGenerados.Text = "Ver barras generadas";
            this.btnVerGenerados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerGenerados.UseVisualStyleBackColor = true;
            this.btnVerGenerados.Click += new System.EventHandler(this.btnVerGenerados_Click);
            // 
            // numPrecioVenta
            // 
            this.numPrecioVenta.Location = new System.Drawing.Point(144, 175);
            this.numPrecioVenta.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numPrecioVenta.Name = "numPrecioVenta";
            this.numPrecioVenta.ReadOnly = true;
            this.numPrecioVenta.Size = new System.Drawing.Size(325, 21);
            this.numPrecioVenta.TabIndex = 70;
            // 
            // numPrecioCompra
            // 
            this.numPrecioCompra.Location = new System.Drawing.Point(144, 140);
            this.numPrecioCompra.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numPrecioCompra.Name = "numPrecioCompra";
            this.numPrecioCompra.Size = new System.Drawing.Size(325, 21);
            this.numPrecioCompra.TabIndex = 69;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(487, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 15);
            this.label15.TabIndex = 68;
            this.label15.Text = "%";
            // 
            // numPorcentaje
            // 
            this.numPorcentaje.DecimalPlaces = 1;
            this.numPorcentaje.Location = new System.Drawing.Point(399, 209);
            this.numPorcentaje.Name = "numPorcentaje";
            this.numPorcentaje.Size = new System.Drawing.Size(77, 21);
            this.numPorcentaje.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(312, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 66;
            this.label16.Text = "Porcentaje:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(144, 209);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(140, 21);
            this.numCantidad.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(519, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 64;
            this.label13.Text = "Existencia:";
            // 
            // ckbExistencia
            // 
            this.ckbExistencia.AutoSize = true;
            this.ckbExistencia.Location = new System.Drawing.Point(594, 211);
            this.ckbExistencia.Name = "ckbExistencia";
            this.ckbExistencia.Size = new System.Drawing.Size(15, 14);
            this.ckbExistencia.TabIndex = 63;
            this.ckbExistencia.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Precio de venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 61;
            this.label7.Text = "Precio de compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(325, 21);
            this.txtNombre.TabIndex = 10;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(144, 80);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(325, 21);
            this.txtMarca.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(144, 110);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(325, 21);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción:";
            // 
            // frmGeneradorBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(663, 478);
            this.Controls.Add(this.grbCodBarras);
            this.Controls.Add(this.grbDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGeneradorBarras";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generado de etiquetas de código de barras";
            this.grbCodBarras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBarras)).EndInit();
            this.grbOpciones.ResumeLayout(false);
            this.grbOpciones.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbBarras;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox grbCodBarras;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.RadioButton rbtnTercerTipo;
        private System.Windows.Forms.RadioButton rbtnSegundoTipo;
        private System.Windows.Forms.RadioButton rbtnPrimerTipo;
        private System.Windows.Forms.NumericUpDown numPrecioVenta;
        private System.Windows.Forms.NumericUpDown numPrecioCompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numPorcentaje;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ckbExistencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVerGenerados;
    }
}