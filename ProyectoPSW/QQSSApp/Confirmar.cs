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
    public partial class Confirmar : Form
    {
        PartidaForm partidaForm;
        public Confirmar(PartidaForm partidaForm)
        {
            InitializeComponent();
            this.partidaForm = partidaForm;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            QQSS.service.AbandonarPartida();
            Consolidar consolidarForm = new Consolidar();
            consolidarForm.Show();
            this.Close();
            partidaForm.Close();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
