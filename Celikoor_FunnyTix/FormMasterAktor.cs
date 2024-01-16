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

            //dataGridViewHasil.DataSource = listAktor;
            dataGridViewHasil.Rows.Clear(); 


            foreach(Aktor act in listAktor)
            {
                string id = act.ID.ToString();
                string nama = act.Nama.ToString();
                string tgllahir = act.Tgl_Lahir.ToString("yyyy-MM-dd");
                string gender = act.Gender.ToString();
                string negara = act.Negara_Asal.ToString();

                dataGridViewHasil.Rows.Add(id, nama, tgllahir, gender, negara);    
            }
            comboBox.SelectedIndex = 0;
            /*

            if (listAktor.Count > 0)
            {
                dataGridViewHasil.DataSource = listAktor;
                if (dataGridViewHasil.ColumnCount == 5)
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
            }*/
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

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

            panelTambahAktor.Visible = false;
            textBoxNama.Clear();
            textBoxNegara.Clear();
            dateTimePickerTglLahir.Value = DateTime.Now;

            FormMasterAktor_Load(this, e);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["ID"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["Nama"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonUbahGrid"].Index)
            {
                Aktor aktor = Aktor.BacaData("id", kode)[0];
                labelID.Text = kode;
                textBoxNamaUbah.Text = nama;
                dateTimePickerUbah.Value = aktor.Tgl_Lahir;
                if(aktor.Gender == "L")
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
            else if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus aktor " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(confirm == DialogResult.Yes)
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

        private void buttonBatalUbah_Click(object sender, EventArgs e)
        {
            panelUbah.Visible = false;
        }

        private void buttonSimpanUbah_Click(object sender, EventArgs e)
        {
            Aktor aktor = new Aktor(textBoxNamaUbah.Text, dateTimePickerUbah.Value, comboBoxGenderUbah.Text, textBoxNegaraAsalUbah.Text);
            aktor.ID = int.Parse(labelID.Text);
            Aktor.UpdateData(aktor);
            panelUbah.Visible = false;

            FormMasterAktor_Load(this, e);
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
                dataGridViewHasil.DataSource = listAktor;
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
    }
}
