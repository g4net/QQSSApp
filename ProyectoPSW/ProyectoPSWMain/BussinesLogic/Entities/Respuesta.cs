using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Respuesta
    {
      public Respuesta() {
        
      
      }

    public Respuesta(string txt) {
           this.Texto = txt;
    }
        public string GetText()
        {
            return this.Texto;
        }
    }
   
}
