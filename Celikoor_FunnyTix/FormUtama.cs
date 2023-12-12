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
                if(role == "ADMIN")
                {
                    foreach (Control c in FormUtama.form.Controls)
                    {
                        if (c is Panel)
                        {
                            c.Visible = true;
                            c.BackColor = Color.Maroon;
                        }
                    }
                    form.panelListMaster.Visible = false;
                    form.panelHistory.Visible = false;
                    form.OpenChild(new FormMasterPegawai());
                }
                else if(role=="OPERATOR")
                {

                    form.OpenChild(new FormOperator());
                }
                else if (role == "KASIR")
                {

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
                form.panelListMaster.Visible = false;
                form.panelMaster.Visible = false;
                form.panelDataTransaksi.Visible = false;
                form.panelInvoice.Visible = false;
                form.panelUpdateStatus.Visible = false;

                form.OpenChild(new FormMasterKonsumen());
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
            if (!(ACTIVE_CHILD is null))
            {
                ACTIVE_CHILD.Close();
                ACTIVE_CHILD = null;
            }

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

        bool visiblePanelList = false;
        private void panelMaster_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelProfil_Click(object sender, EventArgs e)
        {
            OpenChild(new FormProfile());
        }

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
    }
}
