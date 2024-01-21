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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Celikoor_FunnyTix
{
    public partial class FormHistoryPembelian : Form
    {
        List<History> listHistory;
        List<InvoiceMenu> listInvoiceMenu;
        public FormHistoryPembelian()
        {
            InitializeComponent();
        }

        private void FormHistoryPembelian_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            int kode = Auth.GetKonsumen().ID;
            listHistory = History.BacaHistory(kode);
            listInvoiceMenu = InvoiceMenu.BacaHistory("tanggal",0,Auth.GetKonsumen());
            panelDetailMenu.Visible = false;
            InputDataGrid();
            FormatHeaderDataGrid();
        }
        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();
            dataGridViewMenu.Rows.Clear();

            foreach (History In in listHistory)
            {
                string status = In.Status.ToString();
                string tgl = In.Tanggal.ToString("yyyy-MM-dd");
                string no_kursi = In.NoKursi.ToString();
                string harga = In.Harga.ToString();
                string judul = In.Judul.ToString();

                dataGridViewHasil.Rows.Add(status, tgl, no_kursi, harga, judul, "Print");
            }

            foreach (InvoiceMenu Im in listInvoiceMenu)
            {
                int id = int.Parse(Im.Id.ToString());
                string tgl = Im.Tanggal.ToString("yyyy-MM-dd");
                string status = Im.Status.ToString();
                double grand_total = double.Parse(Im.Grand_total.ToString());

                dataGridViewMenu.Rows.Add(status, tgl, grand_total, "Detail", "Barcode");
            }
        }
        private void FormatHeaderDataGrid()
        {
            //tiket
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 8, FontStyle.Bold);
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewHasil.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHasil.EnableHeadersVisualStyles = false;

            dataGridViewHasil.AllowUserToAddRows = false;
            dataGridViewHasil.ReadOnly = true;
            dataGridViewHasil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridViewHasil.RowHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;

            //menu
            dataGridViewMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;
            dataGridViewMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 8, FontStyle.Bold);
            dataGridViewMenu.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewMenu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMenu.EnableHeadersVisualStyles = false;

            dataGridViewMenu.AllowUserToAddRows = false;
            dataGridViewMenu.ReadOnly = true;
            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridViewMenu.RowHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;

            //DetailMenu
            dataGridViewDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;
            dataGridViewDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 8, FontStyle.Bold);
            dataGridViewDetail.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDetail.EnableHeadersVisualStyles = false;

            dataGridViewDetail.AllowUserToAddRows = false;
            dataGridViewDetail.ReadOnly = true;
            dataGridViewDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridViewDetail.RowHeadersDefaultCellStyle.BackColor = Color.NavajoWhite;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void buttonCari_Click(object sender, EventArgs e)
        {
            List<Invoice> listInvoice = Invoice.BacaData("tanggal", dateTimePickerTglTransaksi.Value.ToString("yyyy-MM-dd"), Auth.GetKonsumen());
            InputDataGrid();
        }*/

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string noKursi = dataGridViewHasil.CurrentRow.Cells["no_kursi_column"].Value.ToString();
            string status = dataGridViewHasil.CurrentRow.Cells["status_column"].Value.ToString();

            if (e.ColumnIndex == dataGridViewHasil.Columns["btn_print"].Index)
            {
                //MessageBox.Show(noKursi + " " + status);
                if (status.ToLower() == "terbayar")
                {
                    PrintTiket printTiket = new PrintTiket();
                    printTiket.Print(noKursi);
                }
                else
                {
                    MessageBox.Show($"Maaf, invoice anda belum terverifikasi!", "WARNING ⚠️");
                }
            }
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = dataGridViewMenu.CurrentRow.Cells["kolom_status"].Value.ToString();
            string tanggal = dataGridViewMenu.CurrentRow.Cells["kolom_tanggal"].Value.ToString();
            string harga = dataGridViewMenu.CurrentRow.Cells["kolom_total_harga"].Value.ToString();
            InvoiceMenu im = InvoiceMenu.CariInvoice("grand_total", harga, "tanggal", tanggal);
            if (e.ColumnIndex == dataGridViewMenu.Columns["detail_button"].Index)
            {
                dataGridViewDetail.Rows.Clear();
                List<DetailPesanan> listDetailPesanan = InvoiceMenu.BacaDetailPesanan(im.Id.ToString());
                labelStatus.Text = status;
                labelTanggal.Text = tanggal;
                labelTotalHarga.Text = harga;
                labelCinema.Text = Cinema.BacaData("id", listDetailPesanan[0].Cinema.ID.ToString())[0].NamaCabang;
                
                foreach(DetailPesanan dp in listDetailPesanan)
                {
                    string nama = dp.Makanan.Nama;
                    string jumlah = dp.Jumlah.ToString();
                    string subHarga = dp.Harga.ToString();
                    dataGridViewDetail.Rows.Add(nama, jumlah, subHarga);
                }

                panelDetailMenu.Visible = true;
            }
            if (e.ColumnIndex == dataGridViewMenu.Columns["barcode_button"].Index)
            {

            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            panelDetailMenu.Visible = false;
        }
    }
}
