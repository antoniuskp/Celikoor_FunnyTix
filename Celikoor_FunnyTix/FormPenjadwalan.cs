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

        Studio selectedStudio;
        Film selectedFilm;
        Cinema selectedCinema;

        private void FormPenjadwalan_Load(object sender, EventArgs e)
        {
            dataGridViewHasil.DefaultCellStyle.ForeColor = Color.Black;
            this.WindowState = FormWindowState.Maximized;
            List<Cinema> listCinema = Cinema.BacaData();
            //comboBoxCinema.SelectedIndex = -1;
            //comboBoxJudulFilm.SelectedIndex = -1;
            //comboBoxStudio.SelectedIndex = -1;
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "nama_cabang";  
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCinema = (Cinema)comboBoxCinema.SelectedItem;
            List<Studio> listStudio = Studio.BacaData("cinemas_id", selectedCinema.ID.ToString());
            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.DisplayMember = "nama";
        }

        
        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display Studios Attributes 
            selectedStudio = (Studio)comboBoxStudio.SelectedItem;
            string selectedID = selectedStudio.JenisStudio.Id.ToString();
            textBoxNamaBioskop.Text = JenisStudio.CariJenisStudio(selectedStudio).Nama;
            textBoxKapasitas.Text = selectedStudio.Kapasitas.ToString();
            labelHargaWeekday.Text = "Rp " + selectedStudio.HargaWeekday.ToString();
            labelHargaWeekend.Text = "Rp " + selectedStudio.HargaWeekend.ToString();

            //Display Film into ComboBox
            comboBoxJudulFilm.DataSource = Film.BacaData();
            comboBoxJudulFilm.DisplayMember = "judul";
        }
        
        private void comboBoxJudulFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clearing Films Attributes
            textBoxDurasi.Clear();
            textBoxGenre.Clear();
            textBoxAktor.Clear();
            dateTimePicker1.Value = DateTime.Now;

            //Display Films Attributes 
            selectedFilm = (Film)comboBoxJudulFilm.SelectedItem;
            textBoxDurasi.Text = selectedFilm.Durasi.ToString();
            richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
            textBoxKelompok.Text = selectedFilm.Kelompok.Nama;
            selectedFilm.BacaAktorFilm(selectedFilm);
            selectedFilm.BacaGenreFilm(selectedFilm);
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
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            dataGridViewHasil.Rows.Clear();
            if(checkBoxI.Checked == true)
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

            if(dataGridViewHasil.Columns.Count == 5)
            {
                //button hapus
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Name = "Aksi"; //nama objek button
                btnHapus.Text = "Hapus";//text yang muncul di 
                btnHapus.UseColumnTextForButtonValue = true;//agar tulisan muncul di button
                dataGridViewHasil.Columns.Add(btnHapus);//menambahkan button ke grid
            }
        }

        private void ClearTambah()
        {
            comboBoxJudulFilm.SelectedIndex = 0;
            comboBoxCinema.SelectedIndex = 0;
            comboBoxStudio.SelectedIndex = 0;
            textBoxNamaBioskop.Clear();
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

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewHasil.CurrentRow.Index;
            string sesi = dataGridViewHasil.CurrentRow.Cells["columnJam"].Value.ToString(); //mengambil kode yang akan diubah oleh user
            if (e.ColumnIndex == dataGridViewHasil.Columns["Aksi"].Index)
            {
                DialogResult result = MessageBox.Show($"Apakah setuju untuk membatalkan pemutaran film {selectedFilm.Judul} pada Studio {selectedStudio.Nama} sesi {sesi}", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridViewHasil.Rows.RemoveAt(idx);
                }

            }

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewHasil.Rows.Count != 1)
                {
                    DialogResult result = MessageBox.Show("Yakin menambahkan?", "CONFIRMATION", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        List<JadwalFilm> listJadwal = new List<JadwalFilm>();
                        if (dataGridViewHasil != null)
                        {
                            for (int i = 0; i < dataGridViewHasil.Rows.Count - 1; i++)
                            {
                                JadwalFilm jf = new JadwalFilm();
                                jf.Tanggal = DateTime.Parse(dataGridViewHasil.Rows[i].Cells["columnTanggal"].Value.ToString());
                                jf.JamPemutaran = dataGridViewHasil.Rows[i].Cells["columnJam"].Value.ToString();
                                listJadwal.Add(jf);
                            }
                            selectedFilm.TambahSesiFilm(selectedStudio, selectedFilm, listJadwal);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
      
        //dataGridViewHasil.Rows.Clear();
    }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
