﻿namespace QQSSApp
{
    partial class PartidaForm
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
            this.components = new System.ComponentModel.Container();
            this.op1 = new System.Windows.Forms.Button();
            this.op2 = new System.Windows.Forms.Button();
            this.op4 = new System.Windows.Forms.Button();
            this.op3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.puntuaciónNegativa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPuntuacionAcumulada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.enunciado = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            this.pos1 = new System.Windows.Forms.Button();
            this.pos2 = new System.Windows.Forms.Button();
            this.pos3 = new System.Windows.Forms.Button();
            this.pos4 = new System.Windows.Forms.Button();
            this.pos5 = new System.Windows.Forms.Button();
            this.pos6 = new System.Windows.Forms.Button();
            this.pos7 = new System.Windows.Forms.Button();
            this.pos8 = new System.Windows.Forms.Button();
            this.pos9 = new System.Windows.Forms.Button();
            this.pos10 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.reloj_circular = new System.Windows.Forms.PictureBox();
            this.puntuacionPos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reloj_circular)).BeginInit();
            this.SuspendLayout();
            // 
            // op1
            // 
            this.op1.Location = new System.Drawing.Point(84, 395);
            this.op1.Margin = new System.Windows.Forms.Padding(4);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(357, 62);
            this.op1.TabIndex = 0;
            this.op1.Text = "Opcion 1";
            this.op1.UseVisualStyleBackColor = true;
            this.op1.Click += new System.EventHandler(this.op1_click);
            // 
            // op2
            // 
            this.op2.Location = new System.Drawing.Point(532, 395);
            this.op2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(357, 62);
            this.op2.TabIndex = 1;
            this.op2.Text = "Opcion 2";
            this.op2.UseVisualStyleBackColor = true;
            this.op2.Click += new System.EventHandler(this.op2_Click);
            // 
            // op4
            // 
            this.op4.Location = new System.Drawing.Point(532, 471);
            this.op4.Margin = new System.Windows.Forms.Padding(2);
            this.op4.Name = "op4";
            this.op4.Size = new System.Drawing.Size(357, 62);
            this.op4.TabIndex = 3;
            this.op4.Text = "Opcion 4";
            this.op4.UseVisualStyleBackColor = true;
            this.op4.Click += new System.EventHandler(this.op4_Click);
            // 
            // op3
            // 
            this.op3.Location = new System.Drawing.Point(84, 471);
            this.op3.Margin = new System.Windows.Forms.Padding(2);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(357, 62);
            this.op3.TabIndex = 2;
            this.op3.Text = "Opcion 3";
            this.op3.UseVisualStyleBackColor = true;
            this.op3.Click += new System.EventHandler(this.op3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.puntuacionPos);
            this.panel1.Controls.Add(this.puntuaciónNegativa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelPuntuacionAcumulada);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 70);
            this.panel1.TabIndex = 4;
            // 
            // puntuaciónNegativa
            // 
            this.puntuaciónNegativa.AutoSize = true;
            this.puntuaciónNegativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuaciónNegativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.puntuaciónNegativa.Location = new System.Drawing.Point(495, 16);
            this.puntuaciónNegativa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puntuaciónNegativa.Name = "puntuaciónNegativa";
            this.puntuaciónNegativa.Size = new System.Drawing.Size(50, 39);
            this.puntuaciónNegativa.TabIndex = 26;
            this.puntuaciónNegativa.Text = "-0";
            this.puntuaciónNegativa.Click += new System.EventHandler(this.puntuaciónNegativa_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(774, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Acumulado:";
            // 
            // labelPuntuacionAcumulada
            // 
            this.labelPuntuacionAcumulada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPuntuacionAcumulada.AutoSize = true;
            this.labelPuntuacionAcumulada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntuacionAcumulada.ForeColor = System.Drawing.Color.White;
            this.labelPuntuacionAcumulada.Location = new System.Drawing.Point(873, 15);
            this.labelPuntuacionAcumulada.Margin = new System.Windows.Forms.Padding(0);
            this.labelPuntuacionAcumulada.Name = "labelPuntuacionAcumulada";
            this.labelPuntuacionAcumulada.Size = new System.Drawing.Size(93, 37);
            this.labelPuntuacionAcumulada.TabIndex = 23;
            this.labelPuntuacionAcumulada.Text = "2000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(478, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "/";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QQSSApp.Properties.Resources.flecha;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Atras);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(377, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(311, 56);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 37);
            this.label4.TabIndex = 21;
            this.label4.Text = "/";
            // 
            // enunciado
            // 
            this.enunciado.AutoSize = true;
            this.enunciado.BackColor = System.Drawing.Color.Transparent;
            this.enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enunciado.Location = new System.Drawing.Point(80, 355);
            this.enunciado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enunciado.Name = "enunciado";
            this.enunciado.Size = new System.Drawing.Size(66, 24);
            this.enunciado.TabIndex = 7;
            this.enunciado.Text = "label1";
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.Location = new System.Drawing.Point(457, 221);
            this.tiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(49, 24);
            this.tiempo.TabIndex = 8;
            this.tiempo.Text = "0:00";
            // 
            // pos1
            // 
            this.pos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(205)))));
            this.pos1.Enabled = false;
            this.pos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos1.Location = new System.Drawing.Point(0, 0);
            this.pos1.Margin = new System.Windows.Forms.Padding(0);
            this.pos1.Name = "pos1";
            this.pos1.Size = new System.Drawing.Size(56, 30);
            this.pos1.TabIndex = 10;
            this.pos1.Text = "1";
            this.pos1.UseVisualStyleBackColor = false;
            // 
            // pos2
            // 
            this.pos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(205)))));
            this.pos2.Enabled = false;
            this.pos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos2.Location = new System.Drawing.Point(56, 0);
            this.pos2.Margin = new System.Windows.Forms.Padding(0);
            this.pos2.Name = "pos2";
            this.pos2.Size = new System.Drawing.Size(56, 30);
            this.pos2.TabIndex = 11;
            this.pos2.Text = "2";
            this.pos2.UseVisualStyleBackColor = false;
            // 
            // pos3
            // 
            this.pos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(205)))));
            this.pos3.Enabled = false;
            this.pos3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos3.Location = new System.Drawing.Point(112, 0);
            this.pos3.Margin = new System.Windows.Forms.Padding(0);
            this.pos3.Name = "pos3";
            this.pos3.Size = new System.Drawing.Size(56, 30);
            this.pos3.TabIndex = 12;
            this.pos3.Text = "3";
            this.pos3.UseVisualStyleBackColor = false;
            // 
            // pos4
            // 
            this.pos4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(205)))));
            this.pos4.Enabled = false;
            this.pos4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos4.Location = new System.Drawing.Point(168, 0);
            this.pos4.Margin = new System.Windows.Forms.Padding(0);
            this.pos4.Name = "pos4";
            this.pos4.Size = new System.Drawing.Size(56, 30);
            this.pos4.TabIndex = 13;
            this.pos4.Text = "4";
            this.pos4.UseVisualStyleBackColor = false;
            // 
            // pos5
            // 
            this.pos5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(205)))));
            this.pos5.Enabled = false;
            this.pos5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos5.Location = new System.Drawing.Point(224, 0);
            this.pos5.Margin = new System.Windows.Forms.Padding(0);
            this.pos5.Name = "pos5";
            this.pos5.Size = new System.Drawing.Size(56, 30);
            this.pos5.TabIndex = 14;
            this.pos5.Text = "5";
            this.pos5.UseVisualStyleBackColor = false;
            // 
            // pos6
            // 
            this.pos6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(205)))));
            this.pos6.Enabled = false;
            this.pos6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos6.Location = new System.Drawing.Point(280, 0);
            this.pos6.Margin = new System.Windows.Forms.Padding(0);
            this.pos6.Name = "pos6";
            this.pos6.Size = new System.Drawing.Size(56, 30);
            this.pos6.TabIndex = 15;
            this.pos6.Text = "6";
            this.pos6.UseVisualStyleBackColor = false;
            // 
            // pos7
            // 
            this.pos7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(205)))));
            this.pos7.Enabled = false;
            this.pos7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos7.Location = new System.Drawing.Point(336, 0);
            this.pos7.Margin = new System.Windows.Forms.Padding(0);
            this.pos7.Name = "pos7";
            this.pos7.Size = new System.Drawing.Size(56, 30);
            this.pos7.TabIndex = 16;
            this.pos7.Text = "7";
            this.pos7.UseVisualStyleBackColor = false;
            // 
            // pos8
            // 
            this.pos8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(205)))));
            this.pos8.Enabled = false;
            this.pos8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos8.Location = new System.Drawing.Point(392, 0);
            this.pos8.Margin = new System.Windows.Forms.Padding(0);
            this.pos8.Name = "pos8";
            this.pos8.Size = new System.Drawing.Size(56, 30);
            this.pos8.TabIndex = 17;
            this.pos8.Text = "8";
            this.pos8.UseVisualStyleBackColor = false;
            // 
            // pos9
            // 
            this.pos9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(205)))));
            this.pos9.Enabled = false;
            this.pos9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos9.Location = new System.Drawing.Point(448, 0);
            this.pos9.Margin = new System.Windows.Forms.Padding(0);
            this.pos9.Name = "pos9";
            this.pos9.Size = new System.Drawing.Size(56, 30);
            this.pos9.TabIndex = 18;
            this.pos9.Text = "9";
            this.pos9.UseVisualStyleBackColor = false;
            // 
            // pos10
            // 
            this.pos10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(205)))));
            this.pos10.Enabled = false;
            this.pos10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos10.Location = new System.Drawing.Point(504, 0);
            this.pos10.Margin = new System.Windows.Forms.Padding(0);
            this.pos10.Name = "pos10";
            this.pos10.Size = new System.Drawing.Size(56, 30);
            this.pos10.TabIndex = 19;
            this.pos10.Text = "10";
            this.pos10.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pos1);
            this.flowLayoutPanel2.Controls.Add(this.pos2);
            this.flowLayoutPanel2.Controls.Add(this.pos3);
            this.flowLayoutPanel2.Controls.Add(this.pos4);
            this.flowLayoutPanel2.Controls.Add(this.pos5);
            this.flowLayoutPanel2.Controls.Add(this.pos6);
            this.flowLayoutPanel2.Controls.Add(this.pos7);
            this.flowLayoutPanel2.Controls.Add(this.pos8);
            this.flowLayoutPanel2.Controls.Add(this.pos9);
            this.flowLayoutPanel2.Controls.Add(this.pos10);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(205, 76);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(567, 35);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::QQSSApp.Properties.Resources.ODS_05;
            this.pictureBox2.Location = new System.Drawing.Point(439, 180);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // reloj_circular
            // 
            this.reloj_circular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reloj_circular.BackColor = System.Drawing.Color.Transparent;
            this.reloj_circular.Image = global::QQSSApp.Properties.Resources.circulo1;
            this.reloj_circular.Location = new System.Drawing.Point(246, 117);
            this.reloj_circular.Margin = new System.Windows.Forms.Padding(2);
            this.reloj_circular.Name = "reloj_circular";
            this.reloj_circular.Size = new System.Drawing.Size(477, 228);
            this.reloj_circular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reloj_circular.TabIndex = 6;
            this.reloj_circular.TabStop = false;
            // 
            // puntuacionPos
            // 
            this.puntuacionPos.AutoSize = true;
            this.puntuacionPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacionPos.ForeColor = System.Drawing.Color.White;
            this.puntuacionPos.Location = new System.Drawing.Point(413, 16);
            this.puntuacionPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puntuacionPos.Name = "puntuacionPos";
            this.puntuacionPos.Size = new System.Drawing.Size(37, 39);
            this.puntuacionPos.TabIndex = 27;
            this.puntuacionPos.Text = "0";
            this.puntuacionPos.Click += new System.EventHandler(this.label1_Click);
            // 
            // PartidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 568);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.enunciado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.op3);
            this.Controls.Add(this.op4);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.reloj_circular);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PartidaForm";
            this.Text = "Partida";
            this.Load += new System.EventHandler(this.PartidaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reloj_circular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button op1;
        private System.Windows.Forms.Button op2;
        private System.Windows.Forms.Button op4;
        private System.Windows.Forms.Button op3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox reloj_circular;
        private System.Windows.Forms.Label enunciado;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.Button pos1;
        private System.Windows.Forms.Button pos2;
        private System.Windows.Forms.Button pos3;
        private System.Windows.Forms.Button pos4;
        private System.Windows.Forms.Button pos5;
        private System.Windows.Forms.Button pos6;
        private System.Windows.Forms.Button pos7;
        private System.Windows.Forms.Button pos8;
        private System.Windows.Forms.Button pos9;
        private System.Windows.Forms.Button pos10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPuntuacionAcumulada;
  
        private System.Windows.Forms.Label label4;
       
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label puntuaciónNegativa;
        private System.Windows.Forms.Label puntuacionPos;
    }
}