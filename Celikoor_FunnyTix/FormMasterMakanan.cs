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
    public partial class FormMasterMakanan : Form
    {
        List<Makanan> listMakanan;
        public FormMasterMakanan()
        {
            InitializeComponent();
        }

        private void FormMasterMakanan_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listMakanan = Makanan.BacaData();

            InputDataGrid();
            FormatHeaderDataGrid();
        }
        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (Makanan mk in listMakanan)
            {
                string id = mk.Id.ToString();
                string nama = mk.Nama.ToString();
                string deskripsi = mk.Deskripsi.ToString();
                string hapus = "Hapus";

                dataGridViewHasil.Rows.Add(id, nama, deskripsi, hapus);
            }
            comboBox.SelectedIndex = 0;
        }

        private void FormatHeaderDataGrid()
        {
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;
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
            panelTambahMakanan.Visible = true;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelTambahMakanan.Visible = false;
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["nama_column"].Value.ToString();

            if (e.ColumnIndex == dataGridViewHasil.Columns["hapus_column"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus menu " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Makanan.HapusData(kode);

                        FormMasterMakanan_Load(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal. Error : " + ex.Message);
                    }
                }
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listMakanan = Makanan.BacaData("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Deskripsi":
                    listMakanan = Makanan.BacaData("Deskripsi", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listMakanan.Count > 0)
            {
                InputDataGrid();

            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Maaf, Tidak ada menu makanan yang cocok.", "INFORMATION");
                textBox.Text = "";
                comboBox.SelectedIndex = 0;
            }
            for (int i = 0; i < dataGridViewHasil.Columns.Count; i++)
            {
                dataGridViewHasil.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Apakah yakin untuk menambahkan data?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string nama = textBoxNama.Text;
                    string deskripsi = richTextBox1.Text;

                    Makanan makan = new Makanan();
                    makan.Nama = nama;  
                    makan.Deskripsi = deskripsi;
                    Makanan.TambahData(makan);
                    MessageBox.Show("Penambahan Data Berhasil!", "SUCCESS ☑️");

                    textBoxNama.Clear();
                    richTextBox1.Text = "";

                    FormMasterMakanan_Load(this, e);

                    panelTambahMakanan.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penambahan Data Gagal!", "WARNING ⚠️");
            }
        }
    }
}
