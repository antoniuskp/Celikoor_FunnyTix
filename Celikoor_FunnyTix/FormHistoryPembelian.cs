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
        public FormHistoryPembelian()
        {
            InitializeComponent();
        }

        private void FormHistoryPembelian_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            int kode = Auth.GetKonsumen().ID;
            listHistory = History.BacaHistory(kode);

            InputDataGrid();
            FormatHeaderDataGrid();
        }
        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (History In in listHistory)
            {
                string status = In.Status.ToString();
                string tgl = In.Tanggal.ToString("yyyy-MM-dd");
                string no_kursi = In.NoKursi.ToString();
                string harga = In.Harga.ToString();
                string judul = In.Judul.ToString();

                dataGridViewHasil.Rows.Add(status, tgl, no_kursi, harga, judul, "Print");
            }
            dateTimePickerTglTransaksi.Value = DateTime.Now;
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

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            List<Invoice> listInvoice = Invoice.BacaData("tanggal", dateTimePickerTglTransaksi.Value.ToString("yyyy-MM-dd"), Auth.GetKonsumen());
            InputDataGrid();
        }

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
            }
        }
    }
}
