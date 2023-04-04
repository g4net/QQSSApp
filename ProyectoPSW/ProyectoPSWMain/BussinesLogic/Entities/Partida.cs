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
            this.PuntuacionConsolidada = 0;
           
        }

        public Partida(int nivel) : this()
        {
            this.Nivel = nivel;
            this.PuntuacionPartida = 0;
            this.PuntuacionConsolidada = 0;
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
        public String GetPuntuacionConsolidada() {
            return this.PuntuacionConsolidada + "";
        }
    }
}
