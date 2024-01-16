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
    public partial class FormMasterKonsumen : Form
    {
        public FormMasterKonsumen()
        {
            InitializeComponent();
        }
        public List<Konsumen> listKonsumen;
        private void FormMasterKonsumen_Load(object sender, EventArgs e)
        {
            //FormPegawai frmPegawai = (FormPegawai)this.Owner;

            listKonsumen = Konsumen.BacaData();

            InputDataGrid();
            FormatHeaderDataGrid();
        }

        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (Konsumen k in listKonsumen)
            {
                string id = k.ID.ToString();
                string nama = k.Nama.ToString();
                string email = k.Email.ToString();
                string noHp = k.No_Hp.ToString();
                string gender = k.Gender.ToString();
                string tglLahir = k.Tgl_lahir.ToString("dd/MM/yyyy");
                string saldo = k.Saldo.ToString();
                string username = k.Username.ToString();

                dataGridViewHasil.Rows.Add(id, nama, email, noHp, gender, tglLahir, saldo, username, " ", "Hapus");
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            comboBox.SelectedIndex = 0;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["nama_column"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["hapus_column"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus konsumen " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Konsumen.DeleteData(kode);

                        FormMasterKonsumen_Load(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus data gagal. Error : " + ex.Message);
                    }
                }
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listKonsumen = Konsumen.BacaData("Nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Email":
                    listKonsumen = Konsumen.BacaData("Email", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Nomor handphone":
                    listKonsumen = Konsumen.BacaData("no_hp", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Gender":
                    listKonsumen = Konsumen.BacaData("gender", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Tanggal Lahir":
                    listKonsumen = Konsumen.BacaData("tgl_lahir", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Username":
                    listKonsumen = Konsumen.BacaData("username", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Password":
                    listKonsumen = Konsumen.BacaData("username", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listKonsumen.Count > 0)
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
    }
}
