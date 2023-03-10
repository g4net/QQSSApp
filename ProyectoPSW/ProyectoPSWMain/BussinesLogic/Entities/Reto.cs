using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Reto
    {

      public Reto() {
            this.partidaDeReto = new List<Partida>();
            
      }

        public Reto(int Dificulty, int Punt_acierto):this()
        {
            this.dificultad = Dificulty;
            this.puntuacion_acierto = Punt_acierto;
         
        }

    }
}
