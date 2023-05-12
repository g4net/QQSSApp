using System;
using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QQSSApp
{
    public partial class Usuario : Form
    {
        User usuario;
        Form pantallaPrincipalForm;
        public Usuario(Form pantallaPrincipialForm)
        {
            InitializeComponent();
            this.usuario = QQSS.service.GetLoggedUser();
            InitializeLabels();
            InitializeGraphic();
            this.pantallaPrincipalForm = pantallaPrincipialForm;
        }

        public void InitializeLabels()
        {
            nivel.Text = usuario.nivel.ToString();
            puntuacion.Text = usuario.PuntuacionAcumulada.ToString();
            AciertosLabel.Text = CalculoPorcentajeAciertos().ToString("F2") + "%";
            NameLabel.Text = usuario.Nombre;
        }

        public void InitializeGraphic()
        {
            string[] series = { "ODS 1", "ODS 2", "ODS 3", "ODS 4", "ODS 5", "ODS 6", "ODS 7", "ODS 8", "ODS 9", "ODS 10", "ODS 11", "ODS 12", "ODS 13", "ODS 14", "ODS 15", "ODS 16", "ODS 17" };
            double[] puntos = {};
            for(int i = 0; i < series.Length; i++)
            {
                Array.Resize(ref puntos, puntos.Length + 1);
                puntos[puntos.Length - 1] = QQSS.service.GetPuntajeODS(i+1);
            }
            for (int i = 0; i < series.Length; i++)
            {
                ColumnChart.Series["Series1"].Points.AddXY(series[i], puntos[i] > 100 ? 100 : puntos[i]);
            }
            for (int i = 0; i < series.Length; i++)
            {
                Series serie = PieChart.Series.Add(series[i]);
                serie.Points.Add(puntos[i] > 100 ? 100 : puntos[i]);
            }
        }
        

        public double CalculoPorcentajeAciertos()
        {
            if (usuario.Estadistica.NumFallos == 0 && usuario.Estadistica.NumAciertos == 0) return 0;

            double aciertos = usuario.Estadistica.NumAciertos; 
            aciertos /= (usuario.Estadistica.NumAciertos + usuario.Estadistica.NumFallos); 
            aciertos *= 100;
            return  aciertos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CerrarSesionButton_Click(object sender, EventArgs e)
        {
            ConfirmarCerrarSesion confirmarForm = new ConfirmarCerrarSesion(pantallaPrincipalForm, this);
            confirmarForm.ShowDialog();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            Modificar modificarForm = new Modificar(pantallaPrincipalForm);
            modificarForm.Show();
            this.Hide();
        }

    }
}
