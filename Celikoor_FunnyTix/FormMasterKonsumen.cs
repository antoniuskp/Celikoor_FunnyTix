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
    public partial class FormMasterKonsumen : Form
    {
        public FormMasterKonsumen()
        {
            InitializeComponent();
        }
        public List<Konsumen> listKonsumen;
        private void FormMasterKonsumen_Load(object sender, EventArgs e)
        {
            //FormPegawai frmPegawai = (FormPegawai)this.Owner;

            listKonsumen = Konsumen.BacaData();

            dataGridViewHasil.DataSource = listKonsumen;
            ShowDataGrid();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listKonsumen = Konsumen.BacaData("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Email":
                    listKonsumen = Konsumen.BacaData("Email", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Nomor handphone":
                    listKonsumen = Konsumen.BacaData("no_hp", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Gender":
                    listKonsumen = Konsumen.BacaData("gender", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Tanggal Lahir":
                    listKonsumen = Konsumen.BacaData("tgl_lahir", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Username":
                    listKonsumen = Konsumen.BacaData("username", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Password":
                    listKonsumen = Konsumen.BacaData("username", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listKonsumen.Count > 0)
            {
                dataGridViewHasil.DataSource = listKonsumen;
            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Tidak ada data yang cocok.");
                textBox.Text = "";
                comboBox.SelectedIndex = 0;
            }
            ShowDataGrid();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            comboBox.SelectedIndex = 0;
        }
        public void ShowDataGrid()
        {
            if (dataGridViewHasil.ColumnCount == 9)
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
            for (int i = 0; i < dataGridViewHasil.Columns.Count; i++)
            {
                dataGridViewHasil.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }
    }
}
