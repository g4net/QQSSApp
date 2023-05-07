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
        private IPuntosStrategy puntosStrategy;
        private int puntos;
        private Partida partida;

        public void setPartida(Partida partida)
        {
            this.partida = partida;
        }

        public Context() 
        { 
        
        }

        public Context(IPuntosStrategy puntosStrategy)
        {
            this.puntosStrategy = puntosStrategy;
        }

        public int SetStrategy(IPuntosStrategy puntosStrategy)
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



    

    

    

    
}
