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
    public partial class FormPenjadwalan : Form
    {
        public FormPenjadwalan()
        {
            InitializeComponent();
        }

        
        private void FormPenjadwalan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.SelectedIndex = -1;
            comboBoxJudulFilm.SelectedIndex = -1;
            comboBoxStudio.SelectedIndex = -1;
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "nama_cabang";  
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cinema selectedCinema = (Cinema)comboBoxCinema.SelectedItem;
            List<Studio> listStudio = Studio.BacaData("cinemas_id", selectedCinema.ID.ToString());
            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.DisplayMember = "nama";
        }

        Studio selectedStudio;
        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudio = (Studio)comboBoxStudio.SelectedItem;
            string selectedID = selectedStudio.JenisStudio.Id.ToString();
            textBoxNamaBioskop.Text = JenisStudio.CariJenisStudio(selectedStudio).Nama;
            textBoxKapasitas.Text = selectedStudio.Kapasitas.ToString();
            labelHargaWeekday.Text = "Rp " + selectedStudio.HargaWeekday.ToString();
            labelHargaWeekend.Text = "Rp " + selectedStudio.HargaWeekend.ToString();
            comboBoxJudulFilm.DataSource = Film.CariFilmTanpaStudio(selectedStudio);
            comboBoxJudulFilm.DisplayMember = "judul";
        }
        Film selectedFilm;
        private void comboBoxJudulFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDurasi.Clear();
            textBoxGenre.Clear();
            textBoxAktor.Clear();
            //comboBoxTanggal.Items.Clear();
            selectedFilm = (Film)comboBoxJudulFilm.SelectedItem;
            richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
            textBoxDurasi.Text = selectedFilm.Durasi.ToString();
            textBoxKelompok.Text = selectedFilm.Kelompok.Nama;
            Film.BacaAktorFilm(selectedFilm);
            Film.BacaGenreFilm(selectedFilm);
            for(int i = 0; i < selectedFilm.ListAktor.Count; i++)
            {
                if(selectedFilm.ListAktor.Count == 1)
                {
                    textBoxAktor.Text = selectedFilm.ListAktor[i].Aktor.Nama;

                }
                else if (selectedFilm.ListAktor.Count > 1)
                {
                    if (i >= 0 && i <= 1)
                    {
                        textBoxAktor.Text += selectedFilm.ListAktor[i].Aktor.Nama + ", ";
                    }
                }
                
            }
            if (selectedFilm.ListAktor.Count > 2)
            {
                textBoxAktor.Text += "...";
            }
            for (int i = 0; i < selectedFilm.ListGenre.Count; i++)
            {
                if(selectedFilm.ListGenre.Count == 1)
                {
                    textBoxGenre.Text = selectedFilm.ListGenre[i].Genre.Nama;

                }
                else if (i >= 0 && i < 2)
                {
                    textBoxGenre.Text += selectedFilm.ListGenre[i].Genre.Nama + ", ";
                }
            }
            if(selectedFilm.ListGenre.Count > 2)
            {
                textBoxGenre.Text += ",...";
            }

            Film.JadwalKosong(selectedFilm, selectedStudio);



        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

        }
    }
}
