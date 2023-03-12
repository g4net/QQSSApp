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
        private AppBuilder builder;
        public Director(AppBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildApp(FormTemplate form, IQQSSService service)
        {
            builder.BuildForm(form);

            builder.BuildService(service);

            builder.RunApp();
        }
         
    }
}
