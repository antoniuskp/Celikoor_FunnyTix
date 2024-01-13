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
    public partial class FormMasterJenisStudio : Form
    {
        public FormMasterJenisStudio()
        {
            InitializeComponent();
        }

        List<JenisStudio> listJenisStudio;

        private void FormMasterJenisStudio_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listJenisStudio = JenisStudio.BacaData();

            dataGridViewHasil.DataSource = listJenisStudio;
            comboBox.SelectedIndex = 0;

            if (listJenisStudio.Count > 0)
            {
                dataGridViewHasil.DataSource = listJenisStudio;
                if (dataGridViewHasil.ColumnCount == 3)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Hapus";
                    bcol.Name = "buttonHapusGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewHasil.Columns.Add(bcol);
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

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["ID"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["Nama"].Value.ToString();

            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus jenis studio " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        JenisStudio.DeleteData(kode);

                        FormMasterJenisStudio_Load(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal. Error : " + ex.Message);
                    }
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            panelTambahJenisStudio.Visible = true;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelTambahJenisStudio.Visible = false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string deskripsi = richTextBox1.Text;
            JenisStudio jn = new JenisStudio(nama, deskripsi);
            JenisStudio.TambahData(jn);

            textBoxNama.Clear();
            richTextBox1.Text = "";

            FormMasterJenisStudio_Load(this, e);

            panelTambahJenisStudio.Visible = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listJenisStudio = JenisStudio.CariJenisStudio("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Deskripsi":
                    listJenisStudio= JenisStudio.CariJenisStudio("deskripsi", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listJenisStudio.Count > 0)
            {
                dataGridViewHasil.DataSource = listJenisStudio;
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
