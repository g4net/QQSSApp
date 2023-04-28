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
        public PartidaGanada()
        {
            InitializeComponent();
            this.CenterToScreen();
            QQSS.service.PlaySonido("PartidaGanada");
            InitializePartidaGanada();
        }

        private void continuar_salir_Click(object sender, EventArgs e)
        {
            QQSS.service.RetoAcertado();
            QQSS.service.GanarPartida();
            PantallaPrincipalForm pantallaPrincipal = new PantallaPrincipalForm();
            pantallaPrincipal.Show();
            this.Close();
        }
        private void InitializePartidaGanada()
        {
            pregunta = (Pregunta) QQSS.service.GetReto();
            puntuacion.Text = pregunta.GetPuntuacionAcierto();
            puntuacion_partida.Text = QQSS.service.GetPuntuacionPartida().ToString();
            puntuacion_total.Text = QQSS.service.GetLoggedUser().PuntuacionAcumulada.ToString();
        }
      
    }
}
