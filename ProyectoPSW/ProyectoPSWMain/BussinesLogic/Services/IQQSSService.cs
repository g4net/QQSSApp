using ProyectoPSWMain.BussinesLogic.Services;
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

        #endregion

        #region Partida

        int [] GetDifficultyArray(int level);

        #endregion

        #region Reto

        #endregion

        #region Pregunta

        #endregion


    }
}
