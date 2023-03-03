using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Persistence.Entities
{
    public partial class Respuesta
    {
        public string Texto { get; set; }

        public virtual Pregunta Pregunta { get; set; }





            

    }
}
