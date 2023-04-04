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
        Pregunta pregunta;
        public PuntuacionNegativa(IQQSSService service, int index, int err)
        {
            InitializeComponent();
            this.errores = err;
            this.service = service;
            this.retoindex = index;
            //this.errores = errores (atributo) Refactoring
            this.errores = service.GetErrores();
            InitializeNegativePunctuation();
        }

        private void ButtonReintentarClick(object sender, EventArgs e)
        {
            
            PartidaForm partida = new PartidaForm(service, retoindex);
            service.UpdateErrores();
            partida.Show();
            this.Close();
            
            
        }
        private void InitializeNegativePunctuation()
        {
            pregunta = service.QuestionServIndex(retoindex);
            puntuacion.Text = pregunta.GetPuntuacionAcierto();
            punt_actual.Text = service.GetPartidaActual().getPuntuacionPartida();

        }
    }
}
