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
        IQQSSService service;
        Partida pActual;
        
        public Consolidar(IQQSSService service)
        {
            this.CenterToScreen();
            this.service = service;
            pActual = service.GetPartidaActual();
            InitializeComponent();
            InitializeNegativePunctuation();
        }

      
        private void continuar_click(object sender, EventArgs e)
        {
            PantallaPrincipalForm pantallaPrincipalForm = new PantallaPrincipalForm(service);
            pantallaPrincipalForm.Show();
            this.Close();
        }
        private void InitializeNegativePunctuation()
        {
            puntuacion.Text = Math.Min(pActual.PuntuacionPartida, pActual.PuntuacionConsolidada).ToString();
            punt_usuario.Text = service.GetLoggedUser().getPointsStr();
        }
    }
}
