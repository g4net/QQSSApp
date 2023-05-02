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
        
        public Consolidar()
        {
            this.CenterToScreen();
            InitializeComponent();
            InitializeNegativePunctuation();
        }

      
        private void continuar_click(object sender, EventArgs e)
        {
            PantallaPrincipalForm pantallaPrincipalForm = new PantallaPrincipalForm();
            pantallaPrincipalForm.Show();
            this.Close();
        }
        private void InitializeNegativePunctuation()
        { 
            puntuacion.Text = QQSS.service.GetPuntuacionConsolidada().ToString();
            punt_usuario.Text = QQSS.service.GetLoggedUser().PuntuacionAcumulada.ToString();
        }
    }
}
