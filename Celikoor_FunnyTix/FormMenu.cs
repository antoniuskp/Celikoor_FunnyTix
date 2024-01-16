using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FunnyTix_LIB;

namespace Celikoor_FunnyTix
{
    public partial class FormMenu : Form
    {
        public Konsumen konsumen;
        public FormMenu()
        {
            InitializeComponent();
            this.KeyPreview = true; //Agar bisa mendapat input dari keyboard
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Form form = Application.OpenForms["FormLogin"];

                if (form == null)
                {
                    FormLogin login = new FormLogin();
                    login.MdiParent = this;
                    login.Show();
                }
                else
                {
                    form.Show();
                    form.BringToFront();
                }
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            FormUtama form = (FormUtama)this.MdiParent;
        }

        private void pictureBoxPegawai_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Owner = this;
            form.isPegawai = true;
            form.ShowDialog();
        }

        private void pictureBoxKonsumen_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Owner = this;
            form.isPegawai = false;
            form.ShowDialog();
        }
    }
}
