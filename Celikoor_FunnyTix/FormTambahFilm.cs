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
    public partial class FormTambahFilm : Form
    {
        public FormTambahFilm()
        {
            InitializeComponent();
        }

        private void FormTambahFilm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            List<Kelompok> listKelompok = Kelompok.BacaData();
            comboBoxKelompokUmur.DataSource = listKelompok;
            comboBoxKelompokUmur.DisplayMember = "nama";

            List<Film> listBahasa = Film.BacaBahasa();
            comboBoxBahasa.DataSource = listBahasa;
            comboBoxBahasa.DisplayMember = "bahasa";

        }

        private void dateTimePickerRilis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Apakah yakin menambahkan film?", "CONFIRMATION ✅", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Film f = new Film();
                    f.Judul = textBoxJudul.Text;
                    f.Sinopsis = richTextBoxSinopsis.Text;
                    f.Tahun = dateTimePickerRilis.Value.Year;
                    f.Durasi = int.Parse(textBoxDurasi.Text);
                    f.Bahasa = comboBoxBahasa.Text;
                    f.IsSubIndo = 0;
                    if (radioButtonYa.Checked) f.IsSubIndo = 1;
                    f.CoverImage = textBoxUrl.Text;
                    f.Diskon = int.Parse(textBoxDiskon.Text);
                    f.Kelompok = (Kelompok)comboBoxKelompokUmur.SelectedItem;

                    //Tambah Film
                    Film.TambahData(f);
                    MessageBox.Show("Penambahan Data Berhasil!", "SUCCESS ☑️");
                    Bersihkan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penambahan Data Gagal!", "WARNING ⚠️");
            }
        }

        private void buttonTambahDetailFilm_Click(object sender, EventArgs e)
        {
            FormTambahDetailFilm form = new FormTambahDetailFilm();
            form.Owner = this;
            form.ShowDialog();
        }
        private void Bersihkan()
        {
            textBoxDiskon.Clear();
            textBoxDurasi.Clear();
            textBoxJudul.Clear();
            textBoxUrl.Clear();
            dateTimePickerRilis.Value = DateTime.Now;
            comboBoxBahasa.SelectedIndex = -1;
            richTextBoxSinopsis.Clear();
            comboBoxKelompokUmur.SelectedIndex = -1;
            radioButtonTidak.Checked = false;
            radioButtonYa.Checked = false;
        }
    }
    
}
