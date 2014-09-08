namespace GUI
{
    partial class frmConfiguracionBaseDatos
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
            this.grbParametros = new System.Windows.Forms.GroupBox();
            this.lblTipoBaseDatos = new System.Windows.Forms.Label();
            this.txtEsquema = new System.Windows.Forms.TextBox();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblEsquema = new System.Windows.Forms.Label();
            this.lblContrasenna = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.grbSoftValue = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.grbParametros.SuspendLayout();
            this.grbSoftValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbParametros
            // 
            this.grbParametros.Controls.Add(this.lblTipoBaseDatos);
            this.grbParametros.Controls.Add(this.txtEsquema);
            this.grbParametros.Controls.Add(this.txtContrasenna);
            this.grbParametros.Controls.Add(this.txtUsuario);
            this.grbParametros.Controls.Add(this.txtBaseDatos);
            this.grbParametros.Controls.Add(this.txtPuerto);
            this.grbParametros.Controls.Add(this.txtServidor);
            this.grbParametros.Controls.Add(this.lblEsquema);
            this.grbParametros.Controls.Add(this.lblContrasenna);
            this.grbParametros.Controls.Add(this.lblUsuario);
            this.grbParametros.Controls.Add(this.lblBaseDatos);
            this.grbParametros.Controls.Add(this.lblPuerto);
            this.grbParametros.Controls.Add(this.lblServidor);
            this.grbParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbParametros.Location = new System.Drawing.Point(0, 0);
            this.grbParametros.Name = "grbParametros";
            this.grbParametros.Size = new System.Drawing.Size(412, 228);
            this.grbParametros.TabIndex = 0;
            this.grbParametros.TabStop = false;
            this.grbParametros.Text = "Parametros";
            // 
            // lblTipoBaseDatos
            // 
            this.lblTipoBaseDatos.AutoSize = true;
            this.lblTipoBaseDatos.Location = new System.Drawing.Point(184, 30);
            this.lblTipoBaseDatos.Name = "lblTipoBaseDatos";
            this.lblTipoBaseDatos.Size = new System.Drawing.Size(72, 15);
            this.lblTipoBaseDatos.TabIndex = 12;
            this.lblTipoBaseDatos.Text = "Información";
            // 
            // txtEsquema
            // 
            this.txtEsquema.Location = new System.Drawing.Point(110, 196);
            this.txtEsquema.Name = "txtEsquema";
            this.txtEsquema.Size = new System.Drawing.Size(199, 21);
            this.txtEsquema.TabIndex = 11;
            this.txtEsquema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Location = new System.Drawing.Point(110, 169);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.PasswordChar = '*';
            this.txtContrasenna.Size = new System.Drawing.Size(199, 21);
            this.txtContrasenna.TabIndex = 10;
            this.txtContrasenna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(110, 142);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(199, 21);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(110, 115);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(199, 21);
            this.txtBaseDatos.TabIndex = 8;
            this.txtBaseDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(110, 88);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(199, 21);
            this.txtPuerto.TabIndex = 7;
            this.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(110, 61);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(199, 21);
            this.txtServidor.TabIndex = 6;
            this.txtServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEsquema
            // 
            this.lblEsquema.AutoSize = true;
            this.lblEsquema.Location = new System.Drawing.Point(41, 199);
            this.lblEsquema.Name = "lblEsquema";
            this.lblEsquema.Size = new System.Drawing.Size(63, 15);
            this.lblEsquema.TabIndex = 5;
            this.lblEsquema.Text = "Esquema:";
            // 
            // lblContrasenna
            // 
            this.lblContrasenna.AutoSize = true;
            this.lblContrasenna.Location = new System.Drawing.Point(31, 172);
            this.lblContrasenna.Name = "lblContrasenna";
            this.lblContrasenna.Size = new System.Drawing.Size(73, 15);
            this.lblContrasenna.TabIndex = 4;
            this.lblContrasenna.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(51, 145);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 15);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Location = new System.Drawing.Point(16, 118);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(88, 15);
            this.lblBaseDatos.TabIndex = 2;
            this.lblBaseDatos.Text = "Base de datos:";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(58, 91);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(46, 15);
            this.lblPuerto.TabIndex = 1;
            this.lblPuerto.Text = "Puerto:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(49, 64);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(55, 15);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor:";
            // 
            // grbSoftValue
            // 
            this.grbSoftValue.Controls.Add(this.btnProbarConexion);
            this.grbSoftValue.Controls.Add(this.btnCancelar);
            this.grbSoftValue.Controls.Add(this.btnAplicar);
            this.grbSoftValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbSoftValue.Location = new System.Drawing.Point(0, 228);
            this.grbSoftValue.Name = "grbSoftValue";
            this.grbSoftValue.Size = new System.Drawing.Size(412, 58);
            this.grbSoftValue.TabIndex = 1;
            this.grbSoftValue.TabStop = false;
            this.grbSoftValue.Text = "SoftValue";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(290, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(44, 20);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(87, 27);
            this.btnAplicar.TabIndex = 0;
            this.btnAplicar.Text = "Cambiar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(158, 20);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(108, 26);
            this.btnProbarConexion.TabIndex = 2;
            this.btnProbarConexion.Text = "Probar conexión";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // frmConfiguracionBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(412, 286);
            this.Controls.Add(this.grbParametros);
            this.Controls.Add(this.grbSoftValue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracionBaseDatos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar parametros de Base de Datos";
            this.grbParametros.ResumeLayout(false);
            this.grbParametros.PerformLayout();
            this.grbSoftValue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbParametros;
        private System.Windows.Forms.GroupBox grbSoftValue;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenna;
        private System.Windows.Forms.Label lblEsquema;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtEsquema;
        private System.Windows.Forms.Label lblTipoBaseDatos;
        private System.Windows.Forms.Button btnProbarConexion;
    }
}