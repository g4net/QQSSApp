using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPSWMain.EntityFramework;
using ProyectoPSWMain.Services;

namespace QQSSApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            AppBuilder appBuilder = new QQSSAppBuilder();
            Director director = new Director(appBuilder);
            FormTemplate mainForm = new PantallaPrincipalForm();
            IQQSSService service = new QQSSService(new EntityFrameworkDAL(new ProyectPSWDBContext()));

            director.BuildApp(mainForm, service);

            
        }



    }
}
