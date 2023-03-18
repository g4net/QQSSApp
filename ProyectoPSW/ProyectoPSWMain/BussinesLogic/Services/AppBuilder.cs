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

        public App GetApp() { return app; }


    }



}
