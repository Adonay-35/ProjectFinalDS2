namespace General.GUI
{
    partial class ProveedoresEdicion
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
            this.txbContacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbProveedor = new System.Windows.Forms.TextBox();
            this.txbIDProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbDepartamentos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDistritos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMunicipios = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCodigoPostal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbLinea2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbLinea1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCorreo
            // 
            this.txbCorreo.Location = new System.Drawing.Point(15, 333);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(408, 24);
            this.txbCorreo.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Correo";
            // 
            // 
            // txbContacto
            // 
            this.txbContacto.Location = new System.Drawing.Point(15, 168);
            this.txbContacto.Name = "txbContacto";
            this.txbContacto.Size = new System.Drawing.Size(408, 24);
            this.txbContacto.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Cotacto";
            // 
            // txbProveedor
            // 
            this.txbProveedor.Location = new System.Drawing.Point(65, 88);
            this.txbProveedor.Name = "txbProveedor";
            this.txbProveedor.Size = new System.Drawing.Size(408, 24);
            this.txbProveedor.TabIndex = 52;
            // 
            // txbIDProveedor
            // 
            this.txbIDProveedor.Location = new System.Drawing.Point(65, 28);
            this.txbIDProveedor.Name = "txbIDProveedor";
            this.txbIDProveedor.ReadOnly = true;
            this.txbIDProveedor.Size = new System.Drawing.Size(86, 24);
            this.txbIDProveedor.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID_Proveedor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(459, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(227, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 30);
            this.btnGuardar.TabIndex = 47;
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
            this.cbDepartamentos.Location = new System.Drawing.Point(410, 210);
            this.cbDepartamentos.Name = "cbDepartamentos";
            this.cbDepartamentos.Size = new System.Drawing.Size(353, 21);
            this.cbDepartamentos.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Departamentos";
            // 
            // cbDistritos
            // 
            this.cbDistritos.FormattingEnabled = true;
            this.cbDistritos.Location = new System.Drawing.Point(410, 349);
            this.cbDistritos.Name = "cbDistritos";
            this.cbDistritos.Size = new System.Drawing.Size(353, 21);
            this.cbDistritos.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 101;
            this.label9.Text = "Distritos";
            // 
            // cbMunicipios
            // 
            this.cbMunicipios.FormattingEnabled = true;
            this.cbMunicipios.Location = new System.Drawing.Point(410, 278);
            this.cbMunicipios.Name = "cbMunicipios";
            this.cbMunicipios.Size = new System.Drawing.Size(353, 21);
            this.cbMunicipios.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Municipios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "CodigoPostal";
            // 
            // txbCodigoPostal
            // 
            this.txbCodigoPostal.Location = new System.Drawing.Point(410, 146);
            this.txbCodigoPostal.Name = "txbCodigoPostal";
            this.txbCodigoPostal.Size = new System.Drawing.Size(175, 20);
            this.txbCodigoPostal.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 96;
            this.label10.Text = "Linea2";
            // 
            // txbLinea2
            // 
            this.txbLinea2.Location = new System.Drawing.Point(410, 93);
            this.txbLinea2.Name = "txbLinea2";
            this.txbLinea2.Size = new System.Drawing.Size(353, 20);
            this.txbLinea2.TabIndex = 95;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "Linea1";
            // 
            // txbLinea1
            // 
            this.txbLinea1.Location = new System.Drawing.Point(410, 37);
            this.txbLinea1.Name = "txbLinea1";
            this.txbLinea1.Size = new System.Drawing.Size(353, 20);
            this.txbLinea1.TabIndex = 93;
            // 
            // ProveedoresEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 440);
            this.Controls.Add(this.cbDepartamentos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDistritos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMunicipios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbCodigoPostal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbLinea2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbLinea1);
            this.Controls.Add(this.txbCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbContacto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbProveedor);
            this.Controls.Add(this.txbIDProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProveedoresEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProveedoresEdicion";
            this.Load += new System.EventHandler(this.ProveedoresEdicion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbCorreo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbContacto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbProveedor;
        public System.Windows.Forms.TextBox txbIDProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.ComboBox cbDepartamentos;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbDistritos;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbMunicipios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txbCodigoPostal;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txbLinea2;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txbLinea1;
    }
}