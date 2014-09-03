namespace appClientesAsociadosCredito.GUI
{
    partial class frmNuevoVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoVendedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.tabControlVendedor = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabDatosContacto = new System.Windows.Forms.TabPage();
            this.tabObservaciones = new System.Windows.Forms.TabPage();
            this.lblCodigoVendedor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.txtCodigoVendedor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.ptbFotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.btnEliminarFoto = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblSkype = new System.Windows.Forms.Label();
            this.txtSkype = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.pnlBotones.SuspendLayout();
            this.tabControlVendedor.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabDatosContacto.SuspendLayout();
            this.tabObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 368);
            this.panel1.TabIndex = 0;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotones.BackgroundImage")));
            this.pnlBotones.Controls.Add(this.btnAyuda);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 368);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(737, 39);
            this.pnlBotones.TabIndex = 1;
            // 
            // tabControlVendedor
            // 
            this.tabControlVendedor.Controls.Add(this.tabGeneral);
            this.tabControlVendedor.Controls.Add(this.tabDatosContacto);
            this.tabControlVendedor.Controls.Add(this.tabObservaciones);
            this.tabControlVendedor.Location = new System.Drawing.Point(128, 14);
            this.tabControlVendedor.Name = "tabControlVendedor";
            this.tabControlVendedor.SelectedIndex = 0;
            this.tabControlVendedor.Size = new System.Drawing.Size(597, 300);
            this.tabControlVendedor.TabIndex = 2;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.btnEliminarFoto);
            this.tabGeneral.Controls.Add(this.btnAgregarFoto);
            this.tabGeneral.Controls.Add(this.ptbFotoPerfil);
            this.tabGeneral.Controls.Add(this.txtFacebook);
            this.tabGeneral.Controls.Add(this.txtCorreoElectronico);
            this.tabGeneral.Controls.Add(this.txtTelefono);
            this.tabGeneral.Controls.Add(this.txtDireccion);
            this.tabGeneral.Controls.Add(this.txtNombre);
            this.tabGeneral.Controls.Add(this.txtCodigoVendedor);
            this.tabGeneral.Controls.Add(this.lblFacebook);
            this.tabGeneral.Controls.Add(this.lblCorreoElectronico);
            this.tabGeneral.Controls.Add(this.lblTelefono);
            this.tabGeneral.Controls.Add(this.lblDireccion);
            this.tabGeneral.Controls.Add(this.lblNombre);
            this.tabGeneral.Controls.Add(this.lblCodigoVendedor);
            this.tabGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(589, 272);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabDatosContacto
            // 
            this.tabDatosContacto.Controls.Add(this.txtSkype);
            this.tabDatosContacto.Controls.Add(this.lblSkype);
            this.tabDatosContacto.Controls.Add(this.dtpFechaNacimiento);
            this.tabDatosContacto.Controls.Add(this.lblFechaNacimiento);
            this.tabDatosContacto.Location = new System.Drawing.Point(4, 24);
            this.tabDatosContacto.Name = "tabDatosContacto";
            this.tabDatosContacto.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosContacto.Size = new System.Drawing.Size(589, 272);
            this.tabDatosContacto.TabIndex = 1;
            this.tabDatosContacto.Text = "Datos de contacto";
            this.tabDatosContacto.UseVisualStyleBackColor = true;
            // 
            // tabObservaciones
            // 
            this.tabObservaciones.Controls.Add(this.txtObservaciones);
            this.tabObservaciones.Location = new System.Drawing.Point(4, 24);
            this.tabObservaciones.Name = "tabObservaciones";
            this.tabObservaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabObservaciones.Size = new System.Drawing.Size(589, 272);
            this.tabObservaciones.TabIndex = 2;
            this.tabObservaciones.Text = "Observaciones";
            this.tabObservaciones.UseVisualStyleBackColor = true;
            // 
            // lblCodigoVendedor
            // 
            this.lblCodigoVendedor.AutoSize = true;
            this.lblCodigoVendedor.Location = new System.Drawing.Point(33, 32);
            this.lblCodigoVendedor.Name = "lblCodigoVendedor";
            this.lblCodigoVendedor.Size = new System.Drawing.Size(123, 15);
            this.lblCodigoVendedor.TabIndex = 0;
            this.lblCodigoVendedor.Text = "Código del vendedor:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(227, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(33, 90);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(62, 15);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(33, 145);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 15);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(33, 199);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(110, 15);
            this.lblCorreoElectronico.TabIndex = 4;
            this.lblCorreoElectronico.Text = "Correo electrónico:";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Location = new System.Drawing.Point(254, 199);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(64, 15);
            this.lblFacebook.TabIndex = 5;
            this.lblFacebook.Text = "Facebook:";
            // 
            // txtCodigoVendedor
            // 
            this.txtCodigoVendedor.Location = new System.Drawing.Point(36, 50);
            this.txtCodigoVendedor.Name = "txtCodigoVendedor";
            this.txtCodigoVendedor.Size = new System.Drawing.Size(169, 21);
            this.txtCodigoVendedor.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(230, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 21);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(36, 108);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(403, 21);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(36, 163);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(199, 21);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(36, 217);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(199, 21);
            this.txtCorreoElectronico.TabIndex = 10;
            // 
            // txtFacebook
            // 
            this.txtFacebook.Location = new System.Drawing.Point(257, 217);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(182, 21);
            this.txtFacebook.TabIndex = 11;
            // 
            // ptbFotoPerfil
            // 
            this.ptbFotoPerfil.Location = new System.Drawing.Point(484, 32);
            this.ptbFotoPerfil.Name = "ptbFotoPerfil";
            this.ptbFotoPerfil.Size = new System.Drawing.Size(88, 73);
            this.ptbFotoPerfil.TabIndex = 12;
            this.ptbFotoPerfil.TabStop = false;
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.Location = new System.Drawing.Point(484, 111);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(35, 23);
            this.btnAgregarFoto.TabIndex = 13;
            this.btnAgregarFoto.Text = "+";
            this.btnAgregarFoto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFoto
            // 
            this.btnEliminarFoto.Location = new System.Drawing.Point(537, 111);
            this.btnEliminarFoto.Name = "btnEliminarFoto";
            this.btnEliminarFoto.Size = new System.Drawing.Size(35, 23);
            this.btnEliminarFoto.TabIndex = 14;
            this.btnEliminarFoto.Text = "-";
            this.btnEliminarFoto.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(442, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(535, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(630, 5);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 28);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(31, 34);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(125, 15);
            this.lblFechaNacimiento.TabIndex = 0;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(36, 59);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(204, 21);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // lblSkype
            // 
            this.lblSkype.AutoSize = true;
            this.lblSkype.Location = new System.Drawing.Point(278, 34);
            this.lblSkype.Name = "lblSkype";
            this.lblSkype.Size = new System.Drawing.Size(43, 15);
            this.lblSkype.TabIndex = 2;
            this.lblSkype.Text = "Skype:";
            // 
            // txtSkype
            // 
            this.txtSkype.Location = new System.Drawing.Point(281, 59);
            this.txtSkype.Name = "txtSkype";
            this.txtSkype.Size = new System.Drawing.Size(274, 21);
            this.txtSkype.TabIndex = 3;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(16, 19);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(557, 228);
            this.txtObservaciones.TabIndex = 0;
            // 
            // frmNuevoVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(737, 407);
            this.Controls.Add(this.tabControlVendedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBotones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevoVendedor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar vendedor";
            this.pnlBotones.ResumeLayout(false);
            this.tabControlVendedor.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabDatosContacto.ResumeLayout(false);
            this.tabDatosContacto.PerformLayout();
            this.tabObservaciones.ResumeLayout(false);
            this.tabObservaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.TabControl tabControlVendedor;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabDatosContacto;
        private System.Windows.Forms.TabPage tabObservaciones;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoVendedor;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.TextBox txtCodigoVendedor;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.PictureBox ptbFotoPerfil;
        private System.Windows.Forms.Button btnEliminarFoto;
        private System.Windows.Forms.Button btnAgregarFoto;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblSkype;
        private System.Windows.Forms.TextBox txtSkype;
        private System.Windows.Forms.TextBox txtObservaciones;
    }
}