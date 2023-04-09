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
            app.SetForm(form);
        }


        //esto cuando tengamos sonidos / selector de idioma / modo oscuro y demás lo usaremos (de momento no sé que poner)
        public override void BuildConfig()
        {
            throw new NotImplementedException();
        }
    }

}
