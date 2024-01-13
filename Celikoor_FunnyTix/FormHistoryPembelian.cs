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
    public partial class FormHistoryPembelian : Form
    {
        public FormHistoryPembelian()
        {
            InitializeComponent();
        }

        private void FormHistoryPembelian_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            int kode = Auth.GetKonsumen().ID;
            List<History> listHistory = History.BacaHistory(kode);

            dataGridViewHasil.DataSource = listHistory;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            List<Invoice> listInvoice = Invoice.BacaData("tanggal", dateTimePickerTglTransaksi.Value.ToString("yyyy-MM-dd"), Auth.GetKonsumen());
            dataGridViewHasil.DataSource = listInvoice;


        }
    }
}
