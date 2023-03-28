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
        IQQSSService service;
        Partida partida;
        Pregunta pregunta;
        List<Respuesta> respuestas;
        private List<Image> images;
        private List<Image> ods;
        private int currentImageIndex = 0;
        int retoindex;
        public PartidaForm(IQQSSService service, int index)
        {
            InitializeComponent();
            InitializeImages();
            timer1.Interval = 1764;
            timer1.Start();
            this.service = service;
            
            partida = service.GetPartidaActual();
            this.retoindex = index;
            


            
            pregunta = service.QuestionServIndex(index);
            this.labelPuntuacionAcumulada.Text = partida.getPuntuacionPartida();
            enunciado.Text = pregunta.Enunciado;
            puntuacionPos.Text = pregunta.GetPuntuacionAcierto();
            puntuaciónNegativa.Text = pregunta.GetPuntuacionFallo();
            respuestas = service.AnswerShuffle(pregunta);
            op1.Text = respuestas.ElementAt(0).getText();
            op2.Text = respuestas.ElementAt(1).getText();
            op3.Text = respuestas.ElementAt(2).getText();
            op4.Text = respuestas.ElementAt(3).getText();
            ods_picture.Image = ods.ElementAt(pregunta.Ods - 1);
            marcarProgreso(retoindex);
        }

        private void PartidaForm_Load(object sender, EventArgs e)
        {
            

        }

        private void marcarProgreso(int index) {
            string nombreBoton = "pos" + index.ToString();
            Control[] controles = this.Controls.Find(nombreBoton, true);
            if (controles.Length > 0)
            {
                Button botonActual = (Button)controles[0];

                // Verifica que el botón no sea nulo antes de intentar cambiar su color
                if (botonActual != null)
                {
                    botonActual.BackColor = Color.Yellow;
                }
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

            for(int i= 1; i <= 17; i++)
            {
                string image = "ODS_" + i;
                Image imagen = (System.Drawing.Bitmap) QQSSApp.Properties.Resources.ResourceManager.GetObject(image);
                ods.Add(imagen);
            }

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
            if(service.TestAnswer(optext, pregunta))
            {
                
                this.retoindex++;
                service.UpdateGameScore(pregunta.Puntuacion_acierto);
                PuntuacionPositiva partidag = new PuntuacionPositiva(service, this.retoindex);
                partidag.Show();
                this.Close();
            }
            else
            {
                service.UpdateGameScore(pregunta.PuntuacionFallo());
                PuntuacionNegativa partidag = new PuntuacionNegativa(service, this.retoindex);
                partidag.Show();
                this.Close();
            }

        }

        private void TimerTick(object sender, EventArgs e)
        {
            currentImageIndex++;
            if (currentImageIndex >= images.Count)
            {
                currentImageIndex = 0;
            }
            reloj_circular.Image = images[currentImageIndex];
        }
        private void Atras(object sender, EventArgs e) {
        
        }
        private void puntuacionPositiva_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void puntuaciónNegativa_Click(object sender, EventArgs e)
        {

        }
    }
}
