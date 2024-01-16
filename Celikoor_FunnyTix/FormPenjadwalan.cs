using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            dateTimePicker1.ForeColor = Color.DarkRed; // Ganti Color.Red dengan warna yang diinginkan

            dataGridViewHasil.DefaultCellStyle.ForeColor = Color.Black;
            this.WindowState = FormWindowState.Maximized;
            List<Cinema> listCinema = Cinema.BacaData();
            
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "nama_cabang";

            FormatHeaderDataGrid();
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

        private void ClearTambah()
        {
            //pictureBoxCover.Image = null;
            groupBox3.Enabled = false;

            //labelJudulFilm.Text = "";
            //labelKelompok.Text = "";
            //richTextBoxSinopsis.Text = "";
            //labelDurasi.Text = "";
            //labelGenre.Text = "";
            //labelAktor.Text = "";

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
            comboBoxCinema.SelectedIndex = 0;
            comboBoxJenisStudio.SelectedIndex = 0;

            richTextBoxSinopsis.Clear();
            checkBoxI.Checked = false;
            checkBoxII.Checked = false;
            checkBoxIII.Checked = false;
            checkBoxIV.Checked = false;

            comboBoxCinema.Text = "";
            comboBoxJenisStudio.Text = "";
            comboBoxJudulFilm.Text = "";
            comboBoxStudio.Text = "";

            cekCinema = true;
            cekFilm = false;
            cekJenisStudio = false;
            cekStudio = false;

            labelAktor.Text = "";
            labelDurasi.Text = "";
            labelGenre.Text = "";
            labelKelompok.Text = "";


            labelKapasitas.Text = "";
            labelHargaWeekday.Text = "0";
            labelHargaWeekend.Text = "0";

            labelKapasitas.Text = "0 kursi";

            labelJudulFilm.Text = "";

            pictureBoxCover.Image= null;
            dataGridViewHasil.Rows.Clear();  
            dateTimePicker1.Value = DateTime.Now;
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
            
        }

        private void buttonPilihJudul_Click(object sender, EventArgs e)
        {

            //Display Films Attributes 
            selectedFilm = (Film)comboBoxJudulFilm.SelectedItem;
            labelJudulFilm.Text = selectedFilm.Judul;
            LoadImage(selectedFilm.CoverImage);
            labelDurasi.Text = selectedFilm.Durasi.ToString() + " menit";
            richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
            labelKelompok.Text = selectedFilm.Kelompok.Nama;
            selectedFilm.BacaAktorFilm(selectedFilm);
            selectedFilm.BacaGenreFilm(selectedFilm);
            for (int i = 0; i < selectedFilm.ListAktor.Count; i++)
            {
                if (selectedFilm.ListAktor.Count == 1)
                {
                    labelAktor.Text = selectedFilm.ListAktor[i].Aktor.Nama;

                }
                else if (selectedFilm.ListAktor.Count > 1)
                {
                    if (i >= 0 && i <= 1)
                    {
                        labelAktor.Text += selectedFilm.ListAktor[i].Aktor.Nama + ", ";
                    }
                }

            }
            if (selectedFilm.ListAktor.Count > 2)
            {
                labelAktor.Text += "...";
            }
            for (int i = 0; i < selectedFilm.ListGenre.Count; i++)
            {
                if (selectedFilm.ListGenre.Count == 1)
                {
                    labelGenre.Text = selectedFilm.ListGenre[i].Genre.Nama;

                }
                else if (i >= 0 && i < 2)
                {
                    labelGenre.Text += selectedFilm.ListGenre[i].Genre.Nama + ", ";
                }
            }
            if (selectedFilm.ListGenre.Count > 2)
            {
                labelGenre.Text += ",...";
            }
            

            groupBox3.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonPilihCinema_Click(object sender, EventArgs e)
        {
            
            selectedCinema = (Cinema)comboBoxCinema.SelectedItem;
            listJenisStudio = JenisStudio.BacaJenisStudio(selectedCinema);

            comboBoxJenisStudio.DataSource = listJenisStudio;
            comboBoxJenisStudio.Text = "";

            comboBoxJenisStudio.DisplayMember = "nama";
            cekJenisStudio = true;
            
            groupBox3.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                if (checkBoxI.Checked == false && checkBoxII.Checked == false && checkBoxIII.Checked == false && checkBoxIV.Checked == false)
                {
                    MessageBox.Show("Invalid data entry.");
                }
                if (checkBoxI.Checked == true)
                {
                    dataGridViewHasil.Rows.Add(selectedFilm.Judul, selectedCinema.NamaCabang, selectedStudio.Nama, dateTimePicker1.Value.ToShortDateString(), "I");
                    ClearTambah();
                }
                if (checkBoxII.Checked == true)
                {
                    dataGridViewHasil.Rows.Add(selectedFilm.Judul, selectedCinema.NamaCabang, selectedStudio.Nama, dateTimePicker1.Value.ToShortDateString(), "II");
                    ClearTambah();
                }
                if (checkBoxIII.Checked == true)
                {
                    dataGridViewHasil.Rows.Add(selectedFilm.Judul, selectedCinema.NamaCabang, selectedStudio.Nama, dateTimePicker1.Value.ToShortDateString(), "III");
                    ClearTambah();
                }
                if (checkBoxIV.Checked == true)
                {
                    dataGridViewHasil.Rows.Add(selectedFilm.Judul, selectedCinema.NamaCabang, selectedStudio.Nama, dateTimePicker1.Value.ToShortDateString(), "IV");
                    ClearTambah();
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
            
            //Display Studios Attributes 
            selectedJenisStudio = (JenisStudio)comboBoxJenisStudio.SelectedItem;
            listStudio = Studio.BacaStudio(selectedCinema, selectedJenisStudio, null);

            if (listStudio != null)
            {
                comboBoxStudio.Text = "";
                comboBoxStudio.DataSource = listStudio;
                comboBoxStudio.DisplayMember = "nama";
                cekStudio = true;
            }
            
        }

        private void buttonSimpan_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewHasil.Rows.Count == 1)
                {
                    DialogResult result = MessageBox.Show("Yakin menambahkan?", "CONFIRMATION", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (dataGridViewHasil != null)
                        {
                            try
                            {
                                Film.TambahSesiFilm(selectedFilm);
                                MessageBox.Show("Penambahan Data Berhasil!", "SUCCESS ☑️");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Penambahan Data Gagal!", "WARNING ⚠️");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Maaf, Tidak Ada Data yang Ditambahkan", "WARNING ⚠️");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tolong, tambahkan Film, Studio, dan Jadwal Film", "WARNING ⚠");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Bersihkan();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBioskop_Click(object sender, EventArgs e)
        {
            cekFilm = false;
            cekJenisStudio = false;
            cekCinema = false;
            if (cekStudio)
            {
                if (comboBoxStudio != null)
                {
                    selectedStudio = (Studio)comboBoxStudio.SelectedItem;
                    labelKapasitas.Text = selectedStudio.Kapasitas.ToString() + " Kursi";
                    labelHargaWeekday.Text = selectedStudio.HargaWeekday.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
                    labelHargaWeekend.Text = selectedStudio.HargaWeekend.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));

                    //Display Film into ComboBox
                    comboBoxJudulFilm.Text = "";
                    comboBoxJudulFilm.DataSource = Film.BacaData();
                    comboBoxJudulFilm.DisplayMember = "judul";
                }
            }
        }
    }
    
}
