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

        List<JenisStudio> listJenisStudio;

        public FormMasterJenisStudio()
        {
            InitializeComponent();
        }

        private void FormMasterJenisStudio_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listJenisStudio = JenisStudio.BacaData();

            InputDataGrid();
            FormatHeaderDataGrid();
        }

        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (JenisStudio js in listJenisStudio)
            {
                string id = js.Id.ToString();
                string nama = js.Nama.ToString();
                string deskripsi = js.Deskripsi.ToString();
                string hapus = "Hapus";

                dataGridViewHasil.Rows.Add(id, nama, deskripsi, hapus);
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
                case "Nama":
                    listJenisStudio = JenisStudio.CariJenisStudio("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Deskripsi":
                    listJenisStudio = JenisStudio.CariJenisStudio("Deskripsi", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listJenisStudio.Count > 0)
            {
                InputDataGrid();

            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Maaf, Tidak ada jenis studio yang cocok.", "INFORMATION");
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
            panelTambahJenisStudio.Visible = true;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelTambahJenisStudio.Visible = false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Apakah yakin untuk menambah data?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string nama = textBoxNama.Text;
                    string deskripsi = richTextBox1.Text;
                    JenisStudio jn = new JenisStudio(nama, deskripsi);
                    JenisStudio.TambahData(jn);
                    MessageBox.Show("Penambahan Data Berhasil!", "SUCCESS ☑️");

                    textBoxNama.Clear();
                    richTextBox1.Text = "";

                    FormMasterJenisStudio_Load(this, e);

                    panelTambahJenisStudio.Visible = false;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Penambahan Data Gagal!", "WARNING ⚠️");
            }
            
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["nama_column"].Value.ToString();

            if (e.ColumnIndex == dataGridViewHasil.Columns["hapus_column"].Index)
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
    }
}
