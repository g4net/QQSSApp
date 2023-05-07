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
    public partial class CatalogoReto : Form
    {
        public CatalogoReto()
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
        private void PlayButton(TipoReto tipoReto) {
            QQSS.service.GenerarRetos(tipoReto);
            Form partida = new Form();
            if (tipoReto == TipoReto.AdivinarFrase) partida = new PartidaDescubrirFrase();
            else if (tipoReto == TipoReto.Pregunta) partida = new PartidaForm();
            else if(tipoReto == TipoReto.None)
            {
                Reto reto = QQSS.service.GetReto();
                if (reto is Pregunta) partida = new PartidaForm();
                else if (reto is Frase) partida = new PartidaDescubrirFrase();
            }
            partida.Show();
            this.Close();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Niveles niveles = new Niveles();
            niveles.Show();
            this.Hide();
        }

        private void ButtonPreguntas_OnClick(object sender, EventArgs e)
        {
            PlayButton(TipoReto.Pregunta);
        }

        private void ButtonAdivinar_OnClick(object sender, EventArgs e)
        {
            PlayButton(TipoReto.AdivinarFrase);
        }

        private void ButtonAleatorio_OnClick(object sender, EventArgs e)
        {
            PlayButton(TipoReto.None);
        }
    }
}
