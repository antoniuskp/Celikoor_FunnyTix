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
    public partial class FormMasterKelompok : Form
    {

        public List<Kelompok> listKelompok;

        public FormMasterKelompok()
        {
            InitializeComponent();
        }

        private void FormMasterKelompok_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listKelompok = Kelompok.BacaData();

            InputDataGrid();
            FormatHeaderDataGrid();
        }

        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (Kelompok k in listKelompok)
            {
                string id = k.Id.ToString();
                string nama = k.Nama.ToString();

                dataGridViewHasil.Rows.Add(id, nama, "Hapus");
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
                    listKelompok = Kelompok.BacaData("nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listKelompok.Count > 0)
            {
                InputDataGrid();
            }
            else
            {
                dataGridViewHasil.DataSource = null;
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
            panelTambahKelompok.Visible = true;    
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelTambahKelompok.Visible = false;
            textBoxBatasanUsia.Clear();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string batasanUsia = textBoxBatasanUsia.Text;

            Kelompok kel = new Kelompok(batasanUsia);
            Kelompok.TambahData(kel);

            panelTambahKelompok.Visible = false;
            textBoxBatasanUsia.Clear();

            FormMasterKelompok_Load(this, e);
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["nama_column"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["hapus_column"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus kelompok " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Kelompok.DeleteData(kode);

                        FormMasterKelompok_Load(this, e);
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
