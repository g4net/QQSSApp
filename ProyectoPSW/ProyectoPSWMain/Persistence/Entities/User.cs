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
        public String Id { get; set; }
        public int Puntuacion {
            get; set;
        
        }
        public virtual ICollection<Partida> PartidasJugadas { get; set; }



    }
}
