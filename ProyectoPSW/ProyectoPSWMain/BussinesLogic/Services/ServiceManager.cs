using ProyectoPSWMain.Entities;
using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPSWMain.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private static ServiceManager instance = null;
        private IUserManager userManager;
        private IDatabaseService databaseService;
        private IGameController gameController;

        ServiceManager()
        {
        }

        public static ServiceManager Instance
        {
            get
            {
                if (instance == null) instance = new ServiceManager();
                return instance;
            }
        }

        public void Init(IUserManager userManager, IDatabaseService databaseService, IGameController gameController)
        {
            if (this.userManager == null) this.userManager = userManager;
            if (this.databaseService == null) this.databaseService = databaseService;
            if (this.gameController == null) this.gameController = gameController;
        }

        public void SetUserManager(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        public void SetDatabaseService(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        public void SetGameController(IGameController gameController)
        {
            this.gameController = gameController;
        }
        

        #region User

        public void Login(string username, string password)
        {
            if(username.IndexOf("@") != -1 && userManager.IsValidEmail(username)) throw new ServiceException("InvalidEmailFormat");
            if (!userManager.IsValidUsername(username)) throw new ServiceException("InvalidUserFormat");
            if (!userManager.IsValidPassword(password)) throw new ServiceException("InvalidPasswordFormat");
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

        public void Register(string username, string email, string password) 
        {
            if (!userManager.IsValidUsername(username)) throw new ServiceException("InvalidUserFormat");
            if (!userManager.IsValidPassword(password)) throw new ServiceException("InvalidPasswordFormat");
            if (!userManager.IsValidEmail(email)) throw new ServiceException("InvalidEmailFormat");
            try
            {
                databaseService.Register(username, email, password);
            }
            catch (Exception e)
            {
                throw e; 
            }
            
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

        public string EnlaceInteres(int ods)
        {
            return gameController.EnlaceInteres(ods);
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

        public void PerderPartida()
        {
            ActualizarRetosAcertados();
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


        #region Sonidos

        public void PlaySonido(string sonido)
        {
            string rutaSonido = @"..\..\Resources\Sonidos\" + sonido + ".wav";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(rutaSonido);
            player.Play();
        }

        #endregion
    }
}
