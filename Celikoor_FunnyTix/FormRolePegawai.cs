using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_FunnyTix
{
    public partial class FormRolePegawai : Form
    {
        public FormRolePegawai()
        {
            InitializeComponent();
        }

        private void panelOperator_MouseHover(object sender, EventArgs e)
        {
            panelOperator.BackColor = Color.LightSalmon;
        }

        private void panelOperator_MouseLeave(object sender, EventArgs e)
        {
            panelOperator.BackColor = Color.Transparent;

        }

        private void FormRolePegawai_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
