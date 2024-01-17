using FunnyTix_LIB;
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
    public partial class FormLogin : Form
    {
        public bool isPegawai = false;
        bool showPwd = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            FormMenu form = (FormMenu)this.Owner;
            if(isPegawai == true)
            {
                label1.Text="";
                label1.Enabled = false;
                labelRegister.Text = "";
                labelRegister.Enabled = false;
            }
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Kalo login sbg pegawai
                if(isPegawai==true)
                {
                    bool status;
                    Auth.Attempt(textBoxUsername.Text, textBoxPassword.Text, Role.PEGAWAI, out status);
                    if(status)
                    {
                        FormUtama.statusLogin = true;
                        FormUtama.PegawaiInit(Auth.GetPegawai().Roles);
                        FormUtama.CURRENT_ROLE = Role.PEGAWAI;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Maaf, Password atau Username Salah!", "WARNING⚠️");
                    }
                }
                
                // Kalo login sbg konsumen
                else
                {
                    bool status;
                    Auth.Attempt(textBoxUsername.Text, textBoxPassword.Text, Role.KONSUMEN, out status);
                    if (status)
                    {
                        FormUtama.statusLogin = true;
                        FormUtama.KonsumenInit();
                        FormUtama.CURRENT_ROLE = Role.KONSUMEN;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Maaf, Password atau Username Salah!", "WARNING⚠️");
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void pictBoxHide_Click(object sender, EventArgs e)
        {
            if (showPwd == false)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                showPwd = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                showPwd = false;
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister();
            form.Owner = this;
            form.ShowDialog();

        }
        

    }
}
