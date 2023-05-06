﻿using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
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
    public partial class PartidaDescubrirFrase : Form
    {
        int retoindex;
        int error;
        Frase frase;
        private int currentImageIndex;
        private List<Image> images;
        private List<Image> ods;
        private int tiempoContador;
        private int tiempodeMostrarRta;
        bool esCorrecta;

        public PartidaDescubrirFrase()
        {
            InitializeComponent();
            InitializeImages();
            this.CenterToScreen();
            this.frase = (Frase) QQSS.service.GetReto();
            this.retoindex = QQSS.service.GetProgressIndex();
            this.error = QQSS.service.GetError();
            this.labelPuntuacionAcumulada.Text = QQSS.service.GetPuntuacionPartida().ToString();
            this.puntuacionConsolidadaLabel.Text = QQSS.service.GetPuntuacionConsolidada().ToString();
            InitializeRetoFrase();
            MarcarProgreso();
            InitializeTimers();
            InitializeODS();
            HabilitarBotonAbandonar();
            QQSS.service.PlaySonido("musicaFondo" + GetRandomNumber(7));
        }


        public void InitializeRetoFrase()
        {
            List<char> huecos;

            char [] textoFrase = QQSS.service.QuitarLetras(out huecos).ToCharArray();

            enunciado.Text = frase.Descripcion;

            puntuacionPos.Text = frase.Puntuacion_acierto.ToString();
            puntuaciónNegativa.Text = (frase.Puntuacion_acierto * 2).ToString();

            for (int i = 0; i <= 70; i++)
            {
                string nombreLabel = "letra" + i;
                Control[] controles = this.Controls.Find(nombreLabel, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Label b = (Label)controles[0];
                if (i >= textoFrase.Length) { b.Hide(); continue; }
                b.Text = "" + textoFrase[i];
            }

            for(int i = 0; i<= 49; i++)
            {
                string nombreLabel = "letraHueco" + i;
                Control[] controles = this.Controls.Find(nombreLabel, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Label b = (Label)controles[0];
                if (i >= huecos.Count) { b.Hide(); continue; }
                b.Text = "" + huecos[i];
            }

        }
        public string GetRandomNumber(int maxNumber)
        {
            Random random = new Random();
            return random.Next(maxNumber).ToString();
        }

        private void HabilitarBotonAbandonar()
        {
            botonAbandonar.Enabled = QQSS.service.GetConsolidado();
        }
        private void MarcarProgreso()
        {
            for (int i = 0; i <= (retoindex); i++)
            {
                string nombreBoton = "pos" + i;
                Control[] controles = this.Controls.Find(nombreBoton, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Button b = (Button)controles[0];
                if (i == retoindex)
                {
                    b.BackColor = Color.YellowGreen;
                }
                else b.BackColor = Color.DarkSeaGreen;
                if (i == QQSS.service.GetError()) { b.BackColor = Color.LightCoral; }
            }
        }

        public void InitializeImages()
        {
            images = new List<Image>();
            ods = new List<Image>();

            for (int i = 1; i <= 18; i++)
            {
                string image = "circulo" + i;
                Image imagen = (System.Drawing.Bitmap)QQSSApp.Properties.Resources.ResourceManager.GetObject(image);
                images.Add(imagen);
            }

            for (int i = 0; i <= 17; i++)
            {
                string image = "ODS_" + i;
                Image imagen = (System.Drawing.Bitmap)QQSSApp.Properties.Resources.ResourceManager.GetObject(image);
                ods.Add(imagen);
            }

        }

        public void InitializeODS()
        {
            ods_picture.Image = ods[0];
            if (frase.MuestraImagen) ods_picture.Image = ods[frase.Ods];
        }

        private void TimerTick(object sender, EventArgs e)
        {
            currentImageIndex++;

            if (currentImageIndex >= images.Count) currentImageIndex = 0;

            reloj_circular.Image = images[currentImageIndex];
        }

        private void Atras(object sender, EventArgs e)
        {
            Confirmar confirmarForm = new Confirmar(this);
            confirmarForm.ShowDialog();
        }

        public void CheckAnswer(string fraseFormada)
        {
            timer3.Interval = 1000;
            timer3.Start();
            timer1.Stop();
            timer2.Stop();

            esCorrecta = true;
        }

        private void TimerTiempoTick(object sender, EventArgs e)
        {
            tiempoContador--;
            tiempo.Text = tiempoContador.ToString();
            if (tiempoContador == 0)
            {

                CheckAnswer(null);
            }
        }

        private void InitializeTimers()
        {
            timer1.Interval = 1764;
            timer1.Start();
            timer2.Interval = 1000;
            tiempoContador = 30;
            timer2.Start();
            tiempodeMostrarRta = 3;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tiempodeMostrarRta--;

            if (tiempodeMostrarRta != 0) return;

            if(esCorrecta)
            {
                Form respuestaAcertada;
                if (retoindex != 9) respuestaAcertada = new PuntuacionPositiva();
                else respuestaAcertada = new PartidaGanada();
                respuestaAcertada.Show();
                this.Close();
            }
            else
            {
                Form respuestaFallada;
                if (QQSS.service.GetError() != -1) respuestaFallada = new PartidaPerdida();
                else respuestaFallada = new PuntuacionNegativa();
                respuestaFallada.Show();
                this.Close();
            }

        }

    }
}
