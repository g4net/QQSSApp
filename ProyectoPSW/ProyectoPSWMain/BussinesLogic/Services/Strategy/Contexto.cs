using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.BussinesLogic.Services
{
    public class Contexto
    {
        private IPuntosStrategy puntosStrategy;
        private int puntos;
        private Partida partida;

        public void setPartida(Partida partida)
        {
            this.partida = partida;
        }

        public int GetPuntos() 
        { 
            return this.puntos; 
        }

        public Contexto() 
        { 
        
        }

        public Contexto(IPuntosStrategy puntosStrategy)
        {
            this.puntosStrategy = puntosStrategy;
        }

        public IPuntosStrategy GetPuntosStrategy() 
        { 
            return this.puntosStrategy; 
        }

        public void SetStrategy(IPuntosStrategy puntosStrategy)
        {
            this.puntosStrategy = puntosStrategy;
            //Console.WriteLine(puntosStrategy.ToString());
            puntos = puntosStrategy.SetPuntos();
            
        }

        public void AñadirPuntos()
        {
            //Console.WriteLine("CONTEXTO");
            this.puntosStrategy.AñadirPuntos(partida, puntos);
        }
    }



    

    

    

    
}
