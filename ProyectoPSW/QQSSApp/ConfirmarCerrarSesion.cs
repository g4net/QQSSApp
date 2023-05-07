using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQSSApp
{
    public partial class ConfirmarCerrarSesion : Form
    {
        Form pantallaPrincipalForm;
        Form UserForm;
        public ConfirmarCerrarSesion(Form PantallaPrincipalForm, Form Usuario)
        {
            InitializeComponent();
            this.pantallaPrincipalForm = PantallaPrincipalForm;
            this.UserForm = Usuario;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            QQSS.service.Logout();
            this.Close();
            pantallaPrincipalForm.Close();
            UserForm.Close();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
