using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProyectoPSWMain.Services
{
    public interface IUserManager
    {
        bool IsValidUsername(string username);
        bool IsValidPassword(string password);
        bool IsValidEmail(string email);
        User GetLoggedUser();
        void UpdateUserScore(int points);
        void IncrementaAciertos();
        void IncrementaFallos();
        bool CheckLevel();
        void SetLoggedUser(User user);
        void UpdateUserRetos(List<Reto> retos);
        bool CheckRetoPlayed(Reto reto);
        List<Pregunta> GetUsersQuestionByDifficulty(int dificultad);
        List<Frase> GetUsersFrasesByDifficulty(int dificultad);
        List<Reto> GetUsersRetosByDifficulty(int dificultad);
        void ResetUserQuestions(int dificultad);
        void ResetUserFrases(int dificultad);
        void ResetUserRetos(int dificultad);
    }
}
