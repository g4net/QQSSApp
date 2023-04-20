using ProyectoPSWMain.Services;
using ProyectoPSWMain.Entities;
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
    public partial class PuntuacionNegativa : Form
    {
        IQQSSService service;
        int retoindex;
        int errores;
        Pregunta pregunta;
        public PuntuacionNegativa(IQQSSService service, int index)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.service = service;
            this.retoindex = index;
            this.errores = service.GetErrores();
            InitializeNegativePunctuation();

            string ruta = service.GetRutaSonido("respuestaIncorrecta");
            service.Play(ruta);
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 15000;
            timer1.Start();
        }

        private void ButtonReintentarClick(object sender, EventArgs e)
        {
            service.PreguntaExtra(retoindex);
            PartidaForm partida = new PartidaForm(service, retoindex);
            partida.Show();
            this.Close();
        }
        private void InitializeNegativePunctuation()
        {
            pregunta = service.QuestionServIndex(retoindex);
            puntuacion.Text = pregunta.GetPuntuacionFallo();
            punt_actual.Text = service.GetPartidaActual().PuntuacionPartida.ToString();
        }
    }
}
