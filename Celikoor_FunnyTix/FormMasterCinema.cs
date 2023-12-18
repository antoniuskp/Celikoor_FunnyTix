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
    public partial class FormMasterCinema : Form
    {
        public List<Cinema> listCabang;
        public FormMasterCinema()
        {
            InitializeComponent();
        }

        private void FormMasterCinema_Load(object sender, EventArgs e)
        {
            FormPegawai frm =(FormPegawai)this.Owner;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            listCabang = Cinema.BacaData();
            dataGridViewHasil.DataSource = listCabang;

            comboBox.SelectedIndex = 0;
            if (listCabang.Count > 0)
            {
                dataGridViewHasil.DataSource = listCabang;
                if (dataGridViewHasil.ColumnCount >4)
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

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Cabang":
                    listCabang = Cinema.BacaData("nama_cabang", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Alamat":
                    listCabang = Cinema.BacaData("alamat", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Tanggal Dibuka":
                    listCabang = Cinema.BacaData("tgl_dibuka", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Kota":
                    listCabang = Cinema.BacaData("kota", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listCabang.Count > 0)
            {
                dataGridViewHasil.DataSource = listCabang;
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
            textBox.Text = "";
            comboBox.SelectedIndex = 0;
        }
    }
}
