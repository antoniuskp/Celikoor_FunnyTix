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
    public partial class FormDataTransaksi : Form
    {
        public FormDataTransaksi()
        {
            InitializeComponent();
        }

        private void FormDataTransaksi_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            List<Invoice> listInvoice = Invoice.BacaData();

            dataGridViewHasil.DataSource = listInvoice;
        }
    }
}
