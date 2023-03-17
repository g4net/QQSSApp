using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
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

        public abstract void BuildForm(Form form);

        public abstract void BuildConfig();

<<<<<<< HEAD:ProyectoPSW/QQSSApp/AppBuilder.cs
        //public abstract void RunApp();
=======
        public App GetApp() { return app; }

>>>>>>> 566611c5025febd01fdd951d4a637d68cfc161eb:ProyectoPSW/ProyectoPSWMain/BussinesLogic/Services/AppBuilder.cs
    }



}
