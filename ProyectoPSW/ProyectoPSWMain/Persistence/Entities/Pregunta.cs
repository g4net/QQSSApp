using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Persistence.Entities
{
    public partial class Pregunta
    {
        public ICollection<Reto> Retos {
            get; set;
        }
}
}
