using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Pregunta:Reto
    {
        public Pregunta()
        {
            this.Respuestas = new List<Respuesta>();
        }

        public Pregunta(ICollection<Respuesta> rtas, String texto, int Dificulty, int Punt_acierto, Respuesta rtaCorrecta, int ods) : base(Dificulty,Punt_acierto, ods) {
            this.Respuestas = rtas;
            this.Enunciado = texto;
            this.RespuestaCorrecta = rtaCorrecta;
            this.Dificultad = Dificulty;
            this.Puntuacion_acierto = Punt_acierto;
            this.Ods = ods;
        }
        public List<Respuesta> getAllAnswers() {
            List<Respuesta> allAnswers = this.Respuestas.ToList();
            

            return allAnswers;
        }
        public String GetPuntuacionAcierto() {
            return this.Puntuacion_acierto + "";
        }
        public String GetPuntuacionFallo()
        {
            return (this.Puntuacion_acierto * -2) + "";
        }
    }
}
