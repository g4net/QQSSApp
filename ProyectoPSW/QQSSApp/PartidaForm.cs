using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQSSApp
{
    public partial class PartidaForm : FormTemplate
    {

        public PartidaForm(IQQSSService service)
        {
            InitializeComponent();
            this.service = service;
            this.service.Login("1235");
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ODS_especifica.Width, ODS_especifica.Height);
            ODS_especifica.Region = new Region(path);
            
        }

        private void PartidaForm_Load(object sender, EventArgs e)
        {

        }

        private void op1_click(object sender, EventArgs e)
        {

        }

        private void op2_Click(object sender, EventArgs e)
        {

        }

        private void op3_Click(object sender, EventArgs e)
        {

        }

        private void op4_Click(object sender, EventArgs e)
        {

        }
    }
}
