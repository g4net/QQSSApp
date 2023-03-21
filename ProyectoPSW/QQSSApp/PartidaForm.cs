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
        Pregunta p;
        List<Respuesta> respuestas;
        public PartidaForm(IQQSSService service)
        {
            InitializeComponent();
            this.service = service;
            
        }

        private void PartidaForm_Load(object sender, EventArgs e)
        {
            this.service.Login("1235");
            
            partida = this.service.GetPartida(1, 400);
            retos = partida.GetRetos();
            p = (Pregunta) retos.First();
            this.labelPuntuacionAcumulada.Text = partida.getPuntuacionPartida();
            enunciado.Text = p.Enunciado;
            labelPuntuacionAcierto.Text = p.GetPuntuacionAcierto();
            labelPuntuacionFallo.Text = p.GetPuntuacionFallo();
            respuestas = service.AnswerShuffle(p);
            op1.Text = respuestas.ElementAt(0).getText();
            op2.Text = respuestas.ElementAt(1).getText();
            op3.Text = respuestas.ElementAt(2).getText();
            op4.Text = respuestas.ElementAt(3).getText();

        }

        private void op1_click(object sender, EventArgs e)
        {
            if (service.TestAnswer(op1.Text, p))
            {
                this.Hide();
                PuntuacionPositiva partidag = new PuntuacionPositiva(service);
                partidag.FormClosed += (s, args) => this.Show();
                partidag.Show();
            }
            else {
                this.Hide();
                PuntuacionNegativa partidab = new PuntuacionNegativa(service);
                partidab.FormClosed += (s, args) => this.Show();
                partidab.Show();
            }
        }

        private void op2_Click(object sender, EventArgs e)
        {
            if (service.TestAnswer(op2.Text, p))
            {
                this.Hide();
                PuntuacionPositiva partidag = new PuntuacionPositiva(service);
                partidag.FormClosed += (s, args) => this.Show();
                partidag.Show();
            }
            else
            {
                this.Hide();
                PuntuacionNegativa partidab = new PuntuacionNegativa(service);
                partidab.FormClosed += (s, args) => this.Show();
                partidab.Show();
            }
        
        }

        private void op3_Click(object sender, EventArgs e)
        {
            if (service.TestAnswer(op3.Text, p))
            {
            this.Hide();
            PuntuacionPositiva partidag = new PuntuacionPositiva(service);
            partidag.FormClosed += (s, args) => this.Show();
            partidag.Show();
        }
        else
        {
            this.Hide();
            PuntuacionNegativa partidab = new PuntuacionNegativa(service);
            partidab.FormClosed += (s, args) => this.Show();
            partidab.Show();
        
    }
        }

        private void op4_Click(object sender, EventArgs e)
        {
            if (service.TestAnswer(op4.Text, p))
            {

                this.Hide();
                PuntuacionPositiva partidag = new PuntuacionPositiva(service);
                partidag.FormClosed += (s, args) => this.Show();
                partidag.Show();
            }
            else
            {
                this.Hide();
                PuntuacionNegativa partidab = new PuntuacionNegativa(service);
                partidab.FormClosed += (s, args) => this.Show();
                partidab.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
