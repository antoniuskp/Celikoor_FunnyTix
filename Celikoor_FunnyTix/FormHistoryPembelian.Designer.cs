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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerTglTransaksi = new System.Windows.Forms.DateTimePicker();
            this.buttonCari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.status_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_kursi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judul_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_print = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dataGridViewHasil.Size = new System.Drawing.Size(1488, 743);
            this.dataGridViewHasil.TabIndex = 28;
            this.dataGridViewHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.dateTimePickerTglTransaksi);
            this.panel1.Controls.Add(this.buttonCari);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 86);
            this.panel1.TabIndex = 27;
            // 
            // dateTimePickerTglTransaksi
            // 
            this.dateTimePickerTglTransaksi.CalendarFont = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTglTransaksi.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTglTransaksi.Location = new System.Drawing.Point(454, 32);
            this.dateTimePickerTglTransaksi.Name = "dateTimePickerTglTransaksi";
            this.dateTimePickerTglTransaksi.Size = new System.Drawing.Size(652, 28);
            this.dateTimePickerTglTransaksi.TabIndex = 4;
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.Maroon;
            this.buttonCari.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.ForeColor = System.Drawing.Color.White;
            this.buttonCari.Location = new System.Drawing.Point(1145, 19);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(170, 51);
            this.buttonCari.TabIndex = 3;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(145, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal Transaksi:";
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
            // status_column
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkRed;
            this.status_column.DefaultCellStyle = dataGridViewCellStyle6;
            this.status_column.HeaderText = "Status";
            this.status_column.MinimumWidth = 6;
            this.status_column.Name = "status_column";
            this.status_column.Width = 125;
            // 
            // tgl_column
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkRed;
            this.tgl_column.DefaultCellStyle = dataGridViewCellStyle7;
            this.tgl_column.HeaderText = "Tanggal";
            this.tgl_column.MinimumWidth = 6;
            this.tgl_column.Name = "tgl_column";
            this.tgl_column.Width = 125;
            // 
            // no_kursi_column
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkRed;
            this.no_kursi_column.DefaultCellStyle = dataGridViewCellStyle8;
            this.no_kursi_column.HeaderText = "Nomor Kursi";
            this.no_kursi_column.MinimumWidth = 6;
            this.no_kursi_column.Name = "no_kursi_column";
            this.no_kursi_column.Width = 125;
            // 
            // harga_column
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkRed;
            this.harga_column.DefaultCellStyle = dataGridViewCellStyle9;
            this.harga_column.HeaderText = "Harga";
            this.harga_column.MinimumWidth = 6;
            this.harga_column.Name = "harga_column";
            this.harga_column.Width = 125;
            // 
            // judul_column
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkRed;
            this.judul_column.DefaultCellStyle = dataGridViewCellStyle10;
            this.judul_column.HeaderText = "Judul";
            this.judul_column.MinimumWidth = 6;
            this.judul_column.Name = "judul_column";
            this.judul_column.Width = 125;
            // 
            // btn_print
            // 
            this.btn_print.HeaderText = "Aksi";
            this.btn_print.MinimumWidth = 6;
            this.btn_print.Name = "btn_print";
            this.btn_print.Width = 125;
            // 
            // FormHistoryPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1511, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistoryPembelian";
            this.Text = "FormHistoryPembelian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHistoryPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_kursi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn judul_column;
        private System.Windows.Forms.DataGridViewButtonColumn btn_print;
    }
}