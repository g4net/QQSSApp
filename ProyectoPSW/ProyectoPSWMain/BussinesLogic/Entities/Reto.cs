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
                        
      }

        public Reto(int Dificulty, int Punt_acierto, int Ods, bool muestraImagen):this()
        {
            this.Dificultad = Dificulty;
            this.Puntuacion_acierto = Punt_acierto;
            this.Ods = Ods;        
            this.MuestraImagen = muestraImagen;
        }

    }
}
