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
            PuntosStrategy.AñadirPuntos(puntos);
        }
    }
    public abstract class PuntosStrategy
    {
        internal static void AñadirPuntos(int puntos)
        {
            throw new NotImplementedException();
        }

        public abstract void AñadirPutos(int puntos);
    }
    public class AñadirSinPista : PuntosStrategy 
    {
        public override void AñadirPutos(int puntos)
        {
            //implementar
            throw new NotImplementedException();
        }
    }
    public class AñadirConPista : PuntosStrategy 
    {
        public override void AñadirPutos(int puntos)
        {
            //implementar
            throw new NotImplementedException();
        }
    }
}
