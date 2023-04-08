namespace QQSSApp
{
    partial class PuntuacionPositiva
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
            this.label2 = new System.Windows.Forms.Label();
            this.consolidar = new System.Windows.Forms.Button();
            this.continuar_salir = new System.Windows.Forms.Button();
            this.textoConsolidacion = new System.Windows.Forms.Label();
            this.puntuacionConsolidada = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.correcto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 98);
            this.panel1.TabIndex = 0;
            // 
            // correcto
            // 
            this.correcto.AutoSize = true;
            this.correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correcto.ForeColor = System.Drawing.Color.White;
            this.correcto.Location = new System.Drawing.Point(119, 22);
            this.correcto.Name = "correcto";
            this.correcto.Size = new System.Drawing.Size(319, 58);
            this.correcto.TabIndex = 0;
            this.correcto.Text = "CORRECTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // puntuacion
            // 
            this.puntuacion.AutoSize = true;
            this.puntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacion.Location = new System.Drawing.Point(183, 142);
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.Size = new System.Drawing.Size(255, 91);
            this.puntuacion.TabIndex = 2;
            this.puntuacion.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puntuación Actual:";
            // 
            // punt_actual
            // 
            this.punt_actual.AutoSize = true;
            this.punt_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punt_actual.Location = new System.Drawing.Point(344, 270);
            this.punt_actual.Name = "punt_actual";
            this.punt_actual.Size = new System.Drawing.Size(70, 25);
            this.punt_actual.TabIndex = 4;
            this.punt_actual.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "¿Qué deseas hacer ahora?";
            // 
            // consolidar
            // 
            this.consolidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(107)))));
            this.consolidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consolidar.Location = new System.Drawing.Point(37, 455);
            this.consolidar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consolidar.Name = "consolidar";
            this.consolidar.Size = new System.Drawing.Size(175, 52);
            this.consolidar.TabIndex = 6;
            this.consolidar.Text = "CONSOLIDAR";
            this.consolidar.UseVisualStyleBackColor = false;
            this.consolidar.Click += new System.EventHandler(this.consolidar_click);
            // 
            // continuar_salir
            // 
            this.continuar_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.continuar_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuar_salir.Location = new System.Drawing.Point(360, 455);
            this.continuar_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continuar_salir.Name = "continuar_salir";
            this.continuar_salir.Size = new System.Drawing.Size(175, 52);
            this.continuar_salir.TabIndex = 7;
            this.continuar_salir.Text = "CONTINUAR";
            this.continuar_salir.UseVisualStyleBackColor = false;
            this.continuar_salir.Click += new System.EventHandler(this.continuar_salir_Click);
            // 
            // textoConsolidacion
            // 
            this.textoConsolidacion.AutoSize = true;
            this.textoConsolidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoConsolidacion.Location = new System.Drawing.Point(139, 396);
            this.textoConsolidacion.Name = "textoConsolidacion";
            this.textoConsolidacion.Size = new System.Drawing.Size(179, 25);
            this.textoConsolidacion.TabIndex = 8;
            this.textoConsolidacion.Text = "Has consolidado:";
            this.textoConsolidacion.Visible = false;
            // 
            // puntuacionConsolidada
            // 
            this.puntuacionConsolidada.AutoSize = true;
            this.puntuacionConsolidada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacionConsolidada.Location = new System.Drawing.Point(369, 396);
            this.puntuacionConsolidada.Name = "puntuacionConsolidada";
            this.puntuacionConsolidada.Size = new System.Drawing.Size(24, 25);
            this.puntuacionConsolidada.TabIndex = 9;
            this.puntuacionConsolidada.Text = "0";
            this.puntuacionConsolidada.Visible = false;
            // 
            // PuntuacionPositiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 554);
            this.Controls.Add(this.puntuacionConsolidada);
            this.Controls.Add(this.textoConsolidacion);
            this.Controls.Add(this.continuar_salir);
            this.Controls.Add(this.consolidar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puntuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.punt_actual);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PuntuacionPositiva";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button consolidar;
        private System.Windows.Forms.Button continuar_salir;
        private System.Windows.Forms.Label textoConsolidacion;
        private System.Windows.Forms.Label puntuacionConsolidada;
    }
}