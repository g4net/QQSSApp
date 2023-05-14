using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Pregunta:Reto
    {
       
      

        public virtual ICollection<Respuesta> Respuestas { get; set; }
        
        public string RespuestaCorrecta { get; set; }
        
        public string Enunciado { get; set; }   
        }
}

