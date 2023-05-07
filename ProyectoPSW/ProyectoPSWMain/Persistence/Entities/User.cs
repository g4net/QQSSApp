using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        public int PuntuacionAcumulada { get; set; }
        public int nivel { get; set;}

        public String Nombre { get; set; }
        public virtual ICollection<Partida> PartidasJugadas { get; set; }

        public String Email { get; set; }

        public String Contraseña { get; set; }

        public virtual Estadistica Estadistica { get; set; }

        public virtual ICollection<Reto> RetosSuperados { get; set; }
        public virtual ICollection<Reto> RetosJugados { get; set; }

        public virtual ICollection<Pregunta> PreguntasRealizadas { get; set; }

        public virtual ICollection<Reto> RetosRealizados { get; set; }

    }
}
