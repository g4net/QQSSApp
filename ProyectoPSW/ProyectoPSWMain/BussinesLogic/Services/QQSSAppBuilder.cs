using ProyectoPSWMain.Services;
using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace ProyectoPSWMain.Services
{
    public class QQSSAppBuilder : AppBuilder
    {
        IDatabaseService databaseService;
        IGameController gameController;
        IUserManager userManager;
        public QQSSAppBuilder() : base()
        {
            app = new App();
        }


        public override void BuildDbAccess()
        {
            DbContextPSW dbContext = new ProyectPSWDBContext();
            IRepository repository = new EntityFrameworkDAL(dbContext);
            databaseService = new DatabaseService(repository);
        }

        public override void BuildGameController()
        {
            gameController = new GameController();
        }

        public override void BuildUserManager()
        {
            userManager = new UserManager();
        }

        public override void BuildService()
        { 
            QQSS.service = new ServiceManager(userManager, databaseService, gameController);    
        }

        public override void BuildForm(Type typeForm)
        {
            if (typeForm.BaseType != typeof(Form)) throw new ServiceException("The director is not giving a form type to the builder");
            Form form = (Form)Activator.CreateInstance(typeForm, new Object[] { new QQSSService(new EntityFrameworkDAL(new ProyectPSWDBContext())) });
            app.SetForm(form);
        }



        //esto cuando tengamos sonidos / selector de idioma / modo oscuro y demás lo usaremos (de momento no sé que poner)
        public override void BuildConfig()
        {
            throw new NotImplementedException();
        }
    }

}
