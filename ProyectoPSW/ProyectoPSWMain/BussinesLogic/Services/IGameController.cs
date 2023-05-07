using ProyectoPSWMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Services
{
    public interface IGameController
    {
        void SetRetos(List<Reto> retos);
        int GetError();

        string EnlaceInteres(int ods);
        int GetIndex();
        void UpdateError();
        void Consolidar();
        bool IsConsolidado();
        void CrearPartida(int nivel);
        void SetPartidaActual(Partida partida);
        Partida GetPartidaActual();
        int[] GetDifficultyArray();
        bool GetConsolidado();
        Reto GetReto();
        void RetoAcertado();
        void SetPuntosStrategy();
        void RetoFallado();
        List<Respuesta> AnswerShuffle();
        bool TestAnswer(string txt);
        List<Reto> GetRetosAcertados();
        List<Reto> GetRetosJugados();
    }
}
