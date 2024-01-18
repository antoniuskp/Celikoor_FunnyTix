using FunnyTix_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_FunnyTix
{
    public partial class FormMakanan : Form
    {
        public FormMakanan()
        {
            InitializeComponent();
        }

        private void FormMakanan_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxCinema.DataSource = Makanan.BacaCinemaMakanan();
                comboBoxCinema.DisplayMember = "NamaCabang";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cinema cinema = comboBoxCinema.SelectedItem as Cinema;
                List<MakananCinemas> lst = MakananCinemas.BacaData(cinema);
                dataGridViewHasil.Rows.Clear();

                foreach (MakananCinemas mc in lst)
                {
                    dataGridViewHasil.Rows.Add(mc.Makanan_.Nama, mc.Makanan_.Deskripsi, mc.Harga, "Tambah");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string nama = dataGridViewHasil.CurrentRow.Cells["nama_column"].Value.ToString();
                double harga = double.Parse(dataGridViewHasil.CurrentRow.Cells["harga_column"].Value.ToString());
                if (e.ColumnIndex == dataGridViewHasil.Columns["tambah_column"].Index)
                {
                    panelRincian.Visible = true;
                    buttonUbah.Visible = false;
                    buttonTambahh.Visible = true;
                    labelHarga.Text = harga.ToString();
                    textBoxNamaMakanan.Text = nama;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string nama = dataGridViewKeranjang.CurrentRow.Cells["nama_keranjang_column"].Value.ToString();
                double total = double.Parse(dataGridViewKeranjang.CurrentRow.Cells["total_column"].Value.ToString());

                if (e.ColumnIndex == dataGridViewKeranjang.Columns["ubah_column"].Index)
                {
                    foreach (DataGridViewRow row in dataGridViewHasil.Rows)
                    {
                        DataGridViewCell namaCell = row.Cells["nama_column"];
                        DataGridViewCell hargaCell = row.Cells["harga_column"];
                        if (namaCell != null && namaCell.Value.ToString() == nama) 
                        {
                            panelRincian.Visible = true;
                            buttonUbah.Visible = true;
                            buttonTambahh.Visible = false;
                            textBoxNamaMakanan.Text = nama;
                            labelHarga.Text = hargaCell.Value.ToString();
                            numericUpDownJumlah.Value = (int)(total / double.Parse(hargaCell.Value.ToString()));
                            break;
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonTambahh_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = textBoxNamaMakanan.Text;
                int jumlah = (int)numericUpDownJumlah.Value;
                double harga = double.Parse(labelHarga.Text);

                if (jumlah < 1)
                {
                    MessageBox.Show("Jumlah Harus lebih dari 1");
                }
                else
                {
                    bool isExist = false;
                    foreach (DataGridViewRow row in dataGridViewKeranjang.Rows)
                    {
                        DataGridViewCell cell = row.Cells["nama_keranjang_column"];
                        if (cell != null && cell.Value != null && cell.Value.ToString() == nama)
                        {
                            double currTotal = double.Parse(row.Cells["total_column"].Value.ToString());
                            currTotal += jumlah * harga;
                            row.Cells["total_column"].Value = currTotal;
                            isExist = true;
                            break;
                        }
                    }

                    if (!isExist)
                    {
                        dataGridViewKeranjang.Rows.Add(nama, jumlah * harga, "Ubah", "Hapus");
                    }
                    panelRincian.Visible = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = textBoxNamaMakanan.Text;
                int jumlah = (int)numericUpDownJumlah.Value;
                double harga = double.Parse(labelHarga.Text);

                if (jumlah < 1)
                {
                    MessageBox.Show("Jumlah Harus lebih dari 1");
                }
                else
                {
                    bool isExist = false;
                    foreach (DataGridViewRow row in dataGridViewKeranjang.Rows)
                    {
                        DataGridViewCell cell = row.Cells["nama_keranjang_column"];
                        if (cell != null && cell.Value != null && cell.Value.ToString() == nama)
                        {
                            row.Cells["total_column"].Value = jumlah * harga;
                            isExist = true;
                            break;
                        }
                    }

                    if (!isExist)
                    {
                        dataGridViewKeranjang.Rows.Add(nama, jumlah * harga, "Ubah", "Hapus");
                    }
                    panelRincian.Visible = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
