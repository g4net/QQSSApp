using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.BussinesLogic.Services
{
    public class PistaStrategy : IPuntosStrategy
    {
        public int EstablecerPuntosReto(int puntosActualPartida)
        {
            return puntosActualPartida / 2;
        }
    }
}
