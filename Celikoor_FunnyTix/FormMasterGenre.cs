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
    public partial class FormMasterGenre : Form
    {
        public List<Genre> listGenre;
        public FormMasterGenre()
        {
            InitializeComponent();
        }

        private void FormMasterGenre_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listGenre = Genre.BacaData(); 

            dataGridViewHasil.DataSource = listGenre;
            comboBox.SelectedIndex = 0;
            ShowDataGrid();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    listGenre = Genre.BacaData("nama", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Deskripsi":
                    listGenre = Genre.BacaData("deskripsi", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listGenre.Count > 0)
            {
                dataGridViewHasil.DataSource = listGenre;

                ShowDataGrid();
            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Tidak ada data yang cocok.");
                textBox.Text = "";
                comboBox.SelectedIndex = 0;
            }
        }

        public void ShowDataGrid()
        {
            if (dataGridViewHasil.ColumnCount == 3)
            {
                DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();

                bcol.HeaderText = "Aksi";
                bcol.Text = "Ubah";
                bcol.Name = "btnUbahGrid";
                bcol.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(bcol);

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
            comboBox.SelectedIndex = 0;
        }
    }
}
