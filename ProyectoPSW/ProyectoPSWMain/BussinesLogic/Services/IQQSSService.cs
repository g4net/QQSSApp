using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Services
{
    public interface IQQSSService
    {
        void DBInitialization();

        #region User
        void AddUser(User usuario);
        void Login(String dni);
        void UpdateScore(int points);
        User GetLoggedUser();
        #endregion

        #region Partida
        void AddPartida(Partida game);

        Partida GetPartida(int level, int points);
        int [] GetDifficultyArray(int level);

        #endregion

        #region Reto
        
        #endregion

        #region Pregunta
        void AddPregunta(Pregunta pregunta);
        void AddPreguntaToPartida(Pregunta pregunta, Partida partida);
        List<Pregunta> Questions(int[] Dificulty);
        #endregion

        #region Respuesta
        List<Respuesta> AnswerShuffle(Pregunta Question);

        bool TestAnswer(String txt, Pregunta pregunta);
        #endregion


    }
}
