namespace Celikoor_FunnyTix
{
    partial class FormDataTransaksi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grand_total_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskon_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konsumen_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasir_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonKeluar.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.buttonKeluar.ForeColor = System.Drawing.Color.Maroon;
            this.buttonKeluar.Location = new System.Drawing.Point(11, 962);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(171, 50);
            this.buttonKeluar.TabIndex = 25;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonTambah.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.buttonTambah.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTambah.Location = new System.Drawing.Point(1329, 962);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(171, 50);
            this.buttonTambah.TabIndex = 24;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.tgl_column,
            this.grand_total_column,
            this.diskon_column,
            this.konsumen_column,
            this.kasir_column,
            this.status_column});
            this.dataGridViewHasil.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewHasil.Location = new System.Drawing.Point(11, 199);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(1488, 743);
            this.dataGridViewHasil.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.buttonCari);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 86);
            this.panel1.TabIndex = 22;
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.Maroon;
            this.buttonCari.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.buttonCari.ForeColor = System.Drawing.Color.White;
            this.buttonCari.Location = new System.Drawing.Point(1296, 22);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(171, 50);
            this.buttonCari.TabIndex = 3;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(611, 30);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(667, 36);
            this.textBox.TabIndex = 2;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "id",
            "tanggal",
            "status",
            "konsumen"});
            this.comboBox.Location = new System.Drawing.Point(321, 26);
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
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1488, 65);
            this.label1.TabIndex = 21;
            this.label1.Text = "DATA TRANSAKSI";
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
            // tgl_column
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            this.tgl_column.DefaultCellStyle = dataGridViewCellStyle2;
            this.tgl_column.HeaderText = "Tanggal";
            this.tgl_column.MinimumWidth = 6;
            this.tgl_column.Name = "tgl_column";
            this.tgl_column.Width = 125;
            // 
            // grand_total_column
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed;
            this.grand_total_column.DefaultCellStyle = dataGridViewCellStyle3;
            this.grand_total_column.HeaderText = "Grand Total";
            this.grand_total_column.MinimumWidth = 6;
            this.grand_total_column.Name = "grand_total_column";
            this.grand_total_column.Width = 125;
            // 
            // diskon_column
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed;
            this.diskon_column.DefaultCellStyle = dataGridViewCellStyle4;
            this.diskon_column.HeaderText = "Diskon";
            this.diskon_column.MinimumWidth = 6;
            this.diskon_column.Name = "diskon_column";
            this.diskon_column.Width = 125;
            // 
            // konsumen_column
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkRed;
            this.konsumen_column.DefaultCellStyle = dataGridViewCellStyle5;
            this.konsumen_column.HeaderText = "Konsumen";
            this.konsumen_column.MinimumWidth = 6;
            this.konsumen_column.Name = "konsumen_column";
            this.konsumen_column.Width = 125;
            // 
            // kasir_column
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkRed;
            this.kasir_column.DefaultCellStyle = dataGridViewCellStyle6;
            this.kasir_column.HeaderText = "Kasir";
            this.kasir_column.MinimumWidth = 6;
            this.kasir_column.Name = "kasir_column";
            this.kasir_column.Width = 125;
            // 
            // status_column
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkRed;
            this.status_column.DefaultCellStyle = dataGridViewCellStyle7;
            this.status_column.HeaderText = "Status";
            this.status_column.MinimumWidth = 6;
            this.status_column.Name = "status_column";
            this.status_column.Width = 125;
            // 
            // FormDataTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1511, 1033);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDataTransaksi";
            this.Text = "FormDataTransaksi";
            this.Load += new System.EventHandler(this.FormDataTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn grand_total_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskon_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn konsumen_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasir_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_column;
    }
}