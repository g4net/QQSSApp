﻿using ProyectoPSWMain.Services;
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
    public partial class PartidaForm : Form
    {
        private IQQSSService service;
        public PartidaForm(IQQSSService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void PartidaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PuntuacionForm puntuacion = new PuntuacionForm(service);
            puntuacion.FormClosed += (s, args) => this.Show();
            puntuacion.Show();
        }
    }
}
