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
    public partial class FormMasterGenre : Form
    {
        public List<Genre> listGenre;
        public FormMasterGenre()
        {
            InitializeComponent();
        }

        private void FormMasterGenre_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listGenre = Genre.BacaData(); 

            dataGridViewHasil.DataSource = listGenre;
            comboBox.SelectedIndex = 0;
            ShowDataGrid();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listGenre = Genre.BacaData("nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Deskripsi":
                    listGenre = Genre.BacaData("deskripsi", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listGenre.Count > 0)
            {
                dataGridViewHasil.DataSource = listGenre;

                ShowDataGrid();
            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Tidak ada data yang cocok.");
                textBox.Text = "";
                comboBox.SelectedIndex = 0;
            }
        }

        public void ShowDataGrid()
        {
            if (dataGridViewHasil.ColumnCount == 3)
            {
                /*DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();

                bcol.HeaderText = "Aksi";
                bcol.Text = "Ubah";
                bcol.Name = "btnUbahGrid";
                bcol.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(bcol);*/

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            comboBox.SelectedIndex = 0;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            panelTambahGenre.Visible = true;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelTambahGenre.Visible = false;
            textBoxDeskripsi.Clear();
            textBoxNama.Clear();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string desc = textBoxDeskripsi.Text;

            Genre genre = new Genre(nama,desc);
            Genre.TambahData(genre);

            panelTambahGenre.Visible = false;
            textBoxDeskripsi.Clear();
            textBoxNama.Clear();

            FormMasterGenre_Load(this, e);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["ID"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["Nama"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus genre " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Genre.DeleteData(kode);

                        FormMasterGenre_Load(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal. Error : " + ex.Message);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelTambahGenre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
