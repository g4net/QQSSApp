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
    public partial class Niveles : Form
    {
        public Niveles()
        {
            InitializeComponent();
            this.CenterToScreen();
            BotonesHabilitados();
        }

        public void BotonesHabilitados()
        {
            for(int i = QQSS.service.GetLoggedUser().nivel; i >= 0; i--)
            {
                string nombreBoton = "BotonNivel" + i;
                Control[] controles = this.Controls.Find(nombreBoton, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Button boton = (Button)controles[0];
                boton.Enabled = true;
            }
        }
        private void PlayButton(int level) {
            QQSS.service.CrearPartida(level);
            CatalogoReto retoForm = new CatalogoReto();
            retoForm.Show();
            this.Close();
        }
        private void click_lvl0(object sender, EventArgs e)
        {
            PlayButton(0);
        }

        private void click_lvl1(object sender, EventArgs e)
        {
            PlayButton(1);
        }

        private void click_lvl2(object sender, EventArgs e)
        {
            PlayButton(2);
        }

        private void click_lvl3(object sender, EventArgs e)
        {
            PlayButton(3);
        }

        private void click_lvl4(object sender, EventArgs e)
        {
            PlayButton(4);
        }

        private void volver_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForm principal = new PantallaPrincipalForm();
            principal.Show();
            this.Close();
        }
    }
}
