using System.Drawing;
using System.Windows.Forms;
namespace ProblemasClassicosDeProcessos.Algoritmo.WindowsForms
{
    partial class FilosofosJantandoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilosofosJantandoUI));
            this.Barra = new System.Windows.Forms.TrackBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ImagemDeFundo = new System.Windows.Forms.PictureBox();
            this.Garfo2 = new System.Windows.Forms.PictureBox();
            this.Garfo3 = new System.Windows.Forms.PictureBox();
            this.Garfo4 = new System.Windows.Forms.PictureBox();
            this.Garfo5 = new System.Windows.Forms.PictureBox();
            this.Garfo1 = new System.Windows.Forms.PictureBox();
            this.Filosofo2 = new System.Windows.Forms.PictureBox();
            this.Filosofo1 = new System.Windows.Forms.PictureBox();
            this.Filosofo5 = new System.Windows.Forms.PictureBox();
            this.Filosofo4 = new System.Windows.Forms.PictureBox();
            this.Filosofo3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemDeFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garfo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garfo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garfo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garfo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filosofo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filosofo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filosofo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filosofo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filosofo3)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra
            // 
            this.Barra.Location = new System.Drawing.Point(39, 405);
            this.Barra.Minimum = 1;
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(400, 45);
            this.Barra.TabIndex = 0;
            this.Barra.Value = 10;
            this.Barra.Scroll += new System.EventHandler(this.Barra_Scroll);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ImagemDeFundo
            // 
            this.ImagemDeFundo.BackColor = System.Drawing.Color.White;
            this.ImagemDeFundo.Image = global::AlgoritmoWindowsForms.Properties.Resources.mesa;
            this.ImagemDeFundo.Location = new System.Drawing.Point(39, 12);
            this.ImagemDeFundo.Name = "ImagemDeFundo";
            this.ImagemDeFundo.Size = new System.Drawing.Size(400, 378);
            this.ImagemDeFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImagemDeFundo.TabIndex = 11;
            this.ImagemDeFundo.TabStop = false;
            // 
            // Garfo2
            // 
            this.Garfo2.BackColor = System.Drawing.Color.Transparent;
            this.Garfo2.Image = global::AlgoritmoWindowsForms.Properties.Resources.garfo2;
            this.Garfo2.Location = new System.Drawing.Point(64, 195);
            this.Garfo2.Name = "Garfo2";
            this.Garfo2.Size = new System.Drawing.Size(57, 57);
            this.Garfo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Garfo2.TabIndex = 5;
            this.Garfo2.TabStop = false;
            // 
            // Garfo3
            // 
            this.Garfo3.BackColor = System.Drawing.Color.Transparent;
            this.Garfo3.Image = global::AlgoritmoWindowsForms.Properties.Resources.garfo1;
            this.Garfo3.Location = new System.Drawing.Point(106, 73);
            this.Garfo3.Name = "Garfo3";
            this.Garfo3.Size = new System.Drawing.Size(57, 57);
            this.Garfo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Garfo3.TabIndex = 4;
            this.Garfo3.TabStop = false;
            // 
            // Garfo4
            // 
            this.Garfo4.BackColor = System.Drawing.Color.Transparent;
            this.Garfo4.Image = global::AlgoritmoWindowsForms.Properties.Resources.garfo5;
            this.Garfo4.Location = new System.Drawing.Point(234, 71);
            this.Garfo4.Name = "Garfo4";
            this.Garfo4.Size = new System.Drawing.Size(57, 57);
            this.Garfo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Garfo4.TabIndex = 3;
            this.Garfo4.TabStop = false;
            // 
            // Garfo5
            // 
            this.Garfo5.BackColor = System.Drawing.Color.Transparent;
            this.Garfo5.Image = global::AlgoritmoWindowsForms.Properties.Resources.garfo4;
            this.Garfo5.Location = new System.Drawing.Point(277, 193);
            this.Garfo5.Name = "Garfo5";
            this.Garfo5.Size = new System.Drawing.Size(57, 57);
            this.Garfo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Garfo5.TabIndex = 2;
            this.Garfo5.TabStop = false;
            // 
            // Garfo1
            // 
            this.Garfo1.BackColor = System.Drawing.Color.Transparent;
            this.Garfo1.Image = global::AlgoritmoWindowsForms.Properties.Resources.garfo3;
            this.Garfo1.Location = new System.Drawing.Point(171, 274);
            this.Garfo1.Name = "Garfo1";
            this.Garfo1.Size = new System.Drawing.Size(57, 57);
            this.Garfo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Garfo1.TabIndex = 1;
            this.Garfo1.TabStop = false;
            // 
            // Filosofo2
            // 
            this.Filosofo2.BackColor = System.Drawing.Color.Transparent;
            this.Filosofo2.Image = global::AlgoritmoWindowsForms.Properties.Resources.prato_usado;
            this.Filosofo2.Location = new System.Drawing.Point(28, 98);
            this.Filosofo2.Name = "Filosofo2";
            this.Filosofo2.Size = new System.Drawing.Size(110, 110);
            this.Filosofo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Filosofo2.TabIndex = 6;
            this.Filosofo2.TabStop = false;
            // 
            // Filosofo1
            // 
            this.Filosofo1.BackColor = System.Drawing.Color.Transparent;
            this.Filosofo1.Image = global::AlgoritmoWindowsForms.Properties.Resources.prato_usado;
            this.Filosofo1.Location = new System.Drawing.Point(73, 232);
            this.Filosofo1.Name = "Filosofo1";
            this.Filosofo1.Size = new System.Drawing.Size(110, 110);
            this.Filosofo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Filosofo1.TabIndex = 10;
            this.Filosofo1.TabStop = false;
            // 
            // Filosofo5
            // 
            this.Filosofo5.BackColor = System.Drawing.Color.Transparent;
            this.Filosofo5.Image = global::AlgoritmoWindowsForms.Properties.Resources.prato_usado;
            this.Filosofo5.Location = new System.Drawing.Point(214, 232);
            this.Filosofo5.Name = "Filosofo5";
            this.Filosofo5.Size = new System.Drawing.Size(110, 110);
            this.Filosofo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Filosofo5.TabIndex = 9;
            this.Filosofo5.TabStop = false;
            // 
            // Filosofo4
            // 
            this.Filosofo4.BackColor = System.Drawing.Color.Transparent;
            this.Filosofo4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Filosofo4.Image = global::AlgoritmoWindowsForms.Properties.Resources.prato_usado;
            this.Filosofo4.Location = new System.Drawing.Point(258, 97);
            this.Filosofo4.Name = "Filosofo4";
            this.Filosofo4.Size = new System.Drawing.Size(110, 110);
            this.Filosofo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Filosofo4.TabIndex = 8;
            this.Filosofo4.TabStop = false;
            // 
            // Filosofo3
            // 
            this.Filosofo3.BackColor = System.Drawing.Color.Transparent;
            this.Filosofo3.Image = global::AlgoritmoWindowsForms.Properties.Resources.prato_usado;
            this.Filosofo3.Location = new System.Drawing.Point(143, 14);
            this.Filosofo3.Name = "Filosofo3";
            this.Filosofo3.Size = new System.Drawing.Size(110, 110);
            this.Filosofo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Filosofo3.TabIndex = 7;
            this.Filosofo3.TabStop = false;
            // 
            // FilosofosJantandoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.Garfo1);
            this.Controls.Add(this.Garfo2);
            this.Controls.Add(this.Garfo3);
            this.Controls.Add(this.Garfo4);
            this.Controls.Add(this.Garfo5);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.Filosofo2);
            this.Controls.Add(this.Filosofo1);
            this.Controls.Add(this.Filosofo5);
            this.Controls.Add(this.Filosofo4);
            this.Controls.Add(this.Filosofo3);
            this.Controls.Add(this.ImagemDeFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FilosofosJantandoUI";
            this.Text = "Filósofos Jantando";
            this.Load += new System.EventHandler(this.FilosofosJantandoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemDeFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garfo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garfo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garfo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garfo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filosofo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filosofo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filosofo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filosofo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filosofo3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Barra;
        private System.Windows.Forms.PictureBox Garfo1;
        public System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox Garfo5;
        private System.Windows.Forms.PictureBox Garfo4;
        private System.Windows.Forms.PictureBox Garfo3;
        private System.Windows.Forms.PictureBox Garfo2;
        private System.Windows.Forms.PictureBox Filosofo2;
        private System.Windows.Forms.PictureBox Filosofo3;
        private System.Windows.Forms.PictureBox Filosofo4;
        private System.Windows.Forms.PictureBox Filosofo5;
        private System.Windows.Forms.PictureBox Filosofo1;
        private System.Windows.Forms.PictureBox ImagemDeFundo;

    }
}