using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Frase:Reto
    {
        public String Descripcion { get; set; }
        public String Enunciado { get; set; }
    }
}
