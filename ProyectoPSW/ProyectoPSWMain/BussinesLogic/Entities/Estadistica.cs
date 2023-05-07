using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Estadistica
    {
        public Estadistica() { }

        public Estadistica(int numAciertos, int numFallos)
        {
            this.NumAciertos = numAciertos;
            this.NumFallos = numFallos;
        }
    }
}
