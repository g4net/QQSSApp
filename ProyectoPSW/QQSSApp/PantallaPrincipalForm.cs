using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace QQSSApp
{
    public partial class PantallaPrincipalForm : Form
    {
        IQQSSService service;
        public PantallaPrincipalForm(IQQSSService service)
        {
            this.service = service;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.FormClosed += (s, args) => Application.Exit();
            this.label1.Select();
            
        }


        private void ButtonComenzar_Click(object sender, EventArgs e)
        {
            /*
            CargarDatos datos = new CargarDatos(service);
            datos.Show();
            this.Hide();
            */
            
           service.SetPartidaActual(this.service.GetPartida(1, 0));
            service.ResetGameScore();
            int index = 0;
            PartidaForm partida = new PartidaForm(service,index);
            partida.Show();
            this.Hide();
            
        }
    }
}
