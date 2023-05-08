using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.BussinesLogic.Services
{
    public interface IPuntosStrategy
    {
        void AñadirPuntos(Partida partida, int puntos);
        int SetPuntos();
    }
}
