﻿using ProyectoPSWMain.Entities;
using ProyectoPSWMain.EntityFramework;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Services
{
    public class UserManager : IUserManager
    {

        public UserManager() { }

        public readonly int[] Levels = { 500, 1000, 2000, 3000 };
        private User loggedUser;


        public bool IsValidEmail(string email)
        {
            if (email == null || email.Length <= 4) return false;
            int indexAt = email.IndexOf('@');
            int indexDot = email.LastIndexOf('.');
            if (indexAt == -1 || indexDot == -1) return false;
            if (indexAt > indexDot) return false;
            if (indexDot - indexAt <= 2) return false;
            if (email.Length - indexDot < 2) return false;
            return true;
        }

        public bool IsValidPassword(string password)
        {
            if (password == null || password.Length < 8 || password.Length > 32) return false;
            int conds = 0;
            foreach (char c in password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    conds++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    conds++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    conds++;
                    break;
                }
            }
            char[] specialCharacters = { '?', '-', '+', '=', '_', '@', '#', '!', '&', '$' };
            if (password.IndexOfAny(specialCharacters) != -1) conds++;
            if (conds < 4) return false;
            return true;
        }

        public void IncrementaAciertos()
        {
            loggedUser.Estadistica.NumAciertos++;
        }
        
        public void IncrementaFallos()
        {
            loggedUser.Estadistica.NumFallos++;
        }

        public bool IsValidUsername(string login)
        {
            if (login == null || login.Length > 30) return false;
            char[] specialCharacters = { '?', '+', '=', '@', '#', '&' };
            if(login.IndexOfAny(specialCharacters) != -1) return false;
            return true;
        }

        public User GetLoggedUser()
        {
            if (this.loggedUser == null) throw new ServiceException("There is no user logged in");

            return this.loggedUser;

        }
        public void UpdateUserScore(int points)
        {
            if (this.loggedUser == null) throw new ServiceException("There is no user logged in");

            this.loggedUser.SetPoints(points < 0 ? 0 : points);
        }

        public bool CheckLevel()
        {

            if (loggedUser == null) throw new ServiceException("No hay usuario registrado");

            int high = Levels.Length;
            int low = 0;

            while (high > low)
            {
                int mid = low + (high - low) / 2;
                if (loggedUser.PuntuacionAcumulada == Levels[mid]) { low = mid; break; }
                else if (loggedUser.PuntuacionAcumulada > Levels[mid]) low = mid + 1;
                else high = mid;
            }
            if (loggedUser.nivel == low) return false;
            loggedUser.nivel = low;
            return true;
        }


        public double GetPuntajeODS(int ods)
        {
            double countODS = loggedUser.RetosJugados.Where(x => x.Ods == ods).Count();
            if (countODS == 0) return 0;
            double aciertosODS = loggedUser.RetosSuperados.Where(x => x.Ods == ods).Count();

            return (aciertosODS / countODS) * 100;
        }

        public void SetLoggedUser(User user)
        {
            loggedUser = user;
        }

        #region Reto
        public void UpdateUserRetos(List<Reto> retosAcertados, List<Reto> retosJugados)
        {
            this.loggedUser.RetosRealizados.Union(retosAcertados);
            this.loggedUser.RetosSuperados.Union(retosAcertados);
            this.loggedUser.RetosJugados.Union(retosJugados);
        }
        public bool CheckRetoPlayed(Reto reto)
        {
            List<Reto> RetosUser = this.loggedUser.RetosRealizados.ToList();
            return RetosUser.Contains(reto);
        }
        #endregion Reto

        #region Pregunta
        public List<Pregunta> GetUsersQuestionByDifficulty(int dificultad)
        {
            List<Reto> retos = this.loggedUser.RetosRealizados.Where(x => x is Pregunta && x.Dificultad == dificultad).ToList();
            List<Pregunta> preguntas = new List<Pregunta>();
            foreach(Reto r in retos) preguntas.Add((Pregunta) r);

            return preguntas;
        }

        public List<Frase> GetUsersFrasesByDifficulty(int dificultad)
        {
            List<Reto> retos = this.loggedUser.RetosRealizados.Where(x => x is Frase && x.Dificultad == dificultad).ToList();
            List<Frase> frases = new List<Frase>();
            foreach (Reto r in retos) frases.Add((Frase)r);

            return frases;
        }

        public List<Reto> GetUsersRetosByDifficulty(int dificultad)
        {
            List<Reto> retos = this.loggedUser.RetosRealizados.ToList();

            return retos.Where(x => x.Dificultad == dificultad).ToList();
        }

        public void ResetUserQuestions(int dificultad)
        {
            List<Reto> retos = this.loggedUser.RetosRealizados.Where(x => x is Pregunta && x.Dificultad == dificultad).ToList();
            List<Pregunta> preguntas = new List<Pregunta>();
            foreach (Reto r in retos) preguntas.Add((Pregunta)r);

            this.loggedUser.RetosRealizados = this.loggedUser.RetosRealizados.Except(preguntas).ToList();
        }

        public void ResetUserFrases(int dificultad)
        {
            List<Reto> retos = this.loggedUser.RetosRealizados.Where(x => x is Frase && x.Dificultad == dificultad).ToList();
            List<Frase> frases = new List<Frase>();
            foreach (Reto r in retos) frases.Add((Frase)r);

            this.loggedUser.RetosRealizados = this.loggedUser.RetosRealizados.Except(frases).ToList();
        }

        public void ResetUserRetos(int dificultad)
        {
            List<Reto> retos = this.loggedUser.RetosRealizados.Where(x => x.Dificultad == dificultad).ToList();
            this.loggedUser.RetosRealizados = this.loggedUser.RetosRealizados.Except(retos).ToList();
        }

        #endregion Pregunta
    }
}
