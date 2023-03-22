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
        public void AddReto(Reto reto) {
            RetoPartida.Add(reto);
        }
        public List<Reto> GetRetos() {
            List<Reto> retopartida = this.RetoPartida.ToList();
            return retopartida;
        }
        public String getPuntuacionPartida()
        {
            return this.PuntuacionPartida + "";

        }
    }
}
