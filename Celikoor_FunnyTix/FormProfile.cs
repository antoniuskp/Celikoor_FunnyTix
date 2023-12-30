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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            textBoxNama.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxNoHp.Enabled = false;
            dateTimePickerBirth.Enabled = false;
            textBoxUsername.Enabled = false;
            textBoxPassword.Enabled = false;

            FormUtama frm = (FormUtama)this.Owner;

            textBoxNama.Text = Auth.GetKonsumen().Nama;
            textBoxEmail.Text = Auth.GetKonsumen().Email;
            textBoxGender.Text = Auth.GetKonsumen().Gender;
            textBoxNoHp.Text = Auth.GetKonsumen().No_Hp;
            textBoxUsername.Text = Auth.GetKonsumen().Username;
            dateTimePickerBirth.Text = Auth.GetKonsumen().Tgl_lahir.ToString("yyyy-MM-dd");
            textBoxPassword.Text = Auth.GetKonsumen().Password; 
        }

        #region EDIT SETTINGS
        private void labelEditNama_Click(object sender, EventArgs e)
        {
            textBoxNama.Enabled = true;
        }

        private void labelEditEmail_Click(object sender, EventArgs e)
        {
            textBoxEmail.Enabled = true;
        }

        private void labelEditNoHp_Click(object sender, EventArgs e)
        {
            textBoxNoHp.Enabled = true; 
        }

        private void labelEditTglLahir_Click(object sender, EventArgs e)
        {
            dateTimePickerBirth.Enabled = true;
        }

        private void labelEditUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.Enabled = true; 
        }

        private void label8_Click(object sender, EventArgs e)
        {
            textBoxPassword.Enabled = true;
        }
        #endregion

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string email = textBoxEmail.Text;
            string noHp = textBoxNoHp.Text;
            DateTime tglLahir = dateTimePickerBirth.Value;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menyimpan perubahan profil?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    List<Konsumen> listKonsumen = Konsumen.BacaData();
                    for(int i = 0; i<= listKonsumen.Count;) 
                    {
                        if (listKonsumen[i].ID == Auth.GetKonsumen().ID)
                        {
                            listKonsumen[i].Nama = nama;
                            listKonsumen[i].Email = email;
                            listKonsumen[i].No_Hp = noHp;
                            listKonsumen[i].Username = username;
                            listKonsumen[i].Password = password;
                            listKonsumen[i].Tgl_lahir = tglLahir;

                            Konsumen.UbahProfil(listKonsumen[i]);

                            FormProfile_Load(this, e);
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Perubahan data profil gagal. Error : " + ex.Message);
                }
            }            
        }
    }
}
