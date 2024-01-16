using FunnyTix_LIB;
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

namespace Celikoor_FunnyTix
{
    public partial class FormPemesanan : Form
    {
        private int Rows = 7;
        private const int Columns = 4;
        private Film selectedFilm;
        private List<string> userSelection = new List<string>();
        private bool studioIsLoaded = false;
        private List<string> chairTaken = new List<string>();
        private double CurrentPrice = 0;
        private double FilmDiscount;
        private bool IsChange = true;
        private Studio selectedStudio;
        private double TicketPrice;
        private JadwalFilm selectedPemutaran;
        private JadwalFilm jadwal;
        private JenisStudio selectedJenisStudio;
        private Cinema selectedCinema;
        private List<Studio> daftarStudio;
        private List<FilmStudio> daftarFilmStudio;
        private List<JenisStudio> daftarJenisStudio;
        private List<Cinema> daftarCinema;
        private bool cekFilm = true;
        private bool cekJenisStudio = true;
        private bool cekCinema = true;
        private bool cekStudio = true;
        private bool cekJamPemutaran = true;
        private bool cekJadwal = true;
        private List<Cinema> listCinema;
        private JadwalFilm selectedJadwal;


        private CheckBox[,] checkBoxArray;
        public FormPemesanan()
        {
            InitializeComponent();
        }

        private void FormPemesanan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            /*InitializeCheckBoxArray("A");
            InitializeCheckBoxArray("B");
            InitializeCheckBoxArray("C");*/
            List<Film> daftarFilm = Film.BacaData();
            comboBoxJudul.DataSource = daftarFilm;
            comboBoxJudul.DisplayMember = "Judul";
            double saldo = Auth.GetKonsumen().Saldo;
            textBoxSaldo.Text = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", saldo.ToString());
            dateTimePickerTambah.Enabled = false;
            comboBoxJamPemutaran.Enabled = false;
            comboBoxStudio.Enabled = false;
        }

        private void InitializeCheckBoxArray(string huruf, int jumKursi)
        {
            /*
             mod => 1 - 4 => A + mod
            mod => 5 - 8 => A + 4, B + (mod - 4)
            mod => 9 - 0 => A + 4, B + (mod - 4), C + (mod - 4)
             */
            int mod = jumKursi % 12;
            int cnt = int.Parse(Math.Floor(jumKursi / 3.0).ToString());
            List<int> listA = new List<int> { 1, 2, 3, 4 };
            List<int> listB = new List<int> { 5, 6, 7, 8 };
            List<int> listC = new List<int> { 9, 10, 11, 0 };
            
            if (huruf == "A")
            {
                panelA.Controls.Clear();
                int actualChair = cnt + mod;
                Rows = (jumKursi / 12) + 1;
                checkBoxArray = new CheckBox[Rows, Columns];
                int i = 0;
                for (int row = 0; row < Rows; row++)
                {
                    for (int col = 0; col < Columns; col++)
                    {
                        // Create a new checkbox
                        CheckBox checkBox = new CheckBox();

                        // Set its properties
                        checkBox.Text = $"{i + 1}";
                        checkBox.AutoSize = true;
                        checkBox.Tag = (i >= 9) ? $"{huruf}{i + 1}" : $"{huruf}0{i+1}";
                        checkBox.CheckedChanged += InputKursi;
                        checkBox.Enabled = false;
                        i++;

                        // Add it to the form
                        panelA.Controls.Add(checkBox);

                        // Add it to the array
                        checkBoxArray[row, col] = checkBox;

                        // Position the checkbox
                        checkBox.Location = new System.Drawing.Point(col * 35, row * 30);
                        // You can customize the positioning based on your layout requirements.
                    }
                }
            }
            else if (huruf == "B")
            {
                panelB.Controls.Clear();
                int actualChair = cnt + mod;
                Rows = (jumKursi / 12) + 1;
                checkBoxArray = new CheckBox[Rows, Columns];
                int i = 0;
                for (int row = 0; row < Rows; row++)
                {
                    for (int col = 0; col < Columns; col++)
                    {
                        // Create a new checkbox
                        CheckBox checkBox = new CheckBox();

                        // Set its properties
                        checkBox.Text = $"{i + 1}";
                        checkBox.AutoSize = true;
                        checkBox.Tag = (i >= 9) ? $"{huruf}{i + 1}" : $"{huruf}0{i + 1}";
                        checkBox.CheckedChanged += InputKursi;
                        checkBox.Enabled = false;
                        i++;

                        // Add it to the form
                        panelB.Controls.Add(checkBox);

                        // Add it to the array
                        checkBoxArray[row, col] = checkBox;

                        // Position the checkbox
                        checkBox.Location = new System.Drawing.Point(col * 35, row * 30);
                        // You can customize the positioning based on your layout requirements.
                    }
                }
            }
            else if (huruf == "C")
            {
                panelC.Controls.Clear();
                int actualChair = cnt + mod;
                Rows = (jumKursi / 12) + 1;
                checkBoxArray = new CheckBox[Rows, Columns];
                int i = 0;
                for (int row = 0; row < Rows; row++)
                {
                    for (int col = 0; col < Columns; col++)
                    {
                        // Create a new checkbox
                        CheckBox checkBox = new CheckBox();

                        // Set its properties
                        checkBox.Text = $"{i + 1}";
                        checkBox.AutoSize = true;
                        checkBox.Tag = (i >= 9) ? $"{huruf}{i + 1}" : $"{huruf}0{i + 1}";
                        checkBox.CheckedChanged += InputKursi;
                        checkBox.Enabled = false;
                        i++;

                        // Add it to the form
                        panelC.Controls.Add(checkBox);

                        // Add it to the array
                        checkBoxArray[row, col] = checkBox;

                        // Position the checkbox
                        checkBox.Location = new System.Drawing.Point(col * 35, row * 30);
                        // You can customize the positioning based on your layout requirements.
                    }
                }
            }
        }

        #region PANEL HOVER
        private void panelA_MouseHover(object sender, EventArgs e)
        {
            panelA.BackColor = Color.LightSalmon;

        }

        private void panelB_MouseHover(object sender, EventArgs e)
        {
            panelB.BackColor = Color.LightSalmon;
        }

        private void panelC_MouseHover(object sender, EventArgs e)
        {
            panelC.BackColor = Color.LightSalmon;
        }

        #endregion

        private void dateTimePickerTambah_ValueChanged(object sender, EventArgs e)
        {
            string selectedTgl = dateTimePickerTambah.Value.ToString("yyyy-MM-dd");
            List<JadwalFilm> listJadwalFilm = JadwalFilm.BacaData("tanggal", selectedTgl);
            if (listJadwalFilm.Count > 0)
            {
                comboBoxJamPemutaran.DataSource = listJadwalFilm;
                comboBoxJamPemutaran.DisplayMember = "jam_pemutaran";
                //cekJamPemutaran = true;
            }
            else if (listJadwalFilm.Count == 0)
            {
                MessageBox.Show("Jadwal Film tidak ditemukan pada studio ini!", "WARNING");
                comboBoxJamPemutaran.Text = "";
            }

        }

        private void InputKursi(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Enabled && studioIsLoaded)
            {
                if (cb.Checked)
                {
                    userSelection.Add((string)cb.Tag);
                    if (comboBoxStudio.Items.Count > 0 && IsChange)
                    {
                        CurrentPrice += TicketPrice;
                        string curPrice = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", CurrentPrice.ToString());
                        textBoxTotal.Text = $"{curPrice}";

                        //double totalAkhir = CurrentPrice - ((CurrentPrice * (FilmDiscount / 100)) * userSelection.Count);
                        double totalAkhir = CurrentPrice - (CurrentPrice * (FilmDiscount / 100));
                        string format = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", totalAkhir.ToString());
                        textBoxTotalAkhir.Text = $"{format}";
                    }  
                }
                else
                {
                    userSelection.Remove((string)cb.Tag);
                    if (comboBoxStudio.Items.Count > 0 && IsChange)
                    {
                        CurrentPrice -= TicketPrice;
                        textBoxTotal.Text = $"{CurrentPrice}";

                        //double totalAkhir = CurrentPrice - ((CurrentPrice * (FilmDiscount / 100)) * userSelection.Count);
                        double totalAkhir = CurrentPrice - (CurrentPrice * (FilmDiscount / 100));
                        textBoxTotalAkhir.Text = $"{totalAkhir}";
                    }
                }
                labelUserSelection.Text = String.Join(",", userSelection);
            }
        }

        private void comboBoxJamPemutaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void comboBoxJudul_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            
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

        private void pictureBoxKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxKonfirmasiPembayaran_Click(object sender, EventArgs e)
        {
            
        }


        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

      

        private void buttonPilihJudul_Click(object sender, EventArgs e)
        {
            try
            {
                selectedFilm = (Film)comboBoxJudul.SelectedItem;
                LoadImage(selectedFilm.CoverImage);
                richTextBoxSinopsis.Clear();
                richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
                textBoxDurasi.Text = selectedFilm.Durasi.ToString() + " menit";
                selectedFilm.BacaAktorFilm(selectedFilm);
                selectedFilm.BacaGenreFilm(selectedFilm);
                textBoxGenre.Clear();
                textBoxAktor.Clear();
                FilmDiscount = selectedFilm.Diskon;
                textBoxDiskon.Text = selectedFilm.Diskon.ToString();
                textBoxAge.Text = selectedFilm.Kelompok.Nama;

                //Display Aktor
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

                //Display Genre
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

                daftarJenisStudio = JenisStudio.CariJenisStudioFilm(selectedFilm);
                if (daftarJenisStudio != null)
                {
                    comboBoxJenisStudio.DataSource = daftarJenisStudio;
                    comboBoxJenisStudio.DisplayMember = "nama";
                }
                else
                {
                    comboBoxJenisStudio.Text = "";
                    MessageBox.Show("Maaf, tidak ada jenis studio untuk film ini!", "WARNING ⚠️");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPilihJenisStudio_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxJenisStudio != null)
                {
                    selectedJenisStudio = (JenisStudio)comboBoxJenisStudio.SelectedItem;
                    listCinema = Cinema.CariCinema(selectedJenisStudio, selectedFilm);
                    comboBoxCinema.DataSource = listCinema;
                    comboBoxCinema.DisplayMember = "nama_cabang";



                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPilihCinema_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCinema != null)
                {
                    selectedCinema = (Cinema)comboBoxCinema.SelectedItem;
                    listCinema = Cinema.CariCinema(selectedJenisStudio, selectedFilm);
                    dateTimePickerTambah.Enabled = true;
                    comboBoxJamPemutaran.Enabled = true;
                    //if (listCinema.Count > 0)
                    //{
                    //    int count = 0;
                    //    for (int i = 0; i < listCinema.Count; i++)
                    //    {
                    //        if (listCinema[i].NamaCabang == comboBoxCinema.Text)
                    //        {
                    //            selectedCinema = (Cinema)comboBoxCinema.SelectedItem;

                    //            //cekJadwal = true;

                    //            break;
                    //        }
                    //        count++;
                    //    }
                    //    if (count == listCinema.Count)
                    //    {
                    //        MessageBox.Show($"Tidak ditemukan cinema {comboBoxCinema.Text} pada jenis studio ini dan film ini!");
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show($"Tidak ditemukan cinema {comboBoxCinema.Text} pada jenis studio ini dan film ini!");
                    //}

                }


            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonPilihStudio_Click(object sender, EventArgs e)
        {
            selectedStudio = (Studio)comboBoxStudio.SelectedItem;
            FilmStudio fs = new FilmStudio();
            fs.Film = selectedFilm;
            fs.Studio = selectedStudio;
            bool status = Film.CekJadwalFilmStudio(fs, selectedJadwal);
            if (status)
            {
                chairTaken = Tiket.CariNomorKursi(selectedJadwal, selectedStudio, selectedFilm);
                IsChange = false;
                InitializeCheckBoxArray("A", selectedStudio.Kapasitas);
                InitializeCheckBoxArray("B", selectedStudio.Kapasitas);
                InitializeCheckBoxArray("C", selectedStudio.Kapasitas);
                //* Cek nomor kursi apa saja yg telah dibeli
                // Ubah Enabled dlu biar di Method InputKursi tidak dijalankan
                // Method InputKursi hanya dijalankan ketika user yg memilih, bukan sistem
                foreach (Control control in panelA.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        if (chairTaken.Contains((string)checkBox.Tag))
                        {
                            checkBox.Enabled = false;
                            checkBox.Checked = true;
                            checkBox.ForeColor = Color.Black;
                        }
                        else
                        {
                            checkBox.Enabled = true;
                            checkBox.Checked = false;
                        }
                    }
                }

                foreach (Control control in panelB.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        if (chairTaken.Contains((string)checkBox.Tag))
                        {
                            checkBox.Enabled = false;
                            checkBox.Checked = true;
                            checkBox.ForeColor = Color.Black;
                        }
                        else
                        {
                            checkBox.Enabled = true;
                            checkBox.Checked = false;
                        }
                    }
                }

                foreach (Control control in panelC.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        if (chairTaken.Contains((string)checkBox.Tag))
                        {
                            checkBox.Enabled = false;
                            checkBox.Checked = true;
                            checkBox.ForeColor = Color.Black;
                        }
                        else
                        {
                            checkBox.Enabled = true;
                            checkBox.Checked = false;
                        }
                    }
                }

                studioIsLoaded = true;
                IsChange = true;
                textBoxTotalAkhir.Text = "";
                labelUserSelection.Text = "";
                textBoxTotal.Text = "";
                //FilmDiscount = 0;
                CurrentPrice = 0;
                textBoxTotal.Text = "";

                DateTime myDateTime = dateTimePickerTambah.Value;
                if (myDateTime.DayOfWeek == DayOfWeek.Saturday || myDateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    TicketPrice = double.Parse(selectedStudio.HargaWeekend.ToString());
                }
                else
                {
                    TicketPrice = double.Parse(selectedStudio.HargaWeekday.ToString());
                }
                textBoxHarga.Text = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", TicketPrice.ToString());
                textBoxKapasitas.Text = selectedStudio.Kapasitas.ToString();

                textBoxSisa.Text = (selectedStudio.Kapasitas - chairTaken.Count).ToString();
            }
            else
            {
                MessageBox.Show("Maaf, tidak ditemukan jadwal film pada studio ini!", "WARNING");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKonfirmasi_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Apakah Anda Yakin untuk membeli tiket? ", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    string kursi = labelUserSelection.Text;
                    string[] arrKursi = kursi.Split(',');


                    int noNota = Invoice.GenerateNoNota();
                    //Tambah Data 
                    Invoice nota = new Invoice();
                    nota.Id = noNota;
                    nota.Tanggal = DateTime.Now;

                    string grandTotal = new string(textBoxTotalAkhir.Text.Where(char.IsDigit).ToArray());

                    nota.GrandTotal = int.Parse(grandTotal);
                    nota.DiskonNominal = int.Parse(textBoxDiskon.Text);
                    nota.Konsumen = Auth.GetKonsumen();
                    nota.Status = "PENDING";

                    foreach (string k in arrKursi)
                    {
                        string jam = comboBoxJamPemutaran.Text;

                        Tiket t = new Tiket();
                        t.IdInvoice = nota;
                        t.NoKursi = k;
                        t.Status = false;
                        t.Operators = Pegawai.BacaData("id", "1")[0];

                        string numericValue = new string(textBoxHarga.Text.Where(char.IsDigit).ToArray());
                        t.Harga = int.Parse(numericValue);

                        string tglPilihan = dateTimePickerTambah.Value.ToString("yyyy-MM-dd");
                        t.JadwalFilm = JadwalFilm.BacaData("tanggal", tglPilihan, jam)[0];


                        t.Studio = Studio.BacaData("nama", selectedStudio.Nama)[0];
                        t.Film = selectedFilm;

                        nota.TambahTiket(t);


                    }

                    string totalAkhir = new string(textBoxTotalAkhir.Text.Where(char.IsDigit).ToArray());
                    if (Auth.GetKonsumen().Saldo > int.Parse(totalAkhir))
                    {
                        Konsumen.UbahSaldo(Auth.GetKonsumen(), -int.Parse(totalAkhir));
                        Invoice.TambahData(nota);
                        MessageBox.Show("Pembayaran Berhasil!", "SUCCESS ☑️");
                        FormPemesanan_Load(this, e);
                    }
                    else
                    {
                        MessageBox.Show("Penambahan Data Gagal!, Saldo Anda Kurang", "WARNING ⚠️");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Penambahan Data Gagal " + ex.Message);
            }
        }

        private void panelC_MouseHover_1(object sender, EventArgs e)
        {
            panelC.BackColor = Color.LightSalmon;
        }

        private void buttonJadwal_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxHarga.Text = "";
                textBoxKapasitas.Text = "";
                textBoxSisa.Text = "";

                selectedJadwal = (JadwalFilm)comboBoxJamPemutaran.SelectedItem;
                JadwalFilm jadwal = JadwalFilm.BacaData("tanggal", dateTimePickerTambah.Value.ToString("yyyy-MM-dd"), comboBoxJamPemutaran.Text)[0];
                if (jadwal != null)
                {
                    daftarStudio = Studio.CariStudio(selectedCinema, selectedJenisStudio, selectedFilm, selectedJadwal);
                    List<Studio> listStudioAdaJadwalFilm = new List<Studio>();
                    for (int i = 0; i < daftarStudio.Count; i++)
                    {
                        if (JadwalFilm.BacaSesiFilm(selectedJadwal, daftarStudio[i], selectedFilm))
                        {
                            listStudioAdaJadwalFilm.Add(daftarStudio[i]);
                        }
                    }
                    if (listStudioAdaJadwalFilm.Count > 0)
                    {
                        comboBoxStudio.DataSource = listStudioAdaJadwalFilm;
                        comboBoxStudio.DisplayMember = "nama";
                        comboBoxStudio.Enabled = true;
                    }
                    else
                    {
                        comboBoxStudio.Text = "Tidak Ada Studio";
                        MessageBox.Show("Maaf, tidak ada studio untuk film ini!", "WARNING ⚠️");
                    }
                }
                else
                {
                    MessageBox.Show("Maaf, Tidak ditemukan Jadwal Film untuk jenis studio dan cinema ini!");
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
            //Pengecekan Jadwal Film apakah ada pada film, jenis studio, cinema, jadwal film
        }

        private void panelB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panelB_MouseLeave(object sender, EventArgs e)
        {
            panelB.BackColor = Color.NavajoWhite;
        }

        private void panelC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelC_MouseLeave(object sender, EventArgs e)
        {
            panelC.BackColor = Color.NavajoWhite;

        }

        private void panelA_MouseLeave(object sender, EventArgs e)
        {
            panelA.BackColor = Color.NavajoWhite;
        }
    }
    
}
