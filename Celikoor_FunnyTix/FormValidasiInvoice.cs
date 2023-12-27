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
        public FormValidasiInvoice()
        {
            InitializeComponent();
        }
        public List<Invoice> listInvoices;

        private void FormValidasiInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                List<Invoice> listInvoice = Invoice.BacaData();

                dataGridViewHasil.DataSource = listInvoice;

                //comboBox.DataSource = listPegawai;
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                dataGridViewHasil.DataSource = listInvoice;
                comboBox.SelectedIndex = 0;

                if (listInvoice.Count > 0)
                {
                    if (dataGridViewHasil.ColumnCount < 8)
                    {
                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Validasi";
                        bcol.Name = "buttonValidasi";
                        bcol.UseColumnTextForButtonValue = true;
                        dataGridViewHasil.Columns.Add(bcol);
                    }
                }
                else
                {
                    dataGridViewHasil.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                Invoice.UpdateInvoice(invoice);
                MessageBox.Show("Invoice berhasil diupdate");
                panelValidasiInvoice.Visible = false;

                FormValidasiInvoice_Load(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
            textBox.Text = "";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
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
                dataGridViewHasil.DataSource = listInvoices;
            }
            else
            {
                dataGridViewHasil.DataSource = null;
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
                string kode = dataGridViewHasil.CurrentRow.Cells["ID"].Value.ToString();
                string status = dataGridViewHasil.CurrentRow.Cells["Status"].Value.ToString();

                if (e.ColumnIndex == dataGridViewHasil.Columns["buttonValidasi"].Index)
                {
                    Invoice invoice = Invoice.BacaData("id", kode)[0];
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
    }
}
