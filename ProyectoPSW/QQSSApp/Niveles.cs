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
        IQQSSService service;
        public Niveles(IQQSSService service)
        {
            this.service = service;
            InitializeComponent();
            this.CenterToScreen();
            BotonesHabilitados();
        }

        public void BotonesHabilitados()
        {
            for(int i = service.GetLoggedUser().nivel; i >= 0; i--)
            {
                string nombreBoton = "BotonNivel" + i;
                Control[] controles = this.Controls.Find(nombreBoton, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Button b = (Button)controles[0];
                b.Enabled = true;


                //GetButton(i).Enabled = true;
            }
        }

        //public Button GetButton(int nivel)
        //{
        //    if (nivel == 1)
        //    {
        //        return BotonNivel1;
        //    }
        //    else if(nivel == 2)
        //    {
        //        return BotonNivel2;
        //    }
        //    else if (nivel == 3)
        //    {
        //        return BotonNivel3;
        //    }
        //    else if(nivel == 4)
        //    {
        //        return BotonNivel4;
        //    }
        //    return BotonNivel0;
        //}
        private void PlayButton(int level) {
            service.CrearPartida(level);
            service.Questions(service.GetDifficultyArray(level));
            PartidaForm partidaForm = new PartidaForm(service, 0);
            partidaForm.Show();
            service.ResetErroresyConsolidaciones();
            this.Close();
        }
        private void click_lvl0(object sender, EventArgs e)
        {
            //Refactoring
            //service.CrearPartida(0);
            //service.Questions(service.GetDifficultyArray(0));
            //PartidaForm partidaForm = new PartidaForm(service, 0);
            // partidaForm.Show();
            // service.ResetErroresyConsolidaciones();
            // this.Close();
            PlayButton(0);
        }

        private void click_lvl1(object sender, EventArgs e)
        {
            // Refactoring
            //service.CrearPartida(1);
            //service.Questions(service.GetDifficultyArray(1));
            //PartidaForm partidaForm = new PartidaForm(service, 0);
            // partidaForm.Show();
            // service.ResetErroresyConsolidaciones();
            // this.Close();
            PlayButton(1);
        }

        private void click_lvl2(object sender, EventArgs e)
        {


            // Refactoring
            //service.CrearPartida(2);
            //service.Questions(service.GetDifficultyArray(2));
            //PartidaForm partidaForm = new PartidaForm(service, 0);
            // partidaForm.Show();
            // service.ResetErroresyConsolidaciones();
            // this.Close();
            PlayButton(2);
        }

        private void click_lvl3(object sender, EventArgs e)
        {
            //Refactoring
            //service.CrearPartida(3);
            //service.Questions(service.GetDifficultyArray(3));
            //PartidaForm partidaForm = new PartidaForm(service, 0);
            // partidaForm.Show();
            // service.ResetErroresyConsolidaciones();
            // this.Close();
            PlayButton(3);
        }

        private void click_lvl4(object sender, EventArgs e)
        {
            //Refactoring
            //service.CrearPartida(4);
            //service.Questions(service.GetDifficultyArray(4));
            //PartidaForm partidaForm = new PartidaForm(service, 0);
            // partidaForm.Show();
            // service.ResetErroresyConsolidaciones();
            // this.Close();
            PlayButton(4);
        }

        private void volver_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForm principal = new PantallaPrincipalForm(service);
            principal.Show();
            this.Hide();
        }
    }
}
