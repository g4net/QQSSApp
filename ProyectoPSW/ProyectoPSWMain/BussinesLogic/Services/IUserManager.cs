using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Services
{
    public interface IUserManager
    {
        bool IsValidUsername(string username);
        bool IsValidPassword(string password);
        bool IsValidEmail(string email);
        User GetLoggedUser();
        void UpdateUserScore(int points);
        bool CheckLevel();
        void SetLoggedUser(User user);
        void UpdateUserRetos(List<Reto> retos);
        bool CheckRetoPlayed(Reto reto);
        List<Pregunta> GetUsersQuestionByDificulty(int dificultad);
        void ResetUserQuestions(int dificultad);
    }
}
