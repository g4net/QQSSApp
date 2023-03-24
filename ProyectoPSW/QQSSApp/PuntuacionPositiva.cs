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


// esto era un intento de tener un form base del cual heredaran todos para no tener que pasar el servicio cada vez pero de momento
// no he conseguido que funcione (ignorad esta clase)

namespace QQSSApp
{
    public partial class PuntuacionPositiva : Form
    {
        IQQSSService service;
        
        int retoindex;
        public PuntuacionPositiva(IQQSSService service, int index)
        {
            InitializeComponent();
            this.service = service;
            
            retoindex= index;
        }

        private void continuar_salir_Click(object sender, EventArgs e)
        {
            PartidaForm partida = new PartidaForm(service, retoindex);
            partida.Show();
            this.Close();
        }
    }
}
