﻿namespace ProyectoCRUD
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.Splash1 = new System.Windows.Forms.PictureBox();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Splash1)).BeginInit();
            this.SuspendLayout();
            // 
            // Splash1
            // 
            this.Splash1.Image = ((System.Drawing.Image)(resources.GetObject("Splash1.Image")));
            this.Splash1.Location = new System.Drawing.Point(0, -2);
            this.Splash1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Splash1.Name = "Splash1";
            this.Splash1.Size = new System.Drawing.Size(621, 305);
            this.Splash1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Splash1.TabIndex = 0;
            this.Splash1.TabStop = false;
            // 
            // Cronometro
            // 
            this.Cronometro.Interval = 3500;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 301);
            this.Controls.Add(this.Splash1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Splash1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Splash1;
        private System.Windows.Forms.Timer Cronometro;
    }
}