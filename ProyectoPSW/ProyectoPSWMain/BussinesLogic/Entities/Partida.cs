using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Partida
    {
        public Partida() {
            this.RetoPartida = new List<Reto>();
        }

        public Partida(int Level, int Puntos):this()
        {
            this.Nivel = Level;
            this.PuntuacionPartida = Puntos;
           
        }
    }
}
