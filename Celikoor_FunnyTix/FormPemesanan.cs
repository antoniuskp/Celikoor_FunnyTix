using FunnyTix_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            comboBoxJudul.SelectedIndex = 0;
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
                Environment.Exit(0);
            }
        }

        private void comboBoxJudul_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
            listBoxSinopsis.Items.Clear();
            listBoxSinopsis.Items.Add(selectedFilm.Sinopsis);
            textBoxDurasi.Text = selectedFilm.Durasi.ToString();
            List<Genre> listGenre = Film.ListGenreFilm(selectedFilm);
            if(listGenre.Count > 0)
            {
                for (int i = 0; i < listGenre.Count; i++)
                {
                    if(i >= 0 && i < 2)
                    {
                        textBoxGenre.Text = $"{listGenre[i].Nama},";
                    }
                }
                textBoxGenre.Text += "...";
            }
            
            
            //Film film = Film.BacaData(selectedFilm.Id.ToString())[0];
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
                            textBoxHarga.Text = price;
                        }
                        else
                        {
                            string price = jenisStudio.Rows[0][1].ToString();
                            textBoxHarga.Text = price;
                        }
                        textBoxKapasitas.Text = jenisStudio.Rows[0][3].ToString();
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

        private void listBoxSinopsis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
