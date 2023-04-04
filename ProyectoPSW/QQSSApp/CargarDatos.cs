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
    public partial class CargarDatos : Form
    {
        IQQSSService service;
        ICollection<Respuesta> respuestasMal;
        int dificultad;
        int ODS;
        int puntuacion;
        String enunciado;
        public CargarDatos(IQQSSService service)
        {
            this.service = service;
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            for(int i = 1; i <= 3; i++)
            {
                combo_dificultad.Items.Add(i);
            }
            for (int i = 0; i <= 17; i++)
            {
                combo_ods.Items.Add(i);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            enunciado = texto.Text;
            dificultad = Int32.Parse(combo_dificultad.Text);
            ODS = Int32.Parse(combo_ods.Text);
            respuestasMal.Add(new Respuesta(respuesta1.Text));
            respuestasMal.Add(new Respuesta(respuesta2.Text));
            respuestasMal.Add(new Respuesta(respuesta3.Text));
            if(dificultad == 1)
            {
                puntuacion = 100;
            }else if(dificultad == 2)
            {
                puntuacion = 200;
            }
            else
            {
                puntuacion = 300;
            }
            //service.AddPregunta(new Pregunta(respuestasMal, enunciado, dificultad, puntuacion, respuesta4.Text, ODS));
            limpia();
        }
        public void limpia()
        {
            texto.Text = "";
            respuesta1.Text = "";
            respuesta2.Text = "";
            respuesta3.Text = "";
            respuesta4.Text = "";
            combo_dificultad.Text = "";
            combo_ods.Text = "";
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            limpia();
        }
    }
}
