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
    public partial class FormTambahDetailFilm : Form
    {
        public FormTambahDetailFilm()
        {
            InitializeComponent();
        }

        Film selectedFilm;
        Aktor selectedAktor;
        Genre selectedGenre;
        FormTambahFilm frm;
        private void FormTambahDetailFilm_Load(object sender, EventArgs e)
        {
            frm = (FormTambahFilm)this.Owner;   
            List<Film> listFilm = Film.BacaData();
            comboBoxFilm.DataSource = listFilm;
            comboBoxFilm.DisplayMember = "judul";

            List<Aktor> actress = Aktor.BacaAktorBelum(selectedFilm);
            if (actress == null)
            {
                List<Aktor> listAktor = Aktor.BacaData();
                comboBoxAktor.DataSource = listAktor;
                comboBoxAktor.DisplayMember = "nama";
            }
            else if (actress != null)
            {
                comboBoxAktor.DataSource = actress;
                comboBoxAktor.DisplayMember = "nama";
            }


            List<Genre> genre = Genre.BacaGenreBelum(selectedFilm);
            if (genre == null)
            {
                List<Genre> listGenre = Genre.BacaData();
                comboBoxNamaGenre.DataSource = listGenre;
                comboBoxNamaGenre.DisplayMember = "nama";
            }
            else if (genre != null)
            {
                comboBoxNamaGenre.DataSource = genre;
                comboBoxNamaGenre.DisplayMember = "nama";
            }
        }

        private void comboBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFilm = (Film)comboBoxFilm.SelectedItem;

            List<Genre> genre = Genre.BacaGenreBelum(selectedFilm);
            if (genre == null)
            {
                List<Genre> listGenre = Genre.BacaData();
                comboBoxNamaGenre.DataSource = listGenre;
                comboBoxNamaGenre.DisplayMember = "nama";
            }
            else if (genre != null)
            {
                comboBoxNamaGenre.DataSource = genre;
                comboBoxNamaGenre.DisplayMember = "nama";
            }

            List<Aktor> actress = Aktor.BacaAktorBelum(selectedFilm);
            if (actress == null)
            {
                List<Aktor> listAktor = Aktor.BacaData();
                comboBoxAktor.DataSource = listAktor;
                comboBoxAktor.DisplayMember = "nama";
            }
            else if (actress != null)
            {
                comboBoxAktor.DataSource = actress;
                comboBoxAktor.DisplayMember = "nama";
            }
        }

        private void comboBoxNamaGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void comboBoxAktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Yakin Menambahkan?", "CONFIRMATION ⚠️", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) 
                {
                    Genre g = (Genre)comboBoxNamaGenre.SelectedItem;
                    Genre.TambahGenreFilm(selectedFilm, g);
                    MessageBox.Show("Penambahan Data Berhasil!", "SUCCESS ☑️");
                    Bersihkan();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penambahan Data Gagal!", "WARNING ⚠️");
            }
        }


        private void buttonTambahAktor_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Yakin Menambahkan?", "CONFIRMATION ⚠️", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string peran = "";
                    if (radioButtonUtama.Checked) peran = "UTAMA";
                    else if (radioButtonPembantu.Checked) peran = "PEMBANTU";
                    else peran = "FIGURAN";

                    Aktor.TambahAktorFilm(selectedFilm, selectedAktor, peran);
                    MessageBox.Show("Penambahan Data Berhasil", "CONFIRMATION ✅");
                    Bersihkan();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Penambahan Data Gagal!", "ERROR ❌");
            }
            

        }

        private void Bersihkan()
        {
            comboBoxAktor.SelectedIndex = 0;
            comboBoxFilm.SelectedIndex = 0;
            radioButtonFiguran.Checked = false;
            radioButtonPembantu.Checked = false;
            radioButtonUtama.Checked = false;
            labelValueTanggalLahir.Text = "";
            labelGenderValue.Text = "";
            labelNegaraAsalValue.Text = "";
            comboBoxNamaGenre.SelectedIndex = 0;
            richTextBoxDeskripsiGenre.Clear();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPilihAktor_Click(object sender, EventArgs e)
        {
            selectedAktor = (Aktor)comboBoxAktor.SelectedItem;
            labelValueTanggalLahir.Text = selectedAktor.Tgl_Lahir.ToString("yyyy-MM-dd");
            if (selectedAktor.Gender == "P") labelGenderValue.Text = "WANITA";
            labelGenderValue.Text = "PRIA";
            labelNegaraAsalValue.Text = selectedAktor.Negara_Asal;
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            selectedGenre = (Genre)comboBoxNamaGenre.SelectedItem;
            richTextBoxDeskripsiGenre.Text = selectedGenre.Deskripsi;
        }
    }
}