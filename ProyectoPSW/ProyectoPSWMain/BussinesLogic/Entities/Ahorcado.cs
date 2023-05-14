using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class Ahorcado : Reto
    {
        public Ahorcado() { }

        public Ahorcado(string Descripcion, string Enunciado, int Dificulty, int Punt_acierto, int ods, bool muestraImagen) : base(Dificulty, Punt_acierto, ods, muestraImagen)
        {
            this.Descripcion = Descripcion;
            this.Enunciado = Enunciado;
        }
    }
}
