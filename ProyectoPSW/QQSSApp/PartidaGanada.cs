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
        Reto reto;
        public PartidaGanada()
        {
            InitializeComponent();
            this.CenterToScreen();
            QQSS.service.PlaySonido("PartidaGanada");
            InitializePartidaGanada();
            QQSS.service.GetLoggedUser().RetosSuperados.Add(reto);
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
            reto = QQSS.service.GetReto();
            puntuacion.Text = reto.Puntuacion_acierto.ToString();
            QQSS.service.RetoAcertado(reto);
            puntuacion_partida.Text = QQSS.service.GetPuntuacionPartida().ToString();
            puntuacion_total.Text = QQSS.service.GetLoggedUser().PuntuacionAcumulada.ToString();
        }

        private void TextEnlace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void PartidaGanada_Load(object sender, EventArgs e)
        {
            TextEnlace.Text = "ODS" + reto.Ods;
            TextEnlace.Links.Add(0, 100, QQSS.service.EnlaceInteres(reto.Ods));
        }
    }
}
