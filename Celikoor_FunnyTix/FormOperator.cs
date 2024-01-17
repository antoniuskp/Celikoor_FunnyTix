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

        private void FormOperator_Load(object sender, EventArgs e)
        {
            FormUtama frmUtama = (FormUtama)this.Owner;
            textBoxID.Text = $"{Auth.GetPegawai().ID}";
            dateTimePicker.BackColor = Color.NavajoWhite;
            dateTimePicker.CalendarForeColor= Color.DarkRed;
            textBoxNoTiket.Focus();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int noInv = int.Parse(textBoxNoTiket.Text.Substring(0, 3).TrimStart('0'));
                string noKursi = textBoxNoTiket.Text.Substring(3, 3);
                Tiket.UpdateKehadiran(noInv.ToString(), noKursi, Auth.GetPegawai());
                MessageBox.Show("Pengubahan Data Berhasil!", "SUCCESS ☑️");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan Data Gagal!", "WARNING ⚠️");
            }
            
        }

        private void textBoxNoTiket_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNoTiket.Text.Length == 6)
                {
                    string noKursi = textBoxNoTiket.Text.Substring(3, 3);
                    int noInv = int.Parse(textBoxNoTiket.Text.Substring(0, 3).TrimStart('0'));
                    Tiket ticket = Tiket.CariTiket(noInv, noKursi);

                    if (ticket != null)
                    {
                        if(ticket.IdInvoice.Status == "TERBAYAR")
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
                            textBoxHarga.Text = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp. {0:N}", ticket.Harga.ToString());
                            textBoxID.Text = ticket.Operators.ID.ToString();
                            dateTimePicker.Value = Invoice.CariInvoice(noInv, noKursi).Tanggal;
                            textBoxJudul.Text = Tiket.CariFilm(noInv, noKursi).Judul;
                            textBoxTime.Text = JadwalFilm.DefineJam(noInv, noKursi).ToString();
                            textBoxStudio.Text = Tiket.CariStudio(noInv, noKursi).Nama;
                        }
                        else
                        {
                            MessageBox.Show($"Maaf, invoice anda sedang {ticket.IdInvoice.Status}");
                            textBoxID.Clear();
                        }
                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
