namespace General.GUI
{
    partial class UsuariosEdicion
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbID_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.btnCancealr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(555, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(555, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Empleado";
            // 
            // txbClave
            // 
            this.txbClave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClave.Location = new System.Drawing.Point(70, 316);
            this.txbClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbClave.Name = "txbClave";
            this.txbClave.Size = new System.Drawing.Size(278, 22);
            this.txbClave.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(67, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Clave";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(70, 199);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(278, 22);
            this.txbUsuario.TabIndex = 23;
            // 
            // txbID_Usuario
            // 
            this.txbID_Usuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID_Usuario.Location = new System.Drawing.Point(69, 98);
            this.txbID_Usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbID_Usuario.Name = "txbID_Usuario";
            this.txbID_Usuario.ReadOnly = true;
            this.txbID_Usuario.Size = new System.Drawing.Size(76, 22);
            this.txbID_Usuario.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(66, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID_Usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(260, 442);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 30);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(555, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Estado";
            // 
            // cbEstados
            // 
            this.cbEstados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(558, 316);
            this.cbEstados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(262, 24);
            this.cbEstados.TabIndex = 8;
            // 
            // cbRoles
            // 
            this.cbRoles.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(558, 199);
            this.cbRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(262, 24);
            this.cbRoles.TabIndex = 32;
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(558, 98);
            this.cbEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(262, 24);
            this.cbEmpleados.TabIndex = 33;
            // 
            // btnCancealr
            // 
            this.btnCancealr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancealr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancealr.Location = new System.Drawing.Point(558, 442);
            this.btnCancealr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancealr.Name = "btnCancealr";
            this.btnCancealr.Size = new System.Drawing.Size(88, 30);
            this.btnCancealr.TabIndex = 34;
            this.btnCancealr.Text = "Cancelar";
            this.btnCancealr.UseVisualStyleBackColor = true;
            this.btnCancealr.Click += new System.EventHandler(this.btnCancealr_Click);
            // 
            // UsuariosEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(898, 513);
            this.Controls.Add(this.btnCancealr);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.cbEstados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbID_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsuariosEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuariosEdicion";
            this.Load += new System.EventHandler(this.UsuariosEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbUsuario;
        public System.Windows.Forms.TextBox txbID_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbEstados;
        public System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Button btnCancealr;
    }
}