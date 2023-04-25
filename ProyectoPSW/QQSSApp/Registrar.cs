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
        IQQSSService Service;
        public Registrar(IQQSSService service)
        {
            InitializeComponent();
            Service = service;  
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aceptar_click(object sender, EventArgs e)
        {
           Login login = new Login(Service);
            login.Show();
            this.Close();
        }

        private void Volver_click(object sender, EventArgs e)
        {
            Login login = new Login(Service);
            login.Show();
            this.Close();
        }

        private void name_TextChange(object sender, EventArgs e)
        {

        }

        private void Correo_change(object sender, EventArgs e)
        {

        }

        private void Contrasenya_Change(object sender, EventArgs e)
        {

        }

        private void RepetirContra_change(object sender, EventArgs e)
        {

        }
    }
}
