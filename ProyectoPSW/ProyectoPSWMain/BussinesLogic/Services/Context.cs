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

        public Context(PuntosStrategy puntosStrategy) 
        {
            this.puntosStrategy = puntosStrategy;
        }

        public void SetSortStrategy(PuntosStrategy puntosStrategy)
        {
            this.puntosStrategy = puntosStrategy;
        }
        
        public void AñadirPuntos()
        {
            this.puntosStrategy.AñadirPuntos(puntos);
        }
    }

    public interface PuntosStrategy
    {
        void AñadirPuntos(int puntos);
    }


    public class EasyStrategy: PuntosStrategy 
    {
        public void AñadirPuntos(int puntos)
        {
            puntos = 100;
            //añadir al user
            throw new NotImplementedException();
        }
    }

    public class MiddleStrategy : PuntosStrategy 
    {
        public void AñadirPuntos(int puntos)
        {
            puntos = 200;
            //añadir al user
            throw new NotImplementedException();
        }
    }

    public class HardStrategy : PuntosStrategy
    {
        public void AñadirPuntos(int puntos)
        {
            puntos = 300;
            //añadir al user
            throw new NotImplementedException();
        }
    }

    public class HalfStrategy : PuntosStrategy
    {
        public void AñadirPuntos(int puntos)
        {
            puntos = puntos / 2;
            //añadir al user
            throw new NotImplementedException();
        }
    }

}
