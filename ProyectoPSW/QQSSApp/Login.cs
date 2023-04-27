using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQSSApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoggerError.Text = "";
            ErrorGeneral.Text = "";
            PasswordError.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoggerError.Text = "";
            ErrorGeneral.Text = "";
            PasswordError.Text = "";
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            try 
            {
                QQSS.service.Login(LoggerText.Text, PasswordText.Text);
                PantallaPrincipalForm paginaPrincipal = new PantallaPrincipalForm();
                paginaPrincipal.Show();
                this.Hide();
            }
            catch (ServiceException ex) 
            {
                if (ex.Message == "InvalidUserFormat") LoggerError.Text = "Username is not correct";
                else PasswordError.Text = ex.Message;
            }
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            Registrar registrarse = new Registrar();
            registrarse.Show();
            this.Hide();
            
        }

        private void PassTextChanged(object sender, EventArgs e)
        {
            LoggerError.Text = "";
            ErrorGeneral.Text = "";
            PasswordError.Text = "";
        }
    }
}
