﻿using ProyectoPSWMain.Services;
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


// esto era un intento de tener un form base del cual heredaran todos para no tener que pasar el servicio cada vez pero de momento
// no he conseguido que funcione (ignorad esta clase)

namespace QQSSApp
{
    public partial class PuntuacionNegativa : Form
    {
        IQQSSService service;
        public PuntuacionNegativa(IQQSSService service, List<Reto> reto, int index, Partida partidas)
        {
            InitializeComponent();
            this.service = service;

        }

        private void ButtonReintentarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}