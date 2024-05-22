namespace General.GUI
{
    partial class ClientesEdicion
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
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.txbIDCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCorreo
            // 
            this.txbCorreo.Location = new System.Drawing.Point(23, 208);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(307, 20);
            this.txbCorreo.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Correo";
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(23, 145);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(307, 20);
            this.txbApellidos.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Apellido";
            // 
            // txbNombres
            // 
            this.txbNombres.Location = new System.Drawing.Point(23, 84);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(307, 20);
            this.txbNombres.TabIndex = 64;
            // 
            // txbIDCliente
            // 
            this.txbIDCliente.Location = new System.Drawing.Point(23, 24);
            this.txbIDCliente.Name = "txbIDCliente";
            this.txbIDCliente.ReadOnly = true;
            this.txbIDCliente.Size = new System.Drawing.Size(103, 20);
            this.txbIDCliente.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "IDCliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(253, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(21, 252);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // ClientesEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 282);
            this.Controls.Add(this.txbCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNombres);
            this.Controls.Add(this.txbIDCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientesEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesEdicion";
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbCorreo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbApellidos;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbNombres;
        public System.Windows.Forms.TextBox txbIDCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider Notificador;
    }
}