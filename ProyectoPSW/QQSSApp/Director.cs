using ProyectoPSWMain.EntityFramework;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQSSApp
{
    public class Director
    {
        public Director()
        {
        }

        public void BuildApp(AppBuilder builder)
        {
            builder.BuildDbAccess();
            builder.BuildUserManager();
            builder.BuildGameController();
            builder.BuildService();
            builder.BuildForm(typeof(Login));
            builder.SetApp();
        }
         
    }
}
