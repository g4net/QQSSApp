namespace QQSSApp
{
    partial class Registrar
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.correcto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.continuar_salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Contrasenya = new System.Windows.Forms.TextBox();
            this.RepetirContrasenya = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.correcto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 86);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::QQSSApp.Properties.Resources.Black_question_mark;
            this.pictureBox3.Location = new System.Drawing.Point(416, 21);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // correcto
            // 
            this.correcto.AutoSize = true;
            this.correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correcto.ForeColor = System.Drawing.Color.White;
            this.correcto.Location = new System.Drawing.Point(115, 18);
            this.correcto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.correcto.Name = "correcto";
            this.correcto.Size = new System.Drawing.Size(262, 46);
            this.correcto.TabIndex = 1;
            this.correcto.Text = "REGISTRAR";
            this.correcto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(191, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRARSE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Repita la Contraseña:";
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.Location = new System.Drawing.Point(195, 123);
            this.nombre.Multiline = true;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(248, 28);
            this.nombre.TabIndex = 9;
            this.nombre.TextChanged += new System.EventHandler(this.name_TextChange);
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Correo.Location = new System.Drawing.Point(195, 170);
            this.Correo.Multiline = true;
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(248, 28);
            this.Correo.TabIndex = 11;
            this.Correo.TextChanged += new System.EventHandler(this.Correo_change);
            // 
            // continuar_salir
            // 
            this.continuar_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.continuar_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuar_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continuar_salir.Location = new System.Drawing.Point(24, 344);
            this.continuar_salir.Margin = new System.Windows.Forms.Padding(2);
            this.continuar_salir.Name = "continuar_salir";
            this.continuar_salir.Size = new System.Drawing.Size(193, 40);
            this.continuar_salir.TabIndex = 12;
            this.continuar_salir.Text = "VOLVER";
            this.continuar_salir.UseVisualStyleBackColor = false;
            this.continuar_salir.Click += new System.EventHandler(this.Volver_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(267, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Aceptar_click);
            // 
            // Contrasenya
            // 
            this.Contrasenya.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Contrasenya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contrasenya.Location = new System.Drawing.Point(195, 220);
            this.Contrasenya.Multiline = true;
            this.Contrasenya.Name = "Contrasenya";
            this.Contrasenya.Size = new System.Drawing.Size(248, 28);
            this.Contrasenya.TabIndex = 14;
            this.Contrasenya.UseSystemPasswordChar = true;
            this.Contrasenya.TextChanged += new System.EventHandler(this.Contrasenya_Change);
            // 
            // RepetirContrasenya
            // 
            this.RepetirContrasenya.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RepetirContrasenya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepetirContrasenya.Location = new System.Drawing.Point(195, 269);
            this.RepetirContrasenya.Multiline = true;
            this.RepetirContrasenya.Name = "RepetirContrasenya";
            this.RepetirContrasenya.Size = new System.Drawing.Size(248, 28);
            this.RepetirContrasenya.TabIndex = 15;
            this.RepetirContrasenya.UseSystemPasswordChar = true;
            this.RepetirContrasenya.TextChanged += new System.EventHandler(this.RepetirContra_change);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(484, 405);
            this.Controls.Add(this.RepetirContrasenya);
            this.Controls.Add(this.Contrasenya);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.continuar_salir);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label correcto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Button continuar_salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Contrasenya;
        private System.Windows.Forms.TextBox RepetirContrasenya;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}