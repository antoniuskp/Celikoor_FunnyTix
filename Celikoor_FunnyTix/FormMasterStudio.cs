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

            dataGridViewHasil.DataSource = listStudio;
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

            if (listStudio.Count > 0)
            {
                dataGridViewHasil.DataSource = listStudio;
                if (dataGridViewHasil.ColumnCount == 7)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();

                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Ubah";
                    bcol.Name = "buttonUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewHasil.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "buttonHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewHasil.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            comboBox.SelectedIndex = 0;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listStudio = Studio.BacaData("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Kapasitas":
                    listStudio = Studio.BacaData("kapasitas", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Jenis Studio":
                    listStudio = Studio.BacaData("jenis_studios_id", JenisStudio.BacaData(textBox.Text)[0].Nama);
                    dataGridViewHasil.Refresh();
                    break;
                case "Cinema":
                    listStudio = Studio.BacaData("cinemas_id", Cinema.BacaData("id", textBox.Text)[0].NamaCabang);
                    dataGridViewHasil.Refresh();
                    break;
                case "Harga Weekday":
                    listStudio = Studio.BacaData("harga_weekday", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Harga Weekend":
                    listStudio = Studio.BacaData("harga_weekend", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listStudio.Count > 0)
            {
                dataGridViewHasil.DataSource = listStudio;
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

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            panelTambahStudio.Visible = true;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
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

                JenisStudio jenisStudio = JenisStudio.BacaData("Nama", comboBoxJenisStudio.Text)[0];
                Cinema cinema = Cinema.BacaData("NamaCabang", comboBoxCinema.Text)[0];


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
                string id = labelID.Text;
                string nama = textBoxNamaUbah.Text;
                int kapasitas = int.Parse(textBoxKapasitasUbah.Text);

                JenisStudio jenisStudio = JenisStudio.BacaData("nama", comboBoxJenisStudioUbah.Text)[0];
                Cinema cinema = Cinema.BacaData("nama_cabang", comboBoxCinemaUbah.Text)[0];

                int hargaWeekday = int.Parse(textBoxHargaWeekdayUbah.Text);
                int hargaWeekend = int.Parse(textBoxHargaWeekendUbah.Text);

                Studio studio = new Studio(nama, kapasitas, jenisStudio, cinema, hargaWeekday, hargaWeekend);
                Studio.UbahData(studio);

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
            string kode = dataGridViewHasil.CurrentRow.Cells["ID"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["Nama"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonUbahGrid"].Index)
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
            else if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
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
