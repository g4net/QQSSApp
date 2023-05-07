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

            QQSS.service.PlaySonido("respuestaIncorrecta");
            InitializeTimer();
            QQSS.service.IncrementaFallos();
            QQSS.service.GetLoggedUser().RetosJugados.Add(pregunta);
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

        private void TextEnlace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void PuntuacionNegativa_Load(object sender, EventArgs e)
        {
            TextEnlace.Text = "ODS" + pregunta.Ods;
            TextEnlace.Links.Add(0, 100, QQSS.service.EnlaceInteres(pregunta.Ods));
        }
    }
}
