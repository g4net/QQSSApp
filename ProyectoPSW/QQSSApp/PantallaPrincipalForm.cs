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
    public partial class PantallaPrincipalForm : Form
    {
        private IQQSSService service;
        public PantallaPrincipalForm(IQQSSService service)
        {
            InitializeComponent();
            this.service = service;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void ButtonComenzar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PartidaForm partida = new PartidaForm(service);
            partida.FormClosed += (s, args) => this.Show();
            partida.Show();
        }
    }
}
