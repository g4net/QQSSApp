using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace QQSSApp
{
    public partial class PantallaPrincipalForm : FormTemplate
    {
        public PantallaPrincipalForm() : base()
        {
            InitializeComponent();
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
