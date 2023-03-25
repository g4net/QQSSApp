using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class User
    {
        public User() {
            this.PartidasJugadas = new List<Partida>();
        }

        public User(string dni, int Points, int nivel) : this() {
            this.Id = dni;
            this.PuntuacionAcumulada = Points;
            this.nivel = nivel;
        }
        public int getPoints() {
            return this.PuntuacionAcumulada;
        }
        public string getPointsStr() {
            return this.PuntuacionAcumulada.ToString();
        }
        public void SetPoints(int points) {
            this.PuntuacionAcumulada = points;
        }

    }
}
