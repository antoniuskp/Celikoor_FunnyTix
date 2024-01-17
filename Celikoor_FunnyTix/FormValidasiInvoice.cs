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
    public partial class FormValidasiInvoice : Form
    {
        List<Invoice> listInvoice;
        public FormValidasiInvoice()
        {
            InitializeComponent();
        }
        public List<Invoice> listInvoices;

        private void FormValidasiInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                listInvoice = Invoice.BacaData();
                InputDataGrid();
                FormatHeaderDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string validasi = "Validasi";

                dataGridViewHasil.Rows.Add(id, tgl, grand_total, diskon, konsumen, kasir, status, validasi);
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
        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelValidasiInvoice.Visible = false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(labelId.Text);
                string status = comboBoxStatus.Text;

                Invoice invoice = new Invoice();
                invoice.Id = id;
                invoice.Status = status;
                invoice.Kasir = Auth.GetPegawai();

                Invoice.UpdateInvoice(invoice);
                MessageBox.Show("Pengubahan Data Berhasil!", "SUCCESS ☑️");
                panelValidasiInvoice.Visible = false;

                FormValidasiInvoice_Load(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan Data Gagal!", "WARNING ⚠️");

            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Tanggal":
                    listInvoices = Invoice.BacaData("Tanggal", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
                case "Status":
                    listInvoices = Invoice.BacaData("Status", textBox.Text);
                    dataGridViewHasil.Refresh();
                    break;
            }

            if (listInvoices.Count > 0)
            {
                InputDataGrid();
            }
            else
            {
                dataGridViewHasil.DataSource = listInvoices;
                MessageBox.Show("Tidak ada data yang cocok.");
                textBox.Text = "";
                comboBox.SelectedIndex = 0;
            }

            for (int i = 0; i < dataGridViewHasil.Columns.Count; i++)
            {
                dataGridViewHasil.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
                string status = dataGridViewHasil.CurrentRow.Cells["status_column"].Value.ToString();

                if (e.ColumnIndex == dataGridViewHasil.Columns["validasi_column"].Index)
                {
                    Invoice invoice = Invoice.BacaData("Id", kode)[0];
                    labelId.Text = kode;
                    comboBoxStatus.Text = status;
                    panelValidasiInvoice.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hapus data gagal. Error : " + ex.Message);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelValidasiInvoice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
