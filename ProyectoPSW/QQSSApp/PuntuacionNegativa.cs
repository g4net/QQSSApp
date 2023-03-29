using ProyectoPSWMain.Services;
using ProyectoPSWMain.Entities;
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
    public partial class PuntuacionNegativa : Form
    {
        IQQSSService service;
        int retoindex;
        int errores;
        public PuntuacionNegativa(IQQSSService service, int index, int errores)
        {
            InitializeComponent();
            this.service = service;
            this.retoindex = index;
            this.errores = errores;
        }

        private void ButtonReintentarClick(object sender, EventArgs e)
        {
            if(errores == 1)
            {
                // game over form (se implementa cuando se pueda);
            }
            else
            {
                PartidaForm partida = new PartidaForm(service, retoindex, errores + 1);
                partida.Show();
                this.Close();
            }
            
        }
    }
}
