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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Celikoor_FunnyTix
{
    public partial class FormMasterFilm : Form
    {

        List<Film> listFilm;

        public FormMasterFilm()
        {
            InitializeComponent();
        }

        private void FormMasterFilm_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listFilm = Film.BacaData();

            InputDataGrid();
            FormatHeaderDataGrid();
        }

        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (Film f in listFilm)
            {
                string id = f.Id.ToString();
                string judul = f.Judul.ToString();
                string sinopsis = f.Sinopsis.ToString();
                string tahun = f.Tahun.ToString();
                string durasi = f.Durasi.ToString();
                string kelompok = f.Kelompok.Nama.ToString();
                string bhs = f.Bahasa.ToString();
                string sub = f.IsSubIndo.ToString();
                string cover = f.CoverImage.ToString();
                string diskon = f.Diskon.ToString();
                string hapus = "Hapus";

                dataGridViewHasil.Rows.Add(id, judul, sinopsis, tahun, durasi, kelompok, bhs, sub, cover, diskon, hapus);
            }
            comboBoxCari.SelectedIndex = 0;
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
            //dataGridViewHasil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridViewHasil.RowHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBoxCari.Text)
            {
                case "Judul":
                    listFilm = Film.BacaData("Judul", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Sinopsis":
                    listFilm = Film.BacaData("Sinopsis", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Tahun":
                    listFilm = Film.BacaData("Tahun", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Durasi":
                    listFilm = Film.BacaData("Durasi", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Kelompok":
                    listFilm = Film.BacaData("Kelompok", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Bahasa":
                    listFilm = Film.BacaData("Bahasa", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Sub Indonesia":
                    listFilm = Film.BacaData("IsSubIndo", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Diskon":
                    listFilm = Film.BacaData("Diskon", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listFilm.Count > 0)
            {
                InputDataGrid();
            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Tidak ada data yang cocok.");
                textBox.Text = "";
                comboBoxCari.SelectedIndex = 0;
            }
            for (int i = 0; i < dataGridViewHasil.Columns.Count; i++)
            {
                dataGridViewHasil.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahFilm frmTambah = new FormTambahFilm();
            frmTambah.Owner = this;
            frmTambah.ShowDialog();

            FormMasterFilm_Load(this, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["judul_column"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["hapus_column"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus film " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Film.DeleteData(kode);

                        FormMasterFilm_Load(this, e);
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
