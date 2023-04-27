using ProyectoPSWMain.Entities;
using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPSWMain.Services
{
    public class ServiceManager : IServiceManager
    {
        private IUserManager userManager;
        private IDatabaseService databaseService;
        private IGameController gameController;

        public ServiceManager(IUserManager userManager, IDatabaseService databaseService, IGameController gameController)
        {
            this.userManager = userManager;
            this.databaseService = databaseService;
            this.gameController = gameController;
        }

        #region User

        public void Login(string username, string password)
        {
            if(!userManager.IsValidUsername(username)) throw new ServiceException("InvalidUserFormat");
            if(!userManager.IsValidPassword(password)) throw new ServiceException("InvalidPasswordFormat");
            User login;
            try
            {
                login = databaseService.Login(username, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            userManager.SetLoggedUser(login);

        }

        public void Logout()
        {
            databaseService.Logout();
        }

        public User GetLoggedUser()
        {
            return userManager.GetLoggedUser();
        }

        public bool CheckUserLevel()
        {
            return userManager.CheckLevel();
        }


        #endregion


        #region Pregunta

        public List<Pregunta> LoadUndoneQuestionsByDifficulty(int difficulty)
        {
            List<Pregunta> preguntasDificultad = databaseService.LoadQuestionsByDifficulty(difficulty);
            List<Pregunta> preguntasUsuario = userManager.GetUsersQuestionByDificulty(difficulty);

            return preguntasDificultad.Except(preguntasUsuario).ToList();
        }

        public void Questions()
        {
            int[] dificultad = gameController.GetDifficultyArray();
            if (dificultad.Length != 10) throw new ServiceException("Difficulty array has not the correct length");


            var questions = new List<Reto>();
            Random random = new Random();
            int prevDifficulty = -1;
            List<Pregunta> questionsDB = null;


            foreach (int difficulty in dificultad)
            { 

                if (difficulty > 4 || difficulty < 0) throw new ServiceException("Difficulty array has incorrect values");
                if (difficulty != prevDifficulty)
                {
                    questionsDB = LoadUndoneQuestionsByDifficulty(difficulty);
                    prevDifficulty = difficulty;
                }
                if (questionsDB.Count == 0)
                {
                    userManager.ResetUserQuestions(difficulty);
                    questionsDB = LoadUndoneQuestionsByDifficulty(difficulty);
                }
                int index = random.Next(questionsDB.Count);
                questions.Add(questionsDB[index]);



                questionsDB.RemoveAt(index);
            }

            gameController.SetRetos(questions.ToList());
        }

        public List<Respuesta> GetRespuestas()
        {
            return gameController.AnswerShuffle();
        }

        #endregion


        #region Partida

        public void CrearPartida(int lvl)
        {
            gameController.CrearPartida(lvl);
            Questions();
        }

        public void SavePartida()
        {
            Partida partida = gameController.GetPartidaActual();
            if (partida != null) throw new ServiceException("There is no game to save");
            databaseService.SavePartida(partida);
        }

        public void RetoAcertado()
        {
            gameController.RetoAcertado();
        }

        public void RetoFallado()
        {
            gameController.RetoFallado();
        }

        public bool TestAnswer(string txt)
        {
            return gameController.TestAnswer(txt);
        }

        public Reto GetReto()
        {
            return gameController.GetReto();
        }

        public int GetProgressIndex()
        {
            return gameController.GetIndex();
        }

        public bool GetConsolidado()
        {
            return gameController.GetConsolidado();
        }

        protected void ActualizarRetosAcertados()
        {
            List<Reto> retosAcertados = gameController.GetRetosAcertados();
            userManager.UpdateUserRetos(retosAcertados);
        }

        public void AbandonarPartida()
        {
            ActualizarRetosAcertados();
            int puntuacion = gameController.GetPartidaActual().PuntuacionConsolidada;
            userManager.UpdateUserScore(puntuacion);
        }

        public void GanarPartida()
        {
            ActualizarRetosAcertados();
            int puntuacion = gameController.GetPartidaActual().PuntuacionPartida;
            userManager.UpdateUserScore(puntuacion);

        }

        public void Consolidar()
        {
            gameController.Consolidar();
        }

        public int GetError()
        {
            return gameController.GetError();
        }

        public int GetPuntuacionConsolidada()
        {
            return gameController.GetPartidaActual().PuntuacionConsolidada;
        }

        public int GetPuntuacionPartida()
        {
            return gameController.GetPartidaActual().PuntuacionPartida;
        }

        #endregion
    }
}
