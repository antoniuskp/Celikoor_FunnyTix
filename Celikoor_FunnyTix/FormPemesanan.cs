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
        private List<Film> daftarFilm;
        private DataTable daftarCinema;
        private List<string> userSelection = new List<string>();
        private bool jamPemutaranIsLoaded = false;
        private List<string> chairTaken = new List<string>();
        Film selectedFilm;
        private double TicketPrice;
        private double CurrentPrice;
        private double FilmDiscount;
        private bool IsChange = true;
        //private DataTable daftarStudio;


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
            daftarFilm = Film.BacaData();
            comboBoxJudul.DataSource = daftarFilm;
            comboBoxJudul.DisplayMember = "Judul";
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
                    comboBoxCinema.ValueMember = "nama_cabang";
                    Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
                    //Film filmId = Film.BacaData(selectedFilm.Id.ToString())[0];
                    string selectedCinema = (string)comboBoxCinema.SelectedValue;
                    Cinema cinema = Cinema.BacaData("nama_cabang", selectedCinema)[0];

                    //Studio studio = Studio.BacaData("cinemas_id", cinema.ID.ToString())[0];
                    var ds = new DataTable();
                    ds = Film.CariStudio(selectedFilm.Id, dateTimePickerTambah.Value, cinema);

                    if (ds.Rows.Count == 0)
                    {
                        MessageBox.Show("KOSONG");
                    }
                    comboBoxStudio.DataSource = ds;
                    comboBoxStudio.DisplayMember = "Studio";
                    comboBoxStudio.ValueMember = "Studio";
                }
            } 
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
                //Environment.Exit(0);
            }
        }

        private void dateTimePickerTambah_ValueChanged(object sender, EventArgs e)
        {
            Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
            //Film filmId = Film.BacaData(selectedFilm.Id.ToString())[0];
            daftarCinema = Film.CariCinema(selectedFilm.Id, dateTimePickerTambah.Value.ToString("yyyy-MM-dd"));
            if (daftarCinema.Rows.Count > 0)
            {
                comboBoxCinema.DataSource = daftarCinema;
                comboBoxCinema.DisplayMember = "nama_cabang";
                comboBoxCinema.ValueMember = "nama_cabang";
                //comboBoxCinema.SelectedIndex = 0;
            } 
            else
            {
                comboBoxCinema.DataSource = null;
            }
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxStudio != null)
                {
                    string day = dateTimePickerTambah.Value.DayOfWeek.ToString();
                    string namaStudio = comboBoxStudio.Text;
                    var jenisStudio = Studio.CariJenisStudio(namaStudio);

                    if (jenisStudio.Rows.Count > 0)
                    {                               
                        textBoxJenisStudio.Text = jenisStudio.Rows[0][0].ToString();
                        if (day == "Sunday" || day == "Saturday")
                        {
                            string price = jenisStudio.Rows[0][2].ToString();
                            textBoxHarga.Text = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", price.ToString());
                            TicketPrice = double.Parse(price);
                        }
                        else
                        {
                            string price = jenisStudio.Rows[0][1].ToString();
                            textBoxHarga.Text = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", price.ToString());
                            TicketPrice = double.Parse(price);
                        }
                        textBoxKapasitas.Text = jenisStudio.Rows[0][3].ToString();
                    }

                    //* Add jam pemutaran
                    Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
                    DateTime selectedDate = dateTimePickerTambah.Value;
                    string cinema = comboBoxCinema.Text;

                    var daftarJamPemutaran = Film.CariJadwalPemutaran(selectedFilm.Id, selectedDate, cinema, namaStudio);

                    if (daftarJamPemutaran.Rows.Count > 0)
                    {
                        comboBoxJamPemutaran.DataSource = daftarJamPemutaran;
                        comboBoxJamPemutaran.DisplayMember = "Jam Pemutaran";
                        comboBoxJamPemutaran.ValueMember = "Jam Pemutaran";
                        jamPemutaranIsLoaded = true;
                        //comboBoxCinema.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBoxJamPemutaran.DataSource = null;
                    }

                    
                }
                else
                {
                    MessageBox.Show("Studio Kosong");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void InputKursi(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Enabled && jamPemutaranIsLoaded)
            {
                if (cb.Checked)
                {
                    userSelection.Add((string)cb.Tag);
                    if (comboBoxJamPemutaran.Items.Count > 0 && IsChange)
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
                    if (comboBoxJamPemutaran.Items.Count > 0 && IsChange)
                    {
                        CurrentPrice -= TicketPrice;
                        textBoxTotal.Text = $"{CurrentPrice}";

                        //double totalAkhir = CurrentPrice - ((CurrentPrice * (FilmDiscount / 100)) * userSelection.Count);
                        double totalAkhir = CurrentPrice - (CurrentPrice * (FilmDiscount / 100));
                        textBoxTotalAkhir.Text = $"{totalAkhir}";
                    }
                }
                labelUserSelection.Text = String.Join(", ", userSelection);
            }
        }

        private void listBoxSinopsis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxJamPemutaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string namaStudio = comboBoxStudio.Text;
                Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
                DateTime selectedDate = dateTimePickerTambah.Value;
                string cinema = comboBoxCinema.Text;
                string jamPemutaran = comboBoxJamPemutaran.Text;

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

                IsChange = true;
                textBoxTotalAkhir.Text = "";
                labelUserSelection.Text = "";
                textBoxTotal.Text = "";
                //FilmDiscount = 0;
                CurrentPrice = 0;
                textBoxTotal.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void comboBoxJudul_SelectedIndexChanged_1(object sender, EventArgs e)
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



        daftarCinema = Film.CariCinema(selectedFilm.Id, dateTimePickerTambah.Value.ToString("yyyy-MM-dd"));

            if (daftarCinema != null)
            {
                comboBoxCinema.DataSource = daftarCinema;
                comboBoxCinema.DisplayMember = "nama_cabang";
                comboBoxCinema.ValueMember = "nama_cabang";
                //comboBoxCinema.SelectedIndex = 0;
            }
            else
            {
                comboBoxCinema.DataSource = null;
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
    }
}
