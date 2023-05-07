using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Services
{
    public interface IDatabaseService
    {

        #region User
        User Login(string login, string password);

        void Register(string nombre, string email, string password,string reppassword);

        void DeleteUser(int dni);

        void Logout();


        #endregion


        #region Pregunta

        List<Pregunta> LoadQuestionsByDifficulty(int difficulty);
        List<Frase> LoadFrasesByDifficulty(int difficulty);
        List<Reto> LoadRetosByDifficulty(int difficulty);

        #endregion


        #region Partida

        void SavePartida(Partida partida);

        #endregion
    }
}
