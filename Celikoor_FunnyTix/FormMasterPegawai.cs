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
                List<Pegawai> listPegawai = Pegawai.BacaData();
                
                dataGridViewHasil.DataSource = listPegawai;

                //comboBox.DataSource = listPegawai;
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                dataGridViewHasil.DataSource = listPegawai;
                comboBox.SelectedIndex = 0;

                if (listPegawai.Count > 0)
                {
                    if (dataGridViewHasil.ColumnCount <8)
                    {
                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();

                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Ubah";
                        bcol.Name = "btnUbahGrid";
                        bcol.UseColumnTextForButtonValue = true;
                        dataGridViewHasil.Columns.Add(bcol);

                        DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                        bcol2.HeaderText = "Aksi";
                        bcol2.Text = "Hapus";
                        bcol2.Name = "buttonHapusGrid";
                        bcol2.UseColumnTextForButtonValue = true;
                        dataGridViewHasil.Columns.Add(bcol2);
                    }
                }
                else
                {
                    dataGridViewHasil.DataSource = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
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
                dataGridViewHasil.DataSource = listPegawai;
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
            textBox.Text = "";
        }
    }
}
