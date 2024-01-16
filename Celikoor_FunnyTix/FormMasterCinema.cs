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
    public partial class FormMasterCinema : Form
    {

        public List<Cinema> listCabang;

        public FormMasterCinema()
        {
            InitializeComponent();
        }

        private void FormMasterCinema_Load(object sender, EventArgs e)
        {
            FormUtama frm =(FormUtama)this.Owner;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            listCabang = Cinema.BacaData();

            InputDataGrid();
            FormatHeaderDataGrid(); 

        }

        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (Cinema cin in listCabang)
            {
                string id = cin.ID.ToString();
                string nama_cabang = cin.NamaCabang.ToString();
                string alamat = cin.Alamat.ToString();
                string tgl_dibuka = cin.Tgl_Buka.ToString("yyyy-MM-dd");    
                string kota = cin.Kota.ToString();
                string hapus = "Hapus";

                dataGridViewHasil.Rows.Add(id, nama_cabang, alamat, tgl_dibuka, kota, hapus);
            }
            comboBox.SelectedIndex = 0;
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

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Cabang":
                    listCabang = Cinema.BacaData("Nama_cabang", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Alamat":
                    listCabang = Cinema.BacaData("Alamat", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Tanggal Dibuka":
                    listCabang = Cinema.BacaData("Tgl_dibuka", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Kota":
                    listCabang = Cinema.BacaData("Kota", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listCabang.Count > 0)
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
            panelTambahCinema.Visible = true;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelTambahCinema.Visible = false;
            textBoxAlamat.Clear();
            textBoxKota.Clear();
            textBoxNamaCabang.Clear();
            dateTimePickerTglBuka.Value = DateTime.Now; 
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string namaCabang = textBoxNamaCabang.Text;
            string alamat = textBoxAlamat.Text;
            DateTime tglBuka = dateTimePickerTglBuka.Value;
            string kota = textBoxKota.Text; 

            Cinema cinema = new Cinema(namaCabang, alamat, tglBuka, kota);
            Cinema.TambahData(cinema);

            panelTambahCinema.Visible = false;
            textBoxAlamat.Clear();
            textBoxKota.Clear();
            textBoxNamaCabang.Clear();
            dateTimePickerTglBuka.Value = DateTime.Now;

            FormMasterCinema_Load(this, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["nama_cabang_column"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["hapus_column"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus cinema " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Cinema.DeleteData(kode);

                        FormMasterCinema_Load(this, e);
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
