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
            IQQSSService service = new QQSSService(new EntityFrameworkDAL(new ProyectPSWDBContext()));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaPrincipalForm(service));
        }

    }
}
