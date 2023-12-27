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
    public partial class FormUtama : Form
    {
        public static bool statusLogin = false;
        public Konsumen konsumen;
        public static string CURRENT_ROLE;
        public Form ACTIVE_CHILD = null;

        public FormUtama()
        {
            InitializeComponent();
        }
        public static FormUtama form;
        public static void PegawaiInit(string role)
        {
            try
            {
                foreach (Control c in FormUtama.form.Controls)
                {
                    if (c is Panel)
                    {
                        c.Visible = true;
                        c.BackColor = Color.Maroon;
                    }
                }

                if (!(form.ACTIVE_CHILD is null))
                {
                    form.ACTIVE_CHILD.Close();
                    form.ACTIVE_CHILD = null;
                }

                if (role == "ADMIN")
                {
                    form.panelPegawaiAdmin.Visible = true;
                    form.panelPegawaiKasir.Visible = false;
                    form.panelPegawaiOperator.Visible = false;
                    form.panelKonsumen.Visible = false;
                    form.panelListMaster.Visible = false;
                    form.panelLogout.Visible = true;
                }
                else if (role == "OPERATOR")
                {
                    form.OpenChild(new FormOperator());
                    form.panelPegawaiAdmin.Visible = false;
                    form.panelPegawaiKasir.Visible = false;
                    form.panelPegawaiOperator.Visible = true;
                    form.panelKonsumen.Visible = false;
                    form.panelListMaster.Visible = false;
                    form.panelLogout.Visible = true;    
                }
                else if (role == "KASIR")
                {
                    form.OpenChild(new FormValidasiInvoice());
                    form.panelPegawaiAdmin.Visible = false;
                    form.panelPegawaiKasir.Visible = true;
                    form.panelInvoice.Visible = true;
                    form.panelPegawaiOperator.Visible = false;
                    form.panelKonsumen.Visible = false;
                    form.panelListMaster.Visible = false;
                    form.panelLogout.Visible = true;
                }
                form.textBox1.Text = Auth.GetPegawai().Nama;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        public static void KonsumenInit()
        {
            try
            {
                foreach (Control c in FormUtama.form.Controls)
                {
                    if (c is Panel)
                    {
                        c.Visible = true;
                        c.BackColor = Color.Maroon;
                    }
                }

                if (!(form.ACTIVE_CHILD is null))
                {
                    form.ACTIVE_CHILD.Close();
                    form.ACTIVE_CHILD = null;
                }
                form.panelPegawaiAdmin.Visible = false;
                form.panelPegawaiKasir.Visible = false;
                form.panelPegawaiOperator.Visible = false;
                form.panelKonsumen.Visible = true;

                form.panelListMaster.Visible = false;

                form.textBox1.Text = Auth.GetKonsumen().Nama;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void FormUtama_Load(object sender, EventArgs e)
        {
            form = this;
            panelPIlihan.Dock = DockStyle.Left;
            if (statusLogin == false)
            {
                this.WindowState = FormWindowState.Maximized;
                this.IsMdiContainer = true;

                foreach (Control c in this.Controls)
                {
                    if (c is Panel)
                    {
                        c.Visible = false;
                    }
                }
                form.OpenChild(new FormMenu());
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Panel)
                    {
                        c.Visible = false;
                    }
                }
            }
        }
        public void OpenChild(Form form)
        {
            ACTIVE_CHILD = form;
            form.MdiParent = this;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.BringToFront();
            form.Show();
        }

        #region SETTINGS
        private void panelProfil_MouseHover(object sender, EventArgs e)
        {
            panelProfil.BackColor = Color.LightSalmon;
        }

        private void panelProfil_MouseLeave(object sender, EventArgs e)
        {
            panelProfil.BackColor = Color.Transparent;
        }

        private void panelJadwalFilm_MouseHover(object sender, EventArgs e)
        {
            panelJadwalFilm.BackColor = Color.LightSalmon;

        }

        private void panelJadwalFilm_MouseLeave(object sender, EventArgs e)
        {
            panelJadwalFilm.BackColor = Color.Transparent;

        }

        private void panelHistry_MouseHover(object sender, EventArgs e)
        {
            panelHistory.BackColor = Color.LightSalmon;

        }

        private void panelHistry_MouseLeave(object sender, EventArgs e)
        {
            panelHistory.BackColor = Color.Transparent;

        }
        #endregion

        #region Panel Pegawai Admin
        bool visiblePanelList = false;
        #region Panel Master
        private void panelMaster_Click(object sender, EventArgs e)
        {
            if (visiblePanelList == false)
            {
                form.panelListMaster.Visible = true;
                visiblePanelList = true;
            }
            else
            {
                form.panelListMaster.Visible = false;
                visiblePanelList = false;
            }
        }
        private void labelMaster_Click(object sender, EventArgs e)
        {
            if (visiblePanelList == false)
            {
                form.panelListMaster.Visible = true;
                visiblePanelList = true;
            }
            else
            {
                form.panelListMaster.Visible = false;
                visiblePanelList = false;
            }
        }
        #endregion
        //List SubPanel Master
        #region Konsumen
        private void panelMasterKonsumen_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterKonsumen());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        private void label14_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterKonsumen());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        #endregion
        #region Cinema
        private void panelMasterCinema_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterCinema());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        private void label16_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterCinema());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        #endregion
        #region Pegawai
        private void panelMasterPegawai_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterPegawai());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        private void label20_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterPegawai());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        #endregion
        #region Kelompok
        private void label18_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterKelompok());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        private void panelMasterKelompok_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterKelompok());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        #endregion
        #region Aktor
        private void panelMasterAktor_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterAktor());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        private void label24_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterAktor());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        #endregion
        #region Genre
        private void panelMasterGenre_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterGenre());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        private void label22_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterGenre());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        #endregion
        #region Studio
        private void label7_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterStudio());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        private void panelStudio_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterStudio());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }

        #endregion
        #region Jenis Studio
        private void panelJenisStudio_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterJenisStudio());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        private void label9_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterJenisStudio());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        #endregion
        //

        #region Penjadwalan
        private void panelPenjadwalan_Click(object sender, EventArgs e)
        {
            FormPenjadwalan frm = new FormPenjadwalan();
            frm.Owner = this;
            frm.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            FormPenjadwalan frm = new FormPenjadwalan();
            frm.Owner = this;
            frm.ShowDialog();
        }
        #endregion
        #region Data Transaksi
        private void panelDataTransaksi_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormDataTransaksi());
        }
        private void labelDataTransaksi_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormDataTransaksi());

        }
        #endregion
        #endregion

        #region Panel Pegawai Kasir
        private void panelInvoice_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormValidasiInvoice());
        }
        private void label10_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormValidasiInvoice());
        }
        #endregion

        #region Panel Pegawai Operator
        private void panelUpdateStatus_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormOperator());
        }

        //label update status hadir
        private void label12_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormOperator());
        }
        #endregion

        #region Panel Konsumen
        private void panelBeliTiket_Click(object sender, EventArgs e)
        {
            var frm = new FormPemesanan();
            frm.ShowDialog();
        }
        //label beli tiket
        private void label3_Click(object sender, EventArgs e)
        {
            var frm = new FormPemesanan();
            frm.ShowDialog();
        }


        private void panelProfil_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormProfile());
        }

        private void panelJadwalFilm_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormJadwalFilm());
        }

        //label Jadwal Film
        private void label4_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormJadwalFilm());
        }


        private void label5_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormHistoryPembelian());
        }

        //label history
        private void panelHistory_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormHistoryPembelian());

        }


        #endregion

        #region Panel Log Out
        private void panelLogout_Click(object sender, EventArgs e)
        {
            statusLogin = false;
            form.ACTIVE_CHILD = null;
            form.CloseAllForm();
            Auth.LogOut();
            FormUtama_Load(this, e);
        }
        private void CloseAllForm()
        {
            foreach (Form frm in form.MdiChildren)
            {
                frm.Close();
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            statusLogin = false;
            form.ACTIVE_CHILD = null;
            form.CloseAllForm();
            Auth.LogOut();
            FormUtama_Load(this, e);
        }
        #endregion


        private void panelIsiSaldo_Click(object sender, EventArgs e)
        {
            var frm = new FormIsiSaldo();
            frm.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            var frm = new FormIsiSaldo();
            frm.ShowDialog();
        }
    }
}