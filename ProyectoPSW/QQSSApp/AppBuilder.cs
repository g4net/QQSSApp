using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQSSApp
{
    public abstract class AppBuilder
    {
        protected FormTemplate mainForm;
        protected IQQSSService service;

        public AppBuilder() { }

        public abstract void BuildForm(FormTemplate mainForm);

        public abstract void BuildService(IQQSSService service);

        public abstract void BuildConfig();

        public abstract void RunApp();
    }



}
