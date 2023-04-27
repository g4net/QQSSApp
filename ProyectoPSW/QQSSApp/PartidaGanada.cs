using ProyectoPSWMain.Entities;
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
    public partial class PartidaGanada : Form
    {
        Pregunta pregunta;
        int retoindex;
        Partida partida;
        public PartidaGanada()
        {
            InitializeComponent();
            this.CenterToScreen();
            retoindex = QQSS.service.GetProgressIndex();
            string ruta = service.GetRutaSonido("PartidaGanada");
            service.Play(ruta);
            InitializePartidaGanada();
        }

        private void continuar_salir_Click(object sender, EventArgs e)
        {
            service.CleanProgresoPreguntas();
            PantallaPrincipalForm pantallaPrincipal = new PantallaPrincipalForm();
            pantallaPrincipal.Show();
            this.Close();
        }
        private void InitializePartidaGanada()
        {
            pregunta = QQSS.service.QuestionServIndex(retoindex);
            puntuacion.Text = pregunta.GetPuntuacionAcierto();
            puntuacion_partida.Text = pActual.PuntuacionPartida.ToString();
            //puntuacion_acumulada.Text = pActual.
                //service.GetPuntuacionAcumulada().ToString();
            service.UpdateUserScore(pActual.PuntuacionPartida);
            puntuacion_total.Text = service.GetLoggedUser().getPointsStr();
        }
      
    }
}
