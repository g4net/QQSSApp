using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Frase : Reto
    {
        public Frase(){}

        public Frase(String Descripcion, String Enunciado, int Dificulty, int Punt_acierto, int ods, bool muestraImagen) : base(Dificulty, Punt_acierto, ods, muestraImagen)
        {
            this.Descripcion = Descripcion;
            this.Enunciado = Enunciado;
        }
    }
}
