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
        List<Reto> retos;
        Pregunta pregunta;
        List<Respuesta> respuestas;
        private List<Image> images;
        private int currentImageIndex = 0;
        int retoindex;
        public PartidaForm(IQQSSService service, List<Reto> reto, int index, Partida partidas)
        {
            InitializeComponent();
            InitializeImages();
            timer1.Interval = 1764;
            timer1.Start();
            this.service = service;
            this.service.Login("1235");
            partida = partidas;
            this.retoindex = index;



            this.retos = reto;
            pregunta = (Pregunta)retos.ElementAt(index);
            this.labelPuntuacionAcumulada.Text = partida.getPuntuacionPartida();
            enunciado.Text = pregunta.Enunciado;
            labelPuntuacionAcierto.Text = pregunta.GetPuntuacionAcierto();
            labelPuntuacionFallo.Text = pregunta.GetPuntuacionFallo();
            respuestas = service.AnswerShuffle(pregunta);
            op1.Text = respuestas.ElementAt(0).getText();
            op2.Text = respuestas.ElementAt(1).getText();
            op3.Text = respuestas.ElementAt(2).getText();
            op4.Text = respuestas.ElementAt(3).getText();
        }

        private void PartidaForm_Load(object sender, EventArgs e)
        {
          

        }

        public void InitializeImages()
        {
            images = new List<Image>();

            for(int i = 0; i <= 17; i++)
            {
                //ages.Add(Image.FromFile("circulo" + i + ".png"));
            }

        }

        private void op1_click(object sender, EventArgs e)
        {
            if (service.TestAnswer(op1.Text,    pregunta))
            {
                this.Hide();
                PuntuacionPositiva partidag = new PuntuacionPositiva(service, this.retos, this.retoindex++, this.partida);
                partidag.FormClosed += (s, args) => this.Show();
                partidag.Show();
            }
            else {
                this.Hide();
                PuntuacionNegativa partidab = new PuntuacionNegativa(service, this.retos, this.retoindex, this.partida);
                partidab.FormClosed += (s, args) => this.Show();
                partidab.Show();
            }
        }

        private void op2_Click(object sender, EventArgs e)
        {
            if (service.TestAnswer(op2.Text, pregunta))
            {
                this.Hide();
                PuntuacionPositiva partidag = new PuntuacionPositiva(service, this.retos, this.retoindex++,this.partida);
                partidag.FormClosed += (s, args) => this.Show();
                partidag.Show();
            }
            else
            {
                this.Hide();
                PuntuacionNegativa partidab = new PuntuacionNegativa(service, this.retos, this.retoindex,this.partida);
                partidab.FormClosed += (s, args) => this.Show();
                partidab.Show();
            }
        
        }

        private void op3_Click(object sender, EventArgs e)
        {
            if (service.TestAnswer(op3.Text, pregunta))
            {
            this.Hide();
            PuntuacionPositiva partidag = new PuntuacionPositiva(service, this.retos, this.retoindex++, this.partida);
            partidag.FormClosed += (s, args) => this.Show();
            partidag.Show();
        }
        else
        {
            this.Hide();
            PuntuacionNegativa partidab = new PuntuacionNegativa(service, this.retos, this.retoindex, this.partida);
            partidab.FormClosed += (s, args) => this.Show();
            partidab.Show();
        
    }
        }

        private void op4_Click(object sender, EventArgs e)
        {
            if (service.TestAnswer(op4.Text, pregunta))
            {

                this.Hide();
                PuntuacionPositiva partidag = new PuntuacionPositiva(service, this.retos, this.retoindex++, this.partida);
                partidag.FormClosed += (s, args) => this.Show();
                partidag.Show();
            }
            else
            {
                this.Hide();
                PuntuacionNegativa partidab = new PuntuacionNegativa(service, this.retos, this.retoindex, this.partida);
                partidab.FormClosed += (s, args) => this.Show();
                partidab.Show();
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            currentImageIndex++;
            if (currentImageIndex >= images.Count)
            {
                currentImageIndex = 0;
            }
            //pictureBox1.Image = images[currentImageIndex];
        }
    }
}
