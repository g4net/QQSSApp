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
            this.service.Login("0");
            this.CenterToScreen();
        }


        private void ButtonComenzar_Click(object sender, EventArgs e)
        {
            Niveles niveles = new Niveles(service);
            niveles.Show();
            this.Hide();
        }

        private void BotonReglas_Click(object sender, EventArgs e)
        {
            if (actualVentanaReglas != null) actualVentanaReglas.Close();
            actualVentanaReglas = new Reglas();
            actualVentanaReglas.Show();
        }
    }
}
