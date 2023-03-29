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
    public partial class PuntuacionPositiva : Form
    {
        IQQSSService service;
        
        int retoindex;
        int errores;
        public PuntuacionPositiva(IQQSSService service, int index, int errores)
        {
            InitializeComponent();
            this.service = service;
            this.errores = errores; 
            retoindex= index;
        }

        private void continuar_salir_Click(object sender, EventArgs e)
        {
            PartidaForm partida = new PartidaForm(service, retoindex, errores);
            partida.Show();
            this.Close();
        }
    }
}
