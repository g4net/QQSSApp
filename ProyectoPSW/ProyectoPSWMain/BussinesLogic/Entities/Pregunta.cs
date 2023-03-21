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
        }
        public List<Respuesta> getAllAnswers() {
            List<Respuesta> allAnswers = this.Respuestas.ToList();
            

            return allAnswers;
        }
        public String getPuntuacionAcierto() {
            return this.Puntuacion_acierto + "";
        }
        public String getPuntuacionFallo()
        {
            return (this.Puntuacion_acierto * -2) + "";
        }
        public int getOds() {
            return this.ods;
        }
    }
}
