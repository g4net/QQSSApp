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
        //void DBInitialization();

        #region User
        void AddUser(User usuario);
        void Login(String dni);
        void UpdateUserScore(int points);
        User GetLoggedUser();

        void NextLevel(User usuario);
        #endregion

        #region Partida
        int GetErrores();
        int GetPuntuacionAcumulada();
        void SetPuntuacionAcumulada(int points);
        void UpdateErrores();
        
        
        void Consolidar();

        bool IsConsolidado();
        void ResetErroresyConsolidaciones();
        void CrearPartida(int nivel);
        void UpdateGameScore(int score);
        void ResetGameScore();
        void DeleteUser(int id);
        void AddPartida(Partida game);
        void SetPartidaActual(Partida partida);
        Partida GetPartidaActual();  
        Partida GetPartida(int level, int points);
        int [] GetDifficultyArray(int level);

        bool GetConsolidado();

        #endregion

        #region Reto

        #endregion



        #region Pregunta
        List<Pregunta> GetUsersQuestionByDificulty(int dificultad);
        void UpdateUserQuestions(Pregunta pregunta);
        void AddPregunta(Pregunta pregunta);
        void AddPreguntaToPartida(Pregunta pregunta, Partida partida);
        void Questions(int[] Dificulty);
        bool CheckQuestionPlayed(Pregunta pregunta);
        void ResetUserQuestions(int dificultad);
        List<int> GetProgresoPreguntas();
        void ProgresoDeletePreguntaFallada(int index);
        void ProgresoAddPreguntaFallada(int index);
        void CleanProgresoPreguntas();
        Pregunta QuestionServIndex(int index);
        #endregion

        #region Respuesta
        List<Respuesta> AnswerShuffle(Pregunta Question);

        bool TestAnswer(String txt, Pregunta pregunta);
        #endregion


    }
}
