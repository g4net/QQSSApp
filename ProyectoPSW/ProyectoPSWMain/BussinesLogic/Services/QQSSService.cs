using ProyectoPSWMain.Entities;
using ProyectoPSWMain.EntityFramework;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPSWMain.Services
{
    public class QQSSService : IQQSSService
    {
        // Dal persistence service
        private readonly IRepository repository;

        // Resources Manager for error messaging
        private ResourceManager resourceManager;

        private User loggedUser;


        public QQSSService(IRepository repository)
        {
            this.repository = repository;

        }

        public void DBInitialization()
        {

        }

        #region User

        #endregion

        #region Partida

        public int[] GetDifficultyArray(int level)
        {
            // falta implementar el ServiceException y el archivo de las excepciones
            //if(level > 4) throw new ServiceException(resourceManager.GetString("Difficulty level does not exist!""));
            switch (level)
            {
                case 0: return new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 2, 2 };
                case 1: return new int[] { 0, 0, 0, 0, 1, 1, 1, 2, 2, 2 };
                case 2: return new int[] { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2 };
                case 3: return new int[] { 0, 0, 1, 1, 1, 1, 2, 2, 2, 2 };
                case 4: return new int[] { 1, 1, 1, 1, 1, 2, 2, 2, 2, 2 };
            }

            return null;
        }

        #endregion
    }
}
