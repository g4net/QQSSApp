using ProyectoPSWMain.Services;
using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQSSApp
{
    public class QQSSAppBuilder : AppBuilder
    {

        public QQSSAppBuilder() : base()
        {

        }


        public override void BuildForm(FormTemplate mainForm)
        {
            this.mainForm = mainForm;
        }

        public override void BuildService(IQQSSService service)
        {
            this.service = service;
            mainForm.SetService(service);
        }


        //esto cuando tengamos sonidos / selector de idioma / modo oscuro y demás lo usaremos (de momento no sé que poner)
        public override void BuildConfig()
        {
            throw new NotImplementedException();
        }

        public override void RunApp()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm);
        }
    }

}