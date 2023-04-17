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
    public partial class PartidaPerdida : Form
    {
        IQQSSService service;
        int retoindex;
        Partida pActual;
        Pregunta pregunta;
        public PartidaPerdida(IQQSSService service, int index)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.service = service;
            pActual = service.GetPartidaActual();
            retoindex = index;
            puntuacion_acumulada.Text = pActual.GetPuntuacionConsolidada();
            pregunta = service.QuestionServIndex(retoindex);
            OtorgarPuntuacion();
            
        }

        private void OtorgarPuntuacion()
        {
            if (!service.GetConsolidado())
            {
                service.UpdateUserScore(0);
            }
        }

        private void reintentar_salir_Click(object sender, EventArgs e)
        {
            service.CleanProgresoPreguntas();
            PantallaPrincipalForm pantallaPrincipal = new PantallaPrincipalForm(service);
            pantallaPrincipal.Show();
            this.Close();
        }
    }
}
