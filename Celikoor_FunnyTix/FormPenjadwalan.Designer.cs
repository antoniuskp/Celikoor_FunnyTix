
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
            this.comboBoxJenisStudio = new System.Windows.Forms.ComboBox();
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
            this.comboBoxJudulFilm = new System.Windows.Forms.ComboBox();
            this.checkBoxI = new System.Windows.Forms.CheckBox();
            this.checkBoxII = new System.Windows.Forms.CheckBox();
            this.checkBoxIII = new System.Windows.Forms.CheckBox();
            this.checkBoxIV = new System.Windows.Forms.CheckBox();
            this.textBoxKelompok = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStudio = new System.Windows.Forms.ComboBox();
            this.buttonPilihJudul = new System.Windows.Forms.Button();
            this.buttonPilihCinema = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonPilihStudio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCinema.FormattingEnabled = true;
            this.comboBoxCinema.Location = new System.Drawing.Point(116, 89);
            this.comboBoxCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(229, 33);
            this.comboBoxCinema.TabIndex = 0;
            // 
            // comboBoxJenisStudio
            // 
            this.comboBoxJenisStudio.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxJenisStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJenisStudio.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxJenisStudio.FormattingEnabled = true;
            this.comboBoxJenisStudio.Location = new System.Drawing.Point(445, 89);
            this.comboBoxJenisStudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxJenisStudio.Name = "comboBoxJenisStudio";
            this.comboBoxJenisStudio.Size = new System.Drawing.Size(190, 33);
            this.comboBoxJenisStudio.TabIndex = 1;
            this.comboBoxJenisStudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenisStudio_SelectedIndexChanged);
            // 
            // labelHargaWeekday
            // 
            this.labelHargaWeekday.AutoSize = true;
            this.labelHargaWeekday.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelHargaWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaWeekday.ForeColor = System.Drawing.Color.Black;
            this.labelHargaWeekday.Location = new System.Drawing.Point(531, 170);
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
            this.labelHargaWeekend.ForeColor = System.Drawing.Color.Black;
            this.labelHargaWeekend.Location = new System.Drawing.Point(531, 212);
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
            this.dataGridViewHasil.Location = new System.Drawing.Point(53, 628);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 62;
            this.dataGridViewHasil.RowTemplate.Height = 28;
            this.dataGridViewHasil.Size = new System.Drawing.Size(1633, 306);
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
            this.pictureBoxCover.Location = new System.Drawing.Point(755, 42);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(487, 553);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 10;
            this.pictureBoxCover.TabStop = false;
            // 
            // textBoxKapasitas
            // 
            this.textBoxKapasitas.BackColor = System.Drawing.Color.White;
            this.textBoxKapasitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKapasitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKapasitas.ForeColor = System.Drawing.Color.Black;
            this.textBoxKapasitas.Location = new System.Drawing.Point(116, 248);
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
            this.textBoxDurasi.Location = new System.Drawing.Point(1425, 395);
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
            this.textBoxGenre.Location = new System.Drawing.Point(1756, 407);
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
            this.textBoxAktor.Location = new System.Drawing.Point(1496, 474);
            this.textBoxAktor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAktor.Name = "textBoxAktor";
            this.textBoxAktor.Size = new System.Drawing.Size(391, 16);
            this.textBoxAktor.TabIndex = 18;
            // 
            // comboBoxJudulFilm
            // 
            this.comboBoxJudulFilm.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxJudulFilm.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJudulFilm.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxJudulFilm.FormattingEnabled = true;
            this.comboBoxJudulFilm.Location = new System.Drawing.Point(116, 314);
            this.comboBoxJudulFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxJudulFilm.Name = "comboBoxJudulFilm";
            this.comboBoxJudulFilm.Size = new System.Drawing.Size(343, 36);
            this.comboBoxJudulFilm.TabIndex = 25;
            this.comboBoxJudulFilm.SelectedIndexChanged += new System.EventHandler(this.comboBoxJudulFilm_SelectedIndexChanged_1);
            // 
            // checkBoxI
            // 
            this.checkBoxI.AutoSize = true;
            this.checkBoxI.BackColor = System.Drawing.Color.NavajoWhite;
            this.checkBoxI.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxI.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxI.Location = new System.Drawing.Point(116, 490);
            this.checkBoxI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.checkBoxII.Location = new System.Drawing.Point(180, 490);
            this.checkBoxII.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.checkBoxIII.Location = new System.Drawing.Point(244, 490);
            this.checkBoxIII.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.checkBoxIV.Location = new System.Drawing.Point(315, 490);
            this.checkBoxIV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.textBoxKelompok.Location = new System.Drawing.Point(1861, 89);
            this.textBoxKelompok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKelompok.Name = "textBoxKelompok";
            this.textBoxKelompok.Size = new System.Drawing.Size(51, 25);
            this.textBoxKelompok.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 398);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(343, 28);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // comboBoxStudio
            // 
            this.comboBoxStudio.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStudio.FormattingEnabled = true;
            this.comboBoxStudio.Location = new System.Drawing.Point(116, 164);
            this.comboBoxStudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudio.Name = "comboBoxStudio";
            this.comboBoxStudio.Size = new System.Drawing.Size(229, 31);
            this.comboBoxStudio.TabIndex = 33;
            this.comboBoxStudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudio_SelectedIndexChanged);
            // 
            // buttonPilihJudul
            // 
            this.buttonPilihJudul.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilihJudul.ForeColor = System.Drawing.Color.Black;
            this.buttonPilihJudul.Location = new System.Drawing.Point(490, 314);
            this.buttonPilihJudul.Name = "buttonPilihJudul";
            this.buttonPilihJudul.Size = new System.Drawing.Size(145, 40);
            this.buttonPilihJudul.TabIndex = 34;
            this.buttonPilihJudul.Text = "Pilih";
            this.buttonPilihJudul.UseVisualStyleBackColor = true;
            this.buttonPilihJudul.Click += new System.EventHandler(this.buttonPilihJudul_Click);
            // 
            // buttonPilihCinema
            // 
            this.buttonPilihCinema.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilihCinema.ForeColor = System.Drawing.Color.Black;
            this.buttonPilihCinema.Location = new System.Drawing.Point(351, 86);
            this.buttonPilihCinema.Name = "buttonPilihCinema";
            this.buttonPilihCinema.Size = new System.Drawing.Size(84, 39);
            this.buttonPilihCinema.TabIndex = 35;
            this.buttonPilihCinema.Text = "Pilih";
            this.buttonPilihCinema.UseVisualStyleBackColor = true;
            this.buttonPilihCinema.Click += new System.EventHandler(this.buttonPilihCinema_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.Black;
            this.buttonTambah.Location = new System.Drawing.Point(490, 474);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(145, 39);
            this.buttonTambah.TabIndex = 36;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPilihStudio
            // 
            this.buttonPilihStudio.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilihStudio.ForeColor = System.Drawing.Color.Black;
            this.buttonPilihStudio.Location = new System.Drawing.Point(641, 83);
            this.buttonPilihStudio.Name = "buttonPilihStudio";
            this.buttonPilihStudio.Size = new System.Drawing.Size(94, 39);
            this.buttonPilihStudio.TabIndex = 37;
            this.buttonPilihStudio.Text = "Pilih";
            this.buttonPilihStudio.UseVisualStyleBackColor = true;
            this.buttonPilihStudio.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(111, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cinema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(441, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 39;
            this.label2.Text = "Studio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(111, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nama Bioskop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(386, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Weekday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(386, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "Weekend";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(111, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 43;
            this.label6.Text = "Kapasitas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(118, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 44;
            this.label7.Text = "Judul";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(118, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 28);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tanggal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(118, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 28);
            this.label9.TabIndex = 46;
            this.label9.Text = "Jam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(386, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 28);
            this.label10.TabIndex = 47;
            this.label10.Text = "Harga";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.Black;
            this.buttonSimpan.Location = new System.Drawing.Point(1756, 673);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(145, 39);
            this.buttonSimpan.TabIndex = 48;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click_1);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Black;
            this.buttonKeluar.Location = new System.Drawing.Point(1756, 742);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(145, 39);
            this.buttonKeluar.TabIndex = 49;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1288, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 32);
            this.label11.TabIndex = 50;
            this.label11.Text = "Sinopsis";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1287, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 32);
            this.label12.TabIndex = 51;
            this.label12.Text = "Durasi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(1615, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 32);
            this.label13.TabIndex = 52;
            this.label13.Text = "Genre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(1287, 463);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 32);
            this.label14.TabIndex = 53;
            this.label14.Text = "Aktor Utama :";
            // 
            // FormPenjadwalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 844);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPilihStudio);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonPilihCinema);
            this.Controls.Add(this.buttonPilihJudul);
            this.Controls.Add(this.comboBoxStudio);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxKelompok);
            this.Controls.Add(this.checkBoxIV);
            this.Controls.Add(this.checkBoxIII);
            this.Controls.Add(this.checkBoxII);
            this.Controls.Add(this.checkBoxI);
            this.Controls.Add(this.comboBoxJudulFilm);
            this.Controls.Add(this.textBoxAktor);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxDurasi);
            this.Controls.Add(this.richTextBoxSinopsis);
            this.Controls.Add(this.textBoxKapasitas);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.labelHargaWeekend);
            this.Controls.Add(this.labelHargaWeekday);
            this.Controls.Add(this.comboBoxJenisStudio);
            this.Controls.Add(this.comboBoxCinema);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPenjadwalan";
            this.Text = "FormPenjadwalan";
            this.Load += new System.EventHandler(this.FormPenjadwalan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCinema;
        private System.Windows.Forms.ComboBox comboBoxJenisStudio;
        private System.Windows.Forms.Label labelHargaWeekday;
        private System.Windows.Forms.Label labelHargaWeekend;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.TextBox textBoxKapasitas;
        private System.Windows.Forms.RichTextBox richTextBoxSinopsis;
        private System.Windows.Forms.TextBox textBoxDurasi;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAktor;
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
        private System.Windows.Forms.ComboBox comboBoxStudio;
        private System.Windows.Forms.Button buttonPilihJudul;
        private System.Windows.Forms.Button buttonPilihCinema;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonPilihStudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}