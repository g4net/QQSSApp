using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QQSSApp
{
    public partial class PuntuacionPositiva : Form
    {
        IQQSSService service;
        Pregunta pregunta;
        int retoindex;
        bool consolidado;
        public PuntuacionPositiva(IQQSSService service, int index)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.service = service;
            this.consolidado = service.IsConsolidado();
            consolidar.Enabled = !consolidado;
            retoindex= index;
            InitializePositivePunctuation();
        }

        private void continuar_salir_Click(object sender, EventArgs e)
        {
            this.retoindex++;
            PartidaForm partida = new PartidaForm(service, retoindex);
            partida.Show();
            this.Close();
        }
        
        private void InitializePositivePunctuation()
        {
            pregunta = service.QuestionServIndex(retoindex);
            puntuacion.Text = pregunta.GetPuntuacionAcierto();
            punt_actual.Text = service.GetPartidaActual().getPuntuacionPartida();
            
        }

        private void consolidar_click(object sender, EventArgs e)
        {
            service.Consolidar();
            consolidar.Enabled = false;
            //Consolidar consolidar = new Consolidar(service, retoindex);                
            //consolidar.Show();
            //this.Close();
        }
    }
}
