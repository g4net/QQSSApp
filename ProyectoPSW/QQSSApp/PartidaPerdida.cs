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
        Reto reto;
        
        public PartidaPerdida()
        {
            InitializeComponent();
            this.CenterToScreen();
            puntuacion_acumulada.Text = "0";
            reto = QQSS.service.GetReto();
            QQSS.service.PlaySonido("PartidaPerdida");
            if (reto is Pregunta) respuesta.Text = (reto as Pregunta).RespuestaCorrecta.ToString();
            if (reto is Frase) respuesta.Text = (reto as Frase).Enunciado.ToString();
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
            TextEnlace.Text = "ODS" + reto.Ods;
            TextEnlace.Links.Add(0, 100, QQSS.service.EnlaceInteres(reto.Ods));
        }
    }
}
