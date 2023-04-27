using ProyectoPSWMain.Entities;
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

        public bool IsValidUsername(string login)
        {
            if (login == null || login.Length == 0 || login.Length > 30) return false;
            if (login.IndexOf('@') != -1) return IsValidEmail(login);
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

        public void SetLoggedUser(User user)
        {
            loggedUser = user;
        }

        #region Reto
        public void UpdateUserRetos(List<Reto> retos)
        {
            this.loggedUser.RetosRealizados.Union(retos);
        }
        public bool CheckRetoPlayed(Reto reto)
        {
            List<Reto> RetosUser = this.loggedUser.RetosRealizados.ToList();
            return RetosUser.Contains(reto);
        }
        #endregion Reto

        #region Pregunta
        public List<Pregunta> GetUsersQuestionByDificulty(int dificultad)
        {
            List<Pregunta> preguntas = this.loggedUser.PreguntasRealizadas.ToList();

            return preguntas.Where(x => x.Dificultad == dificultad).ToList();
        }
        public void ResetUserQuestions(int dificultad)
        {
            List<Pregunta> preguntas = this.loggedUser.PreguntasRealizadas.ToList();
            this.loggedUser.PreguntasRealizadas = preguntas.Where(x => x.Dificultad > dificultad).ToList();
        }

        #endregion Pregunta
    }
}
