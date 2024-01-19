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
    public partial class FormValidasiMenu : Form
    {
        List<InvoiceMenu> listInvoiceMenu;
        private string status = "";

        public FormValidasiMenu()
        {
            InitializeComponent();
        }

        private void FormValidasiMenu_Load(object sender, EventArgs e)
        {
            try
            {
                listInvoiceMenu = InvoiceMenu.BacaData();
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

                dataGridViewHasil.Rows.Add(id, tgl, grand_total, konsumen, kasir, status, validasi, "Print");
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
        int index;
        private void dataGridViewHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridViewHasil.CurrentRow.Index;
            string idNota = dataGridViewHasil.Rows[index].Cells["id_column"].Value.ToString();
            if (e.ColumnIndex == dataGridViewHasil.Columns["print_column"].Index)
            {
                string status = dataGridViewHasil.Rows[index].Cells["status_column"].Value.ToString();
                if (status == "TERBAYAR")
                {
                    InvoiceMenu nota = InvoiceMenu.CariInvoice("id", idNota);
                    InvoiceMenu.CetakNota(nota);
                }
                else if (status == "VALIDASI" || status == "PENDING")
                {

                    MessageBox.Show($"Maaf, Nota anda masih dalam status {status}");
                }
            }
            else if(e.ColumnIndex == dataGridViewHasil.Columns["validasi_column"].Index)
            {
                labelId.Text = idNota;
                panelValidasiInvoice.Visible = true;

            }
        }

        
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            status = comboBoxStatus.Text;
            dataGridViewHasil.Rows[index].Cells["status_column"].Value = status;
            panelValidasiInvoice.Visible = false;
        }
    }
}
