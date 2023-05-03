namespace QQSSApp
{
    partial class CatalogoReto
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
            this.volver = new System.Windows.Forms.Button();
            this.BotonNivel2 = new System.Windows.Forms.Button();
            this.BotonNivel1 = new System.Windows.Forms.Button();
            this.BotonNivel0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.volver);
            this.panel1.Controls.Add(this.BotonNivel2);
            this.panel1.Controls.Add(this.BotonNivel1);
            this.panel1.Controls.Add(this.BotonNivel0);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 332);
            this.panel1.TabIndex = 1;
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.volver.ForeColor = System.Drawing.Color.White;
            this.volver.Location = new System.Drawing.Point(59, 283);
            this.volver.Margin = new System.Windows.Forms.Padding(2);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(96, 31);
            this.volver.TabIndex = 6;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // BotonNivel2
            // 
            this.BotonNivel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.BotonNivel2.Enabled = false;
            this.BotonNivel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNivel2.ForeColor = System.Drawing.Color.White;
            this.BotonNivel2.Location = new System.Drawing.Point(59, 208);
            this.BotonNivel2.Margin = new System.Windows.Forms.Padding(2);
            this.BotonNivel2.Name = "BotonNivel2";
            this.BotonNivel2.Size = new System.Drawing.Size(396, 45);
            this.BotonNivel2.TabIndex = 3;
            this.BotonNivel2.Text = "Aleatorio";
            this.BotonNivel2.UseVisualStyleBackColor = false;
            this.BotonNivel2.Click += new System.EventHandler(this.ButtonAleatorio_OnClick);
            // 
            // BotonNivel1
            // 
            this.BotonNivel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.BotonNivel1.Enabled = false;
            this.BotonNivel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNivel1.ForeColor = System.Drawing.Color.White;
            this.BotonNivel1.Location = new System.Drawing.Point(59, 145);
            this.BotonNivel1.Margin = new System.Windows.Forms.Padding(2);
            this.BotonNivel1.Name = "BotonNivel1";
            this.BotonNivel1.Size = new System.Drawing.Size(396, 47);
            this.BotonNivel1.TabIndex = 2;
            this.BotonNivel1.Text = "Adivinar la Frase";
            this.BotonNivel1.UseVisualStyleBackColor = false;
            this.BotonNivel1.Click += new System.EventHandler(this.ButtonAdivinar_OnClick);
            // 
            // BotonNivel0
            // 
            this.BotonNivel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.BotonNivel0.Enabled = false;
            this.BotonNivel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNivel0.ForeColor = System.Drawing.Color.White;
            this.BotonNivel0.Location = new System.Drawing.Point(59, 77);
            this.BotonNivel0.Margin = new System.Windows.Forms.Padding(2);
            this.BotonNivel0.Name = "BotonNivel0";
            this.BotonNivel0.Size = new System.Drawing.Size(396, 48);
            this.BotonNivel0.TabIndex = 1;
            this.BotonNivel0.Text = "Preguntas";
            this.BotonNivel0.UseVisualStyleBackColor = false;
            this.BotonNivel0.Click += new System.EventHandler(this.ButtonPreguntas_OnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "RETOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QQSSApp.Properties.Resources.agüita;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CatalogoReto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CatalogoReto";
            this.Text = "Niveles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonNivel2;
        private System.Windows.Forms.Button BotonNivel1;
        private System.Windows.Forms.Button BotonNivel0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volver;
    }
}