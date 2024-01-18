using FunnyTix_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
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
                    form.panelLaporan.Visible = true;
                    form.panelMakanan.Visible = false;

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
                    form.panelLaporan.Visible = false;
                    form.panelMakanan.Visible = false;

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
                    form.panelLaporan.Visible =false;
                    form.panelMakanan.Visible = false;


                }
                form.labelNama.Text = Auth.GetPegawai().Nama + " - " + Auth.GetPegawai().Username + "\n" + Auth.GetPegawai().Roles;
                MessageBox.Show("LOGIN BERHASIL!", "SUCCESS ☑️");
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
                form.panelBeliTiket.Visible = true;
                form.panelMakanan.Visible = true;

                form.panelListMaster.Visible = false;

                form.labelNama.Text = Auth.GetKonsumen().Nama + "\n" + Auth.GetKonsumen().Saldo.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
                MessageBox.Show("LOGIN BERHASIL!", "SUCCESS ☑️");
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

        public void UpdateSaldo()
        {
            form.labelNama.Text = Auth.GetKonsumen().Nama + "\n" + Auth.GetKonsumen().Saldo.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
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

        #region Laporan
        private void labelLaporan_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormLaporan());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }

        private void panelLaporan_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormLaporan());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        #endregion
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
            /*FormValidasiInvoice frm = new FormValidasiInvoice();
            frm.MdiParent = this;
            frm.ShowDialog();*/
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
            frm.formUtama = this;
            frm.ShowDialog();
        }
        private void panelMakanan_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMakanan());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }


        private void panelMasterFilm_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterFilm());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }

        private void panelMasterKonsumen_MouseHover(object sender, EventArgs e)
        {
            panelMasterKonsumen.BackColor = Color.LightSalmon;
        }

        private void panelMasterKonsumen_MouseLeave(object sender, EventArgs e)
        {
            panelMasterKonsumen.BackColor = Color.Transparent;

        }

        private void labelPegawai_MouseHover(object sender, EventArgs e)
        {

        }

        private void panelMasterPegawai_MouseHover(object sender, EventArgs e)
        {
            panelMasterPegawai.BackColor = Color.LightSalmon;

        }

        private void panelMasterPegawai_MouseLeave(object sender, EventArgs e)
        {
            panelMasterPegawai.BackColor = Color.Transparent;

        }

        private void panelStudio_MouseHover(object sender, EventArgs e)
        {
            panelStudio.BackColor = Color.LightSalmon;

        }

        private void panelStudio_MouseLeave(object sender, EventArgs e)
        {
            panelStudio.BackColor = Color.Transparent;
        }

        private void panelMasterKelompok_MouseHover(object sender, EventArgs e)
        {
            panelMasterKelompok.BackColor = Color.LightSalmon;

        }

        private void panelMasterKelompok_MouseLeave(object sender, EventArgs e)
        {
            panelMasterKelompok.BackColor = Color.Transparent;
        }

        private void panelUpdateStatus_MouseHover(object sender, EventArgs e)
        {
            panelUpdateStatus.BackColor = Color.LightSalmon;
        }

        private void panelUpdateStatus_MouseLeave(object sender, EventArgs e)
        {
            panelUpdateStatus.BackColor = Color.Transparent; 

        }

        private void panelIsiSaldo_MouseHover(object sender, EventArgs e)
        {
            panelIsiSaldo.BackColor = Color.LightSalmon;

        }

        private void panelIsiSaldo_MouseLeave(object sender, EventArgs e)
        {
            panelIsiSaldo.BackColor = Color.Transparent;

        }

        private void panelBeliTiket_MouseHover(object sender, EventArgs e)
        {
            panelBeliTiket.BackColor = Color.LightSalmon;

        }

        private void panelBeliTiket_MouseLeave(object sender, EventArgs e)
        {
            panelBeliTiket.BackColor = Color.Transparent;

        }

        private void panelHistory_MouseHover(object sender, EventArgs e)
        {
            panelHistory.BackColor = Color.LightSalmon;
        }

        private void panelHistory_MouseLeave(object sender, EventArgs e)
        {
            panelHistory.BackColor = Color.Transparent;

        }

        private void panelUpdateStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInvoice_MouseHover(object sender, EventArgs e)
        {
            panelInvoice.BackColor = Color.LightSalmon;
        }

        private void panelInvoice_MouseLeave(object sender, EventArgs e)
        {
            panelInvoice.BackColor = Color.Transparent;

        }

        private void panelLogout_MouseHover(object sender, EventArgs e)
        {
            panelLogout.BackColor = Color.LightSalmon;
        }

        private void panelLogout_MouseLeave(object sender, EventArgs e)
        {
            panelLogout.BackColor = Color.Transparent;
        }

        private void panelPegawaiAdmin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panelLaporan_MouseHover(object sender, EventArgs e)
        {
            panelLaporan.BackColor = Color.LightSalmon;
        }

        private void panelLaporan_MouseLeave(object sender, EventArgs e)
        {
            panelLaporan.BackColor = Color.Maroon;

        }

        private void panelDataTransaksi_MouseHover(object sender, EventArgs e)
        {
            panelDataTransaksi.BackColor = Color.LightSalmon;

        }

        private void panelDataTransaksi_MouseLeave(object sender, EventArgs e)
        {
            panelDataTransaksi.BackColor = Color.Transparent;

        }

        private void panelPenjadwalan_MouseHover(object sender, EventArgs e)
        {
            panelPenjadwalan.BackColor = Color.LightSalmon;
        }

        private void panelPenjadwalan_MouseLeave(object sender, EventArgs e)
        {
            panelPenjadwalan.BackColor = Color.Transparent;

        }

        private void panelMaster_MouseHover(object sender, EventArgs e)
        {
            panelMaster.BackColor = Color.LightSalmon;
        }

        private void panelMaster_MouseLeave(object sender, EventArgs e)
        {
            panelMaster.BackColor = Color.Transparent;
        }

        private void panelMasterFilm_MouseHover(object sender, EventArgs e)
        {
            panelMasterFilm.BackColor = Color.LightSalmon;
        }

        private void panelMasterFilm_MouseLeave(object sender, EventArgs e)
        {
            panelMasterFilm.BackColor = Color.Transparent;
        }

        private void panelJenisStudio_MouseHover(object sender, EventArgs e)
        {
            panelJenisStudio.BackColor = Color.LightSalmon;
        }

        private void panelJenisStudio_MouseLeave(object sender, EventArgs e)
        {
            panelJenisStudio.BackColor = Color.Transparent;

        }

        private void panelMasterGenre_MouseHover(object sender, EventArgs e)
        {
            panelMasterGenre.BackColor = Color.LightSalmon;
        }

        private void panelMasterGenre_MouseLeave(object sender, EventArgs e)
        {
            panelMasterGenre.BackColor = Color.Transparent;

        }

        private void panelMasterAktor_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panelMasterAktor_MouseHover(object sender, EventArgs e)
        {
            panelMasterAktor.BackColor = Color.LightSalmon;
        }

        private void panelMasterCinema_MouseHover(object sender, EventArgs e)
        {
            panelMasterCinema.BackColor = Color.LightSalmon;
        }

        private void panelMasterCinema_MouseLeave(object sender, EventArgs e)
        {
            panelMasterCinema.BackColor = Color.Transparent;

        }

        private void panelMasterAktor_MouseLeave(object sender, EventArgs e)
        {
            panelMasterAktor.BackColor = Color.Transparent;
        }

        private void panelMakanan_MouseHover(object sender, EventArgs e)
        {
            panelMakanan.BackColor = Color.LightSalmon;
        }

        private void panelMakanan_MouseLeave(object sender, EventArgs e)
        {
            panelMakanan.BackColor = Color.Transparent;
        }
    }
}