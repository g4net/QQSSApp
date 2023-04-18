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
        IQQSSService service;
        Pregunta pregunta;
        int retoindex;
        bool consolidado;
        public PuntuacionPositiva(IQQSSService service, int index)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.service = service;
            this.consolidado = service.IsConsolidado();
            consolidar.Enabled = !consolidado;
            retoindex = index;
            DeshabilitarBotonConsolidar();
            InitializePositivePunctuation();

            string ruta = service.GetRutaSonido("respuestaCorrecta");
            service.Play(ruta);
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 15000;
            timer1.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.retoindex++;
            PartidaForm partida = new PartidaForm(service, retoindex);
            partida.Show();
            this.Close();
        }

        public void DeshabilitarBotonConsolidar()
        {
            if (service.GetConsolidado())
            {
                consolidar.Enabled = false;
            }
        }

        private void continuar_salir_Click(object sender, EventArgs e)
        {
            this.retoindex++;
            PartidaForm partida = new PartidaForm(service, retoindex);
            partida.Show();
            this.Close();
        }
        
        private void InitializePositivePunctuation()
        {
            pregunta = service.QuestionServIndex(retoindex);
            puntuacion.Text = pregunta.GetPuntuacionAcierto();
            punt_actual.Text = service.GetPartidaActual().PuntuacionPartida.ToString();
            
        }

        private void consolidar_click(object sender, EventArgs e)
        {
            service.Consolidar();
            puntuacionConsolidada.Text = service.GetPartidaActual().PuntuacionConsolidada.ToString();
            puntuacionConsolidada.Visible = true;
            textoConsolidacion.Visible = true;
            consolidar.Enabled = false;
            /*
            Consolidar Consolidar = new Consolidar(service, retoindex);
            Consolidar.Show();
            this.Close();
            */

        }
    }
}
