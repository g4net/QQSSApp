using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Reto
    {
        [Key]
        public int Id
        {
            get; set;
        }
        public int Puntuacion_acierto
        {
            get; set;
        }
        public int Dificultad {  get; set; }

        public int Ods { get; set; }
       

    }
}
