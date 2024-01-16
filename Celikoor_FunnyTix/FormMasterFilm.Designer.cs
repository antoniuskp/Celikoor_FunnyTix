namespace Celikoor_FunnyTix
{
    partial class FormMasterFilm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judul_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopsis_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahun_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelompok_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bahasa_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_indo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cover_image_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskon_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus_column = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonKeluar.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Maroon;
            this.buttonKeluar.Location = new System.Drawing.Point(16, 961);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(170, 51);
            this.buttonKeluar.TabIndex = 23;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
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
            this.textBox.Location = new System.Drawing.Point(611, 29);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(667, 36);
            this.textBox.TabIndex = 2;
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCari.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Items.AddRange(new object[] {
            "Judul",
            "Sinopsis",
            "Tahun",
            "Durasi",
            "Kelompok",
            "Bahasa",
            "Sub Indonesia",
            "Diskon"});
            this.comboBoxCari.Location = new System.Drawing.Point(321, 24);
            this.comboBoxCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(269, 40);
            this.comboBoxCari.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Berdasarkan : ";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonTambah.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTambah.Location = new System.Drawing.Point(1334, 961);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(170, 51);
            this.buttonTambah.TabIndex = 22;
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
            this.judul_column,
            this.sinopsis_column,
            this.tahun_column,
            this.durasi_column,
            this.kelompok_column,
            this.bahasa_column,
            this.sub_indo_column,
            this.cover_image_column,
            this.diskon_column,
            this.hapus_column});
            this.dataGridViewHasil.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewHasil.Location = new System.Drawing.Point(16, 197);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(1488, 743);
            this.dataGridViewHasil.TabIndex = 21;
            this.dataGridViewHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.buttonCari);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.comboBoxCari);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 86);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1488, 65);
            this.label1.TabIndex = 19;
            this.label1.Text = "MASTER FILM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_column
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            this.id_column.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_column.HeaderText = "ID";
            this.id_column.MinimumWidth = 6;
            this.id_column.Name = "id_column";
            this.id_column.Width = 125;
            // 
            // judul_column
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            this.judul_column.DefaultCellStyle = dataGridViewCellStyle2;
            this.judul_column.HeaderText = "Judul";
            this.judul_column.MinimumWidth = 6;
            this.judul_column.Name = "judul_column";
            this.judul_column.Width = 125;
            // 
            // sinopsis_column
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed;
            this.sinopsis_column.DefaultCellStyle = dataGridViewCellStyle3;
            this.sinopsis_column.HeaderText = "Sinopsis";
            this.sinopsis_column.MinimumWidth = 6;
            this.sinopsis_column.Name = "sinopsis_column";
            this.sinopsis_column.Width = 125;
            // 
            // tahun_column
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed;
            this.tahun_column.DefaultCellStyle = dataGridViewCellStyle4;
            this.tahun_column.HeaderText = "Tahun";
            this.tahun_column.MinimumWidth = 6;
            this.tahun_column.Name = "tahun_column";
            this.tahun_column.Width = 125;
            // 
            // durasi_column
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkRed;
            this.durasi_column.DefaultCellStyle = dataGridViewCellStyle5;
            this.durasi_column.HeaderText = "Durasi";
            this.durasi_column.MinimumWidth = 6;
            this.durasi_column.Name = "durasi_column";
            this.durasi_column.Width = 125;
            // 
            // kelompok_column
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkRed;
            this.kelompok_column.DefaultCellStyle = dataGridViewCellStyle6;
            this.kelompok_column.HeaderText = "Kelompok";
            this.kelompok_column.MinimumWidth = 6;
            this.kelompok_column.Name = "kelompok_column";
            this.kelompok_column.Width = 125;
            // 
            // bahasa_column
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkRed;
            this.bahasa_column.DefaultCellStyle = dataGridViewCellStyle7;
            this.bahasa_column.HeaderText = "Bahasa";
            this.bahasa_column.MinimumWidth = 6;
            this.bahasa_column.Name = "bahasa_column";
            this.bahasa_column.Width = 125;
            // 
            // sub_indo_column
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkRed;
            this.sub_indo_column.DefaultCellStyle = dataGridViewCellStyle8;
            this.sub_indo_column.HeaderText = "Sub Indonesia";
            this.sub_indo_column.MinimumWidth = 6;
            this.sub_indo_column.Name = "sub_indo_column";
            this.sub_indo_column.Width = 125;
            // 
            // cover_image_column
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkRed;
            this.cover_image_column.DefaultCellStyle = dataGridViewCellStyle9;
            this.cover_image_column.HeaderText = "Cover Image";
            this.cover_image_column.MinimumWidth = 6;
            this.cover_image_column.Name = "cover_image_column";
            this.cover_image_column.Width = 125;
            // 
            // diskon_column
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkRed;
            this.diskon_column.DefaultCellStyle = dataGridViewCellStyle10;
            this.diskon_column.HeaderText = "Diskon";
            this.diskon_column.MinimumWidth = 6;
            this.diskon_column.Name = "diskon_column";
            this.diskon_column.Width = 125;
            // 
            // hapus_column
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkRed;
            this.hapus_column.DefaultCellStyle = dataGridViewCellStyle11;
            this.hapus_column.HeaderText = "Aksi";
            this.hapus_column.MinimumWidth = 6;
            this.hapus_column.Name = "hapus_column";
            this.hapus_column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hapus_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hapus_column.Width = 125;
            // 
            // FormMasterFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1520, 1029);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterFilm";
            this.Text = "FormMasterFilm";
            this.Load += new System.EventHandler(this.FormMasterFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn judul_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopsis_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelompok_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn bahasa_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_indo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn cover_image_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskon_column;
        private System.Windows.Forms.DataGridViewButtonColumn hapus_column;
    }
}