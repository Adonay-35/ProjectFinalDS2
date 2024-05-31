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
            this.cbDepartamentos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDistritos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMunicipios = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCodigoPostal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbLinea2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbLinea1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCorreo
            // 
            this.txbCorreo.Location = new System.Drawing.Point(12, 292);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(301, 20);
            this.txbCorreo.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Correo";
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(12, 211);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(301, 20);
            this.txbApellidos.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Apellidos";
            // 
            // txbNombres
            // 
            this.txbNombres.Location = new System.Drawing.Point(12, 125);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(301, 20);
            this.txbNombres.TabIndex = 64;
            // 
            // txbIDCliente
            // 
            this.txbIDCliente.Location = new System.Drawing.Point(20, 39);
            this.txbIDCliente.Name = "txbIDCliente";
            this.txbIDCliente.ReadOnly = true;
            this.txbIDCliente.Size = new System.Drawing.Size(97, 20);
            this.txbIDCliente.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "ID_Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(398, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 23);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(199, 403);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 23);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // cbDepartamentos
            // 
            this.cbDepartamentos.FormattingEnabled = true;
            this.cbDepartamentos.Location = new System.Drawing.Point(401, 211);
            this.cbDepartamentos.Name = "cbDepartamentos";
            this.cbDepartamentos.Size = new System.Drawing.Size(353, 21);
            this.cbDepartamentos.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Departamentos";
            // 
            // cbDistritos
            // 
            this.cbDistritos.FormattingEnabled = true;
            this.cbDistritos.Location = new System.Drawing.Point(401, 363);
            this.cbDistritos.Name = "cbDistritos";
            this.cbDistritos.Size = new System.Drawing.Size(353, 21);
            this.cbDistritos.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Distritos";
            // 
            // cbMunicipios
            // 
            this.cbMunicipios.FormattingEnabled = true;
            this.cbMunicipios.Location = new System.Drawing.Point(401, 280);
            this.cbMunicipios.Name = "cbMunicipios";
            this.cbMunicipios.Size = new System.Drawing.Size(353, 21);
            this.cbMunicipios.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Municipios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "CodigoPostal";
            // 
            // txbCodigoPostal
            // 
            this.txbCodigoPostal.Location = new System.Drawing.Point(401, 148);
            this.txbCodigoPostal.Name = "txbCodigoPostal";
            this.txbCodigoPostal.Size = new System.Drawing.Size(175, 20);
            this.txbCodigoPostal.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Linea2";
            // 
            // txbLinea2
            // 
            this.txbLinea2.Location = new System.Drawing.Point(401, 95);
            this.txbLinea2.Name = "txbLinea2";
            this.txbLinea2.Size = new System.Drawing.Size(353, 20);
            this.txbLinea2.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Linea1";
            // 
            // txbLinea1
            // 
            this.txbLinea1.Location = new System.Drawing.Point(401, 39);
            this.txbLinea1.Name = "txbLinea1";
            this.txbLinea1.Size = new System.Drawing.Size(353, 20);
            this.txbLinea1.TabIndex = 81;
            // 
            // ClientesEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 457);
            this.Controls.Add(this.cbDepartamentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDistritos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMunicipios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbCodigoPostal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbLinea2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbLinea1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClientesEdicion";
            this.Load += new System.EventHandler(this.ClientesEdicion_Load_1);
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
        public System.Windows.Forms.ComboBox cbDepartamentos;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbDistritos;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbMunicipios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txbCodigoPostal;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txbLinea2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txbLinea1;
    }
}