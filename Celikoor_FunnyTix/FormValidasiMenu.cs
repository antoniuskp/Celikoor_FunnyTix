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
using System.Windows.Forms.VisualStyles;

namespace Celikoor_FunnyTix
{
    public partial class FormValidasiMenu : Form
    {
        List<InvoiceMenu> listInvoiceMenu;
        private string status;

        public FormValidasiMenu()
        {
            InitializeComponent();
        }

        private void FormValidasiMenu_Load(object sender, EventArgs e)
        {
            try
            {
                buttonPrintNota.Visible = false;
                listInvoiceMenu = InvoiceMenu.BacaDataHariIni();
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

            foreach (InvoiceMenu In in listInvoiceMenu)
            {
                string id = In.Id.ToString();
                string tgl = In.Tanggal.ToString("yyyy-MM-dd");
                string grand_total = In.Grand_total.ToString();
                string konsumen = In.Konsumen.ToString();
                string kasir = In.Kasir.ToString();
                string status = In.Status.ToString();
                string validasi = "Validasi";

                dataGridViewHasil.Rows.Add(id, tgl, grand_total, konsumen, kasir, status, validasi);
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

        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
                string status = dataGridViewHasil.CurrentRow.Cells["status_column"].Value.ToString();
                if (e.ColumnIndex == dataGridViewHasil.Columns["validasi_column"].Index)
                {
                    InvoiceMenu invoice = InvoiceMenu.BacaData("Id", kode)[0];
                    labelId.Text = kode;
                    comboBoxStatus.Text = status;
                    panelValidasiInvoice.Visible = true;
                }
                if (status == "TERAMBIL")
                {
                    buttonPrintNota.Visible = true;
                }
                else
                {
                    buttonPrintNota.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Perubahan data gagal. Error : " + ex.Message);
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            int id = int.Parse(labelId.Text);
            string status = comboBoxStatus.Text;
            if (status == "TERAMBIL")
            {
                InvoiceMenu invoice = new InvoiceMenu();
                invoice.Id = id;
                invoice.Status = status;
                invoice.Kasir = Auth.GetPegawai();//gabisa

                InvoiceMenu.UpdateInvoice(invoice);
                MessageBox.Show("Pengubahan Data Berhasil!", "SUCCESS ☑️");
                panelValidasiInvoice.Visible = false;

                FormValidasiMenu_Load(this, e);
            }
            /*try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan Data Gagal!", "WARNING ⚠️");

            }*/
        }

        private void buttonPrintNota_Click(object sender, EventArgs e)
        {
            string kode = dataGridViewHasil.CurrentRow.Cells["id_column"].Value.ToString();
            InvoiceMenu invoice = InvoiceMenu.BacaData("Id", kode)[0];
            InvoiceMenu.CetakNota(invoice);
            MessageBox.Show("Nota berhasil diprint!");
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            panelValidasiInvoice.Visible = false;
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text.Length == 11)
                {
                    string noInv = textBox.Text.Substring(8, 3).TrimStart('0');
                    listInvoiceMenu = InvoiceMenu.BacaDataHariIni("id", noInv);

                    buttonPrintNota.Visible = false;
                    InputDataGrid();
                    FormatHeaderDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
