namespace Celikoor_FunnyTix
{
    partial class FormLaporan
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(72, 293);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1838, 567);
            this.dataGridView.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.NavajoWhite;
            this.label.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DarkRed;
            this.label.Location = new System.Drawing.Point(805, 65);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(446, 65);
            this.label.TabIndex = 1;
            this.label.Text = "       LAPORAN     ";
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChoose.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Items.AddRange(new object[] {
            "Laporan jumlah film terlaris (paling banyak ditonton) per bulannya selama tahun 2" +
                "023",
            "Laporan peringkat 3 cabang terbanyak yang mendapatkan pemasukkan dari penjualan t" +
                "iket (dilihat dari total nominalnya)",
            "Laporan 3 teratas film yang paling banyak jumlah ketidakhadiran penontonnya",
            "Laporan 3 studio beserta nama cinemanya, yang memiliki tingkat utilitas terendah " +
                "pada bulan tertentu (dihitung dari banyaknya kosong kursi pada studio tersebut)",
            "Laporan 10 konsumen teratas yang paling sering menonton film bergenre comedy (dil" +
                "ihat dari frekuensi menonton film komedinya)"});
            this.comboBoxChoose.Location = new System.Drawing.Point(361, 221);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(1549, 35);
            this.comboBoxChoose.TabIndex = 2;
            this.comboBoxChoose.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoose_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(76, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "  Jenis Laporan   :";
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(1670, 901);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(172, 47);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChoose);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormLaporan";
            this.Text = "2";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExport;
    }
}