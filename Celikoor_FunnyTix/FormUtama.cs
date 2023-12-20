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
        public static bool statusLogin=false;
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
                }
                else if(role=="OPERATOR")
                {
                    form.panelPegawaiAdmin.Visible = false;
                    form.panelPegawaiKasir.Visible = false;
                    form.panelPegawaiOperator.Visible = true;
                    form.panelKonsumen.Visible = false;
                    form.panelListMaster.Visible = false;
                }
                else if (role == "KASIR")
                {
                    form.panelPegawaiAdmin.Visible = false;
                    form.panelPegawaiKasir.Visible = true;
                    form.panelPegawaiOperator.Visible = false;
                    form.panelKonsumen.Visible = false;
                    form.panelListMaster.Visible = false;
                }
                form.labelNama.Text = $"Welcome, {Auth.GetPegawai().Nama}";
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

                form.labelNama.Text = $"Welcome, {Auth.GetKonsumen().Nama}";
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
            if(statusLogin==false)
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
                /*
                FormMenu form = new FormMenu();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.TopLevel = false;
                form.AutoScroll = true;
                form.ControlBox = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.BringToFront();
                form.Show();
                */
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
            
            /*
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            
            var form = new FormMenu();
            form.TopLevel = false;
            form.AutoScroll = true;
            //panelForm.Visible = true;
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            form.ControlBox = false;
            form.BringToFront();
            form.Show();
            */

            //label1.Text = "Welcome, " + konsumen.Nama;
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
        #region Panel
        #region Panel Pegawai Admin
        bool visiblePanelList = false;
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

        private void panelPenjadwalan_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormPenjadwalan());
        }

        private void panelDataTransaksi_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormDataTransaksi());
        }
        #region List Panel Master
        private void panelMasterKonsumen_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterKonsumen());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }

        private void panelMasterCinema_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterCinema());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }

        private void panelMasterPegawai_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterPegawai());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }

        private void panelMasterKelompok_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterKelompok());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }

        private void panelMasterAktor_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterAktor());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }

        private void panelMasterGenre_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormMasterGenre());
            form.panelListMaster.Visible = false;
            visiblePanelList = false;
        }
        #endregion
        #endregion
        #region Panel Pegawai Kasir
        private void panelInvoice_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormValidasiInvoice());
        }
        #endregion
        #region Panel Pegawai Operator
        private void panelUpdateStatus_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormOperator());
        }
        #endregion
        #region Panel Konsumen
        private void panelProfil_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormProfile());
        }

        private void panelJadwalFilm_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormJadwalFilm());
        }

        private void panelHistory_Click(object sender, EventArgs e)
        {
            form.OpenChild(new FormHistoryPembelian());

        }
        #endregion
        private void panelLogout_Click(object sender, EventArgs e)
        {
            statusLogin = false;
            form.ACTIVE_CHILD = null;
            form.CloseAllForm();
            Auth.LogOut();
            FormUtama_Load(this,e);
        }
        private void CloseAllForm()
        {
            foreach(Form frm in form.MdiChildren)
            {
                frm.Close();
            }
        }

        #endregion

        private void panelBeliTiket_Click(object sender, EventArgs e)
        {
            var frm = new FormPemesanan();
            frm.ShowDialog();
        }

        private void panelMasterKonsumen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panelUpdateStatus_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
