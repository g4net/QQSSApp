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
    public partial class ConfirmarPista : Form
    {
        public ConfirmarPista()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            QQSS.service.PidePista();
            this.Close();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
