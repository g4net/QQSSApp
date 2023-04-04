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
        int consolidaciones;
        public PuntuacionPositiva(IQQSSService service, int index)
        {
            InitializeComponent();
            this.service = service;
            this.consolidaciones = service.GetConsolidaciones();
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
            if (consolidaciones == 1)
            {
                //No se puede seguir consolidando
            }
            else {
                service.UpdateConsolidaciones();
                Consolidar consolidar = new Consolidar(service, retoindex);                
                consolidar.Show();
                this.Close();
            }
        }
    }
}
