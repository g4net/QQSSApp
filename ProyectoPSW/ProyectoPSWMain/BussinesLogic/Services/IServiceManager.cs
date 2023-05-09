using ProyectoPSWMain.BussinesLogic.Services;
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

        void Register(string username, string email, string password, string repasword);
        void SetAtributo(string tipoAtributo, string nuevoAtributo);
        double GetPuntajeODS(int ods);
        bool TestUser(string username);
        bool TestEmail(string email);

        bool TestPassword(string password); 
        #endregion

        #region Reto
        List<Pregunta> LoadUndoneQuestionsByDifficulty(int difficulty);
        List<Frase> LoadUndoneFrasesByDifficulty(int difficulty);

        void Questions();

        List<Respuesta> GetRespuestas();

        #endregion

        #region Partida
        void CrearPartida(int lvl);
        int GetNumPistas();
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
        void SetPuntosStrategy();
        int GetPuntuacionConsolidada();
        void GenerarRetos(TipoReto tipoReto);
        void UsarPista();
        int GetPuntuacionReto();
        string QuitarLetras(out List<char> letrasHueco);
        #endregion

        #region Sonidos

        void PlaySonido(string sonido);

        #endregion
    }
}
