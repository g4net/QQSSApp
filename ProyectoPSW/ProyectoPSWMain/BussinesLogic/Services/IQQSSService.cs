using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPSWMain.Services
{
    public interface IQQSSService
    {
        void RemoveAllData();
        void Commit();  
        void DBInitialization();

        #region User
        void AddUser(User usuario);
        void Login(String dni);
        void UpdateScore(int points);
        User GetLoggedUser();
        #endregion

        #region Partida
        void UpdateGameScore(int score);
        void ResetGameScore();
        void DeleteUser(int id);
        void AddPartida(Partida game);
        void SetPartidaActual(Partida partida);
        Partida GetPartidaActual();  
        Partida GetPartida(int level, int points);
        int [] GetDifficultyArray(int level);

        #endregion

        #region Reto
        
        #endregion

        #region Pregunta
        void AddPregunta(Pregunta pregunta);
        void AddPreguntaToPartida(Pregunta pregunta, Partida partida);
        void Questions(int[] Dificulty);

        Pregunta QuestionServIndex(int index);
        #endregion

        #region Respuesta
        List<Respuesta> AnswerShuffle(Pregunta Question);

        bool TestAnswer(String txt, Pregunta pregunta);
        #endregion


    }
}
