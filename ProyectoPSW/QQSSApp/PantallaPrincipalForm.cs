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
        IQQSSService service;
        Reglas actualVentanaReglas;
        public PantallaPrincipalForm(IQQSSService service)
        {
            this.service = service;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.FormClosed += (s, args) => Application.Exit();
            this.label1.Select();            
            this.CenterToScreen();
            service.ResetErroresyConsolidaciones();
            string ruta = service.GetRutaSonido("menuPrincipal");
            service.Play(ruta);
            SiguienteNivel();
        }

        public void SiguienteNivel()
        {
            int antiguoNivel = service.GetLoggedUser().nivel;
            service.NextLevel(service.GetLoggedUser());
            int nuevoNivel = service.GetLoggedUser().nivel;
            if (antiguoNivel != nuevoNivel)
            {
                DialogResult siguienteNivel = MessageBox.Show(this,
                    "Acabas de subir al nivel " + nuevoNivel,
                    "Nivel de Usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ButtonComenzar_Click(object sender, EventArgs e)
        {
            Niveles niveles = new Niveles(service);
            niveles.Show();
            this.Hide();
            //string ruta = service.GetRutaSonido("CuentaAtras");
            //service.Play(ruta);
        }

        private void BotonReglas_Click(object sender, EventArgs e)
        {
            if (actualVentanaReglas != null) actualVentanaReglas.Close();
            actualVentanaReglas = new Reglas();
            actualVentanaReglas.Show();
        }

        private void UserClick(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(service.GetLoggedUser());
            usuario.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
