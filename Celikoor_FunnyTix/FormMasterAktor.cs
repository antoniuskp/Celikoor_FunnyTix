using FunnyTix_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_FunnyTix
{
    public partial class FormMasterAktor : Form
    {

        public List<Aktor> listAktor;

        public FormMasterAktor()
        {
            InitializeComponent();
        }

        private void FormMasterAktor_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listAktor = Aktor.BacaData();

            InputDataGrid();
        }

        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (Aktor act in listAktor)
            {
                string id = act.ID.ToString();
                string nama = act.Nama.ToString();
                string tgllahir = act.Tgl_Lahir.ToString("yyyy-MM-dd");
                string gender = act.Gender.ToString();
                string negara = act.Negara_Asal.ToString();
                string ubah = "Ubah";
                string hapus = "Hapus";
                
                dataGridViewHasil.Rows.Add(id, nama, tgllahir, gender, negara, ubah, hapus);
            }
            comboBox.SelectedIndex = 0;
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listAktor = Aktor.BacaData("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Tanggal Lahir":
                    listAktor = Aktor.BacaData("Tgl_lahir", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Gender":
                    listAktor = Aktor.BacaData("Gender", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Negara":
                    listAktor = Aktor.BacaData("Negara_asal", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listAktor.Count > 0)
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
            panelTambahAktor.Visible = true;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelTambahAktor.Visible = false;
            textBoxNama.Clear();
            textBoxNegara.Clear();
            dateTimePickerTglLahir.Value = DateTime.Now;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Apakah yakin untuk menambah data?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string nama = textBoxNama.Text;
                    DateTime tglLahir = dateTimePickerTglLahir.Value;
                    string gender = comboBoxGender.Text;
                    string negara = textBoxNegara.Text;

                    Aktor act = new Aktor();
                    act.Nama = nama;
                    act.Tgl_Lahir = tglLahir;
                    act.Gender = gender;
                    act.Negara_Asal = negara;

                    Aktor.TambahData(act);
                    MessageBox.Show("Penambahan Data Berhasil!", "SUCCESS ☑️");

                    FormMasterAktor_Load(this, e);
                    panelTambahAktor.Visible = false;
                    textBoxNama.Clear();
                    textBoxNegara.Clear();
                    dateTimePickerTglLahir.Value = DateTime.Now;


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Penambahan Data Gagal!", "WARNING ⚠️");
            }
            

            
            
        }

        private void buttonBatalUbah_Click(object sender, EventArgs e)
        {
            panelUbah.Visible = false;
        }

        private void buttonSimpanUbah_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Apakah yakin untuk mengubah data?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Aktor aktor = new Aktor(textBoxNamaUbah.Text, dateTimePickerUbah.Value, comboBoxGenderUbah.Text, textBoxNegaraAsalUbah.Text);
                    aktor.ID = int.Parse(labelID.Text);
                    Aktor.UpdateData(aktor);
                    panelUbah.Visible = false;
                    MessageBox.Show("Pengubahan Data Berhasil!", "SUCCESS ☑️");
                    FormMasterAktor_Load(this, e);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pengubahan Data Gagal!", "WARNING ⚠️");
            }
            
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["nama_column"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["ubah_column"].Index)
            {
                Aktor aktor = Aktor.BacaData("id", kode)[0];
                labelID.Text = kode;
                textBoxNamaUbah.Text = nama;
                dateTimePickerUbah.Value = aktor.Tgl_Lahir;
                if (aktor.Gender == "L")
                {
                    comboBoxGenderUbah.SelectedIndex = 0;
                }
                else
                {
                    comboBoxGenderUbah.SelectedIndex = 1;
                }
                textBoxNegaraAsalUbah.Text = aktor.Negara_Asal;

                panelUbah.Visible = true;
            }
            else if (e.ColumnIndex == dataGridViewHasil.Columns["hapus_column"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus aktor " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Aktor.DeleteData(kode);

                        FormMasterAktor_Load(this, e);
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
