using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
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
            this.service.Login("0");

        }


        private void ButtonComenzar_Click(object sender, EventArgs e)
        {
            /*
            CargarDatos datos = new CargarDatos(service);
            datos.Show();
            this.Hide();
            */

            //el siguiente codigo debera estar en el selector de nivel
            //START
            /*
            service.CrearPartida(1);
            service.Questions(service.GetDifficultyArray(1));
            PartidaForm partidaForm = new PartidaForm(service, 0);
            partidaForm.Show();
            service.ResetErroresyConsolidaciones();
            this.Hide();*/
            Niveles niveles = new Niveles(service);
            niveles.Show();
            this.Hide();

            //END
           

            //codigo refactorizado
            //service.SetPartidaActual(this.service.GetPartida(1, 0));            
            // service.ResetGameScore();
            // service.Questions(service.GetDifficultyArray(service.GetPartidaActual().Nivel));
            // int index = 0;
            // PartidaForm partida = new PartidaForm(service,index, 0);
            // partida.Show();
            // this.Hide();
            
        }

        private void BotonReglas_Click(object sender, EventArgs e)
        {
            Reglas regla = new Reglas();
            regla.Show();
        }
    }
}
