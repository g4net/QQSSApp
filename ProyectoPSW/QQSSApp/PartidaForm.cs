using ProyectoPSWMain.Entities;
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
        Partida partida;
        Pregunta pregunta;
        List<Respuesta> respuestas;
        private List<Image> images;
        private List<Image> ods;
        private int currentImageIndex = 0;
        int retoindex;
        int tiempoContador;
        int error;
        public PartidaForm()
        {
            InitializeComponent();
            InitializeImages();
            this.CenterToScreen();
            this.retoindex = QQSS.service.GetProgressIndex();
            this.error = QQSS.service.GetError();
            this.partida = QQSS.service.GetPartida();
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

        private void HabilitarBotonAbandonar()
        {
            botonAbandonar.Enabled = QQSS.service.GetConsolidado();
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
            int error = QQSS.service.GetError();
           
            if (QQSS.service.TestAnswer(optext))
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
                if (QQSS.service.GetError() != ) respuestaFallada = new PartidaPerdida();
                else respuestaFallada = new PuntuacionNegativa();
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
                QQSS.service.AbandonarPartida();
                Consolidar consolidarForm = new Consolidar();
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
            pregunta = (Pregunta) QQSS.service.GetReto();
            enunciado.Text = pregunta.Enunciado;
            puntuacionPos.Text = pregunta.GetPuntuacionAcierto();
            puntuaciónNegativa.Text = pregunta.GetPuntuacionFallo();
            respuestas = QQSS.service.GetRespuestas();
            op1.Text = respuestas.ElementAt(0).getText();
            op2.Text = respuestas.ElementAt(1).getText();
            op3.Text = respuestas.ElementAt(2).getText();
            op4.Text = respuestas.ElementAt(3).getText();
        }
    }
}
