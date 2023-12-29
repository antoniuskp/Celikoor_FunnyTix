
namespace Celikoor_FunnyTix
{
    partial class FormTambahFilm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxSinopsis = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerRilis = new System.Windows.Forms.DateTimePicker();
            this.textBoxDurasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxBahasa = new System.Windows.Forms.ComboBox();
            this.radioButtonYa = new System.Windows.Forms.RadioButton();
            this.radioButtonTidak = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxIndo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxKelompokUmur = new System.Windows.Forms.ComboBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonTambahDetailFilm = new System.Windows.Forms.Button();
            this.groupBoxIndo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(93, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Judul Film :";
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxJudul.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJudul.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxJudul.Location = new System.Drawing.Point(97, 214);
            this.textBoxJudul.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(576, 27);
            this.textBoxJudul.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(782, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sinopsis :";
            // 
            // richTextBoxSinopsis
            // 
            this.richTextBoxSinopsis.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBoxSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSinopsis.ForeColor = System.Drawing.Color.Maroon;
            this.richTextBoxSinopsis.Location = new System.Drawing.Point(786, 214);
            this.richTextBoxSinopsis.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxSinopsis.Name = "richTextBoxSinopsis";
            this.richTextBoxSinopsis.Size = new System.Drawing.Size(461, 129);
            this.richTextBoxSinopsis.TabIndex = 3;
            this.richTextBoxSinopsis.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(93, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tahun :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(93, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Durasi :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePickerRilis
            // 
            this.dateTimePickerRilis.CalendarFont = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRilis.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRilis.Location = new System.Drawing.Point(97, 308);
            this.dateTimePickerRilis.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerRilis.Name = "dateTimePickerRilis";
            this.dateTimePickerRilis.Size = new System.Drawing.Size(339, 24);
            this.dateTimePickerRilis.TabIndex = 6;
            this.dateTimePickerRilis.ValueChanged += new System.EventHandler(this.dateTimePickerRilis_ValueChanged);
            // 
            // textBoxDurasi
            // 
            this.textBoxDurasi.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxDurasi.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDurasi.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxDurasi.Location = new System.Drawing.Point(97, 411);
            this.textBoxDurasi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDurasi.Name = "textBoxDurasi";
            this.textBoxDurasi.Size = new System.Drawing.Size(156, 24);
            this.textBoxDurasi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label5.Location = new System.Drawing.Point(267, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Menit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label7.Location = new System.Drawing.Point(93, 480);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bahasa :";
            // 
            // comboBoxBahasa
            // 
            this.comboBoxBahasa.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxBahasa.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBahasa.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxBahasa.FormattingEnabled = true;
            this.comboBoxBahasa.Location = new System.Drawing.Point(97, 517);
            this.comboBoxBahasa.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBahasa.Name = "comboBoxBahasa";
            this.comboBoxBahasa.Size = new System.Drawing.Size(156, 27);
            this.comboBoxBahasa.TabIndex = 12;
            // 
            // radioButtonYa
            // 
            this.radioButtonYa.AutoSize = true;
            this.radioButtonYa.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonYa.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYa.ForeColor = System.Drawing.Color.NavajoWhite;
            this.radioButtonYa.Location = new System.Drawing.Point(27, 28);
            this.radioButtonYa.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonYa.Name = "radioButtonYa";
            this.radioButtonYa.Size = new System.Drawing.Size(44, 23);
            this.radioButtonYa.TabIndex = 14;
            this.radioButtonYa.TabStop = true;
            this.radioButtonYa.Text = "Ya";
            this.radioButtonYa.UseVisualStyleBackColor = false;
            // 
            // radioButtonTidak
            // 
            this.radioButtonTidak.AutoSize = true;
            this.radioButtonTidak.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTidak.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTidak.ForeColor = System.Drawing.Color.NavajoWhite;
            this.radioButtonTidak.Location = new System.Drawing.Point(106, 28);
            this.radioButtonTidak.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTidak.Name = "radioButtonTidak";
            this.radioButtonTidak.Size = new System.Drawing.Size(68, 23);
            this.radioButtonTidak.TabIndex = 15;
            this.radioButtonTidak.TabStop = true;
            this.radioButtonTidak.Text = "Tidak";
            this.radioButtonTidak.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label16.Location = new System.Drawing.Point(239, 623);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 22);
            this.label16.TabIndex = 21;
            this.label16.Text = "%";
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxDiskon.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiskon.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxDiskon.Location = new System.Drawing.Point(97, 623);
            this.textBoxDiskon.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(123, 24);
            this.textBoxDiskon.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label15.Location = new System.Drawing.Point(93, 590);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 22);
            this.label15.TabIndex = 19;
            this.label15.Text = "Diskon :";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxUrl.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUrl.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxUrl.Location = new System.Drawing.Point(785, 517);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(320, 24);
            this.textBoxUrl.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label14.Location = new System.Drawing.Point(782, 480);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 22);
            this.label14.TabIndex = 17;
            this.label14.Text = "Image URL :";
            // 
            // groupBoxIndo
            // 
            this.groupBoxIndo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxIndo.Controls.Add(this.radioButtonYa);
            this.groupBoxIndo.Controls.Add(this.radioButtonTidak);
            this.groupBoxIndo.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIndo.ForeColor = System.Drawing.Color.NavajoWhite;
            this.groupBoxIndo.Location = new System.Drawing.Point(785, 590);
            this.groupBoxIndo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxIndo.Name = "groupBoxIndo";
            this.groupBoxIndo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxIndo.Size = new System.Drawing.Size(204, 68);
            this.groupBoxIndo.TabIndex = 16;
            this.groupBoxIndo.TabStop = false;
            this.groupBoxIndo.Text = "Bahasa Indonesia";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label13.Location = new System.Drawing.Point(577, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(442, 53);
            this.label13.TabIndex = 21;
            this.label13.Text = "T A M B A H  F I L M";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label6.Location = new System.Drawing.Point(782, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kelompok Umur :";
            // 
            // comboBoxKelompokUmur
            // 
            this.comboBoxKelompokUmur.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxKelompokUmur.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKelompokUmur.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxKelompokUmur.FormattingEnabled = true;
            this.comboBoxKelompokUmur.Location = new System.Drawing.Point(785, 408);
            this.comboBoxKelompokUmur.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKelompokUmur.Name = "comboBoxKelompokUmur";
            this.comboBoxKelompokUmur.Size = new System.Drawing.Size(156, 27);
            this.comboBoxKelompokUmur.TabIndex = 23;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonTambah.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTambah.Location = new System.Drawing.Point(844, 684);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(196, 41);
            this.buttonTambah.TabIndex = 24;
            this.buttonTambah.Text = "Tambah Film";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click_1);
            // 
            // buttonTambahDetailFilm
            // 
            this.buttonTambahDetailFilm.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonTambahDetailFilm.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahDetailFilm.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTambahDetailFilm.Location = new System.Drawing.Point(1086, 684);
            this.buttonTambahDetailFilm.Name = "buttonTambahDetailFilm";
            this.buttonTambahDetailFilm.Size = new System.Drawing.Size(196, 41);
            this.buttonTambahDetailFilm.TabIndex = 25;
            this.buttonTambahDetailFilm.Text = "Tambah Detail Film";
            this.buttonTambahDetailFilm.UseVisualStyleBackColor = false;
            this.buttonTambahDetailFilm.Click += new System.EventHandler(this.buttonTambahDetailFilm_Click);
            // 
            // FormTambahFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1294, 737);
            this.Controls.Add(this.buttonTambahDetailFilm);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.comboBoxKelompokUmur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBahasa);
            this.Controls.Add(this.dateTimePickerRilis);
            this.Controls.Add(this.textBoxDurasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDiskon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.richTextBoxSinopsis);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxIndo);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTambahFilm";
            this.Text = "FormTambahFilm";
            this.Load += new System.EventHandler(this.FormTambahFilm_Load);
            this.groupBoxIndo.ResumeLayout(false);
            this.groupBoxIndo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxSinopsis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerRilis;
        private System.Windows.Forms.TextBox textBoxDurasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxBahasa;
        private System.Windows.Forms.RadioButton radioButtonYa;
        private System.Windows.Forms.RadioButton radioButtonTidak;
        private System.Windows.Forms.GroupBox groupBoxIndo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxKelompokUmur;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonTambahDetailFilm;
    }
}