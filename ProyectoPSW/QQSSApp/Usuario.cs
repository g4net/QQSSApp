using System;
using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
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
    public partial class Usuario : Form
    {
        User usuario;
        public Usuario()
        {
            InitializeComponent();
            this.usuario = QQSS.service.GetLoggedUser();
            InitializeLabels();
        }

        public void InitializeLabels()
        {
            nivel.Text = usuario.nivel.ToString();
            puntuacion.Text = usuario.PuntuacionAcumulada.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
