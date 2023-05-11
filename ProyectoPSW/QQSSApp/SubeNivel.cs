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
    public partial class SubeNivel : Form
    {
        public SubeNivel()
        {
            InitializeComponent();
            this.CenterToScreen();
            Nivel.Text = QQSS.service.GetLoggedUser().nivel.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForm pantallaPrincipal = new PantallaPrincipalForm();
            pantallaPrincipal.Show();
            this.Hide();
        }
    }
}
