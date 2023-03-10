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
    }
}
