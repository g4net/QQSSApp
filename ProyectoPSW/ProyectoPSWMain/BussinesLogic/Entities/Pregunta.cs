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

        public Pregunta(ICollection<Respuesta> rtas, String texto, int Dificulty, int Punt_acierto) : base(Dificulty,Punt_acierto) {
            this.Respuestas = rtas;
            this.Enunciado = texto;
        }
    }
}
