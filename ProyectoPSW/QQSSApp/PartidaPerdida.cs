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
    public partial class PartidaPerdida : Form
    {
        Pregunta pregunta;
        
        public PartidaPerdida()
        {
            InitializeComponent();
            this.CenterToScreen();
            puntuacion_acumulada.Text = "0";
            pregunta = (Pregunta) QQSS.service.GetReto();
            QQSS.service.PlaySonido("PartidaPerdida");
            respuesta.Text = pregunta.RespuestaCorrecta.ToString();
            QQSS.service.IncrementaFallos();
            QQSS.service.GetLoggedUser().RetosJugados.Add(pregunta);
        }


        private void reintentar_salir_Click(object sender, EventArgs e)
        {
            QQSS.service.PerderPartida();
            PantallaPrincipalForm pantallaPrincipal = new PantallaPrincipalForm();
            pantallaPrincipal.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextEnlace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void PartidaPerdida_Load(object sender, EventArgs e)
        {
            TextEnlace.Text = "ODS" + pregunta.Ods;
            TextEnlace.Links.Add(0, 100, QQSS.service.EnlaceInteres(pregunta.Ods));
        }
    }
}
