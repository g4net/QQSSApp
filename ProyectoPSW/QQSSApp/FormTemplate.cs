﻿using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// esto era un intento de tener un form base del cual heredaran todos para no tener que pasar el servicio cada vez pero de momento
// no he conseguido que funcione (ignorad esta clase)

namespace QQSSApp
{
    public partial class FormTemplate : Form
    {
        protected IQQSSService service;
        public FormTemplate()
        {
            
        }

        public FormTemplate(IQQSSService service)
        {
            this.service = service;
        }

        public void SetService(IQQSSService service)
        {
            this.service = service;
        }
    }
}
