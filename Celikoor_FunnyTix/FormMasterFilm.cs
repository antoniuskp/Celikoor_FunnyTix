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
    public partial class FormMasterFilm : Form
    {
        public FormMasterFilm()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahFilm frmTambah = new FormTambahFilm();
            frmTambah.Owner = this;
            frmTambah.ShowDialog();

            FormMasterFilm_Load(this, e);
        }

        private void FormMasterFilm_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            List<Film> listFilm = Film.BacaData();
            dataGridViewHasil.DataSource = listFilm;

            if (dataGridViewHasil.ColumnCount == 10)
            {
                DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                bcol2.HeaderText = "Aksi";
                bcol2.Text = "Hapus";
                bcol2.Name = "buttonHapusGrid";
                bcol2.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(bcol2);
            }
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["Id"].Value.ToString();
            string nama = dataGridViewHasil.CurrentRow.Cells["Judul"].Value.ToString();


            if (e.ColumnIndex == dataGridViewHasil.Columns["buttonHapusGrid"].Index)
            {
                DialogResult confirm = MessageBox.Show(this, "Anda yakin akan menghapus film " + nama + "?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Film.DeleteData(kode);

                        FormMasterFilm_Load(this, e);
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
