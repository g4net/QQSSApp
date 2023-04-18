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
    public partial class Consolidar : Form
    {
        int retoindex;
        IQQSSService service;
        
        public Consolidar(IQQSSService service, int index)
        {
            this.service = service;
            this.retoindex = index;            
            InitializeComponent();
            InitializeNegativePunctuation();
        }

      
        private void continuar_click(object sender, EventArgs e)
        {
            this.retoindex++;
            PartidaForm partida = new PartidaForm(service, retoindex);
            partida.Show();
            this.Close();
        }
        private void InitializeNegativePunctuation()
        {
            
            puntuacion.Text = service.GetPartidaActual().PuntuacionConsolidada.ToString();
            punt_usuario.Text = service.GetLoggedUser().getPointsStr();

        }
    }
}
