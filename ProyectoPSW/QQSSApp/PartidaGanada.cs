﻿using ProyectoPSWMain.Entities;
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
        IQQSSService service;
        Pregunta pregunta;
        int retoindex;
        Partida pActual;
        public PartidaGanada(IQQSSService service, int index)
        {
            InitializeComponent();
            this.service = service;
            pActual = service.GetPartidaActual();
            retoindex= index;
            InitializePartidaGanada();
        }

        private void continuar_salir_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForm pantallaPrincipal = new PantallaPrincipalForm(service);
            pantallaPrincipal.Show();
            this.Close();
        }
        private void InitializePartidaGanada()
        {
            pregunta = service.QuestionServIndex(retoindex);
            puntuacion.Text = pregunta.GetPuntuacionAcierto();
            puntuacion_partida.Text = CalcularPuntTotal();
            puntuacion_acumulada.Text = pActual.getPuntuacionPartida();
            service.UpdateUserScore(pActual.PuntuacionPartida);
            puntuacion_total.Text = service.GetLoggedUser().getPointsStr();
        }
        private String CalcularPuntTotal() 
        {
            int total = pActual.PuntuacionPartida + pActual.PuntuacionConsolidada;
            return total + "";
        }
    }
}
