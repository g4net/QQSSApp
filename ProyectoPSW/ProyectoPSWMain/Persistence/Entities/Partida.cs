using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Partida
    {
        [Key]
        public int Id
        {
            get; set;
        }
        public virtual ICollection<Reto> RetoPartida
        {
            get; set;

        }
        public int PuntuacionPartida {

            get; set;
        }
        public int Nivel {
            get; set;
        }

    }
}
