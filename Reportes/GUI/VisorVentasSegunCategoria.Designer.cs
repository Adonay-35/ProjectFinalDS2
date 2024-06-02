namespace Reportes.GUI
{
    partial class VisorVentasSegunCategoria
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nudMaxima = new System.Windows.Forms.NumericUpDown();
            this.nudMinima = new System.Windows.Forms.NumericUpDown();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crvVisorVentasCategorias = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinima)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.splitContainer1.Panel1.Controls.Add(this.nudMaxima);
            this.splitContainer1.Panel1.Controls.Add(this.nudMinima);
            this.splitContainer1.Panel1.Controls.Add(this.btnMostrar);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crvVisorVentasCategorias);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 2;
            // 
            // nudMaxima
            // 
            this.nudMaxima.DecimalPlaces = 2;
            this.nudMaxima.Location = new System.Drawing.Point(75, 279);
            this.nudMaxima.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMaxima.Name = "nudMaxima";
            this.nudMaxima.Size = new System.Drawing.Size(120, 20);
            this.nudMaxima.TabIndex = 11;
            // 
            // nudMinima
            // 
            this.nudMinima.DecimalPlaces = 2;
            this.nudMinima.Location = new System.Drawing.Point(75, 211);
            this.nudMinima.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMinima.Name = "nudMinima";
            this.nudMinima.Size = new System.Drawing.Size(120, 20);
            this.nudMinima.TabIndex = 10;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrar.Location = new System.Drawing.Point(92, 340);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(88, 30);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(72, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Maximo Vendido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(72, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Minimo Vendido";
            // 
            // crvVisorVentasCategorias
            // 
            this.crvVisorVentasCategorias.ActiveViewIndex = -1;
            this.crvVisorVentasCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisorVentasCategorias.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisorVentasCategorias.DisplayStatusBar = false;
            this.crvVisorVentasCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisorVentasCategorias.Location = new System.Drawing.Point(0, 0);
            this.crvVisorVentasCategorias.Name = "crvVisorVentasCategorias";
            this.crvVisorVentasCategorias.Size = new System.Drawing.Size(530, 450);
            this.crvVisorVentasCategorias.TabIndex = 0;
            this.crvVisorVentasCategorias.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorVentasSegunCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VisorVentasSegunCategoria";
            this.Text = "VisorVentasSegunCategoria";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown nudMaxima;
        private System.Windows.Forms.NumericUpDown nudMinima;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisorVentasCategorias;
    }
}