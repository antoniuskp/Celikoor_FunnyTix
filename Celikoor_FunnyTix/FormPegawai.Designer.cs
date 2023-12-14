namespace Celikoor_FunnyTix
{
    partial class FormPegawai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konsumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStatusHadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.updateStatusHadirToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konsumenToolStripMenuItem,
            this.cinemaToolStripMenuItem,
            this.pegawaiToolStripMenuItem,
            this.kelToolStripMenuItem,
            this.aktorToolStripMenuItem,
            this.genreToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // konsumenToolStripMenuItem
            // 
            this.konsumenToolStripMenuItem.Name = "konsumenToolStripMenuItem";
            this.konsumenToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.konsumenToolStripMenuItem.Text = "Konsumen";
            this.konsumenToolStripMenuItem.Click += new System.EventHandler(this.konsumenToolStripMenuItem_Click);
            // 
            // cinemaToolStripMenuItem
            // 
            this.cinemaToolStripMenuItem.Name = "cinemaToolStripMenuItem";
            this.cinemaToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.cinemaToolStripMenuItem.Text = "Cinema";
            this.cinemaToolStripMenuItem.Click += new System.EventHandler(this.cinemaToolStripMenuItem_Click);
            // 
            // pegawaiToolStripMenuItem
            // 
            this.pegawaiToolStripMenuItem.Name = "pegawaiToolStripMenuItem";
            this.pegawaiToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.pegawaiToolStripMenuItem.Text = "Pegawai";
            this.pegawaiToolStripMenuItem.Click += new System.EventHandler(this.pegawaiToolStripMenuItem_Click);
            // 
            // kelToolStripMenuItem
            // 
            this.kelToolStripMenuItem.Name = "kelToolStripMenuItem";
            this.kelToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.kelToolStripMenuItem.Text = "Kelompok";
            this.kelToolStripMenuItem.Click += new System.EventHandler(this.kelToolStripMenuItem_Click);
            // 
            // aktorToolStripMenuItem
            // 
            this.aktorToolStripMenuItem.Name = "aktorToolStripMenuItem";
            this.aktorToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.aktorToolStripMenuItem.Text = "Aktor";
            this.aktorToolStripMenuItem.Click += new System.EventHandler(this.aktorToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // updateStatusHadirToolStripMenuItem
            // 
            this.updateStatusHadirToolStripMenuItem.Name = "updateStatusHadirToolStripMenuItem";
            this.updateStatusHadirToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.updateStatusHadirToolStripMenuItem.Text = "Update status hadir";
            this.updateStatusHadirToolStripMenuItem.Click += new System.EventHandler(this.updateStatusHadirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(717, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome,";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelRole.Location = new System.Drawing.Point(939, 474);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(99, 42);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Role";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelNama.Location = new System.Drawing.Point(1133, 474);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(121, 42);
            this.labelNama.TabIndex = 3;
            this.labelNama.Text = "Nama";
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // FormPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.NavajoWhite;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormPegawai";
            this.Text = "Form Pegawai";
            this.Load += new System.EventHandler(this.FormPegawai_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.ToolStripMenuItem konsumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStatusHadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
    }
}