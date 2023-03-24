using ProyectoPSWMain.Services;
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
