namespace GUI
{
    partial class frmModificarPrivilegios
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
            this.grbPrivilegios = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.chkAdministrarClientes = new System.Windows.Forms.CheckBox();
            this.chkAdministrarEmpleados = new System.Windows.Forms.CheckBox();
            this.chkAdministrarInventario = new System.Windows.Forms.CheckBox();
            this.chkAdministrarCajas = new System.Windows.Forms.CheckBox();
            this.chkAdministrarFacturas = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.grbPrivilegios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPrivilegios
            // 
            this.grbPrivilegios.Controls.Add(this.groupBox1);
            this.grbPrivilegios.Controls.Add(this.chkAdministrarClientes);
            this.grbPrivilegios.Controls.Add(this.chkAdministrarEmpleados);
            this.grbPrivilegios.Controls.Add(this.chkAdministrarInventario);
            this.grbPrivilegios.Controls.Add(this.chkAdministrarCajas);
            this.grbPrivilegios.Controls.Add(this.chkAdministrarFacturas);
            this.grbPrivilegios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPrivilegios.Location = new System.Drawing.Point(0, 0);
            this.grbPrivilegios.Name = "grbPrivilegios";
            this.grbPrivilegios.Size = new System.Drawing.Size(410, 172);
            this.grbPrivilegios.TabIndex = 0;
            this.grbPrivilegios.TabStop = false;
            this.grbPrivilegios.Text = "Privilegios";
            this.grbPrivilegios.MouseHover += new System.EventHandler(this.grbPrivilegios_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDetalles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(221, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 153);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // txtDetalles
            // 
            this.txtDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetalles.Location = new System.Drawing.Point(3, 16);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.ReadOnly = true;
            this.txtDetalles.Size = new System.Drawing.Size(180, 134);
            this.txtDetalles.TabIndex = 0;
            // 
            // chkAdministrarClientes
            // 
            this.chkAdministrarClientes.AutoSize = true;
            this.chkAdministrarClientes.Location = new System.Drawing.Point(38, 142);
            this.chkAdministrarClientes.Name = "chkAdministrarClientes";
            this.chkAdministrarClientes.Size = new System.Drawing.Size(116, 17);
            this.chkAdministrarClientes.TabIndex = 24;
            this.chkAdministrarClientes.Text = "Administrar clientes";
            this.chkAdministrarClientes.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarEmpleados
            // 
            this.chkAdministrarEmpleados.AutoSize = true;
            this.chkAdministrarEmpleados.Location = new System.Drawing.Point(38, 116);
            this.chkAdministrarEmpleados.Name = "chkAdministrarEmpleados";
            this.chkAdministrarEmpleados.Size = new System.Drawing.Size(131, 17);
            this.chkAdministrarEmpleados.TabIndex = 23;
            this.chkAdministrarEmpleados.Text = "Administrar empleados";
            this.chkAdministrarEmpleados.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarInventario
            // 
            this.chkAdministrarInventario.AutoSize = true;
            this.chkAdministrarInventario.Location = new System.Drawing.Point(38, 89);
            this.chkAdministrarInventario.Name = "chkAdministrarInventario";
            this.chkAdministrarInventario.Size = new System.Drawing.Size(126, 17);
            this.chkAdministrarInventario.TabIndex = 22;
            this.chkAdministrarInventario.Text = "Administrar inventario";
            this.chkAdministrarInventario.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarCajas
            // 
            this.chkAdministrarCajas.AutoSize = true;
            this.chkAdministrarCajas.Location = new System.Drawing.Point(38, 63);
            this.chkAdministrarCajas.Name = "chkAdministrarCajas";
            this.chkAdministrarCajas.Size = new System.Drawing.Size(105, 17);
            this.chkAdministrarCajas.TabIndex = 21;
            this.chkAdministrarCajas.Text = "Administrar cajas";
            this.chkAdministrarCajas.UseVisualStyleBackColor = true;
            // 
            // chkAdministrarFacturas
            // 
            this.chkAdministrarFacturas.AutoSize = true;
            this.chkAdministrarFacturas.Location = new System.Drawing.Point(38, 40);
            this.chkAdministrarFacturas.Name = "chkAdministrarFacturas";
            this.chkAdministrarFacturas.Size = new System.Drawing.Size(118, 17);
            this.chkAdministrarFacturas.TabIndex = 0;
            this.chkAdministrarFacturas.Text = "Administrar facturas";
            this.chkAdministrarFacturas.UseVisualStyleBackColor = true;
            this.chkAdministrarFacturas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ckbAdministrarFacturas_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAplicar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(236, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(79, 6);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 0;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // frmModificarPrivilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 214);
            this.Controls.Add(this.grbPrivilegios);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarPrivilegios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar privilegios";
            this.grbPrivilegios.ResumeLayout(false);
            this.grbPrivilegios.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPrivilegios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAdministrarFacturas;
        private System.Windows.Forms.CheckBox chkAdministrarClientes;
        private System.Windows.Forms.CheckBox chkAdministrarEmpleados;
        private System.Windows.Forms.CheckBox chkAdministrarInventario;
        private System.Windows.Forms.CheckBox chkAdministrarCajas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDetalles;
    }
}