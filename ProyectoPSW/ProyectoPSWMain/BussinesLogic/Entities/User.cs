﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Entities
{
    public partial class User
    {
        public User() {
            this.PartidasJugadas = new List<Partida>();
            this.PreguntasRealizadas = new List<Pregunta>();
            this.PuntuacionAcumulada = 0;
            this.nivel = 0;
        }

        public User(String Nombre, String Email, String Contraseña) : this() {
            this.Nombre = Nombre;
            this.Email = Email;
            this.Contraseña = Contraseña;
           
        }
        public int getPoints() {
            return this.PuntuacionAcumulada;
        }
        public string getPointsStr() {
            return this.PuntuacionAcumulada.ToString();
        }
        public void SetPoints(int points) {
            this.PuntuacionAcumulada += points;
        }

    }
}
