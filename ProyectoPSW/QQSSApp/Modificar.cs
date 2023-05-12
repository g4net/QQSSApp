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
    public partial class Modificar : Form
    {
        Reglas formato;
        Form pantallaPrincipal;
        public Modificar(Form pantallaPrincipal)
        {
            InitializeComponent();
            this.CenterToScreen();
            /* Refactoring
            CorreoError.Text = "";
            ContraError.Text = "";
            RepetirContraError.Text = "";
            ErrorGeneral.Text = "";
            NombreError.Text = "";
            */
            clearText();
            this.pantallaPrincipal = pantallaPrincipal; 
        }

        private void Aceptar_click(object sender, EventArgs e)
        {
            try
            {
                if (nombre.Text != "")
                {
                    QQSS.service.SetAtributo("nombre", nombre.Text);
                }
                if (Correo.Text != "") {
                    QQSS.service.SetAtributo("email", Correo.Text);
                }
                if(RepetirContrasenya.Text != "" && Contrasenya.Text != "")
                {
                    if(Contrasenya.Text == RepetirContrasenya.Text)
                    {
                        QQSS.service.SetAtributo("contraseña", Contrasenya.Text);
                    }
                }
                QQSS.service.Logout();
                Usuario usuarioForm = new Usuario(pantallaPrincipal);
                this.Hide();
                usuarioForm.ShowDialog();
                

            }
            catch (ServiceException ex)
            {
                AceptarButton.Enabled = false;
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
                if (ex.Message == "InvalidEmailFormat") 
                {
                    CorreoError.Text = "Email format is not correct \nExample: valentinoelbueno@dom.com";
                    if (!QQSS.service.TestUser(nombre.Text)) { NombreError.Text = "Username format is not correct \nExample: ValentinoPiola123"; }
                    if (!QQSS.service.TestPassword(Contrasenya.Text)) { ContraError.Text = "Password format is not correct \nExample: Password123$"; }
                    if (RepetirContrasenya.Text != Contrasenya.Text) RepetirContraError.Text = "The passwords do not match";

                }
                if (ex.Message == "UsernameExists") NombreError.Text = "Username is already taken";
                if (ex.Message == "EmailExists") CorreoError.Text = "An account is already linked to that email";
                if (ex.Message == "Passwordsnotmatch") RepetirContraError.Text = "The passwords do not match";
            }

        }

        private void Volver_click(object sender, EventArgs e)
        {
            Usuario usuarioForm = new Usuario(pantallaPrincipal);
            this.Hide();
            usuarioForm.ShowDialog();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChange(object sender, MouseEventArgs e)
        {
    
            if (Correo.Text != "")
            {
                if (!QQSS.service.TestEmail(Correo.Text))
                {
                    MostrarTextoCorreoMal();
                }
                AceptarButton.Enabled = true;
            }
                
            if (Contrasenya.Text != "")
            {
                if (!QQSS.service.TestPassword(Contrasenya.Text))
                {
                    MostrarTextoContraseñaMal();
                }
                AceptarButton.Enabled = true;
            }
                
            if (RepetirContrasenya.Text != "")
            {
                if (RepetirContrasenya.Text != Contrasenya.Text)
                {
                    MostrarTextoRepetirContraseñaMal();
                }
                AceptarButton.Enabled = true;
            }
        }

        private void Correo_change(object sender, MouseEventArgs e)
        {
            if (nombre.Text != "")
            {
                if (!QQSS.service.TestUser(nombre.Text))
                {
                    MostrarTextoNombreMal();
                }
                AceptarButton.Enabled = true;
            }
            if (Contrasenya.Text != "")
            {
                if (!QQSS.service.TestPassword(Contrasenya.Text))
                {
                    MostrarTextoContraseñaMal();
                }
                AceptarButton.Enabled = true;
            }
                
            if (RepetirContrasenya.Text != "")
            {
                if (RepetirContrasenya.Text != Contrasenya.Text)
                {
                    MostrarTextoRepetirContraseñaMal();
                }
                AceptarButton.Enabled = true;
            }
        }

        private void MostrarTextoCorreoMal()
        {
            CorreoError.Text = "Email format is not correct \nExample: valentinoelbueno@dom.com";
            AceptarButton.Enabled = false;
        }

        private void MostrarTextoNombreMal()
        {
            NombreError.Text = "Username format is not correct \nExample: ValentinoPiola123";
            AceptarButton.Enabled = false;
        }

        private void MostrarTextoContraseñaMal()
        {
            ContraError.Text = "Password format is not correct \nExample: Password123$";
            AceptarButton.Enabled = false;
        }

        private void MostrarTextoRepetirContraseñaMal()
        {
            RepetirContraError.Text = "The passwords do not match";
            AceptarButton.Enabled = false;
        }
        
        
        private void Contrasenya_Change(object sender, MouseEventArgs e)
        { 
            if (Correo.Text != "")
            {
                if (!QQSS.service.TestEmail(Correo.Text))
                {
                    MostrarTextoCorreoMal();
                }
                AceptarButton.Enabled = true;
            }
            if (nombre.Text != "")
            {
                if (!QQSS.service.TestUser(nombre.Text))
                {
                    MostrarTextoNombreMal();
                }
                AceptarButton.Enabled = true;
            }
            if (RepetirContrasenya.Text != "")
            {
                if (RepetirContrasenya.Text != Contrasenya.Text)
                {
                    MostrarTextoRepetirContraseñaMal();
                }
                AceptarButton.Enabled = true;
            }
        }
        

        private void RepetirContra_change(object sender, MouseEventArgs e)
        {
            if (Correo.Text != "")
            {
                if (!QQSS.service.TestEmail(Correo.Text))
                {
                    MostrarTextoCorreoMal();
                }
                AceptarButton.Enabled = true;
            }
                
            if (nombre.Text != "")
            {
                if (!QQSS.service.TestUser(nombre.Text))
                {
                    MostrarTextoNombreMal();
                }
                AceptarButton.Enabled = true;
            }
                
            if (Contrasenya.Text != "")
            {
                if (!QQSS.service.TestPassword(Contrasenya.Text))
                {
                    MostrarTextoContraseñaMal();
                }
                AceptarButton.Enabled = true;
            }
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
            formato = new Reglas(0);
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
