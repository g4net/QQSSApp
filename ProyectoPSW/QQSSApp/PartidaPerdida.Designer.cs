﻿namespace QQSSApp
{
    partial class PartidaPerdida
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
            this.reintentar_salir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.correcto = new System.Windows.Forms.Label();
            this.puntuacion_acumulada = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.respcorrect = new System.Windows.Forms.Label();
            this.respuesta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextEnlace = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reintentar_salir
            // 
            this.reintentar_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.reintentar_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reintentar_salir.Location = new System.Drawing.Point(29, 573);
            this.reintentar_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reintentar_salir.Name = "reintentar_salir";
            this.reintentar_salir.Size = new System.Drawing.Size(515, 52);
            this.reintentar_salir.TabIndex = 13;
            this.reintentar_salir.Text = "VOLVER AL MENÚ PRINCIPAL";
            this.reintentar_salir.UseVisualStyleBackColor = false;
            this.reintentar_salir.Click += new System.EventHandler(this.reintentar_salir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.correcto);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 98);
            this.panel1.TabIndex = 8;
            // 
            // correcto
            // 
            this.correcto.AutoSize = true;
            this.correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correcto.ForeColor = System.Drawing.Color.White;
            this.correcto.Location = new System.Drawing.Point(92, 21);
            this.correcto.Name = "correcto";
            this.correcto.Size = new System.Drawing.Size(371, 58);
            this.correcto.TabIndex = 0;
            this.correcto.Text = "INCORRECTO";
            // 
            // puntuacion_acumulada
            // 
            this.puntuacion_acumulada.AutoSize = true;
            this.puntuacion_acumulada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacion_acumulada.Location = new System.Drawing.Point(323, 295);
            this.puntuacion_acumulada.Name = "puntuacion_acumulada";
            this.puntuacion_acumulada.Size = new System.Drawing.Size(70, 25);
            this.puntuacion_acumulada.TabIndex = 20;
            this.puntuacion_acumulada.Text = "labal5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Puntuación Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 52);
            this.label2.TabIndex = 16;
            this.label2.Text = "Has perdido la partida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(95, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 38);
            this.label6.TabIndex = 21;
            this.label6.Text = "Suerte la próxima vez!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QQSSApp.Properties.Resources.perdiste;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(32, 187);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 390);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // respcorrect
            // 
            this.respcorrect.AutoSize = true;
            this.respcorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respcorrect.Location = new System.Drawing.Point(75, 351);
            this.respcorrect.Name = "respcorrect";
            this.respcorrect.Size = new System.Drawing.Size(210, 25);
            this.respcorrect.TabIndex = 23;
            this.respcorrect.Text = "Respuesta Correcta:";
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.Location = new System.Drawing.Point(323, 351);
            this.respuesta.MaximumSize = new System.Drawing.Size(267, 0);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(70, 25);
            this.respuesta.TabIndex = 24;
            this.respuesta.Text = "labal5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Para saber más, entra en:";
            // 
            // TextEnlace
            // 
            this.TextEnlace.AutoSize = true;
            this.TextEnlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEnlace.Location = new System.Drawing.Point(346, 490);
            this.TextEnlace.Name = "TextEnlace";
            this.TextEnlace.Size = new System.Drawing.Size(47, 25);
            this.TextEnlace.TabIndex = 26;
            this.TextEnlace.TabStop = true;
            this.TextEnlace.Text = "ods";
            this.TextEnlace.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TextEnlace_LinkClicked);
            // 
            // PartidaPerdida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 650);
            this.Controls.Add(this.TextEnlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.respcorrect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.puntuacion_acumulada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reintentar_salir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PartidaPerdida";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PartidaPerdida_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reintentar_salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label correcto;
        private System.Windows.Forms.Label puntuacion_acumulada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label respcorrect;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel TextEnlace;
    }
}