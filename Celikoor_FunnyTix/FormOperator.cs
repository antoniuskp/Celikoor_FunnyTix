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
    public partial class FormOperator : Form
    {
        public List<Tiket> listTiket;
        public FormOperator()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void FormOperator_Load(object sender, EventArgs e)
        {
            FormUtama frmUtama = (FormUtama)this.Owner;
            textBoxID.Text = $"{Auth.GetPegawai().ID}";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int noInv = int.Parse(textBoxNoTiket.Text.Substring(0, 3).TrimStart('0'));
                Tiket.UpdateKehadiran(noInv.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal Mengubah Status. Data Tidak Ditemukan!", "DANGER");
            }
            
        }

        private void textBoxNoTiket_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNoTiket.Text.Length == 6)
            {
                string noKursi = textBoxNoTiket.Text.Substring(3, 3);
                int noInv = int.Parse(textBoxNoTiket.Text.Substring(0, 3).TrimStart('0'));
                MessageBox.Show(noInv.ToString());
                Tiket ticket = Tiket.CariTiket(noInv, noKursi);

                if (ticket != null)
                {
                    if (ticket.Status == true)
                    {
                        textBoxStatus.Text = "Checked in";
                        buttonUpdate.Enabled = false;
                    }
                    else
                    {
                        textBoxStatus.Text = "Not checked in";
                        buttonUpdate.Enabled = true;
                    }
                    textBoxKursi.Text = ticket.NoKursi;
                    textBoxHarga.Text = ticket.Harga.ToString();
                    textBoxID.Text = ticket.Operators.ID.ToString();
                    dateTimePicker.Value = Invoice.CariInvoice(noInv, noKursi).Tanggal;
                    textBoxJudul.Text = Tiket.CariFilm(noInv, noKursi).Judul;
                    textBoxTime.Text = Tiket.CariFilm(noInv, noKursi).Durasi.ToString();
                    textBoxStudio.Text = Tiket.CariStudio(noInv, noKursi).Nama;
                }
            }

        }

        private void textBoxNoTiket_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
