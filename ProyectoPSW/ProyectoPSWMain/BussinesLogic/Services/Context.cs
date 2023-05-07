using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.BussinesLogic.Services
{
    public class Context
    {
        private PuntosStrategy puntosStrategy;
        private int puntos;
        private Partida partida;

        public void setPartida(Partida partida)
        {
            this.partida = partida;
        }

        public Context(PuntosStrategy puntosStrategy)
        {
            this.puntosStrategy = puntosStrategy;
        }

        public int SetStrategy(PuntosStrategy puntosStrategy)
        {
            this.puntosStrategy = puntosStrategy;
            int puntos = puntosStrategy.SetPuntos();
            return puntos;
        }

        public void AñadirPuntos()
        {
            this.puntosStrategy.AñadirPuntos(partida, puntos);
        }
    }

    public interface PuntosStrategy
    {
        void AñadirPuntos(Partida partida, int puntos);
        int SetPuntos();
    }


    public class EasyStrategy : PuntosStrategy
    {
        public int SetPuntos() { return 100; }

        public void AñadirPuntos(Partida partida, int puntos)
        {
            partida.PuntuacionPartida += 100;
        }
    }

    public class MiddleStrategy : PuntosStrategy
    {
        public int SetPuntos() { return 200; }

        public void AñadirPuntos(Partida partida, int puntos)
        {
            partida.PuntuacionPartida += 200;
        }
    }

    public class HardStrategy : PuntosStrategy
    {
        public int SetPuntos() { return 300; }

        public void AñadirPuntos(Partida partida, int puntos)
        {
            partida.PuntuacionPartida += 300;
        }
    }

    public class HalfStrategy : PuntosStrategy
    {
        public int SetPuntos() { return 0; }
        public void AñadirPuntos(Partida partida, int puntos)
        {
            puntos = puntos / 2;
            partida.PuntuacionPartida += puntos;
        }
    }
}
