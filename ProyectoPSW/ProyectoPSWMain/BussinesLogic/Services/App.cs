using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPSWMain.Services
{
    public class App
    {
        private Form form;
        public App()
        {
        }

        public Form GetForm() { return form; }

        public void SetForm(Form form)
        {
            this.form = form;
        }


        

    }
}
