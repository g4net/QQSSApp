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
        public int SetPuntos() { return 0; }

        public void AñadirPuntos(Partida partida, int puntos)
        {
            Console.WriteLine("HALF");
            //puntos = puntos / 2;
            partida.PuntuacionPartida += 1000;
        }
    }
}
