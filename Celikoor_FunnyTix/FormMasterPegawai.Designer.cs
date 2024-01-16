
namespace Celikoor_FunnyTix
{
    partial class FormMasterPegawai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roles_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus_column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTambahPegawai = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTambahPegawai.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.buttonKeluar.TabIndex = 10;
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
            this.buttonTambah.TabIndex = 9;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.nama_column,
            this.email_column,
            this.username_column,
            this.password_column,
            this.roles_column,
            this.hapus_column});
            this.dataGridViewHasil.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewHasil.Location = new System.Drawing.Point(12, 190);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(1488, 743);
            this.dataGridViewHasil.TabIndex = 8;
            this.dataGridViewHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellContentClick);
            // 
            // id_column
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            this.id_column.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_column.HeaderText = "ID";
            this.id_column.MinimumWidth = 6;
            this.id_column.Name = "id_column";
            this.id_column.Width = 125;
            // 
            // nama_column
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            this.nama_column.DefaultCellStyle = dataGridViewCellStyle2;
            this.nama_column.HeaderText = "Nama";
            this.nama_column.MinimumWidth = 6;
            this.nama_column.Name = "nama_column";
            this.nama_column.Width = 125;
            // 
            // email_column
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            this.email_column.DefaultCellStyle = dataGridViewCellStyle3;
            this.email_column.HeaderText = "Email";
            this.email_column.MinimumWidth = 6;
            this.email_column.Name = "email_column";
            this.email_column.Width = 125;
            // 
            // username_column
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            this.username_column.DefaultCellStyle = dataGridViewCellStyle4;
            this.username_column.HeaderText = "Username";
            this.username_column.MinimumWidth = 6;
            this.username_column.Name = "username_column";
            this.username_column.Width = 125;
            // 
            // password_column
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            this.password_column.DefaultCellStyle = dataGridViewCellStyle5;
            this.password_column.HeaderText = "Password";
            this.password_column.MinimumWidth = 6;
            this.password_column.Name = "password_column";
            this.password_column.Width = 125;
            // 
            // roles_column
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            this.roles_column.DefaultCellStyle = dataGridViewCellStyle6;
            this.roles_column.HeaderText = "Roles";
            this.roles_column.MinimumWidth = 6;
            this.roles_column.Name = "roles_column";
            this.roles_column.Width = 125;
            // 
            // hapus_column
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Maroon;
            this.hapus_column.DefaultCellStyle = dataGridViewCellStyle7;
            this.hapus_column.HeaderText = "Aksi";
            this.hapus_column.MinimumWidth = 6;
            this.hapus_column.Name = "hapus_column";
            this.hapus_column.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.buttonCari);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 86);
            this.panel1.TabIndex = 7;
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.Maroon;
            this.buttonCari.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.ForeColor = System.Drawing.Color.White;
            this.buttonCari.Location = new System.Drawing.Point(1296, 22);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(170, 51);
            this.buttonCari.TabIndex = 3;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Maroon;
            this.textBox.Location = new System.Drawing.Point(611, 29);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(667, 36);
            this.textBox.TabIndex = 2;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Nama",
            "Email",
            "Username",
            "Roles"});
            this.comboBox.Location = new System.Drawing.Point(321, 29);
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
            this.label2.Location = new System.Drawing.Point(27, 25);
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
            this.label1.TabIndex = 6;
            this.label1.Text = "MASTER PEGAWAI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTambahPegawai
            // 
            this.panelTambahPegawai.Controls.Add(this.groupBox1);
            this.panelTambahPegawai.Controls.Add(this.buttonBatal);
            this.panelTambahPegawai.Controls.Add(this.buttonSimpan);
            this.panelTambahPegawai.Controls.Add(this.label5);
            this.panelTambahPegawai.Location = new System.Drawing.Point(484, 286);
            this.panelTambahPegawai.Name = "panelTambahPegawai";
            this.panelTambahPegawai.Size = new System.Drawing.Size(549, 472);
            this.panelTambahPegawai.TabIndex = 17;
            this.panelTambahPegawai.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Controls.Add(this.comboBoxRoles);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxNama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(34, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(480, 268);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelUsername.Location = new System.Drawing.Point(171, 131);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(98, 23);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Items.AddRange(new object[] {
            "ADMIN",
            "KASIR",
            "OPERATOR"});
            this.comboBoxRoles.Location = new System.Drawing.Point(170, 216);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(121, 31);
            this.comboBoxRoles.TabIndex = 15;
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(85, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Roles : ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(170, 82);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(263, 28);
            this.textBoxEmail.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(170, 171);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(263, 28);
            this.textBoxPassword.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label8.Location = new System.Drawing.Point(46, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Password : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label7.Location = new System.Drawing.Point(40, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Username : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label6.Location = new System.Drawing.Point(82, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email : ";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(170, 39);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(263, 28);
            this.textBoxNama.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(78, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama : ";
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonBatal.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBatal.Location = new System.Drawing.Point(34, 396);
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
            this.buttonSimpan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSimpan.Location = new System.Drawing.Point(354, 396);
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
            this.label5.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(35, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(479, 47);
            this.label5.TabIndex = 19;
            this.label5.Text = "T A M B A H  P E G A W A I";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMasterPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1516, 1023);
            this.Controls.Add(this.panelTambahPegawai);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterPegawai";
            this.Text = "FormMasterPegawai";
            this.Load += new System.EventHandler(this.FormMasterPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTambahPegawai.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTambahPegawai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn username_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn roles_column;
        private System.Windows.Forms.DataGridViewButtonColumn hapus_column;
    }
}