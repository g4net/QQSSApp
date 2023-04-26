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
        void CheckLevel();

        void SetLoggedUser(User user);


        void UpdateUserRetos(Reto reto);
        bool CheckRetoPlayed(Reto reto);
        List<Pregunta> GetUsersQuestionByDificulty(int dificultad);
        void ResetUserQuestions(int dificultad);
    }
}
