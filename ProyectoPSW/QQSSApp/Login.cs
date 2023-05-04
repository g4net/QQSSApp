using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
            this.FormClosed += (s, args) => Application.Exit();
            /*Refactoring
             LoggerError.Text = "";
             ErrorGeneral.Text = "";
             PasswordError.Text = "";
            */
            clearText();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /* Refactoring
            LoggerError.Text = "";
            ErrorGeneral.Text = "";
            PasswordError.Text = "";*/
            clearText();

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
                /* Refactoring
                if (PasswordText.Text == "" || LoggerText.Text == "") ErrorGeneral.Text = "Please Complete all the camps";
                else
                {
                    if (ex.Message == "InvalidUserFormat") LoggerError.Text = "There is no user with that username/email";
                    if (ex.Message == "InvalidEmailFormat") LoggerError.Text = "There is no user with that useremail";
                    if (ex.Message == "InvalidPasswordFormat") PasswordError.Text = "The Pasword is not correct";
                    if (ex.Message == "UserNotRegistered") ErrorGeneral.Text = "There is no user with that username/email";
                    if (ex.Message == "NotRightPassword") PasswordError.Text = "The Pasword is not correct";
                }*/
                this.ExcpetionHandler(ex);
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
            /*Refactoring
            LoggerError.Text = "";
            ErrorGeneral.Text = "";
            PasswordError.Text = "";*/
            clearText();

        }
        private void clearText()
        {
            LoggerError.Text = "";
            ErrorGeneral.Text = "";
            PasswordError.Text = "";
        }
        private void ExcpetionHandler(Exception ex)
        {
            if (PasswordText.Text == "" || LoggerText.Text == "") ErrorGeneral.Text = "Please Complete all the camps";
            else
            {
                if (ex.Message == "InvalidUserFormat" || ex.Message == "InvalidEmailFormat" || ex.Message == "UserNotRegistered" || ex.Message == "InvalidPasswordFormat" || ex.Message == "NotRightPassword") PasswordError.Text = "The User/Email and Password combination is not correct";


            }
        }
    }
}
