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

        public User(string dni, int Points) : this() {
            this.Id = dni;
            this.Puntuacion = Points;
        }

        public void SetPoints(int points) {
            this.Puntuacion = points;
        }

    }
}
