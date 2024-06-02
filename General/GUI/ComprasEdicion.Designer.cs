namespace General.GUI
{
    partial class ComprasEdicion
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
            this.txbCantidadEntrante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbID_Compra = new System.Windows.Forms.TextBox();
            this.txbFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.txbTotalPagar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.txbID_Producto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCantidadEntrante
            // 
            this.txbCantidadEntrante.Location = new System.Drawing.Point(556, 283);
            this.txbCantidadEntrante.Margin = new System.Windows.Forms.Padding(4);
            this.txbCantidadEntrante.Name = "txbCantidadEntrante";
            this.txbCantidadEntrante.Size = new System.Drawing.Size(282, 22);
            this.txbCantidadEntrante.TabIndex = 57;
            this.txbCantidadEntrante.TextChanged += new System.EventHandler(this.txbCantidadEntrante_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(552, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "CantidadEntrante";
            // 
            // txbID_Compra
            // 
            this.txbID_Compra.Location = new System.Drawing.Point(55, 87);
            this.txbID_Compra.Margin = new System.Windows.Forms.Padding(4);
            this.txbID_Compra.Name = "txbID_Compra";
            this.txbID_Compra.ReadOnly = true;
            this.txbID_Compra.Size = new System.Drawing.Size(76, 22);
            this.txbID_Compra.TabIndex = 69;
            // 
            // txbFechaCompra
            // 
            this.txbFechaCompra.Location = new System.Drawing.Point(54, 183);
            this.txbFechaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txbFechaCompra.Name = "txbFechaCompra";
            this.txbFechaCompra.Size = new System.Drawing.Size(280, 22);
            this.txbFechaCompra.TabIndex = 34;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(54, 290);
            this.cbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(280, 24);
            this.cbUsuarios.TabIndex = 56;
            // 
            // txbTotalPagar
            // 
            this.txbTotalPagar.Location = new System.Drawing.Point(556, 398);
            this.txbTotalPagar.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPagar.Name = "txbTotalPagar";
            this.txbTotalPagar.Size = new System.Drawing.Size(282, 22);
            this.txbTotalPagar.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(551, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "TotalPagar";
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(558, 181);
            this.cbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(280, 24);
            this.cbProductos.TabIndex = 32;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // cbProveedores
            // 
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(54, 398);
            this.cbProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(280, 24);
            this.cbProveedores.TabIndex = 23;
            // 
            // txbID_Producto
            // 
            this.txbID_Producto.AutoSize = true;
            this.txbID_Producto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txbID_Producto.ForeColor = System.Drawing.SystemColors.Control;
            this.txbID_Producto.Location = new System.Drawing.Point(554, 138);
            this.txbID_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txbID_Producto.Name = "txbID_Producto";
            this.txbID_Producto.Size = new System.Drawing.Size(63, 17);
            this.txbID_Producto.TabIndex = 62;
            this.txbID_Producto.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(50, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(50, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(51, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "FechaVenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID_Compra";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(555, 484);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(246, 484);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 30);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // ComprasEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(898, 545);
            this.Controls.Add(this.txbCantidadEntrante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbID_Compra);
            this.Controls.Add(this.txbFechaCompra);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.txbTotalPagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.cbProveedores);
            this.Controls.Add(this.txbID_Producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComprasEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComprasEdicion";
            this.Load += new System.EventHandler(this.ComprasEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbCantidadEntrante;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbID_Compra;
        public System.Windows.Forms.DateTimePicker txbFechaCompra;
        public System.Windows.Forms.ComboBox cbUsuarios;
        public System.Windows.Forms.TextBox txbTotalPagar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbProductos;
        public System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Label txbID_Producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider Notificador;
    }
}