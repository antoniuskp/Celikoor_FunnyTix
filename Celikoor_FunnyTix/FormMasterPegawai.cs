using FunnyTix_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_FunnyTix
{
    public partial class FormMasterPegawai : Form
    {
        public List<Pegawai> listPegawai;
        public FormMasterPegawai()
        {
            InitializeComponent();
        }

        private void FormMasterPegawai_Load(object sender, EventArgs e)
        {
            try
            {
                listPegawai = Pegawai.BacaData();

                InputDataGrid();
                FormatHeaderDataGrid();

                //comboBox.DataSource = listPegawai;
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (Pegawai p in listPegawai)
            {
                string id = p.ID.ToString();
                string nama = p.Nama.ToString();
                string email = p.Email.ToString();
                string username = p.Username.ToString();
                string roles = p.Roles.ToString();

                dataGridViewHasil.Rows.Add(id, nama, email, username, " ", roles, "Ubah", "Hapus");
            }
            comboBox.SelectedIndex = 0;
        }
        private void FormatHeaderDataGrid()
        {
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 8, FontStyle.Bold);
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHasil.EnableHeadersVisualStyles = false;

            dataGridViewHasil.AllowUserToAddRows = false;
            dataGridViewHasil.ReadOnly = true;
            dataGridViewHasil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewHasil.RowHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;
        }
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            
            panelTambahPegawai.Visible = true;

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
            textBox.Text = "";
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelTambahPegawai.Visible = false;
            textBoxEmail.Clear();   
            textBoxNama.Clear();    
            textBoxPassword.Clear();
            labelUsername.Text = "";
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

            string nama = textBoxNama.Text;
            string email = textBoxEmail.Text;    
            string pwd = textBoxPassword.Text;  
            string roles = comboBoxRoles.Text;
            string username = labelUsername.Text;

            Pegawai pegawai = new Pegawai(nama, email, username, pwd, roles);
            Pegawai.TambahData(pegawai);

            panelTambahPegawai.Visible = false;
            textBoxEmail.Clear();
            textBoxNama.Clear();
            textBoxPassword.Clear();
            labelUsername.Text = "Username";

            FormMasterPegawai_Load(this, e);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["nama_column"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["hapus_column"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus pegawai " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Pegawai.DeleteData(kode);

                        FormMasterPegawai_Load(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal. Error : " + ex.Message);
                    }
                }
            }
            /*else if (e.ColumnIndex == dataGridViewHasil.Columns["buttonUbahGrid"].Index)
            {
                Pegawai pegawai = Pegawai.BacaData("id", kode)[0];
                panelUbahPegawai.Visible = true;
                labelID.Text = kode;
                textBoxNamaUbah.Text = nama;
                textBoxEmailUbah.Text = pegawai.Email;
                textBoxPasswordUbah.Text = pegawai.Password;
                textBoxUsernameUbah.Text = pegawai.Username;
                

            }*/
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelUsername.Text = Pegawai.GenerateUsernamePegawai(comboBoxRoles.Text);

        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listPegawai = Pegawai.BacaData("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Email":
                    listPegawai = Pegawai.BacaData("Email", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Username":
                    listPegawai = Pegawai.BacaData("username", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Password":
                    listPegawai = Pegawai.BacaData("password", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Roles":
                    listPegawai = Pegawai.BacaData("roles", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listPegawai.Count > 0)
            {
                InputDataGrid();
            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Tidak ada data yang cocok.");
                textBox.Text = "";
                comboBox.SelectedIndex = 0;
            }

            for (int i = 0; i < dataGridViewHasil.Columns.Count; i++)
            {
                dataGridViewHasil.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }
    }
}
