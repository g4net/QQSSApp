using ProyectoPSWMain.Services;
using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPSWMain.Services
{
    public class QQSSAppBuilder : AppBuilder
    {
        public QQSSAppBuilder() : base()
        {
            app = new App();
        }


        public override void BuildForm(Form form)
        {
            app.form = form;
        }


        //esto cuando tengamos sonidos / selector de idioma / modo oscuro y demás lo usaremos (de momento no sé que poner)
        public override void BuildConfig()
        {
            throw new NotImplementedException();
        }
<<<<<<< HEAD:ProyectoPSW/QQSSApp/QQSSAppBuilder.cs

        //public override void RunApp()
        //{
        //    Application.EnableVisualStyles();
        //    //Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(mainForm);
        //}
=======
>>>>>>> 566611c5025febd01fdd951d4a637d68cfc161eb:ProyectoPSW/ProyectoPSWMain/BussinesLogic/Services/QQSSAppBuilder.cs
    }

}
