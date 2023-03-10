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
            this.PartidaDeReto = new List<Partida>();
            
      }

        public Reto(int Dificulty, int Punt_fallo, int Punt_acierto, int Segundos):this()
        {
            this.Dificultad = Dificulty;
            this.Puntuacion_fallo = Punt_fallo;
            this.Puntuacion_acierto = Punt_acierto;
            this.Segundos = Segundos;
        }

    }
}
