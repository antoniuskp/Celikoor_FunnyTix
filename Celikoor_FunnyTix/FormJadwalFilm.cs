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
    public partial class FormJadwalFilm : Form
    {
        public FormJadwalFilm()
        {
            InitializeComponent();
        }

        List<SesiFilm> listSesiFilm;
        private void FormJadwalFilm_Load_1(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            dataGridViewHasil.Rows.Clear();
            //return;
            listSesiFilm = JadwalFilm.BacaFilmHari(dateTimePicker.Value);
            foreach (SesiFilm sesi in listSesiFilm)
            {
                string JudulFilm = sesi.FilmStudio.Film.Judul;
                string Studio = sesi.FilmStudio.Studio.Nama;
                string Tanggal = sesi.JadwalFilm.Tanggal.ToString("yyyy-MM-dd");
                string Sesi = sesi.JadwalFilm.Jam_pemutaran;
                string JamPemutaran = JadwalFilm.SesiToJam(Sesi);

                dataGridViewHasil.Rows.Add(JudulFilm, Studio, Tanggal, JamPemutaran);
            }

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewHasil.Rows.Clear();
            //MessageBox.Show(JadwalFilm.BacaFilmHari(dateTimePicker.Value));
            //return;
            listSesiFilm = JadwalFilm.BacaFilmHari(dateTimePicker.Value);
            foreach (SesiFilm sesi in listSesiFilm)
            {
                string JudulFilm = sesi.FilmStudio.Film.Judul;
                string Studio = sesi.FilmStudio.Studio.Nama;
                string Tanggal = sesi.JadwalFilm.Tanggal.ToString("yyyy-MM-dd");
                string Sesi = sesi.JadwalFilm.Jam_pemutaran;
                string JamPemutaran = JadwalFilm.SesiToJam(Sesi);

                dataGridViewHasil.Rows.Add(JudulFilm, Studio, Tanggal, JamPemutaran);
            }
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            dataGridViewHasil.Rows.Clear();
            if(textBox.Text!="")
            {
                foreach (SesiFilm sesi in listSesiFilm)
                {
                    if (sesi.FilmStudio.Film.Judul.ToLower().Contains(textBox.Text.ToLower()))
                    {
                        string JudulFilm = sesi.FilmStudio.Film.Judul;
                        string Studio = sesi.FilmStudio.Studio.Nama;
                        string Tanggal = sesi.JadwalFilm.Tanggal.ToString("yyyy-MM-dd");
                        string Sesi = sesi.JadwalFilm.Jam_pemutaran;
                        string JamPemutaran = JadwalFilm.SesiToJam(Sesi);
                        dataGridViewHasil.Rows.Add(JudulFilm, Studio, Tanggal, JamPemutaran);
                    }
                }
            }
            else
            {
                foreach (SesiFilm sesi in listSesiFilm)
                {
                    string JudulFilm = sesi.FilmStudio.Film.Judul;
                    string Studio = sesi.FilmStudio.Studio.Nama;
                    string Tanggal = sesi.JadwalFilm.Tanggal.ToString("yyyy-MM-dd");
                    string Sesi = sesi.JadwalFilm.Jam_pemutaran;
                    string JamPemutaran = JadwalFilm.SesiToJam(Sesi);
                    dataGridViewHasil.Rows.Add(JudulFilm, Studio, Tanggal, JamPemutaran);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewHasil.Rows.Clear();
            textBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            //return;
            listSesiFilm = JadwalFilm.BacaFilmHari(dateTimePicker.Value);
            foreach (SesiFilm sesi in listSesiFilm)
            {
                string JudulFilm = sesi.FilmStudio.Film.Judul;
                string Studio = sesi.FilmStudio.Studio.Nama;
                string Tanggal = sesi.JadwalFilm.Tanggal.ToString("yyyy-MM-dd");
                string Sesi = sesi.JadwalFilm.Jam_pemutaran;
                string JamPemutaran = JadwalFilm.SesiToJam(Sesi);

                dataGridViewHasil.Rows.Add(JudulFilm, Studio, Tanggal, JamPemutaran);
            }
        }
    }
}
