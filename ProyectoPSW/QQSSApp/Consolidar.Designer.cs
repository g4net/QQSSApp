﻿namespace QQSSApp
{
    partial class Consolidar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.correcto = new System.Windows.Forms.Label();
            this.puntuacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.punt_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.continuar_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.correcto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 80);
            this.panel1.TabIndex = 1;
            // 
            // correcto
            // 
            this.correcto.AutoSize = true;
            this.correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correcto.ForeColor = System.Drawing.Color.White;
            this.correcto.Location = new System.Drawing.Point(53, 18);
            this.correcto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.correcto.Name = "correcto";
            this.correcto.Size = new System.Drawing.Size(322, 46);
            this.correcto.TabIndex = 0;
            this.correcto.Text = "CONSOLIDADA";
            // 
            // puntuacion
            // 
            this.puntuacion.AutoSize = true;
            this.puntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacion.Location = new System.Drawing.Point(132, 145);
            this.puntuacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.Size = new System.Drawing.Size(210, 73);
            this.puntuacion.TabIndex = 3;
            this.puntuacion.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puntuacion del Usuario:";
            // 
            // punt_usuario
            // 
            this.punt_usuario.AutoSize = true;
            this.punt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punt_usuario.Location = new System.Drawing.Point(282, 304);
            this.punt_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.punt_usuario.Name = "punt_usuario";
            this.punt_usuario.Size = new System.Drawing.Size(57, 20);
            this.punt_usuario.TabIndex = 6;
            this.punt_usuario.Text = "label5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puntuacion Agregada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 73);
            this.label2.TabIndex = 8;
            this.label2.Text = "+";
            // 
            // continuar_salir
            // 
            this.continuar_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.continuar_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuar_salir.Location = new System.Drawing.Point(145, 377);
            this.continuar_salir.Margin = new System.Windows.Forms.Padding(2);
            this.continuar_salir.Name = "continuar_salir";
            this.continuar_salir.Size = new System.Drawing.Size(131, 42);
            this.continuar_salir.TabIndex = 9;
            this.continuar_salir.Text = "CONTINUAR";
            this.continuar_salir.UseVisualStyleBackColor = false;
            this.continuar_salir.Click += new System.EventHandler(this.continuar_click);
            // 
            // Consolidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.continuar_salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.punt_usuario);
            this.Controls.Add(this.puntuacion);
            this.Controls.Add(this.panel1);
            this.Name = "Consolidar";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label correcto;
        private System.Windows.Forms.Label puntuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label punt_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button continuar_salir;
    }
}