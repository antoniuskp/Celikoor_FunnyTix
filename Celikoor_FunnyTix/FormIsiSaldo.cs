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
    public partial class FormIsiSaldo : Form
    {
        public FormIsiSaldo()
        {
            InitializeComponent();
        }
        private void buttonBayar_Click(object sender, EventArgs e)
        {
            try
            {
                double saldo = Auth.GetKonsumen().Saldo;
                saldo += int.Parse(textBoxNominal.Text);
                Konsumen k = new Konsumen();
                k.ID = Auth.GetKonsumen().ID;
                Konsumen.TopUp(saldo, k);

                MessageBox.Show("Isi saldo sebesar " + int.Parse(textBoxNominal.Text) + " berhasil", "Informasi");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error dalam melakukan top up. Pesan kesalahan: " + ex.Message);
            }
        }

        private void FormIsiSaldo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
