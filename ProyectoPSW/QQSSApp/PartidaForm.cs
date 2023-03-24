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
            enunciado.Select();
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

            for(int i = 0; i <= 17; i++)
            {
                //ages.Add(Image.FromFile("circulo" + i + ".png"));
            }

        }

        private void op1_click(object sender, EventArgs e)
        {
            if (service.TestAnswer(op1.Text,    pregunta))
            {
                marcarProgreso(retoindex);
                this.retoindex++;
                PuntuacionPositiva partidag = new PuntuacionPositiva(service, this.retos, this.retoindex, this.partida);
                partidag.Show();
                this.Close();
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
                marcarProgreso(retoindex);
                this.retoindex++;
                PuntuacionPositiva partidag = new PuntuacionPositiva(service, this.retos, this.retoindex, this.partida);
                partidag.Show();
                this.Close();
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
                marcarProgreso(retoindex);
                this.retoindex++;
                PuntuacionPositiva partidag = new PuntuacionPositiva(service, this.retos, this.retoindex, this.partida);
                partidag.Show();
                this.Close();
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
                marcarProgreso(retoindex);
                this.retoindex++;
                PuntuacionPositiva partidag = new PuntuacionPositiva(service, this.retos, this.retoindex, this.partida);
                partidag.Show();
                this.Close();
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

        private void Atras(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPrincipalForm menu = new PantallaPrincipalForm(service);
            menu.FormClosed += (s, args) => this.Show();
            menu.Show();
        }

        /**private void Enter1(object sender, EventArgs e)
        {
            op1.BackColor = Color.LawnGreen;
            op1.ForeColor = Color.White;
        }

        private void Leave1(object sender, EventArgs e)
        {
            op1.BackColor = Color.White;
            op1.ForeColor= Color.Black;
        }**/
    }
}
