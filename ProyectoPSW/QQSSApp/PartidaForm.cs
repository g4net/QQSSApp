﻿using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQSSApp
{
    public partial class PartidaForm : Form
    {
        IQQSSService service;
        Partida partida;
        Pregunta pregunta;
        List<Respuesta> respuestas;
        private List<Image> images;
        private List<Image> ods;
        private int currentImageIndex = 0;
        int retoindex;
        int tiempoContador;
        int errores;
        List<int> progresoPreguntas;
        public PartidaForm(IQQSSService service, int index)
        {
            InitializeComponent();
            InitializeImages();
            this.CenterToScreen();
            this.service = service;
            progresoPreguntas = service.GetProgresoPreguntas();
            partida = service.GetPartidaActual();
            this.retoindex = index;
            this.errores = service.GetErrores();
            this.labelPuntuacionAcumulada.Text = partida.PuntuacionPartida.ToString();
            this.puntuacionConsolidadaLabel.Text = partida.PuntuacionConsolidada.ToString();
            InitializeRetoPregunta();
            MarcarProgreso();
            InitializeTimers();
            InitializeODS();
            HabilitarBotonAbandonar();
            string ruta = service.GetRutaSonido("musicaFondo" + GetRandomNumber(7));
            service.Play(ruta);
            //Prueba();
        }

        public string GetRandomNumber(int maxNumber)
        {
            Random random = new Random();
            return random.Next(maxNumber).ToString();
        }

        /*private void Prueba()
        {
            String aux = "";
            for (int i = 0; i < progresoPreguntas.Count; i++) { aux += progresoPreguntas[i].ToString(); }
            erroreslabel.Text = aux;
        }*/

        private void HabilitarBotonAbandonar()
        {
            if (service.GetConsolidado())
            {
                botonAbandonar.Enabled = true;
            }
        }
        private void MarcarProgreso() 
        {
            for(int i = 0; i <= (retoindex); i++)
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
                if (progresoPreguntas.Contains(i)) { b.BackColor = Color.LightCoral; }
            }
        }

        public void InitializeImages()
        {
            images = new List<Image>();
            ods = new List<Image>();
            
            for (int i = 1; i <= 18; i++)
            {
                string image = "circulo" + i;
                Image imagen = (System.Drawing.Bitmap) QQSSApp.Properties.Resources.ResourceManager.GetObject(image);
                images.Add(imagen);
            }

            for(int i= 0; i <= 17; i++)
            {
                string image = "ODS_" + i;
                Image imagen = (System.Drawing.Bitmap) QQSSApp.Properties.Resources.ResourceManager.GetObject(image);
                ods.Add(imagen);
            }

        }

        public void InitializeODS()
        {
            ods_picture.Image = ods[0];
            if (pregunta.MuestraImagen) ods_picture.Image = ods[pregunta.Ods];
        }

        private void op1_click(object sender, EventArgs e)
        {
            CheckAnswer(op1.Text);
        }

        private void op2_Click(object sender, EventArgs e)
        {
            CheckAnswer(op2.Text);

        }

        private void op3_Click(object sender, EventArgs e)
        {
            CheckAnswer(op3.Text);
        }

        private void op4_Click(object sender, EventArgs e)
        {
            CheckAnswer(op4.Text);
        }

        private void CheckAnswer(string optext)
        {
           
            if (service.TestAnswer(optext, pregunta))
            {
                //if (progresoPreguntas.Contains(retoindex)) { service.ProgresoDeletePreguntaFallada(retoindex); }
                //progresoPreguntas = service.GetProgresoPreguntas();
                Form respuestaAcertada;
                service.SetPuntuacionAcumulada(pregunta.Puntuacion_acierto);
                service.UpdateGameScore(pregunta.Puntuacion_acierto);
                service.UpdateUserQuestions(pregunta);
                if (retoindex != 9) respuestaAcertada = new PuntuacionPositiva(service, this.retoindex);
                else respuestaAcertada = new PartidaGanada(service, retoindex);
                respuestaAcertada.Show();
                this.Close();
            }
            else
            {
                Form respuestaFallada;
                service.SetPuntuacionAcumulada(pregunta.PuntuacionFallo());
                service.UpdateGameScore(pregunta.PuntuacionFallo());
                service.UpdateErrores();
                service.ProgresoAddPreguntaFallada(retoindex);
                progresoPreguntas = service.GetProgresoPreguntas();
                if (errores == 1) respuestaFallada = new PartidaPerdida(service, this.retoindex);
                else respuestaFallada = new PuntuacionNegativa(service, this.retoindex);
                respuestaFallada.Show();
                this.Close();
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            currentImageIndex++;

            if (currentImageIndex >= images.Count) currentImageIndex = 0;

            reloj_circular.Image = images[currentImageIndex];
        }

        private void Atras(object sender, EventArgs e) 
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea abandonar la partida actual (perderá los puntos no consolidados)?",
                                                  "Confirmación de abandono",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                service.UpdateUserScore(Math.Min(partida.PuntuacionPartida, partida.PuntuacionConsolidada));
                Consolidar consolidarForm = new Consolidar(service);
                consolidarForm.Show();
                this.Close();
            }

            
        }

        private void TimerTiempoTick(object sender, EventArgs e)
        {
            tiempoContador--;
            tiempo.Text = tiempoContador.ToString();
            if (tiempoContador == 0) CheckAnswer("");
        }

        private void InitializeTimers()
        {
            timer1.Interval = 1764;
            timer1.Start();
            timer2.Interval = 1000;
            tiempoContador = 30;
            timer2.Start();
        }

        private void InitializeRetoPregunta()
        {
            pregunta = service.QuestionServIndex(retoindex);
            enunciado.Text = pregunta.Enunciado;
            puntuacionPos.Text = pregunta.GetPuntuacionAcierto();
            puntuaciónNegativa.Text = pregunta.GetPuntuacionFallo();
            respuestas = service.AnswerShuffle(pregunta);
            op1.Text = respuestas.ElementAt(0).getText();
            op2.Text = respuestas.ElementAt(1).getText();
            op3.Text = respuestas.ElementAt(2).getText();
            op4.Text = respuestas.ElementAt(3).getText();
        }
    }
}
