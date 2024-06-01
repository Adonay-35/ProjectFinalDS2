namespace General.GUI
{
    partial class VentasEdicion
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
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbID_Producto = new System.Windows.Forms.Label();
            this.txbPrecioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbTotalCobrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txbFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txbID_Venta = new System.Windows.Forms.TextBox();
            this.txbCantidadSaliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(100, 265);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(307, 21);
            this.cbProductos.TabIndex = 46;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(100, 210);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(307, 21);
            this.cbClientes.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "PrecioVenta";
            // 
            // txbID_Producto
            // 
            this.txbID_Producto.AutoSize = true;
            this.txbID_Producto.Location = new System.Drawing.Point(97, 249);
            this.txbID_Producto.Name = "txbID_Producto";
            this.txbID_Producto.Size = new System.Drawing.Size(55, 13);
            this.txbID_Producto.TabIndex = 44;
            this.txbID_Producto.Text = "Productos";
            // 
            // txbPrecioVenta
            // 
            this.txbPrecioVenta.Location = new System.Drawing.Point(100, 323);
            this.txbPrecioVenta.Name = "txbPrecioVenta";
            this.txbPrecioVenta.Size = new System.Drawing.Size(307, 20);
            this.txbPrecioVenta.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID_Venta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(332, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(100, 458);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbTotalCobrar
            // 
            this.txbTotalCobrar.Location = new System.Drawing.Point(100, 423);
            this.txbTotalCobrar.Name = "txbTotalCobrar";
            this.txbTotalCobrar.Size = new System.Drawing.Size(307, 20);
            this.txbTotalCobrar.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "TotalCobrar";
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(100, 161);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(307, 21);
            this.cbUsuarios.TabIndex = 49;
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "FechaVenta";
            // 
            // txbFechaVenta
            // 
            this.txbFechaVenta.Location = new System.Drawing.Point(100, 94);
            this.txbFechaVenta.Name = "txbFechaVenta";
            this.txbFechaVenta.Size = new System.Drawing.Size(307, 20);
            this.txbFechaVenta.TabIndex = 50;
            // 
            // txbID_Venta
            // 
            this.txbID_Venta.Location = new System.Drawing.Point(100, 31);
            this.txbID_Venta.Name = "txbID_Venta";
            this.txbID_Venta.ReadOnly = true;
            this.txbID_Venta.Size = new System.Drawing.Size(75, 20);
            this.txbID_Venta.TabIndex = 51;
            // 
            // txbCantidadSaliente
            // 
            this.txbCantidadSaliente.Location = new System.Drawing.Point(100, 372);
            this.txbCantidadSaliente.Name = "txbCantidadSaliente";
            this.txbCantidadSaliente.Size = new System.Drawing.Size(307, 20);
            this.txbCantidadSaliente.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "CantidadSaliente";
            // 
            // VentasEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 506);
            this.Controls.Add(this.txbCantidadSaliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbID_Venta);
            this.Controls.Add(this.txbFechaVenta);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.txbTotalCobrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbID_Producto);
            this.Controls.Add(this.txbPrecioVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "VentasEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasEdicion";
            this.Load += new System.EventHandler(this.VentasEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbProductos;
        public System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txbID_Producto;
        public System.Windows.Forms.TextBox txbPrecioVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txbTotalCobrar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker txbFechaVenta;
        public System.Windows.Forms.TextBox txbID_Venta;
        public System.Windows.Forms.TextBox txbCantidadSaliente;
        private System.Windows.Forms.Label label5;
    }
}