﻿
namespace Celikoor_FunnyTix
{
    partial class FormPenjadwalan
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
            this.comboBoxCinema = new System.Windows.Forms.ComboBox();
            this.comboBoxStudio = new System.Windows.Forms.ComboBox();
            this.textBoxNamaBioskop = new System.Windows.Forms.TextBox();
            this.labelHargaWeekday = new System.Windows.Forms.Label();
            this.labelHargaWeekend = new System.Windows.Forms.Label();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.columnJudul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnJam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.textBoxKapasitas = new System.Windows.Forms.TextBox();
            this.richTextBoxSinopsis = new System.Windows.Forms.RichTextBox();
            this.textBoxDurasi = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAktor = new System.Windows.Forms.TextBox();
            this.buttonTambah = new System.Windows.Forms.PictureBox();
            this.buttonSimpan = new System.Windows.Forms.PictureBox();
            this.buttonKeluar = new System.Windows.Forms.PictureBox();
            this.comboBoxJudulFilm = new System.Windows.Forms.ComboBox();
            this.checkBoxI = new System.Windows.Forms.CheckBox();
            this.checkBoxII = new System.Windows.Forms.CheckBox();
            this.checkBoxIII = new System.Windows.Forms.CheckBox();
            this.checkBoxIV = new System.Windows.Forms.CheckBox();
            this.textBoxKelompok = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTambah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonKeluar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCinema.FormattingEnabled = true;
            this.comboBoxCinema.Location = new System.Drawing.Point(116, 101);
            this.comboBoxCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(368, 33);
            this.comboBoxCinema.TabIndex = 0;
            this.comboBoxCinema.SelectedIndexChanged += new System.EventHandler(this.comboBoxCinema_SelectedIndexChanged);
            // 
            // comboBoxStudio
            // 
            this.comboBoxStudio.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStudio.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxStudio.FormattingEnabled = true;
            this.comboBoxStudio.Location = new System.Drawing.Point(538, 101);
            this.comboBoxStudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudio.Name = "comboBoxStudio";
            this.comboBoxStudio.Size = new System.Drawing.Size(128, 33);
            this.comboBoxStudio.TabIndex = 1;
            this.comboBoxStudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudio_SelectedIndexChanged);
            // 
            // textBoxNamaBioskop
            // 
            this.textBoxNamaBioskop.BackColor = System.Drawing.Color.Maroon;
            this.textBoxNamaBioskop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamaBioskop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaBioskop.ForeColor = System.Drawing.Color.NavajoWhite;
            this.textBoxNamaBioskop.Location = new System.Drawing.Point(123, 182);
            this.textBoxNamaBioskop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNamaBioskop.Name = "textBoxNamaBioskop";
            this.textBoxNamaBioskop.Size = new System.Drawing.Size(207, 31);
            this.textBoxNamaBioskop.TabIndex = 2;
            // 
            // labelHargaWeekday
            // 
            this.labelHargaWeekday.AutoSize = true;
            this.labelHargaWeekday.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelHargaWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaWeekday.ForeColor = System.Drawing.Color.Maroon;
            this.labelHargaWeekday.Location = new System.Drawing.Point(530, 207);
            this.labelHargaWeekday.Name = "labelHargaWeekday";
            this.labelHargaWeekday.Size = new System.Drawing.Size(24, 25);
            this.labelHargaWeekday.TabIndex = 4;
            this.labelHargaWeekday.Text = "0";
            // 
            // labelHargaWeekend
            // 
            this.labelHargaWeekend.AutoSize = true;
            this.labelHargaWeekend.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelHargaWeekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaWeekend.ForeColor = System.Drawing.Color.Maroon;
            this.labelHargaWeekend.Location = new System.Drawing.Point(530, 251);
            this.labelHargaWeekend.Name = "labelHargaWeekend";
            this.labelHargaWeekend.Size = new System.Drawing.Size(24, 25);
            this.labelHargaWeekend.TabIndex = 5;
            this.labelHargaWeekend.Text = "0";
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridViewHasil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnJudul,
            this.columnCinema,
            this.columnStudio,
            this.columnTanggal,
            this.columnJam});
            this.dataGridViewHasil.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewHasil.Location = new System.Drawing.Point(54, 628);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 62;
            this.dataGridViewHasil.RowTemplate.Height = 28;
            this.dataGridViewHasil.Size = new System.Drawing.Size(1633, 307);
            this.dataGridViewHasil.TabIndex = 9;
            this.dataGridViewHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellContentClick);
            this.dataGridViewHasil.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewHasil_ColumnAdded);
            // 
            // columnJudul
            // 
            this.columnJudul.HeaderText = "Judul";
            this.columnJudul.MinimumWidth = 6;
            this.columnJudul.Name = "columnJudul";
            this.columnJudul.Width = 125;
            // 
            // columnCinema
            // 
            this.columnCinema.HeaderText = "Cinema";
            this.columnCinema.MinimumWidth = 6;
            this.columnCinema.Name = "columnCinema";
            this.columnCinema.Width = 125;
            // 
            // columnStudio
            // 
            this.columnStudio.HeaderText = "Studio";
            this.columnStudio.MinimumWidth = 6;
            this.columnStudio.Name = "columnStudio";
            this.columnStudio.Width = 125;
            // 
            // columnTanggal
            // 
            this.columnTanggal.HeaderText = "Tanggal";
            this.columnTanggal.MinimumWidth = 6;
            this.columnTanggal.Name = "columnTanggal";
            this.columnTanggal.Width = 125;
            // 
            // columnJam
            // 
            this.columnJam.HeaderText = "Jam";
            this.columnJam.MinimumWidth = 6;
            this.columnJam.Name = "columnJam";
            this.columnJam.Width = 125;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.Color.Sienna;
            this.pictureBoxCover.Location = new System.Drawing.Point(754, 42);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(487, 553);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 10;
            this.pictureBoxCover.TabStop = false;
            // 
            // textBoxKapasitas
            // 
            this.textBoxKapasitas.BackColor = System.Drawing.Color.Maroon;
            this.textBoxKapasitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKapasitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKapasitas.ForeColor = System.Drawing.Color.NavajoWhite;
            this.textBoxKapasitas.Location = new System.Drawing.Point(122, 256);
            this.textBoxKapasitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKapasitas.Name = "textBoxKapasitas";
            this.textBoxKapasitas.Size = new System.Drawing.Size(207, 31);
            this.textBoxKapasitas.TabIndex = 12;
            // 
            // richTextBoxSinopsis
            // 
            this.richTextBoxSinopsis.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBoxSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSinopsis.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSinopsis.ForeColor = System.Drawing.Color.Maroon;
            this.richTextBoxSinopsis.Location = new System.Drawing.Point(1293, 128);
            this.richTextBoxSinopsis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxSinopsis.Name = "richTextBoxSinopsis";
            this.richTextBoxSinopsis.Size = new System.Drawing.Size(659, 257);
            this.richTextBoxSinopsis.TabIndex = 14;
            this.richTextBoxSinopsis.Text = "";
            // 
            // textBoxDurasi
            // 
            this.textBoxDurasi.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxDurasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDurasi.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDurasi.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxDurasi.Location = new System.Drawing.Point(1449, 421);
            this.textBoxDurasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDurasi.Name = "textBoxDurasi";
            this.textBoxDurasi.Size = new System.Drawing.Size(144, 29);
            this.textBoxDurasi.TabIndex = 15;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGenre.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenre.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxGenre.Location = new System.Drawing.Point(1772, 421);
            this.textBoxGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(152, 16);
            this.textBoxGenre.TabIndex = 17;
            // 
            // textBoxAktor
            // 
            this.textBoxAktor.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxAktor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAktor.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAktor.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxAktor.Location = new System.Drawing.Point(1533, 497);
            this.textBoxAktor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAktor.Name = "textBoxAktor";
            this.textBoxAktor.Size = new System.Drawing.Size(391, 16);
            this.textBoxAktor.TabIndex = 18;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambah.Location = new System.Drawing.Point(490, 497);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(130, 52);
            this.buttonTambah.TabIndex = 22;
            this.buttonTambah.TabStop = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Transparent;
            this.buttonSimpan.Location = new System.Drawing.Point(1756, 659);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(156, 42);
            this.buttonSimpan.TabIndex = 23;
            this.buttonSimpan.TabStop = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Transparent;
            this.buttonKeluar.Location = new System.Drawing.Point(1756, 751);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(156, 42);
            this.buttonKeluar.TabIndex = 24;
            this.buttonKeluar.TabStop = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // comboBoxJudulFilm
            // 
            this.comboBoxJudulFilm.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxJudulFilm.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJudulFilm.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxJudulFilm.FormattingEnabled = true;
            this.comboBoxJudulFilm.Location = new System.Drawing.Point(133, 345);
            this.comboBoxJudulFilm.Name = "comboBoxJudulFilm";
            this.comboBoxJudulFilm.Size = new System.Drawing.Size(496, 36);
            this.comboBoxJudulFilm.TabIndex = 25;
            this.comboBoxJudulFilm.SelectedIndexChanged += new System.EventHandler(this.comboBoxJudulFilm_SelectedIndexChanged);
            // 
            // checkBoxI
            // 
            this.checkBoxI.AutoSize = true;
            this.checkBoxI.BackColor = System.Drawing.Color.NavajoWhite;
            this.checkBoxI.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxI.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxI.Location = new System.Drawing.Point(141, 522);
            this.checkBoxI.Name = "checkBoxI";
            this.checkBoxI.Size = new System.Drawing.Size(36, 23);
            this.checkBoxI.TabIndex = 27;
            this.checkBoxI.Text = "I";
            this.checkBoxI.UseVisualStyleBackColor = false;
            // 
            // checkBoxII
            // 
            this.checkBoxII.AutoSize = true;
            this.checkBoxII.BackColor = System.Drawing.Color.NavajoWhite;
            this.checkBoxII.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxII.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxII.Location = new System.Drawing.Point(205, 522);
            this.checkBoxII.Name = "checkBoxII";
            this.checkBoxII.Size = new System.Drawing.Size(41, 23);
            this.checkBoxII.TabIndex = 28;
            this.checkBoxII.Text = "II";
            this.checkBoxII.UseVisualStyleBackColor = false;
            // 
            // checkBoxIII
            // 
            this.checkBoxIII.AutoSize = true;
            this.checkBoxIII.BackColor = System.Drawing.Color.NavajoWhite;
            this.checkBoxIII.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIII.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxIII.Location = new System.Drawing.Point(270, 522);
            this.checkBoxIII.Name = "checkBoxIII";
            this.checkBoxIII.Size = new System.Drawing.Size(46, 23);
            this.checkBoxIII.TabIndex = 29;
            this.checkBoxIII.Text = "III";
            this.checkBoxIII.UseVisualStyleBackColor = false;
            // 
            // checkBoxIV
            // 
            this.checkBoxIV.AutoSize = true;
            this.checkBoxIV.BackColor = System.Drawing.Color.NavajoWhite;
            this.checkBoxIV.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIV.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxIV.Location = new System.Drawing.Point(340, 522);
            this.checkBoxIV.Name = "checkBoxIV";
            this.checkBoxIV.Size = new System.Drawing.Size(46, 23);
            this.checkBoxIV.TabIndex = 30;
            this.checkBoxIV.Text = "IV";
            this.checkBoxIV.UseVisualStyleBackColor = false;
            // 
            // textBoxKelompok
            // 
            this.textBoxKelompok.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxKelompok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKelompok.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKelompok.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxKelompok.Location = new System.Drawing.Point(1862, 89);
            this.textBoxKelompok.Name = "textBoxKelompok";
            this.textBoxKelompok.Size = new System.Drawing.Size(50, 25);
            this.textBoxKelompok.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 431);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(343, 28);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // FormPenjadwalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Celikoor_FunnyTix.Properties.Resources.FormPenjadwalan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 844);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxKelompok);
            this.Controls.Add(this.checkBoxIV);
            this.Controls.Add(this.checkBoxIII);
            this.Controls.Add(this.checkBoxII);
            this.Controls.Add(this.checkBoxI);
            this.Controls.Add(this.comboBoxJudulFilm);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.textBoxAktor);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxDurasi);
            this.Controls.Add(this.richTextBoxSinopsis);
            this.Controls.Add(this.textBoxKapasitas);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.labelHargaWeekend);
            this.Controls.Add(this.labelHargaWeekday);
            this.Controls.Add(this.textBoxNamaBioskop);
            this.Controls.Add(this.comboBoxStudio);
            this.Controls.Add(this.comboBoxCinema);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPenjadwalan";
            this.Text = "FormPenjadwalan";
            this.Load += new System.EventHandler(this.FormPenjadwalan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTambah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonKeluar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCinema;
        private System.Windows.Forms.ComboBox comboBoxStudio;
        private System.Windows.Forms.TextBox textBoxNamaBioskop;
        private System.Windows.Forms.Label labelHargaWeekday;
        private System.Windows.Forms.Label labelHargaWeekend;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.TextBox textBoxKapasitas;
        private System.Windows.Forms.RichTextBox richTextBoxSinopsis;
        private System.Windows.Forms.TextBox textBoxDurasi;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAktor;
        private System.Windows.Forms.PictureBox buttonTambah;
        private System.Windows.Forms.PictureBox buttonSimpan;
        private System.Windows.Forms.PictureBox buttonKeluar;
        private System.Windows.Forms.ComboBox comboBoxJudulFilm;
        private System.Windows.Forms.CheckBox checkBoxI;
        private System.Windows.Forms.CheckBox checkBoxII;
        private System.Windows.Forms.CheckBox checkBoxIII;
        private System.Windows.Forms.CheckBox checkBoxIV;
        private System.Windows.Forms.TextBox textBoxKelompok;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnJudul;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnJam;
    }
}