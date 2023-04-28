using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace QQSSApp
{
    public partial class PantallaPrincipalForm : Form
    {
        Reglas actualVentanaReglas;
        public PantallaPrincipalForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.FormClosed += (s, args) => Application.Exit();
            this.label1.Select();            
            this.CenterToScreen();
            QQSS.service.PlaySonido("menuPrincipal");
            SiguienteNivel();
        }

        public void SiguienteNivel()
        {
            if (!QQSS.service.CheckUserLevel()) return;

            int nuevoNivel = QQSS.service.GetLoggedUser().nivel;
            DialogResult siguienteNivel = MessageBox.Show(this,
                "Acabas de subir al nivel " + nuevoNivel,
                "Nivel de Usuario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ButtonComenzar_Click(object sender, EventArgs e)
        {
            Niveles niveles = new Niveles();
            niveles.Show();
            this.Hide();
        }

        private void BotonReglas_Click(object sender, EventArgs e)
        {
            if (actualVentanaReglas != null) actualVentanaReglas.Close();
            actualVentanaReglas = new Reglas();
            actualVentanaReglas.Show();
        }

        private void UserClick(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
