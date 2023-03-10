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

        public Pregunta(List<Respuesta> rtas, String texto, int Dificulty, int Punt_fallo, int Punt_acierto, int Segundos) : base(Dificulty,Punt_fallo,Punt_acierto,Segundos) {
            if (rtas.Count == 4)
            {
                this.Respuestas = rtas;
            }
            else {
                //excepcion?
            }
            this.Enunciado = texto;
        }
    }
}
