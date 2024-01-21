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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Celikoor_FunnyTix
{
    public partial class FormMakanan : Form
    {
        public FormUtama frmUtama;
        private Cinema selectedCinema;
        private List<MakananCinemas> lstMakananCin;
        public FormMakanan()
        {
            InitializeComponent();
        }

        private void FormMakanan_Load(object sender, EventArgs e)
        {
            try
            {
                frmUtama = (FormUtama)this.Owner;
                comboBoxCinema.DataSource = Makanan.BacaCinemaMakanan();
                comboBoxCinema.DisplayMember = "NamaCabang";
                labelSaldo.Text = Auth.GetKonsumen().Saldo.ToString();
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
                selectedCinema = comboBoxCinema.SelectedItem as Cinema;
                lstMakananCin = MakananCinemas.BacaData(selectedCinema);
                dataGridViewHasil.Rows.Clear();

                foreach (MakananCinemas mc in lstMakananCin)
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
                int index = dataGridViewKeranjang.CurrentRow.Index;
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
                else if(e.ColumnIndex == dataGridViewKeranjang.Columns["hapus_column"].Index)
                {
                    dataGridViewKeranjang.Rows.RemoveAt(index);
                }
                HitungTotal();
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
                        dataGridViewKeranjang.Rows.Add(nama, harga, jumlah, jumlah * harga, "Ubah", "Hapus");
                    }
                    panelRincian.Visible = false;
                }
                //Display Total Akhir
                HitungTotal();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void HitungTotal()
        {
            int total = 0;
            for (int i = 0; i < dataGridViewKeranjang.Rows.Count; i++)
            {
                int subTotal = int.Parse(dataGridViewKeranjang.Rows[i].Cells["total_column"].Value.ToString());
                total += subTotal;
            }
            labelTotal.Text = total.ToString();
            labelTotalAkhir.Text = total.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            try
            {
                int saldo = int.Parse(labelSaldo.Text);
                int totalAkhir = int.Parse(labelTotalAkhir.Text);   
                if(saldo > totalAkhir)
                {
                    DialogResult respond = MessageBox.Show("Apakah yakin untuk membeli menu di keranjang?", "CONFIRMATION", MessageBoxButtons.YesNo);
                    if (respond == DialogResult.Yes)
                    {
                        string NoNota = InvoiceMenu.GenerateNota();
                        //Buat nota makanan
                        InvoiceMenu im = new InvoiceMenu();
                        im.Tanggal = DateTime.Now;
                        im.Grand_total = double.Parse(labelTotalAkhir.Text);
                        im.Konsumen = Auth.GetKonsumen();
                        im.Id = int.Parse(NoNota);

                        //Masukin detail ke db
                        for (int i = 0; i < dataGridViewKeranjang.Rows.Count; i++)
                        {
                            string nama = dataGridViewKeranjang.Rows[i].Cells["nama_keranjang_column"].Value.ToString();
                            int jumlah = int.Parse(dataGridViewKeranjang.Rows[i].Cells["column_jumlah"].Value.ToString());
                            double harga = double.Parse(dataGridViewKeranjang.Rows[i].Cells["column_harga"].Value.ToString());
                            List<Makanan> food = Makanan.SearchMakanan("nama", nama);
                            if (food != null)
                            {
                                MakananCinemas mc = new 
                                    MakananCinemas();
                                mc.Harga = harga;
                                mc.Cinema = selectedCinema;
                                mc.Makanan_ = food[0];
                                im.TambahDetail(jumlah, mc);
                            }
                        }

                        //mengurangi saldo 
                        double totalYgDIbayar = double.Parse(labelTotalAkhir.Text);
                        Konsumen.UbahSaldo(Auth.GetKonsumen(), -(int)totalYgDIbayar);

                        frmUtama.UpdateSaldo();

                        InvoiceMenu.TambahData(im);
                        MessageBox.Show("Pembayaran Berhasil!", "SUCCESS ☑️");
                        FormMakanan_Load(this, e);

                        dataGridViewKeranjang.Rows.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("Saldo Anda tidak mencukupi", "WARNING ⚠️");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Penambahan Data gagal! " + ex.Message);
            }
            
            
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Nama":
                    lstMakananCin = MakananCinemas.SearchData(selectedCinema ,"Nama", textBoxFilter.Text);
                    
                    dataGridViewHasil.Refresh();
                    break;
                case "Harga":
                    lstMakananCin = MakananCinemas.SearchData(selectedCinema ,"Harga", textBoxFilter.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (lstMakananCin.Count > 0)
            {
                dataGridViewHasil.Rows.Clear();

                foreach (MakananCinemas mc in lstMakananCin)
                {
                    dataGridViewHasil.Rows.Add(mc.Makanan_.Nama, mc.Makanan_.Deskripsi, mc.Harga, "Tambah");
                }
            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Tidak ada data yang cocok.");
                textBoxFilter.Text = "";
                comboBox.SelectedIndex = 0;
            }
            for (int i = 0; i < dataGridViewHasil.Columns.Count; i++)
            {
                dataGridViewHasil.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }
    }
}
