using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.BussinesLogic.Services
{
    public class HalfStrategy : IPuntosStrategy
    {
        public int SetPuntos() { return 0; }
        public void AñadirPuntos(Partida partida, int puntos)
        {
            puntos = puntos / 2;
            partida.PuntuacionPartida += puntos;
        }
    }
}
