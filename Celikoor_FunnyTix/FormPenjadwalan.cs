using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

        private Studio selectedStudio;
        private JenisStudio selectedJenisStudio;
        private Cinema selectedCinema;
        private Film selectedFilm;
        private List<JenisStudio> listJenisStudio;
        private List<Studio> listStudio;
        private List<JadwalFilm> listJadwal;
        private bool cekFilm = false;
        private bool cekCinema = false;
        private bool cekStudio = false;
        private bool cekJenisStudio = false;

        private void FormPenjadwalan_Load(object sender, EventArgs e)
        {
            dataGridViewHasil.DefaultCellStyle.ForeColor = Color.Black;
            this.WindowState = FormWindowState.Maximized;
            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "nama_cabang";
        }
       

        private void ClearTambah()
        {
            comboBoxJudulFilm.SelectedIndex = 0;
            comboBoxCinema.SelectedIndex = 0;
            comboBoxJenisStudio.SelectedIndex = 0;
            textBoxKapasitas.Clear();
            textBoxAktor.Clear();
            textBoxDurasi.Clear();
            textBoxGenre.Clear();
            textBoxKelompok.Clear();
            labelHargaWeekday.Text = string.Empty;
            labelHargaWeekend.Text = string.Empty;
            richTextBoxSinopsis.Clear(); 
            checkBoxI.Checked = false;
            checkBoxII.Checked = false;
            checkBoxIII.Checked = false;
            checkBoxIV.Checked = false;

        }

        private void dataGridViewHasil_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void HapusJadwalFilm()
        {
            for(int i = 0; i < listJadwal.Count; i++)
            {
                if(listJadwal[i].Jam_pemutaran == sesi)
                {
                    listJadwal.RemoveAt(i);
                }
            }
        }
        string sesi;
        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewHasil.CurrentRow.Index;
            sesi = dataGridViewHasil.CurrentRow.Cells["columnJam"].Value.ToString(); //mengambil kode yang akan diubah oleh user
            if (e.ColumnIndex == dataGridViewHasil.Columns["Aksi"].Index)
            {
                DialogResult result = MessageBox.Show($"Apakah setuju untuk membatalkan pemutaran film {selectedFilm.Judul} pada Studio {selectedStudio.Nama} sesi {sesi}", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridViewHasil.Rows.RemoveAt(idx);
                    HapusJadwalFilm();
                }

            }

        }

        private void Bersihkan()
        {
            dataGridViewHasil.Rows.Clear();
            comboBoxCinema.SelectedIndex = 0;
            cekCinema = true;
            cekFilm = false;
            cekJenisStudio = false;
            cekStudio = false;
            textBoxAktor.Clear();
            textBoxDurasi.Clear();
            textBoxGenre.Clear();
            textBoxKelompok.Clear();
            textBoxKapasitas.Clear();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadImage(string url)
        {
            // Ambil URL gambar dari TextBox
            string imageUrl = url;

            try
            {
                // Download gambar dari URL
                WebClient webClient = new WebClient();
                byte[] imageData = webClient.DownloadData(imageUrl);
                webClient.Dispose();

                // Konversi data byte menjadi objek gambar
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image loadedImage = Image.FromStream(ms);

                    // Tampilkan gambar di PictureBox
                    pictureBoxCover.Image = loadedImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxJenisStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cekFilm = false;
            cekJenisStudio = false;
            cekCinema = false;
            if (cekStudio)
            {
                if (comboBoxStudio != null)
                {
                    selectedStudio = (Studio)comboBoxStudio.SelectedItem;
                    textBoxKapasitas.Text = selectedStudio.Kapasitas.ToString();
                    labelHargaWeekday.Text = selectedStudio.HargaWeekday.ToString();
                    labelHargaWeekend.Text = selectedStudio.HargaWeekend.ToString();

                    //Display Film into ComboBox
                    comboBoxJudulFilm.DataSource = Film.BacaData();
                    comboBoxJudulFilm.DisplayMember = "judul";
                    cekFilm = true;
                }
            }
        }

        private void buttonPilihJudul_Click(object sender, EventArgs e)
        {
            cekFilm = true;
            cekStudio = false;
            cekJenisStudio = false;
            cekCinema = false;
            if (cekFilm)
            {
                //Clearing Films Attributes
                textBoxDurasi.Clear();
                textBoxGenre.Clear();
                textBoxAktor.Clear();
                dateTimePicker1.Value = DateTime.Now;

                //Display Films Attributes 
                selectedFilm = (Film)comboBoxJudulFilm.SelectedItem;
                MessageBox.Show(selectedFilm.Judul);
                LoadImage(selectedFilm.CoverImage);
                textBoxDurasi.Text = selectedFilm.Durasi.ToString();
                richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
                textBoxKelompok.Text = selectedFilm.Kelompok.Nama;
                selectedFilm.BacaAktorFilm(selectedFilm);
                selectedFilm.BacaGenreFilm(selectedFilm);
                for (int i = 0; i < selectedFilm.ListAktor.Count; i++)
                {
                    if (selectedFilm.ListAktor.Count == 1)
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
                    if (selectedFilm.ListGenre.Count == 1)
                    {
                        textBoxGenre.Text = selectedFilm.ListGenre[i].Genre.Nama;

                    }
                    else if (i >= 0 && i < 2)
                    {
                        textBoxGenre.Text += selectedFilm.ListGenre[i].Genre.Nama + ", ";
                    }
                }
                if (selectedFilm.ListGenre.Count > 2)
                {
                    textBoxGenre.Text += ",...";
                }
            }
        }

        private void buttonPilihCinema_Click(object sender, EventArgs e)
        {
            cekCinema = true;
            if (cekCinema)
            {
                selectedCinema = (Cinema)comboBoxCinema.SelectedItem;
                listJenisStudio = JenisStudio.BacaJenisStudio(selectedCinema);
                comboBoxJenisStudio.DataSource = listJenisStudio;
                comboBoxJenisStudio.DisplayMember = "nama";
                cekJenisStudio = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxI.Checked == true)
                {
                    dataGridViewHasil.Rows.Add(selectedFilm.Judul, selectedCinema.NamaCabang, selectedStudio.Nama, dateTimePicker1.Value.ToShortDateString(), "I");
                }
                if (checkBoxII.Checked == true)
                {
                    dataGridViewHasil.Rows.Add(selectedFilm.Judul, selectedCinema.NamaCabang, selectedStudio.Nama, dateTimePicker1.Value.ToShortDateString(), "II");
                }
                if (checkBoxIII.Checked == true)
                {
                    dataGridViewHasil.Rows.Add(selectedFilm.Judul, selectedCinema.NamaCabang, selectedStudio.Nama, dateTimePicker1.Value.ToShortDateString(), "III");
                }
                if (checkBoxIV.Checked == true)
                {
                    dataGridViewHasil.Rows.Add(selectedFilm.Judul, selectedCinema.NamaCabang, selectedStudio.Nama, dateTimePicker1.Value.ToShortDateString(), "IV");
                }

                if (dataGridViewHasil.Columns.Count == 5)
                {
                    //button hapus
                    DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                    btnHapus.Name = "Aksi"; //nama objek button
                    btnHapus.Text = "Hapus";//text yang muncul di 
                    btnHapus.UseColumnTextForButtonValue = true;//agar tulisan muncul di button
                    dataGridViewHasil.Columns.Add(btnHapus);//menambahkan button ke grid
                }

                listJadwal = new List<JadwalFilm>();
                //Membuat Film
                for (int i = 0; i < dataGridViewHasil.Rows.Count - 1; i++)
                {
                    JadwalFilm jf = new JadwalFilm();
                    jf.Tanggal = DateTime.Parse(dataGridViewHasil.Rows[i].Cells["columnTanggal"].Value.ToString());
                    jf.Jam_pemutaran = dataGridViewHasil.Rows[i].Cells["columnJam"].Value.ToString();
                    listJadwal.Add(jf);
                }
                selectedFilm.TambahSesiFilm(selectedFilm, selectedStudio, listJadwal);
                ClearTambah();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxJudulFilm_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cekJenisStudio = true;
            if (cekJenisStudio)
            {
                //Display Studios Attributes 
                selectedJenisStudio = (JenisStudio)comboBoxJenisStudio.SelectedItem;
                listStudio = Studio.BacaStudio(selectedCinema, selectedJenisStudio, null);

                if (listStudio != null)
                {
                    comboBoxStudio.DataSource = listStudio;
                    comboBoxStudio.DisplayMember = "nama";
                    cekStudio = true;
                }
            }
        }

        private void buttonSimpan_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewHasil.Rows.Count != 1)
                {
                    DialogResult result = MessageBox.Show("Yakin menambahkan?", "CONFIRMATION", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (dataGridViewHasil != null)
                        {
                            try
                            {
                                Film.TambahSesiFilm(selectedFilm);
                                MessageBox.Show("Data Berhasil Ditambahkan");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "WARNING! ⚠️");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tidak Ada Data yang Ditambahkan");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tambahkan Film, Studio, dan Jadwal Film!", "WARNING ⚠️");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
    
}
