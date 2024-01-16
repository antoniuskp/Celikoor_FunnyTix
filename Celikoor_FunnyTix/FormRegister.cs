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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            
            radioButtonMale.Checked = true;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxConfirmPassw.UseSystemPasswordChar = true;
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            
        }
        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            
        }
        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxFirstName.Text;
                string email = textBoxEmail.Text;
                string noHP = textBoxNoHp.Text;
                string gender;
                if (radioButtonFemale.Checked)
                {
                    gender = "P";
                }
                else
                {
                    gender = "L";
                }
                DateTime tglLahir = dateTimePicker.Value;
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;

                Konsumen konsumen = new Konsumen(name, email, noHP, gender, tglLahir, 0, username, password);

                Konsumen.TambahData(konsumen);
                this.Close();
                MessageBox.Show("Register berhasil!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool showPwd = false;
        private void pictBoxHidePwd_Click(object sender, EventArgs e)
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
        bool showConfirm= false;
        private void pictureBoxHideConfirm_Click(object sender, EventArgs e)
        {
            if (showConfirm == false)
            {
                textBoxConfirmPassw.UseSystemPasswordChar = false;
                showConfirm = true;
            }
            else
            {
                textBoxConfirmPassw.UseSystemPasswordChar = true;
                showConfirm = false;
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nama = textBoxFirstName.Text;
                string email = textBoxEmail.Text;
                string no_hp = textBoxNoHp.Text;
                string gender = (radioButtonMale.Checked) ? "L" : "F";
                DateTime tgl_lahir = dateTimePicker.Value;
                string username = textBoxUsername.Text;
                string pwd = textBoxPassword.Text;
                string confirmPwd = textBoxConfirmPassw.Text;

                // Cek jika password != confirmPwd
                if (pwd != confirmPwd)
                {
                    MessageBox.Show("Password dan Confirm Password tidak cocok!", "WARNING ⚠️");
                }
                else
                {
                    Konsumen konsumen = new Konsumen();
                    konsumen.Nama = nama;
                    konsumen.Email = email;
                    konsumen.No_Hp = no_hp;
                    konsumen.Gender = gender;
                    konsumen.Tgl_lahir = tgl_lahir;
                    konsumen.Username = username;
                    konsumen.Password = pwd;
                    Konsumen.TambahData(konsumen);

                    MessageBox.Show("Akun berhasil dibuat", "SUCCESS ☑️");
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
