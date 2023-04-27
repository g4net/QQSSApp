using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPSWMain.EntityFramework;
using ProyectoPSWMain.Services;

namespace QQSSApp
{
    internal static class QQSSQuizLauncher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            AppBuilder builder = new QQSSAppBuilder();
            Director director = new Director();
            director.BuildApp(builder);
            
            Application.EnableVisualStyles();
            Application.Run(QQSS.app.GetForm());


            
        }



    }
}
