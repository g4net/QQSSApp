namespace QQSSApp
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // comenzarButton
            // 
            this.comenzarButton.AutoSize = true;
            this.comenzarButton.BackColor = System.Drawing.Color.SpringGreen;
            this.comenzarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comenzarButton.Location = new System.Drawing.Point(260, 348);
            this.comenzarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comenzarButton.Name = "comenzarButton";
            this.comenzarButton.Size = new System.Drawing.Size(267, 50);
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
            this.label1.Location = new System.Drawing.Point(243, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "QQSS-Quizz";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(181, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 453);
            this.panel1.TabIndex = 28;
            // 
            // BotonReglas
            // 
            this.BotonReglas.AutoSize = true;
            this.BotonReglas.BackColor = System.Drawing.Color.Transparent;
            this.BotonReglas.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.BotonReglas.FlatAppearance.BorderSize = 2;
            this.BotonReglas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BotonReglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReglas.Image = global::QQSSApp.Properties.Resources.reglas;
            this.BotonReglas.Location = new System.Drawing.Point(729, 14);
            this.BotonReglas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonReglas.Name = "BotonReglas";
            this.BotonReglas.Size = new System.Drawing.Size(57, 52);
            this.BotonReglas.TabIndex = 29;
            this.BotonReglas.UseVisualStyleBackColor = false;
            this.BotonReglas.Click += new System.EventHandler(this.BotonReglas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QQSSApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(203, -36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::QQSSApp.Properties.Resources.agüita;
            this.pictureBox2.Location = new System.Drawing.Point(1, -5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(801, 464);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::QQSSApp.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(729, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.UserClick);
            // 
            // PantallaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BotonReglas);
            this.Controls.Add(this.comenzarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaPrincipalForm";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

