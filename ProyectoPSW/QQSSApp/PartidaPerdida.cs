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
    }
}
