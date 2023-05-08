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
        void AddRetoJugado(Reto reto);
        void SetLoggedUser(User user);
        void SetContraseña(string contraseña);
        void SetEmail(string correo);
        void SetNombre(string nombre);
        void UpdateUserRetos(List<Reto> retosAcertados, List<Reto> retosJugados);
        bool CheckRetoPlayed(Reto reto);
        double GetPuntajeODS(int ods);
        List<Pregunta> GetUsersQuestionByDifficulty(int dificultad);
        List<Frase> GetUsersFrasesByDifficulty(int dificultad);
        List<Reto> GetUsersRetosByDifficulty(int dificultad);
        void ResetUserQuestions(int dificultad);
        void ResetUserFrases(int dificultad);
        void ResetUserRetos(int dificultad);
    }
}
