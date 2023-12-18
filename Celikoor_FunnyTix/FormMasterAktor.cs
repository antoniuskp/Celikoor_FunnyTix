using FunnyTix_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_FunnyTix
{
    public partial class FormMasterAktor : Form
    {
        public List<Aktor> listAktor;
        public FormMasterAktor()
        {
            InitializeComponent();
        }

        private void FormMasterAktor_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listAktor = Aktor.BacaData();

            dataGridViewHasil.DataSource = listAktor;
            comboBox.SelectedIndex = 0;

            if (listAktor.Count > 0)
            {
                dataGridViewHasil.DataSource = listAktor;
                if (dataGridViewHasil.ColumnCount == 5)
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


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listAktor = Aktor.BacaData("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Tanggal Lahir":
                    listAktor = Aktor.BacaData("tgl_lahir", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Gender":
                    listAktor = Aktor.BacaData("gender", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Negara":
                    listAktor = Aktor.BacaData("negara_asal", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listAktor.Count > 0)
            {
                dataGridViewHasil.DataSource = listAktor;
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
