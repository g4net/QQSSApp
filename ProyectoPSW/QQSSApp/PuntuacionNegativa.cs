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
        Reto reto;
        public PuntuacionNegativa()
        {
            InitializeComponent();
            this.CenterToScreen();
            InitializeNegativePunctuation();

            QQSS.service.PlaySonido("respuestaIncorrecta");
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 15000;
            timer1.Start();
        }

        private void ButtonReintentarClick(object sender, EventArgs e)
        {
            Form partida = new Form();
            if (reto is Pregunta) partida = new PartidaForm();
            else if (reto is Frase) partida = new PartidaDescubrirFrase();
            partida.Show();
            this.Close();
        }
        private void InitializeNegativePunctuation()
        {
            reto = QQSS.service.GetReto();
            if(reto is Pregunta) respuesta.Text = (reto as Pregunta).RespuestaCorrecta.ToString();
            if(reto is Frase) respuesta.Text = (reto as Frase).Enunciado.ToString();
            //puntuacion.Text = reto.Puntuacion_acierto * 2 + "";
            puntuacion.Text = QQSS.service.GetPuntuacionReto() * 2 + "";
            QQSS.service.RetoFallado();
            punt_actual.Text = QQSS.service.GetPuntuacionPartida().ToString();
        }

        private void TextEnlace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void PuntuacionNegativa_Load(object sender, EventArgs e)
        {
            TextEnlace.Text = "ODS" + reto.Ods;
            TextEnlace.Links.Add(0, 100, QQSS.service.EnlaceInteres(reto.Ods));
        }
    }
}
