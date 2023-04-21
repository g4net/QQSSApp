namespace QQSSApp
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reintentar_salir
            // 
            this.reintentar_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.reintentar_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reintentar_salir.Location = new System.Drawing.Point(22, 389);
            this.reintentar_salir.Margin = new System.Windows.Forms.Padding(2);
            this.reintentar_salir.Name = "reintentar_salir";
            this.reintentar_salir.Size = new System.Drawing.Size(386, 42);
            this.reintentar_salir.TabIndex = 13;
            this.reintentar_salir.Text = "VOLVER AL MENÚ PRINCIPAL";
            this.reintentar_salir.UseVisualStyleBackColor = false;
            this.reintentar_salir.Click += new System.EventHandler(this.reintentar_salir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.correcto);
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 80);
            this.panel1.TabIndex = 8;
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
            // puntuacion_acumulada
            // 
            this.puntuacion_acumulada.AutoSize = true;
            this.puntuacion_acumulada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacion_acumulada.Location = new System.Drawing.Point(177, 240);
            this.puntuacion_acumulada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puntuacion_acumulada.Name = "puntuacion_acumulada";
            this.puntuacion_acumulada.Size = new System.Drawing.Size(57, 20);
            this.puntuacion_acumulada.TabIndex = 20;
            this.puntuacion_acumulada.Text = "labal5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Puntuación Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 40);
            this.label2.TabIndex = 16;
            this.label2.Text = "Has perdido la partida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(71, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Suerte la próxima vez!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QQSSApp.Properties.Resources.perdiste;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(24, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 317);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // respcorrect
            // 
            this.respcorrect.AutoSize = true;
            this.respcorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respcorrect.Location = new System.Drawing.Point(18, 285);
            this.respcorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.respcorrect.Name = "respcorrect";
            this.respcorrect.Size = new System.Drawing.Size(175, 20);
            this.respcorrect.TabIndex = 23;
            this.respcorrect.Text = "Respuesta Correcta:";
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.Location = new System.Drawing.Point(190, 285);
            this.respuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.respuesta.MaximumSize = new System.Drawing.Size(200, 0);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(57, 20);
            this.respuesta.TabIndex = 24;
            this.respuesta.Text = "labal5";
            // 
            // PartidaPerdida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
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
            this.Name = "PartidaPerdida";
            this.Text = "Form1";
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
    }
}