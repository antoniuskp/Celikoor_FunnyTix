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
                //FormLogin frmLogin = new FormLogin();
                //frmLogin.MdiParent = this;

                //frmLogin.ShowDialog();
                //frmLogin.WindowState = FormWindowState.Maximized;
                //frmLogin.BringToFront();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            FormUtama form = (FormUtama)this.MdiParent;

            /*try
            {
                Koneksi koneksi = new Koneksi();
                *//*
                FormLogin formLogin = new FormLogin();
                formLogin.Owner = this;
                formLogin.ShowDialog();
                *//*
                
                //Koneksi koneksi = new Koneksi(db.Default.server, db.Default.database, db.Default.username, db.Default.password);

                *//*if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    //jika login berhasil
                    //labelWelcome.Text = "Welcome, " + konsumen.Nama + " to";

                }
                else
                {
                    //jika login gagal
                    MessageBox.Show("Gagal login");
                    Application.Exit();
                }*//*
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan : " + ex.Message);
                Application.Exit();
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
