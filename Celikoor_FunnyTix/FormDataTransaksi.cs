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
        List<Invoice> listInvoice;

        public FormDataTransaksi()
        {
            InitializeComponent();
        }

        private void FormDataTransaksi_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            listInvoice = Invoice.BacaData();

            dataGridViewHasil.DataSource = listInvoice;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "id":
                    listInvoice = Invoice.BacaData("id", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "tanggal":
                    listInvoice = Invoice.BacaData("tanggal", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "status":
                    listInvoice = Invoice.BacaData("status", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "konsumen":
                    Konsumen k = Konsumen.BacaData("nama", textBox.Text)[0];
                    listInvoice = Invoice.BacaData("konsumens_id", k.ID.ToString());
                    dataGridViewHasil.Refresh();
                    break;
                default:
                    listInvoice = Invoice.BacaData();
                    dataGridViewHasil.Refresh();
                    break;
            }
            if(listInvoice.Count > 0)
            {
                dataGridViewHasil.DataSource = listInvoice;
            }
            else
            {
                dataGridViewHasil.DataSource = null;
                MessageBox.Show("Maaf, Tidak ada nota yang cocok.", "INFORMATION");
                textBox.Text = "";
                comboBox.SelectedIndex = 0;
            }
            for (int i = 0; i < dataGridViewHasil.Columns.Count; i++)
            {
                dataGridViewHasil.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }
    }
}
