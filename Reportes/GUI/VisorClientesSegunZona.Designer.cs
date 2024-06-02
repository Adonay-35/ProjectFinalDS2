namespace Reportes.GUI
{
    partial class VisorClientesSegunZona
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
            this.crvVisorClientesZ = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nudMaxima);
            this.splitContainer1.Panel1.Controls.Add(this.nudMinima);
            this.splitContainer1.Panel1.Controls.Add(this.btnMostrar);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crvVisorClientesZ);
            this.splitContainer1.Size = new System.Drawing.Size(933, 554);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // nudMaxima
            // 
            this.nudMaxima.Location = new System.Drawing.Point(95, 323);
            this.nudMaxima.Margin = new System.Windows.Forms.Padding(4);
            this.nudMaxima.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMaxima.Name = "nudMaxima";
            this.nudMaxima.Size = new System.Drawing.Size(140, 22);
            this.nudMaxima.TabIndex = 11;
            // 
            // nudMinima
            // 
            this.nudMinima.Location = new System.Drawing.Point(95, 239);
            this.nudMinima.Margin = new System.Windows.Forms.Padding(4);
            this.nudMinima.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMinima.Name = "nudMinima";
            this.nudMinima.Size = new System.Drawing.Size(140, 22);
            this.nudMinima.TabIndex = 10;
            // 
            // btnMostrar
            // 
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrar.Location = new System.Drawing.Point(115, 399);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
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
            this.label2.Location = new System.Drawing.Point(91, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad Maxima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(91, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad Minima";
            // 
            // crvVisorClientesZ
            // 
            this.crvVisorClientesZ.ActiveViewIndex = -1;
            this.crvVisorClientesZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisorClientesZ.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisorClientesZ.DisplayStatusBar = false;
            this.crvVisorClientesZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisorClientesZ.Location = new System.Drawing.Point(0, 0);
            this.crvVisorClientesZ.Margin = new System.Windows.Forms.Padding(4);
            this.crvVisorClientesZ.Name = "crvVisorClientesZ";
            this.crvVisorClientesZ.Size = new System.Drawing.Size(618, 554);
            this.crvVisorClientesZ.TabIndex = 0;
            this.crvVisorClientesZ.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorClientesSegunZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisorClientesSegunZona";
            this.Text = "VisorClientesSegunZona";
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisorClientesZ;
    }
}