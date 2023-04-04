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
        }

        private void click_lvl0(object sender, EventArgs e)
        {
            service.CrearPartida(0);
            service.Questions(service.GetDifficultyArray(0));
            PartidaForm partidaForm = new PartidaForm(service, 0);
            partidaForm.Show();
            service.ResetErroresyConsolidaciones();
            this.Close();

        }

        private void click_lvl1(object sender, EventArgs e)
        {
            service.CrearPartida(1);
            service.Questions(service.GetDifficultyArray(1));
            PartidaForm partidaForm = new PartidaForm(service, 0);
            partidaForm.Show();
            service.ResetErroresyConsolidaciones();
            this.Close();
        }

        private void click_lvl2(object sender, EventArgs e)
        {
            service.CrearPartida(2);
            service.Questions(service.GetDifficultyArray(2));
            PartidaForm partidaForm = new PartidaForm(service, 0);
            partidaForm.Show();
            service.ResetErroresyConsolidaciones();
            this.Close();
        }

        private void click_lvl3(object sender, EventArgs e)
        {
            service.CrearPartida(3);
            service.Questions(service.GetDifficultyArray(3));
            PartidaForm partidaForm = new PartidaForm(service, 0);
            partidaForm.Show();
            service.ResetErroresyConsolidaciones();
            this.Close();
        }

        private void click_lvl4(object sender, EventArgs e)
        {
            service.CrearPartida(4);
            service.Questions(service.GetDifficultyArray(4));
            PartidaForm partidaForm = new PartidaForm(service, 0);
            partidaForm.Show();
            service.ResetErroresyConsolidaciones();
            this.Close();
        }
    }
}
