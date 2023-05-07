namespace QQSSApp
{
    partial class Usuario
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.puntuacion = new System.Windows.Forms.Label();
            this.VolverButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CerrarSesionButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ColumnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.AciertosLabel = new System.Windows.Forms.Label();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nivel:";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.Location = new System.Drawing.Point(50, 207);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(84, 91);
            this.nivel.TabIndex = 1;
            this.nivel.Text = "0";
            this.nivel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puntuación:";
            // 
            // puntuacion
            // 
            this.puntuacion.AutoSize = true;
            this.puntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacion.Location = new System.Drawing.Point(391, 196);
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.Size = new System.Drawing.Size(84, 91);
            this.puntuacion.TabIndex = 3;
            this.puntuacion.Text = "0";
            // 
            // VolverButton
            // 
            this.VolverButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.VolverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverButton.ForeColor = System.Drawing.Color.White;
            this.VolverButton.Location = new System.Drawing.Point(47, 826);
            this.VolverButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(287, 46);
            this.VolverButton.TabIndex = 4;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = false;
            this.VolverButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 76);
            this.panel1.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(11, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(254, 29);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "*nombre de usuario*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(854, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________";
            // 
            // CerrarSesionButton
            // 
            this.CerrarSesionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.CerrarSesionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesionButton.ForeColor = System.Drawing.Color.White;
            this.CerrarSesionButton.Location = new System.Drawing.Point(654, 826);
            this.CerrarSesionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CerrarSesionButton.Name = "CerrarSesionButton";
            this.CerrarSesionButton.Size = new System.Drawing.Size(287, 46);
            this.CerrarSesionButton.TabIndex = 7;
            this.CerrarSesionButton.Text = "Cerrar Sesión";
            this.CerrarSesionButton.UseVisualStyleBackColor = false;
            this.CerrarSesionButton.Click += new System.EventHandler(this.CerrarSesionButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.ForeColor = System.Drawing.Color.White;
            this.ModificarButton.Location = new System.Drawing.Point(47, 761);
            this.ModificarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(894, 46);
            this.ModificarButton.TabIndex = 9;
            this.ModificarButton.Text = "Modificar Datos";
            this.ModificarButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "COBERTURA ODS";
            // 
            // ColumnChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ColumnChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ColumnChart.Legends.Add(legend1);
            this.ColumnChart.Location = new System.Drawing.Point(-44, 3);
            this.ColumnChart.Name = "ColumnChart";
            this.ColumnChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ColumnChart.Series.Add(series1);
            this.ColumnChart.Size = new System.Drawing.Size(894, 359);
            this.ColumnChart.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(748, 101);
            this.label6.MaximumSize = new System.Drawing.Size(150, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 87);
            this.label6.TabIndex = 12;
            this.label6.Text = "Porcentaje de Aciertos:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AciertosLabel
            // 
            this.AciertosLabel.AutoSize = true;
            this.AciertosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AciertosLabel.Location = new System.Drawing.Point(709, 207);
            this.AciertosLabel.Name = "AciertosLabel";
            this.AciertosLabel.Size = new System.Drawing.Size(201, 91);
            this.AciertosLabel.TabIndex = 13;
            this.AciertosLabel.Text = "40%";
            // 
            // PieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PieChart.Legends.Add(legend2);
            this.PieChart.Location = new System.Drawing.Point(0, 0);
            this.PieChart.Name = "PieChart";
            this.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.PieChart.Size = new System.Drawing.Size(894, 359);
            this.PieChart.TabIndex = 15;
            this.PieChart.Text = "chart2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(47, 383);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PieChart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ColumnChart);
            this.splitContainer1.Size = new System.Drawing.Size(894, 359);
            this.splitContainer1.SplitterDistance = 863;
            this.splitContainer1.TabIndex = 16;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 898);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.AciertosLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.CerrarSesionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.puntuacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label puntuacion;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CerrarSesionButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart ColumnChart;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AciertosLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}