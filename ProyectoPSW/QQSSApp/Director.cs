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
            IQQSSService service = new QQSSService(new EntityFrameworkDAL(new ProyectPSWDBContext()));
            builder.BuildForm(new Login(service));
        }
         
    }
}
