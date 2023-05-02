using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Services
{
    public interface IServiceManager
    {
        void Init(IUserManager userManager, IDatabaseService databaseService, IGameController gameController);

        #region User
        void Login(string username, string password);
        User GetLoggedUser();
        bool CheckUserLevel();
        void Logout();



        #endregion

        #region Pregunta
        List<Pregunta> LoadUndoneQuestionsByDifficulty(int difficulty);

        void Questions();

        List<Respuesta> GetRespuestas();

        #endregion

        #region Partida
        void CrearPartida(int lvl);

        string EnlaceInteres(int ods);
        void SavePartida();
        int GetError();
        Reto GetReto();
        bool TestAnswer(string txt);
        int GetProgressIndex();
        bool GetConsolidado();
        void AbandonarPartida();
        void PerderPartida();
        void GanarPartida();
        void Consolidar();
        int GetPuntuacionPartida();
        void RetoAcertado();
        void RetoFallado();
        int GetPuntuacionConsolidada();
        #endregion

        #region Sonidos

        void PlaySonido(string sonido);

        #endregion
    }
}
