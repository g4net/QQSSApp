using ProyectoPSWMain.EntityFramework;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPSWMain.Services
{
    public abstract class AppBuilder
    {
        protected App app;

        public AppBuilder() { }

        public abstract void BuildForm(Type formType);

        public abstract void BuildGameController();

        public abstract void BuildDbAccess();

        public abstract void BuildService();

        public abstract void BuildUserManager();

        public abstract void BuildConfig();

        public void SetApp() { QQSS.app = app;  }


    }



}
