using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Estadistica
    {
        [Key]
        public int Id { get; set; }
        public int NumAciertos { get; set; }
        public int NumFallos { get; set; }
    }
}
