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
    public partial class FormPegawai : Form
    {
        public Pegawai pegawai;
        public FormPegawai()
        {
            InitializeComponent();
        }

        private void kelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterKelompok form = new FormMasterKelompok();
            form.Owner = this;
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInvoice frmInvoice = new FormInvoice();
            frmInvoice.Owner = this;
            frmInvoice.ShowDialog();
        }

        private void FormPegawai_Load(object sender, EventArgs e)
        {
            FormMenu formMenu = (FormMenu)this.Owner.MdiParent;
            this.WindowState=FormWindowState.Maximized;
            labelRole.Text = pegawai.Roles.ToString();
            labelNama.Text = pegawai.Nama;
        }

        private void konsumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterKonsumen form = new FormMasterKonsumen();
            form.Owner = this;
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterCinema form = new FormMasterCinema();
            form.Owner = this;
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterPegawai form = new FormMasterPegawai();
            form.Owner = this;
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }

        private void aktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterAktor form = new FormMasterAktor();
            form.Owner = this;
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterGenre form = new FormMasterGenre();
            form.Owner = this;
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }

        private void updateStatusHadirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporan form = new FormLaporan();
            form.Owner = this;
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }
    }
}
