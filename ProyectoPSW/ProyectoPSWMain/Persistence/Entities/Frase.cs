﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Frase:Reto
    {
        public string Descripcion { get; set; }
        public string Enunciado { get; set; }
    }
}
