﻿using System;
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

        public Pregunta(ICollection<Respuesta> rtas, String texto, int Dificulty, int Punt_acierto, String rtaCorrecta, int ods, bool muestraImagen) : base(Dificulty,Punt_acierto, ods, muestraImagen) {
            this.Respuestas = rtas;
            this.Enunciado = texto;
            this.RespuestaCorrecta = rtaCorrecta;

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
        public int PuntuacionFallo()
        {
            return (this.Puntuacion_acierto * -2);
        }
    }
}
