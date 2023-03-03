using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Persistence.Entities
{
    internal class Reto
    {
        public int Puntuacion_acierto
        {
            get; set;
        }
        public int Puntuacion_fallo {
            get; set;
        }
        public int Segundos { 
            get; set;
        }
        public int Dificultad {
            get; set;
        }

    }
}
