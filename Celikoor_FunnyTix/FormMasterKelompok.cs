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

            dataGridViewHasil.DataSource = listKelompok;
            ShowDataGrid();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
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
                dataGridViewHasil.DataSource = listKelompok;
                ShowDataGrid();
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }
        public void ShowDataGrid()
        {
            if (dataGridViewHasil.ColumnCount == 2)
            {
                /*DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();

                bcol.HeaderText = "Aksi";
                bcol.Text = "Ubah";
                bcol.Name = "btnUbahGrid";
                bcol.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(bcol);*/

                DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                bcol2.HeaderText = "Aksi";
                bcol2.Text = "Hapus";
                bcol2.Name = "buttonHapusGrid";
                bcol2.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(bcol2);
            }
            for (int i = 0; i < dataGridViewHasil.Columns.Count; i++)
            {
                dataGridViewHasil.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
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

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["ID"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["Nama"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
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
