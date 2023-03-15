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
    public partial class PartidaForm : Form
    {
        IQQSSService service;
        public PartidaForm(IQQSSService service)
        {
            InitializeComponent();
            this.service = service;
            
        }

        private void PartidaForm_Load(object sender, EventArgs e)
        {
            this.service.Login("1235");
            this.label6.Text = this.service.GetLoggedUser().getPointsStr();
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
