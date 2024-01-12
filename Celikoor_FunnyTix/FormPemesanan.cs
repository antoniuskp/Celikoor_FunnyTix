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
        private const int Rows = 7;
        private const int Columns = 4;
        private Film selectedFilm;
        private List<Cinema> daftarCinema;
        private List<string> userSelection = new List<string>();
        private bool studioIsLoaded = false;
        private List<string> chairTaken = new List<string>();
        private double CurrentPrice = 0;
        private double FilmDiscount;
        private bool IsChange = true;
        private Studio selectedStudio;
        private JenisStudio selectedJenisStudio;
        private Cinema selectedCinema;
        private double TicketPrice;
        private JadwalFilm selectedPemutaran;

        private CheckBox[,] checkBoxArray;
        public FormPemesanan()
        {
            InitializeComponent();
        }

        private void FormPemesanan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeCheckBoxArray("A");
            InitializeCheckBoxArray("B");
            InitializeCheckBoxArray("C");
            List<Film> daftarFilm = Film.BacaData();
            comboBoxJudul.DataSource = daftarFilm;
            comboBoxJudul.DisplayMember = "Judul";
            double saldo = Auth.GetKonsumen().Saldo;
            textBoxSaldo.Text = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", saldo.ToString());


        }

        private void InitializeCheckBoxArray(string huruf)
        {
            checkBoxArray = new CheckBox[Rows, Columns];
            if (huruf == "A")
            {
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
                        checkBox.Tag = $"{huruf}{i + 1}";
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
                        checkBox.Tag = $"{huruf}{i + 1}";
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
                        checkBox.Tag = $"{huruf}{i + 1}";
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

        private void pictureBoxKonfirmasiPembayaran_MouseHover(object sender, EventArgs e)
        {
            pictureBoxKonfirmasiPembayaran.BackColor = Color.LightSalmon;

        }

        private void pictureBoxKeluar_MouseHover(object sender, EventArgs e)
        {
            pictureBoxKeluar.BackColor = Color.LightSalmon;

        }
        #endregion


        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCinema != null)
                {
                    selectedCinema = (Cinema)comboBoxCinema.SelectedItem;
                    //comboBoxCinema.ValueMember = "nama_cabang";
                    //Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
                    //Film filmId = Film.BacaData(selectedFilm.Id.ToString())[0];
                    //string selectedCinema = (string)comboBoxCinema.SelectedValue;
                    //Cinema cinema = Cinema.BacaData("nama_cabang", selectedCinema)[0];

                    //Studio studio = Studio.BacaData("cinemas_id", cinema.ID.ToString())[0];
                    //var ds = new DataTable();
                    //ds = Film.CariStudio(selectedFilm.Id, dateTimePickerTambah.Value, cinema);

                    //if (ds.Rows.Count == 0)
                    //{
                    //    MessageBox.Show("KOSONG");
                    //}
                    //comboBoxJenisStudio.DataSource = ds;
                    //comboBoxJenisStudio.DisplayMember = "Studio";
                    //comboBoxJenisStudio.ValueMember = "Studio";


                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                Environment.Exit(0);
            }
        }

        private void dateTimePickerTambah_ValueChanged(object sender, EventArgs e)
        {
            string selectedTgl = dateTimePickerTambah.Value.ToString("yyyy-MM-dd");
            List<JadwalFilm> listJadwalFilm = JadwalFilm.BacaData("tanggal", selectedTgl);
            if(listJadwalFilm.Count > 0)
            {
                comboBoxJamPemutaran.DataSource = listJadwalFilm;
                comboBoxJamPemutaran.DisplayMember = "jam_pemutaran";
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
                        textBoxTotal.Text = $"{CurrentPrice}";

                        //double totalAkhir = CurrentPrice - ((CurrentPrice * (FilmDiscount / 100)) * userSelection.Count);
                        double totalAkhir = CurrentPrice - (CurrentPrice * (FilmDiscount / 100));
                        textBoxTotalAkhir.Text = $"{totalAkhir}";
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
            try
            {
                textBoxHarga.Text = "";
                textBoxKapasitas.Text = "";
                textBoxSisa.Text = "";
                selectedPemutaran = (JadwalFilm)comboBoxJamPemutaran.SelectedItem;
                
                JadwalFilm jf = JadwalFilm.BacaData("tanggal", dateTimePickerTambah.Value.ToString("yyyy-MM-dd"), selectedPemutaran.Jam_pemutaran)[0];

                List<Studio> listStudio = Studio.BacaStudioSesiFilm(jf, selectedFilm);
                if(listStudio.Count > 0)
                {
                    comboBoxStudio.DataSource = listStudio;
                    comboBoxStudio.DisplayMember = "nama";
                }
                else
                {
                    comboBoxStudio.Text = "";
                }
                
                             
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void comboBoxJudul_SelectedIndexChanged_1(object sender, EventArgs e)
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



                List<JenisStudio> daftarJenisStudio = JenisStudio.BacaJenisStudioFilm(selectedFilm);

                if (daftarJenisStudio != null)
                {
                    comboBoxJenisStudio.DataSource = daftarJenisStudio;
                    comboBoxJenisStudio.DisplayMember = "nama";
                    //comboBoxCinema.ValueMember = "nama";
                    //comboBoxCinema.SelectedIndex = 0;
                }
                else
                {
                    comboBoxCinema.DataSource = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
            try
            {
                DialogResult res = MessageBox.Show("Apakah Anda Yakin untuk membeli tiket? ", "CONFIRMATION", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    string kursi = labelUserSelection.Text;
                    string[] arrKursi = kursi.Split(',');


                    int noNota = Invoice.GenerateNoNota();
                    //Tambah Data 
                    Invoice nota = new Invoice();
                    nota.Id = noNota;
                    nota.Tanggal = DateTime.Now;
                    nota.GrandTotal = int.Parse(textBoxTotal.Text);
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

                    if (Auth.GetKonsumen().Saldo > int.Parse(textBoxTotalAkhir.Text))
                    {
                        Konsumen.UbahSaldo(Auth.GetKonsumen(), -int.Parse(textBoxTotalAkhir.Text));
                        Invoice.TambahData(nota);
                        MessageBox.Show("Pembayaran Berhasil!");
                        this.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Saldo Anda Kurang!");
                    }

                    
                }              

            }
            catch(Exception ex)
            {
                MessageBox.Show("Penambahan Data Gagal " + ex.Message);
            }
        }

        private void Clear()
        {
            InitializeCheckBoxArray("A");
            InitializeCheckBoxArray("B");
            InitializeCheckBoxArray("C");
        }

        private void comboBoxJenisStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               if(comboBoxJenisStudio != null)
                {
                    selectedJenisStudio = (JenisStudio)comboBoxJenisStudio.SelectedItem;
                    daftarCinema = Cinema.BacaCinemaJenisStudio(selectedJenisStudio);
                    comboBoxCinema.DataSource = daftarCinema;
                    comboBoxCinema.DisplayMember = "nama_cabang";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


            //string day = dateTimePickerTambah.Value.DayOfWeek.ToString();
            //string namaStudio = comboBoxStudio.Text;
            //var jenisStudio = Studio.CariJenisStudio(namaStudio);

            //if (jenisStudio.Rows.Count > 0)
            //{
            //    textBoxJenisStudio.Text = jenisStudio.Rows[0][0].ToString();
            //    if (day == "Sunday" || day == "Saturday")
            //    {
            //        string price = jenisStudio.Rows[0][2].ToString();
            //        textBoxHarga.Text = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", price.ToString());
            //        TicketPrice = double.Parse(price);
            //    }
            //    else
            //    {
            //        string price = jenisStudio.Rows[0][1].ToString();
            //        textBoxHarga.Text = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", price.ToString());
            //        TicketPrice = double.Parse(price);
            //    }
            //    textBoxKapasitas.Text = jenisStudio.Rows[0][3].ToString();
            //}

            //*Add jam pemutaran
            //Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
            //DateTime selectedDate = dateTimePickerTambah.Value;
            //string cinema = comboBoxCinema.Text;

            //var daftarJamPemutaran = Film.CariJadwalPemutaran(selectedFilm.Id, selectedDate, cinema, namaStudio);

            //if (daftarJamPemutaran.Rows.Count > 0)
            //{
            //    comboBoxJamPemutaran.DataSource = daftarJamPemutaran;
            //    comboBoxJamPemutaran.DisplayMember = "Jam Pemutaran";
            //    comboBoxJamPemutaran.ValueMember = "Jam Pemutaran";
            //    jamPemutaranIsLoaded = true;
            //    //comboBoxCinema.SelectedIndex = 0;
            //}
            //else
            //{
            //    comboBoxJamPemutaran.DataSource = null;
            //}



        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudio = (Studio)comboBoxStudio.SelectedItem;
            string namaStudio = selectedStudio.Nama;
            Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
            DateTime selectedDate = dateTimePickerTambah.Value;
            string cinema = selectedCinema.NamaCabang;
            string jamPemutaran = selectedPemutaran.Jam_pemutaran;

            chairTaken = Tiket.CariNomorKursi(selectedFilm.Id, selectedDate, cinema, namaStudio, jamPemutaran);

            IsChange = false;
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
        }
    }
    
}
