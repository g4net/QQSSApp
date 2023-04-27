using ProyectoPSWMain.Services;
using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QQSSApp
{
    public partial class PuntuacionNegativa : Form
    {
        Pregunta pregunta;
        public PuntuacionNegativa()
        {
            InitializeComponent();
            this.CenterToScreen();
            InitializeNegativePunctuation();

            string ruta = service.GetRutaSonido("respuestaIncorrecta");
            service.Play(ruta);
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 15000;
            timer1.Start();
        }

        private void ButtonReintentarClick(object sender, EventArgs e)
        {
            PartidaForm partida = new PartidaForm();
            partida.Show();
            this.Close();
        }
        private void InitializeNegativePunctuation()
        {
            pregunta = (Pregunta) QQSS.service.GetReto();
            respuesta.Text = pregunta.RespuestaCorrecta.ToString();
            puntuacion.Text = pregunta.GetPuntuacionFallo();
            QQSS.service.RetoFallado();
            punt_actual.Text = QQSS.service.GetPuntuacionPartida().ToString();
        }
    }
}
