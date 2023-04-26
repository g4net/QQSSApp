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
        void Login(string username, string password);

        List<Pregunta> LoadUndoneQuestionsByDifficulty(int difficulty);

        void Questions();

        List<Respuesta> GetRespuestas();

        void SavePartida();
    }
}
