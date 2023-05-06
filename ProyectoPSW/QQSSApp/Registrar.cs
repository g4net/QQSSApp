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
    public partial class Registrar : Form
    {
        Reglas formato;
        public Registrar()
        {
            InitializeComponent();
            /* Refactoring
            CorreoError.Text = "";
            ContraError.Text = "";
            RepetirContraError.Text = "";
            ErrorGeneral.Text = "";
            NombreError.Text = "";
            */
            this.FormClosed += (s, args) => Application.Exit();
            clearText();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aceptar_click(object sender, EventArgs e)
        {
            try
            {
                QQSS.service.Register(nombre.Text, Correo.Text, Contrasenya.Text, RepetirContrasenya.Text);
                Login login = new Login();
                login.Show();
                this.Hide();

            }
            catch (ServiceException ex)
            {

                if (Contrasenya.Text == "" || Correo.Text == "" || RepetirContrasenya.Text == "" || nombre.Text == "") ErrorGeneral.Text = "Please Complete all the camps";
                else
                {

                    if (ex.Message == "InvalidUserFormat")
                    {
                        NombreError.Text = "Username format is not correct \n Example: ValentinoPiola123";
                        if (!QQSS.service.TestEmail(Correo.Text)) { CorreoError.Text = "Email format is not correct \nExample: valentinoelbueno@dom.com"; }
                        if (!QQSS.service.TestPassword(Contrasenya.Text)) { ContraError.Text = "Password format is not correct \nExample: Password123$"; }
                        if (RepetirContrasenya.Text != Contrasenya.Text) RepetirContraError.Text = "The passwords do not match";

                    }
                    if (ex.Message == "InvalidPasswordFormat")
                    {
                        ContraError.Text = "Passowrd format is not correct \n Example: Password123$\"";

                        if (!QQSS.service.TestEmail(Correo.Text)) { CorreoError.Text = "Email format is not correct \nExample: valentinoelbueno@dom.com"; }
                        if (!QQSS.service.TestUser(nombre.Text)) { NombreError.Text = "Username format is not correct \nExample: ValentinoPiola123"; }
                        if (RepetirContrasenya.Text != Contrasenya.Text) RepetirContraError.Text = "The passwords do not match";


                    }
                    if (ex.Message == "InvalidEmailFormat") CorreoError.Text = "Email format is not correct \nExample: valentinoelbueno@dom.com";
                    {
                        if (!QQSS.service.TestUser(nombre.Text)) { NombreError.Text = "Username format is not correct \nExample: ValentinoPiola123"; }
                        if (!QQSS.service.TestPassword(Contrasenya.Text)) { ContraError.Text = "Password format is not correct \nExample: Password123$"; }
                        if (RepetirContrasenya.Text != Contrasenya.Text) RepetirContraError.Text = "The passwords do not match";

                    }
                    if (ex.Message == "UsernameExists") NombreError.Text = "Username is already taken";
                    if (ex.Message == "EmailExists") CorreoError.Text = "An account is already linked to that email";
                    if (ex.Message == "Passwordsnotmatch") RepetirContraError.Text = "The passwords do not match";
                }
            }

        }

        private void Volver_click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChange(object sender, MouseEventArgs e)
        {
    
           
            if (Correo.Text != "")
                if (!QQSS.service.TestEmail(Correo.Text)) { CorreoError.Text = "Email format is not correct \nExample: valentinoelbueno@dom.com"; }
            if (Contrasenya.Text != "")
                if (!QQSS.service.TestPassword(Contrasenya.Text)) { ContraError.Text = "Password format is not correct \nExample: Password123$"; }
            if (RepetirContrasenya.Text != "")
            {
                if (RepetirContrasenya.Text != Contrasenya.Text) RepetirContraError.Text = "The passwords do not match";
            }
        }

        private void Correo_change(object sender, MouseEventArgs e)
        {

            
            
            if (nombre.Text != "")
                if (!QQSS.service.TestUser(nombre.Text)) { NombreError.Text = "Username format is not correct \nExample: ValentinoPiola123"; }
            if (Contrasenya.Text != "")
                if (!QQSS.service.TestPassword(Contrasenya.Text)) { ContraError.Text = "Password format is not correct \nExample: Password123$"; }
            if (RepetirContrasenya.Text != "")
            {
                if (RepetirContrasenya.Text != Contrasenya.Text) RepetirContraError.Text = "The passwords do not match";
            }
        }
        
        
        private void Contrasenya_Change(object sender, MouseEventArgs e)
        {
           
              
            if (Correo.Text != "")
                if (!QQSS.service.TestEmail(Correo.Text)) { CorreoError.Text = "Email format is not correct \nExample: valentinoelbueno@dom.com"; }
            if (nombre.Text != "")
                if (!QQSS.service.TestUser(nombre.Text)) { NombreError.Text = "Username format is not correct \nExample: ValentinoPiola123"; }
            if (RepetirContrasenya.Text != "")
            {
                if (RepetirContrasenya.Text != Contrasenya.Text) RepetirContraError.Text = "The passwords do not match";
            }
        }
        

        private void RepetirContra_change(object sender, MouseEventArgs e)
        {
            
            
            if (Correo.Text != "")
                if (!QQSS.service.TestEmail(Correo.Text)) { CorreoError.Text = "Email format is not correct \nExample: valentinoelbueno@dom.com"; }
            if (nombre.Text != "")
                if (!QQSS.service.TestUser(nombre.Text)) { NombreError.Text = "Username format is not correct \nExample: ValentinoPiola123"; }
            if (Contrasenya.Text != "")
                if (!QQSS.service.TestPassword(Contrasenya.Text)) { ContraError.Text = "Password format is not correct \nExample: Password123$"; }

        }

        public void clearText() {
            CorreoError.Text = "";
            ContraError.Text = "";
            RepetirContraError.Text = "";
            ErrorGeneral.Text = "";
            NombreError.Text = "";
        }

        private void FormatoClick(object sender, EventArgs e)
        {
            if (formato != null) formato.Close();
            formato = new Reglas();
            formato.Show();
        }

        private void nombreChangeText(object sender, EventArgs e)
        {
            NombreError.Text = "";
            ErrorGeneral.Text = "";
        }

        private void correo_text_Change(object sender, EventArgs e)
        {
            CorreoError.Text = "";
            ErrorGeneral.Text = "";
        }

        private void contrasenya_text_change(object sender, EventArgs e)
        {
            ContraError.Text = "";
            RepetirContraError.Text = "";
            ErrorGeneral.Text = "";
        }

        private void repetircontra_textChange(object sender, EventArgs e)
        {
            RepetirContraError.Text = "";
            ErrorGeneral.Text = "";
        }
    }
}
