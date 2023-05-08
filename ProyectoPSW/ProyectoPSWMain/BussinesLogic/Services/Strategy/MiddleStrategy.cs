using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.BussinesLogic.Services
{
    public class MiddleStrategy : IPuntosStrategy
    {
        public int SetPuntos() { return 200; }

        public void AñadirPuntos(Partida partida, int puntos)
        {
            partida.PuntuacionPartida += 200;
        }
    }
}
