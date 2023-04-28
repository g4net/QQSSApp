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
        Pregunta pregunta;
        int retoindex;
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
        }

        private void InitializeTimer()
        {
            timer1.Interval = 15000;
            timer1.Start();
        }


        private void continuar_salir_Click(object sender, EventArgs e)
        {
            this.retoindex++;
            PartidaForm partida = new PartidaForm();
            partida.Show();
            this.Close();
        }
        
        private void InitializePositivePunctuation()
        {
            pregunta = (Pregunta) QQSS.service.GetReto();
            puntuacion.Text = pregunta.GetPuntuacionAcierto();
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
    }
}
