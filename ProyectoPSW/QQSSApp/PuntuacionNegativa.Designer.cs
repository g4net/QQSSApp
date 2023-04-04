namespace QQSSApp
{
    partial class PuntuacionNegativa
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
            this.label1 = new System.Windows.Forms.Label();
            this.puntuacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.punt_actual = new System.Windows.Forms.Label();
            this.reintentar_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.correcto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 80);
            this.panel1.TabIndex = 0;
            // 
            // correcto
            // 
            this.correcto.AutoSize = true;
            this.correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correcto.ForeColor = System.Drawing.Color.White;
            this.correcto.Location = new System.Drawing.Point(69, 17);
            this.correcto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.correcto.Name = "correcto";
            this.correcto.Size = new System.Drawing.Size(298, 46);
            this.correcto.TabIndex = 0;
            this.correcto.Text = "INCORRECTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // puntuacion
            // 
            this.puntuacion.AutoSize = true;
            this.puntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacion.Location = new System.Drawing.Point(136, 115);
            this.puntuacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.Size = new System.Drawing.Size(210, 73);
            this.puntuacion.TabIndex = 2;
            this.puntuacion.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puntuación Actual:";
            // 
            // punt_actual
            // 
            this.punt_actual.AutoSize = true;
            this.punt_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punt_actual.Location = new System.Drawing.Point(256, 277);
            this.punt_actual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.punt_actual.Name = "punt_actual";
            this.punt_actual.Size = new System.Drawing.Size(57, 20);
            this.punt_actual.TabIndex = 4;
            this.punt_actual.Text = "label5";
            // 
            // reintentar_salir
            // 
            this.reintentar_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.reintentar_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reintentar_salir.Location = new System.Drawing.Point(22, 370);
            this.reintentar_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reintentar_salir.Name = "reintentar_salir";
            this.reintentar_salir.Size = new System.Drawing.Size(386, 42);
            this.reintentar_salir.TabIndex = 7;
            this.reintentar_salir.Text = "REINTENTAR";
            this.reintentar_salir.UseVisualStyleBackColor = false;
            this.reintentar_salir.Click += new System.EventHandler(this.ButtonReintentarClick);
            // 
            // PuntuacionNegativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.reintentar_salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puntuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.punt_actual);
            this.Controls.Add(this.panel1);
            this.Name = "PuntuacionNegativa";
            this.Text = "PuntuacionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label correcto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label puntuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label punt_actual;
        private System.Windows.Forms.Button reintentar_salir;
    }
}