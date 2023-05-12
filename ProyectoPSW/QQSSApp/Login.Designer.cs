namespace QQSSApp
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoggerText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Registrarse = new System.Windows.Forms.Button();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.LoggerError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.ErrorGeneral = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 372);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "QQSS-Quizz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QQSSApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoggerText
            // 
            this.LoggerText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LoggerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoggerText.Location = new System.Drawing.Point(426, 160);
            this.LoggerText.Name = "LoggerText";
            this.LoggerText.Size = new System.Drawing.Size(248, 20);
            this.LoggerText.TabIndex = 11;
            this.LoggerText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.MaximumSize = new System.Drawing.Size(168, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre de Usuario o Correo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordText.Location = new System.Drawing.Point(426, 244);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(248, 20);
            this.PasswordText.TabIndex = 16;
            this.PasswordText.UseSystemPasswordChar = true;
            this.PasswordText.TextChanged += new System.EventHandler(this.PassTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Contraseña:";
            // 
            // Registrarse
            // 
            this.Registrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.Registrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registrarse.Location = new System.Drawing.Point(262, 306);
            this.Registrarse.Margin = new System.Windows.Forms.Padding(2);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(193, 40);
            this.Registrarse.TabIndex = 17;
            this.Registrarse.Text = "REGISTRARSE";
            this.Registrarse.UseVisualStyleBackColor = false;
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.IniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IniciarSesion.Location = new System.Drawing.Point(482, 306);
            this.IniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(193, 40);
            this.IniciarSesion.TabIndex = 18;
            this.IniciarSesion.Text = "INICIAR SESION";
            this.IniciarSesion.UseVisualStyleBackColor = false;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // LoggerError
            // 
            this.LoggerError.AutoSize = true;
            this.LoggerError.ForeColor = System.Drawing.Color.Red;
            this.LoggerError.Location = new System.Drawing.Point(423, 186);
            this.LoggerError.Name = "LoggerError";
            this.LoggerError.Size = new System.Drawing.Size(35, 13);
            this.LoggerError.TabIndex = 19;
            this.LoggerError.Text = "label2";
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(423, 270);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(35, 13);
            this.PasswordError.TabIndex = 20;
            this.PasswordError.Text = "label5";
            // 
            // ErrorGeneral
            // 
            this.ErrorGeneral.AutoSize = true;
            this.ErrorGeneral.ForeColor = System.Drawing.Color.Red;
            this.ErrorGeneral.Location = new System.Drawing.Point(386, 349);
            this.ErrorGeneral.Name = "ErrorGeneral";
            this.ErrorGeneral.Size = new System.Drawing.Size(35, 13);
            this.ErrorGeneral.TabIndex = 21;
            this.ErrorGeneral.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrorGeneral);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.LoggerError);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoggerText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoggerText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.Label LoggerError;
        private System.Windows.Forms.Label PasswordError;
        private System.Windows.Forms.Label ErrorGeneral;
        private System.Windows.Forms.Button button1;
    }
}