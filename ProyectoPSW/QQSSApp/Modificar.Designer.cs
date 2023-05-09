namespace QQSSApp
{
    partial class Modificar
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
            this.Correo = new System.Windows.Forms.TextBox();
            this.continuar_salir = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.Contrasenya = new System.Windows.Forms.TextBox();
            this.RepetirContrasenya = new System.Windows.Forms.TextBox();
            this.NombreError = new System.Windows.Forms.Label();
            this.CorreoError = new System.Windows.Forms.Label();
            this.ContraError = new System.Windows.Forms.Label();
            this.RepetirContraError = new System.Windows.Forms.Label();
            this.ErrorGeneral = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 106);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::QQSSApp.Properties.Resources.Black_question_mark;
            this.pictureBox3.Location = new System.Drawing.Point(555, 26);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.FormatoClick);
            // 
            // correcto
            // 
            this.correcto.AutoSize = true;
            this.correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correcto.ForeColor = System.Drawing.Color.White;
            this.correcto.Location = new System.Drawing.Point(126, 21);
            this.correcto.Name = "correcto";
            this.correcto.Size = new System.Drawing.Size(388, 58);
            this.correcto.TabIndex = 1;
            this.correcto.Text = "Modificar Datos";
            this.correcto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(255, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRARSE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Repita la Contraseña:";
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Correo.Location = new System.Drawing.Point(257, 234);
            this.Correo.Margin = new System.Windows.Forms.Padding(4);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(330, 22);
            this.Correo.TabIndex = 11;
            this.Correo.TextChanged += new System.EventHandler(this.correo_text_Change);
            this.Correo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Correo_change);
            // 
            // continuar_salir
            // 
            this.continuar_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.continuar_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuar_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continuar_salir.Location = new System.Drawing.Point(32, 450);
            this.continuar_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continuar_salir.Name = "continuar_salir";
            this.continuar_salir.Size = new System.Drawing.Size(257, 49);
            this.continuar_salir.TabIndex = 12;
            this.continuar_salir.Text = "VOLVER";
            this.continuar_salir.UseVisualStyleBackColor = false;
            this.continuar_salir.Click += new System.EventHandler(this.Volver_click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.AceptarButton.Enabled = false;
            this.AceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AceptarButton.Location = new System.Drawing.Point(356, 450);
            this.AceptarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(257, 49);
            this.AceptarButton.TabIndex = 13;
            this.AceptarButton.Text = "ACEPTAR";
            this.AceptarButton.UseVisualStyleBackColor = false;
            this.AceptarButton.Click += new System.EventHandler(this.Aceptar_click);
            // 
            // Contrasenya
            // 
            this.Contrasenya.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Contrasenya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contrasenya.Location = new System.Drawing.Point(257, 311);
            this.Contrasenya.Margin = new System.Windows.Forms.Padding(4);
            this.Contrasenya.Name = "Contrasenya";
            this.Contrasenya.PasswordChar = '*';
            this.Contrasenya.Size = new System.Drawing.Size(330, 22);
            this.Contrasenya.TabIndex = 14;
            this.Contrasenya.UseSystemPasswordChar = true;
            this.Contrasenya.TextChanged += new System.EventHandler(this.contrasenya_text_change);
            this.Contrasenya.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Contrasenya_Change);
            // 
            // RepetirContrasenya
            // 
            this.RepetirContrasenya.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RepetirContrasenya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepetirContrasenya.Location = new System.Drawing.Point(257, 382);
            this.RepetirContrasenya.Margin = new System.Windows.Forms.Padding(4);
            this.RepetirContrasenya.Name = "RepetirContrasenya";
            this.RepetirContrasenya.PasswordChar = '*';
            this.RepetirContrasenya.Size = new System.Drawing.Size(330, 22);
            this.RepetirContrasenya.TabIndex = 15;
            this.RepetirContrasenya.UseSystemPasswordChar = true;
            this.RepetirContrasenya.TextChanged += new System.EventHandler(this.repetircontra_textChange);
            this.RepetirContrasenya.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RepetirContra_change);
            // 
            // NombreError
            // 
            this.NombreError.AutoSize = true;
            this.NombreError.ForeColor = System.Drawing.Color.Red;
            this.NombreError.Location = new System.Drawing.Point(256, 190);
            this.NombreError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreError.Name = "NombreError";
            this.NombreError.Size = new System.Drawing.Size(44, 16);
            this.NombreError.TabIndex = 16;
            this.NombreError.Text = "label6";
            // 
            // CorreoError
            // 
            this.CorreoError.AutoSize = true;
            this.CorreoError.ForeColor = System.Drawing.Color.Red;
            this.CorreoError.Location = new System.Drawing.Point(256, 268);
            this.CorreoError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CorreoError.Name = "CorreoError";
            this.CorreoError.Size = new System.Drawing.Size(44, 16);
            this.CorreoError.TabIndex = 17;
            this.CorreoError.Text = "label7";
            // 
            // ContraError
            // 
            this.ContraError.AutoSize = true;
            this.ContraError.ForeColor = System.Drawing.Color.Red;
            this.ContraError.Location = new System.Drawing.Point(256, 343);
            this.ContraError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContraError.Name = "ContraError";
            this.ContraError.Size = new System.Drawing.Size(44, 16);
            this.ContraError.TabIndex = 18;
            this.ContraError.Text = "label8";
            // 
            // RepetirContraError
            // 
            this.RepetirContraError.AutoSize = true;
            this.RepetirContraError.ForeColor = System.Drawing.Color.Red;
            this.RepetirContraError.Location = new System.Drawing.Point(256, 416);
            this.RepetirContraError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RepetirContraError.Name = "RepetirContraError";
            this.RepetirContraError.Size = new System.Drawing.Size(44, 16);
            this.RepetirContraError.TabIndex = 19;
            this.RepetirContraError.Text = "label9";
            // 
            // ErrorGeneral
            // 
            this.ErrorGeneral.AutoSize = true;
            this.ErrorGeneral.ForeColor = System.Drawing.Color.Red;
            this.ErrorGeneral.Location = new System.Drawing.Point(161, 511);
            this.ErrorGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorGeneral.Name = "ErrorGeneral";
            this.ErrorGeneral.Size = new System.Drawing.Size(84, 16);
            this.ErrorGeneral.TabIndex = 20;
            this.ErrorGeneral.Text = "ErrorGeneral";
            this.ErrorGeneral.Click += new System.EventHandler(this.label6_Click);
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.Location = new System.Drawing.Point(257, 155);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(330, 22);
            this.nombre.TabIndex = 9;
            this.nombre.TextChanged += new System.EventHandler(this.nombreChangeText);
            this.nombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.name_TextChange);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(645, 538);
            this.Controls.Add(this.ErrorGeneral);
            this.Controls.Add(this.RepetirContraError);
            this.Controls.Add(this.ContraError);
            this.Controls.Add(this.CorreoError);
            this.Controls.Add(this.NombreError);
            this.Controls.Add(this.RepetirContrasenya);
            this.Controls.Add(this.Contrasenya);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.continuar_salir);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Modificar";
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
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Button continuar_salir;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.TextBox Contrasenya;
        private System.Windows.Forms.TextBox RepetirContrasenya;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label NombreError;
        private System.Windows.Forms.Label CorreoError;
        private System.Windows.Forms.Label ContraError;
        private System.Windows.Forms.Label RepetirContraError;
        private System.Windows.Forms.Label ErrorGeneral;
        private System.Windows.Forms.TextBox nombre;
    }
}