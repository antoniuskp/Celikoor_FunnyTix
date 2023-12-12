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
    public partial class FormPemesanan : Form
    {
        public FormPemesanan()
        {
            InitializeComponent();
        }

        private void FormPemesanan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panelDenahKursi_MouseHover(object sender, EventArgs e)
        {
            //panelDenahKursi.BackColor = Color.LightSalmon;
        }

        private void panelRowA_MouseHover(object sender, EventArgs e)
        {
            panelRowA.BackColor = Color.LightSalmon;

        }

        private void panelRowB_MouseHover(object sender, EventArgs e)
        {
            panelRowB.BackColor = Color.LightSalmon;
        }

        private void panelRowC_MouseHover(object sender, EventArgs e)
        {
            panelRowC.BackColor = Color.LightSalmon;
        }

        private void pictureBoxKonfirmasiPembayaran_MouseHover(object sender, EventArgs e)
        {
            pictureBoxKonfirmasiPembayaran.BackColor = Color.LightSalmon;

        }

        private void pictureBoxKeluar_MouseHover(object sender, EventArgs e)
        {
            pictureBoxKeluar.BackColor = Color.LightSalmon;

        }
    }
}
