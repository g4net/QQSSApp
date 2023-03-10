using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Respuesta
    {
       
        public int Id
        {
            get; set;
        }
        public string Texto { get; set; }

        public virtual Pregunta Pregunta { get; set; }



    }
}
