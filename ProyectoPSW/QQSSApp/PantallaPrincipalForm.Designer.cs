﻿namespace QQSSApp
{
    partial class PantallaPrincipalForm
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
            this.comenzarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonReglas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comenzarButton
            // 
            this.comenzarButton.BackColor = System.Drawing.Color.SpringGreen;
            this.comenzarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comenzarButton.Location = new System.Drawing.Point(195, 283);
            this.comenzarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comenzarButton.Name = "comenzarButton";
            this.comenzarButton.Size = new System.Drawing.Size(200, 41);
            this.comenzarButton.TabIndex = 1;
            this.comenzarButton.Text = "COMENZAR";
            this.comenzarButton.UseVisualStyleBackColor = false;
            this.comenzarButton.Click += new System.EventHandler(this.ButtonComenzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "QQSS-Quizz";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(136, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 368);
            this.panel1.TabIndex = 28;
            // 
            // BotonReglas
            // 
            this.BotonReglas.BackColor = System.Drawing.Color.Transparent;
            this.BotonReglas.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.BotonReglas.FlatAppearance.BorderSize = 2;
            this.BotonReglas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BotonReglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReglas.Image = global::QQSSApp.Properties.Resources.reglas;
            this.BotonReglas.Location = new System.Drawing.Point(547, 11);
            this.BotonReglas.Margin = new System.Windows.Forms.Padding(2);
            this.BotonReglas.Name = "BotonReglas";
            this.BotonReglas.Size = new System.Drawing.Size(43, 42);
            this.BotonReglas.TabIndex = 29;
            this.BotonReglas.UseVisualStyleBackColor = false;
            this.BotonReglas.Click += new System.EventHandler(this.BotonReglas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QQSSApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(152, -29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QQSSApp.Properties.Resources.agüita;
            this.pictureBox2.Location = new System.Drawing.Point(1, -4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(601, 377);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // PantallaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BotonReglas);
            this.Controls.Add(this.comenzarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantallaPrincipalForm";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button comenzarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonReglas;
    }
}

