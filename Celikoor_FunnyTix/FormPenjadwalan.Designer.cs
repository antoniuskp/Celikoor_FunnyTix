
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenjadwalan));
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
            this.richTextBoxSinopsis = new System.Windows.Forms.RichTextBox();
            this.comboBoxJudulFilm = new System.Windows.Forms.ComboBox();
            this.checkBoxI = new System.Windows.Forms.CheckBox();
            this.checkBoxII = new System.Windows.Forms.CheckBox();
            this.checkBoxIII = new System.Windows.Forms.CheckBox();
            this.checkBoxIV = new System.Windows.Forms.CheckBox();
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
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelKapasitas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAktor = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelDurasi = new System.Windows.Forms.Label();
            this.labelKelompok = new System.Windows.Forms.Label();
            this.labelJudulFilm = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonBioskop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxCinema.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCinema.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBoxCinema.FormattingEnabled = true;
            this.comboBoxCinema.Location = new System.Drawing.Point(57, 87);
            this.comboBoxCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(299, 33);
            this.comboBoxCinema.TabIndex = 0;
            // 
            // comboBoxJenisStudio
            // 
            this.comboBoxJenisStudio.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxJenisStudio.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxJenisStudio.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxJenisStudio.FormattingEnabled = true;
            this.comboBoxJenisStudio.Location = new System.Drawing.Point(57, 181);
            this.comboBoxJenisStudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxJenisStudio.Name = "comboBoxJenisStudio";
            this.comboBoxJenisStudio.Size = new System.Drawing.Size(299, 33);
            this.comboBoxJenisStudio.TabIndex = 1;
            this.comboBoxJenisStudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenisStudio_SelectedIndexChanged);
            // 
            // labelHargaWeekday
            // 
            this.labelHargaWeekday.AutoSize = true;
            this.labelHargaWeekday.BackColor = System.Drawing.Color.DarkRed;
            this.labelHargaWeekday.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelHargaWeekday.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelHargaWeekday.Location = new System.Drawing.Point(153, 39);
            this.labelHargaWeekday.Name = "labelHargaWeekday";
            this.labelHargaWeekday.Size = new System.Drawing.Size(0, 24);
            this.labelHargaWeekday.TabIndex = 4;
            // 
            // labelHargaWeekend
            // 
            this.labelHargaWeekend.AutoSize = true;
            this.labelHargaWeekend.BackColor = System.Drawing.Color.DarkRed;
            this.labelHargaWeekend.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelHargaWeekend.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelHargaWeekend.Location = new System.Drawing.Point(153, 81);
            this.labelHargaWeekend.Name = "labelHargaWeekend";
            this.labelHargaWeekend.Size = new System.Drawing.Size(0, 24);
            this.labelHargaWeekend.TabIndex = 5;
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
            this.dataGridViewHasil.Location = new System.Drawing.Point(680, 667);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 62;
            this.dataGridViewHasil.RowTemplate.Height = 28;
            this.dataGridViewHasil.Size = new System.Drawing.Size(1060, 267);
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
            this.pictureBoxCover.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBoxCover.Location = new System.Drawing.Point(663, 42);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(469, 553);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 10;
            this.pictureBoxCover.TabStop = false;
            // 
            // richTextBoxSinopsis
            // 
            this.richTextBoxSinopsis.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBoxSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSinopsis.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSinopsis.ForeColor = System.Drawing.Color.Maroon;
            this.richTextBoxSinopsis.Location = new System.Drawing.Point(22, 82);
            this.richTextBoxSinopsis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxSinopsis.Name = "richTextBoxSinopsis";
            this.richTextBoxSinopsis.Size = new System.Drawing.Size(659, 335);
            this.richTextBoxSinopsis.TabIndex = 14;
            this.richTextBoxSinopsis.Text = "";
            // 
            // comboBoxJudulFilm
            // 
            this.comboBoxJudulFilm.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxJudulFilm.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxJudulFilm.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxJudulFilm.FormattingEnabled = true;
            this.comboBoxJudulFilm.Location = new System.Drawing.Point(50, 665);
            this.comboBoxJudulFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxJudulFilm.Name = "comboBoxJudulFilm";
            this.comboBoxJudulFilm.Size = new System.Drawing.Size(343, 33);
            this.comboBoxJudulFilm.TabIndex = 25;
            this.comboBoxJudulFilm.SelectedIndexChanged += new System.EventHandler(this.comboBoxJudulFilm_SelectedIndexChanged_1);
            // 
            // checkBoxI
            // 
            this.checkBoxI.AutoSize = true;
            this.checkBoxI.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxI.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxI.ForeColor = System.Drawing.Color.NavajoWhite;
            this.checkBoxI.Location = new System.Drawing.Point(25, 40);
            this.checkBoxI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxI.Name = "checkBoxI";
            this.checkBoxI.Size = new System.Drawing.Size(40, 31);
            this.checkBoxI.TabIndex = 27;
            this.checkBoxI.Text = "I";
            this.checkBoxI.UseVisualStyleBackColor = false;
            // 
            // checkBoxII
            // 
            this.checkBoxII.AutoSize = true;
            this.checkBoxII.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxII.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxII.ForeColor = System.Drawing.Color.NavajoWhite;
            this.checkBoxII.Location = new System.Drawing.Point(83, 40);
            this.checkBoxII.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxII.Name = "checkBoxII";
            this.checkBoxII.Size = new System.Drawing.Size(46, 31);
            this.checkBoxII.TabIndex = 28;
            this.checkBoxII.Text = "II";
            this.checkBoxII.UseVisualStyleBackColor = false;
            // 
            // checkBoxIII
            // 
            this.checkBoxIII.AutoSize = true;
            this.checkBoxIII.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxIII.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIII.ForeColor = System.Drawing.Color.NavajoWhite;
            this.checkBoxIII.Location = new System.Drawing.Point(147, 40);
            this.checkBoxIII.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIII.Name = "checkBoxIII";
            this.checkBoxIII.Size = new System.Drawing.Size(52, 31);
            this.checkBoxIII.TabIndex = 29;
            this.checkBoxIII.Text = "III";
            this.checkBoxIII.UseVisualStyleBackColor = false;
            // 
            // checkBoxIV
            // 
            this.checkBoxIV.AutoSize = true;
            this.checkBoxIV.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxIV.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIV.ForeColor = System.Drawing.Color.NavajoWhite;
            this.checkBoxIV.Location = new System.Drawing.Point(218, 40);
            this.checkBoxIV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIV.Name = "checkBoxIV";
            this.checkBoxIV.Size = new System.Drawing.Size(55, 31);
            this.checkBoxIV.TabIndex = 30;
            this.checkBoxIV.Text = "IV";
            this.checkBoxIV.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker1.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 764);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(384, 28);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // comboBoxStudio
            // 
            this.comboBoxStudio.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxStudio.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxStudio.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBoxStudio.FormattingEnabled = true;
            this.comboBoxStudio.Location = new System.Drawing.Point(57, 281);
            this.comboBoxStudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudio.Name = "comboBoxStudio";
            this.comboBoxStudio.Size = new System.Drawing.Size(299, 33);
            this.comboBoxStudio.TabIndex = 33;
            this.comboBoxStudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudio_SelectedIndexChanged);
            // 
            // buttonPilihJudul
            // 
            this.buttonPilihJudul.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonPilihJudul.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPilihJudul.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonPilihJudul.Location = new System.Drawing.Point(419, 663);
            this.buttonPilihJudul.Name = "buttonPilihJudul";
            this.buttonPilihJudul.Size = new System.Drawing.Size(103, 40);
            this.buttonPilihJudul.TabIndex = 34;
            this.buttonPilihJudul.Text = "PILIH";
            this.buttonPilihJudul.UseVisualStyleBackColor = false;
            this.buttonPilihJudul.Click += new System.EventHandler(this.buttonPilihJudul_Click);
            // 
            // buttonPilihCinema
            // 
            this.buttonPilihCinema.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonPilihCinema.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPilihCinema.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonPilihCinema.Location = new System.Drawing.Point(362, 85);
            this.buttonPilihCinema.Name = "buttonPilihCinema";
            this.buttonPilihCinema.Size = new System.Drawing.Size(84, 39);
            this.buttonPilihCinema.TabIndex = 35;
            this.buttonPilihCinema.Text = "PILIH";
            this.buttonPilihCinema.UseVisualStyleBackColor = false;
            this.buttonPilihCinema.Click += new System.EventHandler(this.buttonPilihCinema_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.DarkRed;
            this.buttonTambah.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTambah.ForeColor = System.Drawing.Color.NavajoWhite;
            this.buttonTambah.Location = new System.Drawing.Point(489, 863);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(145, 58);
            this.buttonTambah.TabIndex = 36;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPilihStudio
            // 
            this.buttonPilihStudio.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonPilihStudio.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPilihStudio.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonPilihStudio.Location = new System.Drawing.Point(362, 178);
            this.buttonPilihStudio.Name = "buttonPilihStudio";
            this.buttonPilihStudio.Size = new System.Drawing.Size(84, 39);
            this.buttonPilihStudio.TabIndex = 37;
            this.buttonPilihStudio.Text = "PILIH";
            this.buttonPilihStudio.UseVisualStyleBackColor = false;
            this.buttonPilihStudio.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(52, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cinema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(54, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "Studio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(52, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nama Bioskop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(22, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Weekday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label5.Location = new System.Drawing.Point(22, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Weekend";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label6.Location = new System.Drawing.Point(52, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 27);
            this.label6.TabIndex = 43;
            this.label6.Text = "Kapasitas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label7.Location = new System.Drawing.Point(52, 632);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 27);
            this.label7.TabIndex = 44;
            this.label7.Text = "Judul";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label8.Location = new System.Drawing.Point(52, 725);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 27);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tanggal";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSimpan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.NavajoWhite;
            this.buttonSimpan.Location = new System.Drawing.Point(1756, 673);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(145, 63);
            this.buttonSimpan.TabIndex = 48;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click_1);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.DarkRed;
            this.buttonKeluar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.buttonKeluar.ForeColor = System.Drawing.Color.NavajoWhite;
            this.buttonKeluar.Location = new System.Drawing.Point(1756, 838);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(145, 58);
            this.buttonKeluar.TabIndex = 49;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label12.Location = new System.Drawing.Point(21, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 32);
            this.label12.TabIndex = 51;
            this.label12.Text = "Durasi :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label13.Location = new System.Drawing.Point(337, 436);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 32);
            this.label13.TabIndex = 52;
            this.label13.Text = "Genre :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label14.Location = new System.Drawing.Point(21, 485);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 32);
            this.label14.TabIndex = 53;
            this.label14.Text = "Aktor Utama :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelHargaWeekday);
            this.groupBox1.Controls.Add(this.labelHargaWeekend);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Location = new System.Drawing.Point(57, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 127);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harga";
            // 
            // labelKapasitas
            // 
            this.labelKapasitas.AutoSize = true;
            this.labelKapasitas.BackColor = System.Drawing.Color.Transparent;
            this.labelKapasitas.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            this.labelKapasitas.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelKapasitas.Location = new System.Drawing.Point(194, 350);
            this.labelKapasitas.Name = "labelKapasitas";
            this.labelKapasitas.Size = new System.Drawing.Size(114, 24);
            this.labelKapasitas.TabIndex = 47;
            this.labelKapasitas.Text = "         Kursi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelAktor);
            this.groupBox2.Controls.Add(this.labelGenre);
            this.groupBox2.Controls.Add(this.labelDurasi);
            this.groupBox2.Controls.Add(this.labelKelompok);
            this.groupBox2.Controls.Add(this.richTextBoxSinopsis);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.labelJudulFilm);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Location = new System.Drawing.Point(1261, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 553);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sinopsis";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelAktor
            // 
            this.labelAktor.AutoSize = true;
            this.labelAktor.BackColor = System.Drawing.Color.Transparent;
            this.labelAktor.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.labelAktor.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelAktor.Location = new System.Drawing.Point(214, 487);
            this.labelAktor.Name = "labelAktor";
            this.labelAktor.Size = new System.Drawing.Size(0, 27);
            this.labelAktor.TabIndex = 57;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.BackColor = System.Drawing.Color.Transparent;
            this.labelGenre.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelGenre.Location = new System.Drawing.Point(445, 440);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(0, 27);
            this.labelGenre.TabIndex = 56;
            // 
            // labelDurasi
            // 
            this.labelDurasi.AutoSize = true;
            this.labelDurasi.BackColor = System.Drawing.Color.Transparent;
            this.labelDurasi.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.labelDurasi.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelDurasi.Location = new System.Drawing.Point(129, 439);
            this.labelDurasi.Name = "labelDurasi";
            this.labelDurasi.Size = new System.Drawing.Size(0, 27);
            this.labelDurasi.TabIndex = 55;
            // 
            // labelKelompok
            // 
            this.labelKelompok.AutoSize = true;
            this.labelKelompok.BackColor = System.Drawing.Color.Transparent;
            this.labelKelompok.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelompok.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelKelompok.Location = new System.Drawing.Point(626, 38);
            this.labelKelompok.Name = "labelKelompok";
            this.labelKelompok.Size = new System.Drawing.Size(0, 32);
            this.labelKelompok.TabIndex = 54;
            // 
            // labelJudulFilm
            // 
            this.labelJudulFilm.AutoSize = true;
            this.labelJudulFilm.BackColor = System.Drawing.Color.Transparent;
            this.labelJudulFilm.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudulFilm.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelJudulFilm.Location = new System.Drawing.Point(17, 38);
            this.labelJudulFilm.Name = "labelJudulFilm";
            this.labelJudulFilm.Size = new System.Drawing.Size(0, 27);
            this.labelJudulFilm.TabIndex = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxII);
            this.groupBox3.Controls.Add(this.checkBoxI);
            this.groupBox3.Controls.Add(this.checkBoxIII);
            this.groupBox3.Controls.Add(this.checkBoxIV);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.groupBox3.Location = new System.Drawing.Point(50, 828);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 93);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jam";
            // 
            // buttonBioskop
            // 
            this.buttonBioskop.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonBioskop.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBioskop.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonBioskop.Location = new System.Drawing.Point(362, 279);
            this.buttonBioskop.Name = "buttonBioskop";
            this.buttonBioskop.Size = new System.Drawing.Size(84, 39);
            this.buttonBioskop.TabIndex = 57;
            this.buttonBioskop.Text = "PILIH";
            this.buttonBioskop.UseVisualStyleBackColor = false;
            this.buttonBioskop.Click += new System.EventHandler(this.buttonBioskop_Click);
            // 
            // FormPenjadwalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 844);
            this.Controls.Add(this.buttonBioskop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelKapasitas);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPilihStudio);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonPilihCinema);
            this.Controls.Add(this.buttonPilihJudul);
            this.Controls.Add(this.comboBoxStudio);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxJudulFilm);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.comboBoxJenisStudio);
            this.Controls.Add(this.comboBoxCinema);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPenjadwalan";
            this.Text = "Penjadwalan";
            this.Load += new System.EventHandler(this.FormPenjadwalan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.RichTextBox richTextBoxSinopsis;
        private System.Windows.Forms.ComboBox comboBoxJudulFilm;
        private System.Windows.Forms.CheckBox checkBoxI;
        private System.Windows.Forms.CheckBox checkBoxII;
        private System.Windows.Forms.CheckBox checkBoxIII;
        private System.Windows.Forms.CheckBox checkBoxIV;
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
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelKapasitas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelDurasi;
        private System.Windows.Forms.Label labelKelompok;
        private System.Windows.Forms.Label labelJudulFilm;
        private System.Windows.Forms.Label labelAktor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonBioskop;
    }
}