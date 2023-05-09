using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace QQSSApp
{
    public partial class PuntuacionPositiva : Form
    {
        Reto reto;
        bool consolidado;
        public PuntuacionPositiva()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.consolidado = QQSS.service.GetConsolidado();
            InitializePositivePunctuation();
            consolidar.Enabled = !consolidado;
            QQSS.service.PlaySonido("respuestaCorrecta");
            InitializeTimer();
            QQSS.service.GetLoggedUser().RetosSuperados.Add(reto);
        }

        private void InitializeTimer()
        {
            timer1.Interval = 15000;
            timer1.Start();
        }


        private void continuar_salir_Click(object sender, EventArgs e)
        {
            Form partida = new Form();
            if (reto is Pregunta) partida = new PartidaForm();
            else if (reto is Frase) partida = new PartidaDescubrirFrase();
            partida.Show();
            this.Close();
        }
        
        private void InitializePositivePunctuation()
        {
            reto = QQSS.service.GetReto();
            //puntuacion.Text = reto.Puntuacion_acierto.ToString();
            puntuacion.Text = QQSS.service.GetPuntuacionReto().ToString();
            QQSS.service.RetoAcertado();
            punt_actual.Text = QQSS.service.GetPuntuacionPartida().ToString();
        }

        private void consolidar_click(object sender, EventArgs e)
        {
            QQSS.service.Consolidar();
            puntuacionConsolidada.Text = QQSS.service.GetPuntuacionConsolidada().ToString();
            puntuacionConsolidada.Visible = true;
            textoConsolidacion.Visible = true;
            consolidar.Enabled = false;
        }

        private void TextEnlace_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void PuntuacionPositiva_Load(object sender, EventArgs e)
        {
            TextEnlace.Text = "ODS" + reto.Ods;
            TextEnlace.Links.Add(0,100, QQSS.service.EnlaceInteres(reto.Ods));
        }
    }
}
