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
            InputDataGrid();
            FormatHeaderDataGrid();
        }
        private void InputDataGrid()
        {
            dataGridViewHasil.Rows.Clear();


            foreach (Invoice In in listInvoice)
            {
                string id = In.Id.ToString();
                string tgl = In.Tanggal.ToString("yyyy-MM-dd");
                string grand_total = In.GrandTotal.ToString();
                string diskon = In.DiskonNominal.ToString();
                string konsumen = In.Konsumen.ToString();
                string kasir = In.Kasir.ToString();
                string status = In.Status.ToString();

                dataGridViewHasil.Rows.Add(id, tgl, grand_total, diskon, konsumen, kasir, status);
            }
            comboBox.SelectedIndex = 0;
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
                InputDataGrid();
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
