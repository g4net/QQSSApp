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
            QQSS.service.IncrementaAciertos();
            QQSS.service.GetLoggedUser().RetosSuperados.Add(pregunta);
            QQSS.service.GetLoggedUser().RetosJugados.Add(pregunta);
        }

        private void continuar_salir_Click(object sender, EventArgs e)
        {
            QQSS.service.GanarPartida();
            PantallaPrincipalForm pantallaPrincipal = new PantallaPrincipalForm();
            pantallaPrincipal.Show();
            this.Close();
        }
        private void InitializePartidaGanada()
        {
            pregunta = (Pregunta) QQSS.service.GetReto();
            puntuacion.Text = pregunta.GetPuntuacionAcierto();
            QQSS.service.RetoAcertado();
            puntuacion_partida.Text = QQSS.service.GetPuntuacionPartida().ToString();
            puntuacion_total.Text = QQSS.service.GetLoggedUser().PuntuacionAcumulada.ToString();
        }

        private void TextEnlace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void PartidaGanada_Load(object sender, EventArgs e)
        {
            TextEnlace.Text = "ODS" + pregunta.Ods;
            TextEnlace.Links.Add(0, 100, QQSS.service.EnlaceInteres(pregunta.Ods));
        }
    }
}
