using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Reto
    {
        public int Id
        {
            get; set;
        }
        public int Puntuacion_acierto
        {
            get; set;
        }
        public int Dificultad {  get; set; }

        public int ods { get; set; }
       

    }
}
