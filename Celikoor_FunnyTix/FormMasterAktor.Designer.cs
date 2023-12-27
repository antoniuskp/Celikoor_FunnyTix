
namespace Celikoor_FunnyTix
{
    partial class FormMasterAktor
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
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTambahAktor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTglLahir = new System.Windows.Forms.DateTimePicker();
            this.textBoxNegara = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelUbah = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxGenderUbah = new System.Windows.Forms.ComboBox();
            this.dateTimePickerUbah = new System.Windows.Forms.DateTimePicker();
            this.textBoxNegaraAsalUbah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNamaUbah = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonBatalUbah = new System.Windows.Forms.Button();
            this.buttonSimpanUbah = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTambahAktor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelUbah.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonKeluar.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Maroon;
            this.buttonKeluar.Location = new System.Drawing.Point(12, 954);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(170, 51);
            this.buttonKeluar.TabIndex = 15;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonTambah.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTambah.Location = new System.Drawing.Point(1330, 954);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(170, 51);
            this.buttonTambah.TabIndex = 14;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewHasil.Location = new System.Drawing.Point(12, 190);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(1488, 743);
            this.dataGridViewHasil.TabIndex = 13;
            this.dataGridViewHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 86);
            this.panel1.TabIndex = 12;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Maroon;
            this.buttonClear.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(1296, 22);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(170, 51);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(611, 29);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(667, 36);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Nama",
            "Tanggal Lahir",
            "Gender",
            "Negara"});
            this.comboBox.Location = new System.Drawing.Point(321, 25);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(269, 40);
            this.comboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Berdasarkan : ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1488, 65);
            this.label1.TabIndex = 11;
            this.label1.Text = "MASTER AKTOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTambahAktor
            // 
            this.panelTambahAktor.Controls.Add(this.groupBox1);
            this.panelTambahAktor.Controls.Add(this.buttonBatal);
            this.panelTambahAktor.Controls.Add(this.buttonSimpan);
            this.panelTambahAktor.Controls.Add(this.label5);
            this.panelTambahAktor.Location = new System.Drawing.Point(471, 205);
            this.panelTambahAktor.Name = "panelTambahAktor";
            this.panelTambahAktor.Size = new System.Drawing.Size(549, 451);
            this.panelTambahAktor.TabIndex = 16;
            this.panelTambahAktor.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxGender);
            this.groupBox1.Controls.Add(this.dateTimePickerTglLahir);
            this.groupBox1.Controls.Add(this.textBoxNegara);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxNama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(34, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(480, 240);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "L",
            "P"});
            this.comboBoxGender.Location = new System.Drawing.Point(170, 130);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(263, 24);
            this.comboBoxGender.TabIndex = 11;
            // 
            // dateTimePickerTglLahir
            // 
            this.dateTimePickerTglLahir.Location = new System.Drawing.Point(170, 90);
            this.dateTimePickerTglLahir.Name = "dateTimePickerTglLahir";
            this.dateTimePickerTglLahir.Size = new System.Drawing.Size(263, 22);
            this.dateTimePickerTglLahir.TabIndex = 10;
            // 
            // textBoxNegara
            // 
            this.textBoxNegara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNegara.Location = new System.Drawing.Point(170, 174);
            this.textBoxNegara.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNegara.Name = "textBoxNegara";
            this.textBoxNegara.Size = new System.Drawing.Size(263, 30);
            this.textBoxNegara.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label8.Location = new System.Drawing.Point(26, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Negara Asal : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label7.Location = new System.Drawing.Point(69, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Gender : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label6.Location = new System.Drawing.Point(14, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tanggal Lahir : ";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(170, 42);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(263, 30);
            this.textBoxNama.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(82, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama : ";
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBatal.Location = new System.Drawing.Point(34, 368);
            this.buttonBatal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(160, 43);
            this.buttonBatal.TabIndex = 21;
            this.buttonBatal.Text = "BATAL";
            this.buttonBatal.UseVisualStyleBackColor = false;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSimpan.Location = new System.Drawing.Point(354, 368);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(160, 43);
            this.buttonSimpan.TabIndex = 20;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.NavajoWhite;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(35, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(479, 47);
            this.label5.TabIndex = 19;
            this.label5.Text = "T A M B A H  A K T O R";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUbah
            // 
            this.panelUbah.Controls.Add(this.groupBox2);
            this.panelUbah.Controls.Add(this.buttonBatalUbah);
            this.panelUbah.Controls.Add(this.buttonSimpanUbah);
            this.panelUbah.Controls.Add(this.label12);
            this.panelUbah.Location = new System.Drawing.Point(471, 206);
            this.panelUbah.Name = "panelUbah";
            this.panelUbah.Size = new System.Drawing.Size(549, 451);
            this.panelUbah.TabIndex = 22;
            this.panelUbah.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelID);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBoxGenderUbah);
            this.groupBox2.Controls.Add(this.dateTimePickerUbah);
            this.groupBox2.Controls.Add(this.textBoxNegaraAsalUbah);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxNamaUbah);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(34, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(480, 252);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelID.Location = new System.Drawing.Point(169, 30);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(86, 25);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID Aktor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label13.Location = new System.Drawing.Point(118, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "ID : ";
            // 
            // comboBoxGenderUbah
            // 
            this.comboBoxGenderUbah.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenderUbah.FormattingEnabled = true;
            this.comboBoxGenderUbah.Items.AddRange(new object[] {
            "L",
            "P"});
            this.comboBoxGenderUbah.Location = new System.Drawing.Point(170, 149);
            this.comboBoxGenderUbah.Name = "comboBoxGenderUbah";
            this.comboBoxGenderUbah.Size = new System.Drawing.Size(263, 32);
            this.comboBoxGenderUbah.TabIndex = 11;
            // 
            // dateTimePickerUbah
            // 
            this.dateTimePickerUbah.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerUbah.Location = new System.Drawing.Point(170, 109);
            this.dateTimePickerUbah.Name = "dateTimePickerUbah";
            this.dateTimePickerUbah.Size = new System.Drawing.Size(263, 28);
            this.dateTimePickerUbah.TabIndex = 10;
            // 
            // textBoxNegaraAsalUbah
            // 
            this.textBoxNegaraAsalUbah.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNegaraAsalUbah.Location = new System.Drawing.Point(170, 193);
            this.textBoxNegaraAsalUbah.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNegaraAsalUbah.Name = "textBoxNegaraAsalUbah";
            this.textBoxNegaraAsalUbah.Size = new System.Drawing.Size(263, 28);
            this.textBoxNegaraAsalUbah.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(26, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Negara Asal : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label9.Location = new System.Drawing.Point(69, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Gender : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label10.Location = new System.Drawing.Point(14, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tanggal Lahir : ";
            // 
            // textBoxNamaUbah
            // 
            this.textBoxNamaUbah.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaUbah.Location = new System.Drawing.Point(170, 61);
            this.textBoxNamaUbah.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNamaUbah.Name = "textBoxNamaUbah";
            this.textBoxNamaUbah.Size = new System.Drawing.Size(263, 28);
            this.textBoxNamaUbah.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label11.Location = new System.Drawing.Point(82, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nama : ";
            // 
            // buttonBatalUbah
            // 
            this.buttonBatalUbah.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonBatalUbah.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatalUbah.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBatalUbah.Location = new System.Drawing.Point(34, 368);
            this.buttonBatalUbah.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBatalUbah.Name = "buttonBatalUbah";
            this.buttonBatalUbah.Size = new System.Drawing.Size(160, 43);
            this.buttonBatalUbah.TabIndex = 21;
            this.buttonBatalUbah.Text = "BATAL";
            this.buttonBatalUbah.UseVisualStyleBackColor = false;
            this.buttonBatalUbah.Click += new System.EventHandler(this.buttonBatalUbah_Click);
            // 
            // buttonSimpanUbah
            // 
            this.buttonSimpanUbah.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonSimpanUbah.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpanUbah.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSimpanUbah.Location = new System.Drawing.Point(354, 368);
            this.buttonSimpanUbah.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSimpanUbah.Name = "buttonSimpanUbah";
            this.buttonSimpanUbah.Size = new System.Drawing.Size(160, 43);
            this.buttonSimpanUbah.TabIndex = 20;
            this.buttonSimpanUbah.Text = "SIMPAN";
            this.buttonSimpanUbah.UseVisualStyleBackColor = false;
            this.buttonSimpanUbah.Click += new System.EventHandler(this.buttonSimpanUbah_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.NavajoWhite;
            this.label12.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(35, 45);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(479, 47);
            this.label12.TabIndex = 19;
            this.label12.Text = "U B A H  A K T O R";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMasterAktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1520, 1029);
            this.Controls.Add(this.panelUbah);
            this.Controls.Add(this.panelTambahAktor);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterAktor";
            this.Text = "FormMasterAktor";
            this.Load += new System.EventHandler(this.FormMasterAktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTambahAktor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelUbah.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTambahAktor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNegara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglLahir;
        private System.Windows.Forms.Panel panelUbah;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxGenderUbah;
        private System.Windows.Forms.DateTimePicker dateTimePickerUbah;
        private System.Windows.Forms.TextBox textBoxNegaraAsalUbah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNamaUbah;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonBatalUbah;
        private System.Windows.Forms.Button buttonSimpanUbah;
        private System.Windows.Forms.Label label12;
    }
}