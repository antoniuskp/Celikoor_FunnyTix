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
    public partial class FormMasterStudio : Form
    {

        public List<Studio> listStudio;

        public FormMasterStudio()
        {
            InitializeComponent();
        }
        
        private void FormMasterStudio_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listStudio = Studio.BacaData();


            comboBox.SelectedIndex = 0;

            List<JenisStudio> listJenisStudio = JenisStudio.BacaData();
            //panel tambah
            comboBoxJenisStudio.DataSource = listJenisStudio;
            comboBoxJenisStudio.DisplayMember = "Nama";
            //panel ubah
            comboBoxJenisStudioUbah.DataSource = listJenisStudio;
            comboBoxJenisStudioUbah.DisplayMember = "Nama";

            List<Cinema> listCinema = Cinema.BacaData();
            //panel tambah
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "NamaCabang";
            //panel ubah
            comboBoxCinemaUbah.DataSource = listCinema;
            comboBoxCinemaUbah.DisplayMember = "NamaCabang";

            InputDataGrid();
            FormatHeaderDataGrid();
        }

        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (Studio studio in listStudio)
            {
                string id = studio.ID.ToString();
                string nama = studio.Nama.ToString();
                string kapasitas = studio.Kapasitas.ToString();
                string jenisStudio = studio.JenisStudio.ToString();
                string cinema = studio.Cinema.ToString();
                string hargaWeekday = studio.HargaWeekday.ToString();
                string hargaWeekend = studio.HargaWeekend.ToString();

                dataGridViewHasil.Rows.Add(id, nama, kapasitas, jenisStudio, cinema, hargaWeekday, hargaWeekend, "Ubah", "Hapus");
            }
            comboBox.SelectedIndex = 0;
        }

        private void FormatHeaderDataGrid()
        {
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 8, FontStyle.Bold);
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHasil.EnableHeadersVisualStyles = false;

            dataGridViewHasil.AllowUserToAddRows = false;
            dataGridViewHasil.ReadOnly = true;
            dataGridViewHasil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewHasil.RowHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listStudio = Studio.FilterStudio("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Kapasitas":
                    listStudio = Studio.FilterStudio("kapasitas", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Jenis Studio":
                    listStudio = Studio.FilterStudio("jenis_studios_id", JenisStudio.BacaData(textBox.Text)[0].Nama);
                    dataGridViewHasil.Refresh();
                    break;
                case "Cinema":
                    listStudio = Studio.FilterStudio("cinemas_id", Cinema.BacaData("id", textBox.Text)[0].NamaCabang);
                    dataGridViewHasil.Refresh();
                    break;
                case "Harga Weekday":
                    listStudio = Studio.FilterStudio("harga_weekday", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Harga Weekend":
                    listStudio = Studio.FilterStudio("harga_weekend", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listStudio.Count > 0)
            {
                InputDataGrid();
            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Tidak ada data yang cocok.");
                textBox.Text = "";
                comboBox.SelectedIndex = 0;
            }
            for (int i = 0; i < dataGridViewHasil.Columns.Count; i++)
            {
                dataGridViewHasil.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            panelTambahStudio.Visible = true;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelTambahStudio.Visible = false;

            textBoxHargaWeekday.Clear();
            textBoxHargaWeekend.Clear();
            textBoxKapasitas.Clear();
            textBoxNama.Clear();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = textBoxNama.Text;
                int kapasitas = int.Parse(textBoxKapasitas.Text);

                JenisStudio jenisStudio = (JenisStudio) comboBoxJenisStudio.SelectedItem;
                Cinema cinema = (Cinema) comboBoxCinema.SelectedItem;


                int hargaWeekday = int.Parse(textBoxHargaWeekday.Text);
                int hargaWeekend = int.Parse(textBoxHargaWeekend.Text);

                Studio studio = new Studio(nama, kapasitas, jenisStudio, cinema, hargaWeekday, hargaWeekend);
                Studio.TambahData(studio);

                textBoxNama.Clear();
                textBoxKapasitas.Clear();
                comboBoxJenisStudio.SelectedIndex = 0;
                comboBoxCinema.SelectedIndex = 0;
                textBoxHargaWeekday.Clear();
                textBoxHargaWeekend.Clear();

                FormMasterStudio_Load(this, e);

                panelTambahStudio.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSimpanUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string hargaWeekDay = new string(textBoxHargaWeekdayUbah.Text.Where(char.IsDigit).ToArray());
                string hargaWeekEnd = new string(textBoxHargaWeekendUbah.Text.Where(char.IsDigit).ToArray());
                //int hargaWeekday = int.Parse(textBoxHargaWeekdayUbah.Text);
                //int hargaWeekend = int.Parse(textBoxHargaWeekendUbah.Text);

                Studio s = new Studio();
                s.ID = int.Parse(labelID.Text);
                s.Nama = textBoxNamaUbah.Text;
                s.Kapasitas = int.Parse(textBoxKapasitasUbah.Text);
                s.JenisStudio = (JenisStudio)comboBoxJenisStudio.SelectedItem;
                s.Cinema = (Cinema)comboBoxCinema.SelectedItem;
                s.HargaWeekday = int.Parse(hargaWeekDay);
                s.HargaWeekend = int.Parse(hargaWeekEnd);

                Studio.UbahData(s);

                textBoxNamaUbah.Clear();
                textBoxKapasitasUbah.Clear();
                comboBoxJenisStudioUbah.SelectedIndex = 0;
                comboBoxCinemaUbah.SelectedIndex = 0;
                textBoxHargaWeekdayUbah.Clear();
                textBoxHargaWeekendUbah.Clear();

                FormMasterStudio_Load(this, e);

                panelUbahStudio.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBatalUbah_Click(object sender, EventArgs e)
        {
            panelUbahStudio.Visible = false;
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["nama_column"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["ubah_column"].Index)
            {
                Studio studio = Studio.BacaData("id", kode)[0];
                labelID.Text = kode;
                textBoxNamaUbah.Text = nama;
                textBoxKapasitasUbah.Text = studio.Kapasitas.ToString();
                comboBoxJenisStudioUbah.SelectedText = studio.JenisStudio.Nama;
                comboBoxCinemaUbah.SelectedText = studio.Cinema.NamaCabang;

                textBoxHargaWeekdayUbah.Text = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", studio.HargaWeekday.ToString());
                textBoxHargaWeekendUbah.Text = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", studio.HargaWeekend.ToString());

                panelUbahStudio.Visible = true;
            }
            else if (e.ColumnIndex == dataGridViewHasil.Columns["hapus_column"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus studio " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Studio.HapusData(Studio.BacaData("id", kode)[0]);

                        FormMasterStudio_Load(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal. Error : " + ex.Message);
                    }
                }
            }
        }
    }
}
