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
        IQQSSService Service;
        public Login(IQQSSService Service)
        {
            InitializeComponent();
            this.Service = Service;
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
                Service.Login(LoggerText.Text, PasswordText.Text);
                Service.GetLoggedUser();
                PantallaPrincipalForm paginaPrincipal = new PantallaPrincipalForm(Service);
                paginaPrincipal.Show();
                this.Hide();
            }catch (ServiceException ex) {
                if (ex.Message == "The email or name is not correct") 
                { LoggerError.Text = ex.Message; }
                else if (ex.Message == "Please Complete All the Camps") {
                    ErrorGeneral.Text = ex.Message;
                }
                else {
                    PasswordError.Text = ex.Message;
                }
               

            }
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            Registrar registrarse = new Registrar(Service);
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
