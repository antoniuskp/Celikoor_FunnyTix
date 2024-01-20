
namespace Celikoor_FunnyTix
{
    partial class FormValidasiMenu
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
            this.buttonPrintNota = new System.Windows.Forms.Button();
            this.panelValidasiInvoice = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grand_total_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konsumen_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasir_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validasi_column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelValidasiInvoice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrintNota
            // 
            this.buttonPrintNota.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonPrintNota.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.buttonPrintNota.ForeColor = System.Drawing.Color.Maroon;
            this.buttonPrintNota.Location = new System.Drawing.Point(1332, 957);
            this.buttonPrintNota.Name = "buttonPrintNota";
            this.buttonPrintNota.Size = new System.Drawing.Size(170, 51);
            this.buttonPrintNota.TabIndex = 28;
            this.buttonPrintNota.Text = "Print Nota";
            this.buttonPrintNota.UseVisualStyleBackColor = false;
            this.buttonPrintNota.Click += new System.EventHandler(this.buttonPrintNota_Click);
            // 
            // panelValidasiInvoice
            // 
            this.panelValidasiInvoice.Controls.Add(this.groupBox1);
            this.panelValidasiInvoice.Controls.Add(this.buttonBatal);
            this.panelValidasiInvoice.Controls.Add(this.buttonSimpan);
            this.panelValidasiInvoice.Controls.Add(this.label5);
            this.panelValidasiInvoice.Location = new System.Drawing.Point(444, 293);
            this.panelValidasiInvoice.Name = "panelValidasiInvoice";
            this.panelValidasiInvoice.Size = new System.Drawing.Size(549, 386);
            this.panelValidasiInvoice.TabIndex = 27;
            this.panelValidasiInvoice.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(480, 146);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelId.Location = new System.Drawing.Point(165, 39);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(191, 25);
            this.labelId.TabIndex = 16;
            this.labelId.Text = "ID Invoice Makanan";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "TERBAYAR",
            "TERAMBIL"});
            this.comboBoxStatus.Location = new System.Drawing.Point(170, 85);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(263, 32);
            this.comboBoxStatus.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label6.Location = new System.Drawing.Point(75, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(109, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID :";
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonBatal.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBatal.Location = new System.Drawing.Point(32, 298);
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
            this.buttonSimpan.Location = new System.Drawing.Point(352, 298);
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
            this.label5.Location = new System.Drawing.Point(33, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(479, 47);
            this.label5.TabIndex = 19;
            this.label5.Text = "V A L I D A S I";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonKeluar.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.buttonKeluar.ForeColor = System.Drawing.Color.Maroon;
            this.buttonKeluar.Location = new System.Drawing.Point(14, 958);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(170, 51);
            this.buttonKeluar.TabIndex = 26;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.tgl_column,
            this.grand_total_column,
            this.konsumen_column,
            this.kasir_column,
            this.status_column,
            this.validasi_column});
            this.dataGridViewHasil.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewHasil.Location = new System.Drawing.Point(14, 194);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowHeadersWidth = 51;
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(1488, 743);
            this.dataGridViewHasil.TabIndex = 25;
            this.dataGridViewHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellContentClick);
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
            // konsumen_column
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed;
            this.konsumen_column.DefaultCellStyle = dataGridViewCellStyle4;
            this.konsumen_column.HeaderText = "Konsumen";
            this.konsumen_column.MinimumWidth = 6;
            this.konsumen_column.Name = "konsumen_column";
            this.konsumen_column.Width = 125;
            // 
            // kasir_column
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkRed;
            this.kasir_column.DefaultCellStyle = dataGridViewCellStyle5;
            this.kasir_column.HeaderText = "Kasir";
            this.kasir_column.MinimumWidth = 6;
            this.kasir_column.Name = "kasir_column";
            this.kasir_column.Width = 125;
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
            // validasi_column
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkRed;
            this.validasi_column.DefaultCellStyle = dataGridViewCellStyle7;
            this.validasi_column.HeaderText = "Aksi";
            this.validasi_column.MinimumWidth = 6;
            this.validasi_column.Name = "validasi_column";
            this.validasi_column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.validasi_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.validasi_column.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.buttonCari);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 86);
            this.panel1.TabIndex = 24;
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.Maroon;
            this.buttonCari.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.buttonCari.ForeColor = System.Drawing.Color.White;
            this.buttonCari.Location = new System.Drawing.Point(1296, 22);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(170, 51);
            this.buttonCari.TabIndex = 3;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
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
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Tanggal",
            "Status"});
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
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1488, 65);
            this.label1.TabIndex = 23;
            this.label1.Text = "VALIDASI MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormValidasiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1516, 1023);
            this.Controls.Add(this.buttonPrintNota);
            this.Controls.Add(this.panelValidasiInvoice);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormValidasiMenu";
            this.Text = "FormValidasiMenu";
            this.Load += new System.EventHandler(this.FormValidasiMenu_Load);
            this.panelValidasiInvoice.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintNota;
        private System.Windows.Forms.Panel panelValidasiInvoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonKeluar;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn konsumen_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasir_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_column;
        private System.Windows.Forms.DataGridViewButtonColumn validasi_column;
    }
}