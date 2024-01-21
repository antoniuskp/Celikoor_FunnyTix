namespace Celikoor_FunnyTix
{
    partial class FormHistoryPembelian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.status_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_kursi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judul_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDetailMenu = new System.Windows.Forms.Panel();
            this.kolom_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolom_tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolom_total_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail_button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.barcode_button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.nama_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolom_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCinema = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.panelDetailMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonKeluar.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Maroon;
            this.buttonKeluar.Location = new System.Drawing.Point(11, 963);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(170, 51);
            this.buttonKeluar.TabIndex = 30;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status_column,
            this.tgl_column,
            this.no_kursi_column,
            this.harga_column,
            this.judul_column,
            this.btn_print});
            this.dataGridViewHasil.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewHasil.Location = new System.Drawing.Point(11, 199);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(806, 738);
            this.dataGridViewHasil.TabIndex = 28;
            this.dataGridViewHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellContentClick);
            // 
            // status_column
            // 
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.DarkRed;
            this.status_column.DefaultCellStyle = dataGridViewCellStyle43;
            this.status_column.HeaderText = "Status";
            this.status_column.MinimumWidth = 6;
            this.status_column.Name = "status_column";
            this.status_column.Width = 125;
            // 
            // tgl_column
            // 
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.DarkRed;
            this.tgl_column.DefaultCellStyle = dataGridViewCellStyle44;
            this.tgl_column.HeaderText = "Tanggal";
            this.tgl_column.MinimumWidth = 6;
            this.tgl_column.Name = "tgl_column";
            this.tgl_column.Width = 125;
            // 
            // no_kursi_column
            // 
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.DarkRed;
            this.no_kursi_column.DefaultCellStyle = dataGridViewCellStyle45;
            this.no_kursi_column.HeaderText = "Nomor Kursi";
            this.no_kursi_column.MinimumWidth = 6;
            this.no_kursi_column.Name = "no_kursi_column";
            this.no_kursi_column.Width = 125;
            // 
            // harga_column
            // 
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.DarkRed;
            this.harga_column.DefaultCellStyle = dataGridViewCellStyle46;
            this.harga_column.HeaderText = "Harga";
            this.harga_column.MinimumWidth = 6;
            this.harga_column.Name = "harga_column";
            this.harga_column.Width = 125;
            // 
            // judul_column
            // 
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.DarkRed;
            this.judul_column.DefaultCellStyle = dataGridViewCellStyle47;
            this.judul_column.HeaderText = "Judul";
            this.judul_column.MinimumWidth = 6;
            this.judul_column.Name = "judul_column";
            this.judul_column.Width = 125;
            // 
            // btn_print
            // 
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_print.DefaultCellStyle = dataGridViewCellStyle48;
            this.btn_print.HeaderText = "Aksi";
            this.btn_print.MinimumWidth = 6;
            this.btn_print.Name = "btn_print";
            this.btn_print.Width = 125;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1488, 65);
            this.label1.TabIndex = 26;
            this.label1.Text = "HISTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolom_status,
            this.kolom_tanggal,
            this.kolom_total_harga,
            this.detail_button,
            this.barcode_button});
            this.dataGridViewMenu.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewMenu.Location = new System.Drawing.Point(823, 199);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 24;
            this.dataGridViewMenu.Size = new System.Drawing.Size(676, 738);
            this.dataGridViewMenu.TabIndex = 31;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(11, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(806, 65);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ticket";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(823, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(676, 65);
            this.label3.TabIndex = 33;
            this.label3.Text = "Makanan";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDetailMenu
            // 
            this.panelDetailMenu.Controls.Add(this.buttonTutup);
            this.panelDetailMenu.Controls.Add(this.dataGridViewDetail);
            this.panelDetailMenu.Controls.Add(this.groupBox2);
            this.panelDetailMenu.Controls.Add(this.label7);
            this.panelDetailMenu.Location = new System.Drawing.Point(417, 254);
            this.panelDetailMenu.Name = "panelDetailMenu";
            this.panelDetailMenu.Size = new System.Drawing.Size(815, 700);
            this.panelDetailMenu.TabIndex = 34;
            // 
            // kolom_status
            // 
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.DarkRed;
            this.kolom_status.DefaultCellStyle = dataGridViewCellStyle49;
            this.kolom_status.HeaderText = "Status";
            this.kolom_status.MinimumWidth = 6;
            this.kolom_status.Name = "kolom_status";
            this.kolom_status.Width = 125;
            // 
            // kolom_tanggal
            // 
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.DarkRed;
            this.kolom_tanggal.DefaultCellStyle = dataGridViewCellStyle50;
            this.kolom_tanggal.HeaderText = "Tanggal";
            this.kolom_tanggal.MinimumWidth = 6;
            this.kolom_tanggal.Name = "kolom_tanggal";
            this.kolom_tanggal.Width = 125;
            // 
            // kolom_total_harga
            // 
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.DarkRed;
            this.kolom_total_harga.DefaultCellStyle = dataGridViewCellStyle51;
            this.kolom_total_harga.HeaderText = "Total Harga";
            this.kolom_total_harga.MinimumWidth = 6;
            this.kolom_total_harga.Name = "kolom_total_harga";
            this.kolom_total_harga.Width = 125;
            // 
            // detail_button
            // 
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.DarkRed;
            this.detail_button.DefaultCellStyle = dataGridViewCellStyle52;
            this.detail_button.HeaderText = "Aksi";
            this.detail_button.MinimumWidth = 6;
            this.detail_button.Name = "detail_button";
            this.detail_button.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detail_button.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detail_button.Width = 125;
            // 
            // barcode_button
            // 
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.Maroon;
            this.barcode_button.DefaultCellStyle = dataGridViewCellStyle53;
            this.barcode_button.HeaderText = "Aksi";
            this.barcode_button.MinimumWidth = 6;
            this.barcode_button.Name = "barcode_button";
            this.barcode_button.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.barcode_button.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.barcode_button.Width = 125;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.NavajoWhite;
            this.label7.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(25, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(763, 47);
            this.label7.TabIndex = 22;
            this.label7.Text = "D E T A I L  P E S A N A N";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCinema);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelTotalHarga);
            this.groupBox2.Controls.Add(this.labelTanggal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(25, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(763, 146);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label9.Location = new System.Drawing.Point(75, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Status :";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelStatus.Location = new System.Drawing.Point(151, 25);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(82, 26);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label8.Location = new System.Drawing.Point(60, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tanggal :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label10.Location = new System.Drawing.Point(27, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total Harga : Rp.";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelTanggal.Location = new System.Drawing.Point(152, 63);
            this.labelTanggal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(82, 26);
            this.labelTanggal.TabIndex = 10;
            this.labelTanggal.Text = "Status :";
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHarga.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelTotalHarga.Location = new System.Drawing.Point(197, 104);
            this.labelTotalHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(82, 26);
            this.labelTotalHarga.TabIndex = 11;
            this.labelTotalHarga.Text = "Status :";
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_column,
            this.jumlah_column,
            this.kolom_harga});
            this.dataGridViewDetail.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewDetail.Location = new System.Drawing.Point(25, 236);
            this.dataGridViewDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowHeadersWidth = 51;
            this.dataGridViewDetail.RowTemplate.Height = 24;
            this.dataGridViewDetail.Size = new System.Drawing.Size(763, 370);
            this.dataGridViewDetail.TabIndex = 32;
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonTutup.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTutup.Location = new System.Drawing.Point(22, 640);
            this.buttonTutup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(160, 43);
            this.buttonTutup.TabIndex = 33;
            this.buttonTutup.Text = "TUTUP";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // nama_column
            // 
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.DarkRed;
            this.nama_column.DefaultCellStyle = dataGridViewCellStyle54;
            this.nama_column.HeaderText = "Nama";
            this.nama_column.MinimumWidth = 6;
            this.nama_column.Name = "nama_column";
            this.nama_column.Width = 125;
            // 
            // jumlah_column
            // 
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.DarkRed;
            this.jumlah_column.DefaultCellStyle = dataGridViewCellStyle55;
            this.jumlah_column.HeaderText = "Jumlah";
            this.jumlah_column.MinimumWidth = 6;
            this.jumlah_column.Name = "jumlah_column";
            this.jumlah_column.Width = 125;
            // 
            // kolom_harga
            // 
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.DarkRed;
            this.kolom_harga.DefaultCellStyle = dataGridViewCellStyle56;
            this.kolom_harga.HeaderText = "Harga";
            this.kolom_harga.MinimumWidth = 6;
            this.kolom_harga.Name = "kolom_harga";
            this.kolom_harga.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(386, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bioskop :";
            // 
            // labelCinema
            // 
            this.labelCinema.AutoSize = true;
            this.labelCinema.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCinema.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelCinema.Location = new System.Drawing.Point(479, 25);
            this.labelCinema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCinema.Name = "labelCinema";
            this.labelCinema.Size = new System.Drawing.Size(82, 26);
            this.labelCinema.TabIndex = 13;
            this.labelCinema.Text = "Status :";
            // 
            // FormHistoryPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1511, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.panelDetailMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistoryPembelian";
            this.Text = "FormHistoryPembelian";
            this.Load += new System.EventHandler(this.FormHistoryPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.panelDetailMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_kursi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn judul_column;
        private System.Windows.Forms.DataGridViewButtonColumn btn_print;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDetailMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolom_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolom_tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolom_total_harga;
        private System.Windows.Forms.DataGridViewButtonColumn detail_button;
        private System.Windows.Forms.DataGridViewButtonColumn barcode_button;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolom_harga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCinema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}