using ProyectoPSWMain.Entities;
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
    public partial class PuntuacionForm : Form
    {
        private IQQSSService service;
        private User userLogged;
        public PuntuacionForm(IQQSSService service)
        {
            InitializeComponent();
            this.service = service;
            this.userLogged = service.GetLoggedUser();

        }

    }
}
