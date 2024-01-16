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

            InputDataGrid();
            FormatHeaderDataGrid(); 
        }

        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (Genre g in listGenre)
            {
                string id = g.ID.ToString();
                string nama = g.Nama.ToString();
                string desc = g.Deskripsi.ToString();
                string hapus = "Hapus";

                dataGridViewHasil.Rows.Add(id, nama, desc, hapus);
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

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listGenre = Genre.BacaData("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Deskripsi":
                    listGenre = Genre.BacaData("Deskripsi", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listGenre.Count > 0)
            {
                InputDataGrid();
            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Maaf, Tidak ada genre yang cocok.", "INFORMATION");
                textBox.Text = "";
                comboBox.SelectedIndex = 0;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            try
            {
                DialogResult result = MessageBox.Show("Apakah yakin untuk menambah data?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string nama = textBoxNama.Text;
                    string desc = textBoxDeskripsi.Text;

                    Genre genre = new Genre(nama, desc);
                    Genre.TambahData(genre);
                    MessageBox.Show("Penambahan Data Berhasil!", "SUCCESS ☑️");
                    panelTambahGenre.Visible = false;
                    textBoxDeskripsi.Clear();
                    textBoxNama.Clear();

                    FormMasterGenre_Load(this, e);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Penambahan Data Gagal!", "WARNING ⚠️");
            }
            
        }

        private void dataGridViewHasil_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["nama_column"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["hapus_column"].Index)
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
    }
}
