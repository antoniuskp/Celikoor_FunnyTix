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
        public FormLogin()
        {
            InitializeComponent();
        }
        public bool isPegawai = false;
        private void label3_Click(object sender, EventArgs e)
        {
            FormRegister frmRegister = new FormRegister();
            frmRegister.ShowDialog();
            frmRegister.WindowState = FormWindowState.Maximized;
            frmRegister.BringToFront();
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
            /*            else
                        {
                            label1.Text = "Don’t have an account?";
                            label1.Enabled = true;
                            labelRegister.Text = "Register Here";
                            labelRegister.Enabled = true;
                        }*/

            //this.WindowState = FormWindowState.Maximized;
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
                        MessageBox.Show("Wrong Credentials!");
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
                        //this.Owner.Close();  // Udh ke close waktu OpenChild dipanggil utk buka MasterPegawai

                    }
                    else
                    {
                        MessageBox.Show("Wrong Credentials!");
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            //try
            //{
            //    //membuat objek koneksi 
            //    Koneksi koneksi = new Koneksi();

            //    //string username = textBoxUsername.Text;
            //    //string password = textBoxPassword.Text;

            //    //username dan password
            //    //Konsumen k = Konsumen.CekLogin(username, password);
            //    //Pegawai p = Pegawai.CekLogin(username, password);

            //    if (!(k is null)) //jika ditemukan pegawai dengan username dan password tersebut
            //    {
            //        //tampilkan kode, nama, jabatan pegawai yang sedang login ke label yang ada di form utama
            //        FormUtama formUtama = new FormUtama();
            //        formUtama.Owner = this;
            //        //formUtama.konsumen = k;
            //        formUtama.ShowDialog();

            //        MessageBox.Show("Koneksi berhasil. Selamat menggunakan aplikasi.", "Informasi");

            //        this.DialogResult = DialogResult.OK;
            //        this.Hide();
            //        //this.Close(); //menutup form login
            //    }
            //    else if(!(p is null))
            //    {
            //        FormPegawai formPegawai = new FormPegawai();
            //        formPegawai.Owner = this;
            //        //formPegawai.pegawai = p;
            //        formPegawai.ShowDialog();

            //        MessageBox.Show("Koneksi berhasil. Selamat menggunakan aplikasi.", "Informasi");

            //        this.DialogResult = DialogResult.OK;
            //        this.Hide(); //menutup form login
            //    }
            //    else
            //    {
            //        MessageBox.Show(this, "Username tidak ditemukan atau password salah. Apakah anda sudah registrasi?");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            //}
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister();
            form.Owner = this;
            form.ShowDialog();

        }
        bool showPwd=false;
        private void pictBoxHide_Click(object sender, EventArgs e)
        {
            if(showPwd==false)
            {
                textBoxPassword.UseSystemPasswordChar=false;
                showPwd = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                showPwd = false;
            }
        }
    }
}
