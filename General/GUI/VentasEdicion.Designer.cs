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
            this.cbProductos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(514, 78);
            this.cbProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(297, 24);
            this.cbProductos.TabIndex = 46;
            // 
            // cbClientes
            // 
            this.cbClientes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(79, 355);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(297, 24);
            this.cbClientes.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(510, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "PrecioVenta";
            // 
            // txbID_Producto
            // 
            this.txbID_Producto.AutoSize = true;
            this.txbID_Producto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID_Producto.ForeColor = System.Drawing.SystemColors.Control;
            this.txbID_Producto.Location = new System.Drawing.Point(510, 41);
            this.txbID_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txbID_Producto.Name = "txbID_Producto";
            this.txbID_Producto.Size = new System.Drawing.Size(68, 17);
            this.txbID_Producto.TabIndex = 44;
            this.txbID_Producto.Text = "Productos";
            // 
            // txbPrecioVenta
            // 
            this.txbPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecioVenta.Location = new System.Drawing.Point(514, 164);
            this.txbPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPrecioVenta.Name = "txbPrecioVenta";
            this.txbPrecioVenta.Size = new System.Drawing.Size(297, 22);
            this.txbPrecioVenta.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(77, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(76, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID_Venta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(564, 460);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(248, 460);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 30);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbTotalCobrar
            // 
            this.txbTotalCobrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalCobrar.Location = new System.Drawing.Point(514, 355);
            this.txbTotalCobrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTotalCobrar.Name = "txbTotalCobrar";
            this.txbTotalCobrar.Size = new System.Drawing.Size(297, 22);
            this.txbTotalCobrar.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(510, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "TotalCobrar";
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(79, 258);
            this.cbUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(297, 24);
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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(76, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "FechaVenta";
            // 
            // txbFechaVenta
            // 
            this.txbFechaVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFechaVenta.Location = new System.Drawing.Point(79, 164);
            this.txbFechaVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFechaVenta.Name = "txbFechaVenta";
            this.txbFechaVenta.Size = new System.Drawing.Size(297, 22);
            this.txbFechaVenta.TabIndex = 50;
            // 
            // txbID_Venta
            // 
            this.txbID_Venta.Location = new System.Drawing.Point(79, 80);
            this.txbID_Venta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbID_Venta.Name = "txbID_Venta";
            this.txbID_Venta.ReadOnly = true;
            this.txbID_Venta.Size = new System.Drawing.Size(76, 22);
            this.txbID_Venta.TabIndex = 51;
            // 
            // txbCantidadSaliente
            // 
            this.txbCantidadSaliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidadSaliente.Location = new System.Drawing.Point(514, 258);
            this.txbCantidadSaliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCantidadSaliente.Name = "txbCantidadSaliente";
            this.txbCantidadSaliente.Size = new System.Drawing.Size(297, 22);
            this.txbCantidadSaliente.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(511, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "CantidadSaliente";
            // 
            // VentasEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(898, 513);
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
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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