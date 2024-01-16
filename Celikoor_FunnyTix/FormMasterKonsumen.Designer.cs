
namespace Celikoor_FunnyTix
{
    partial class FormMasterKonsumen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_hp_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_lahir_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.buttonKeluar.Location = new System.Drawing.Point(12, 954);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(171, 50);
            this.buttonKeluar.TabIndex = 15;
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
            this.nama_column,
            this.email_column,
            this.no_hp_column,
            this.gender_column,
            this.tgl_lahir_column,
            this.saldo_column,
            this.username_column,
            this.password_column,
            this.hapus_column});
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
            this.panel1.Controls.Add(this.buttonCari);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 86);
            this.panel1.TabIndex = 12;
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.Maroon;
            this.buttonCari.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.textBox.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBox.ForeColor = System.Drawing.Color.Maroon;
            this.textBox.Location = new System.Drawing.Point(611, 30);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(667, 36);
            this.textBox.TabIndex = 2;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Nama",
            "Email",
            "Nomor handphone",
            "Gender",
            "Tanggal Lahir",
            "Username",
            "Password"});
            this.comboBox.Location = new System.Drawing.Point(321, 30);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(269, 35);
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
            this.label1.TabIndex = 11;
            this.label1.Text = "MASTER KONSUMEN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_column
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Maroon;
            this.id_column.DefaultCellStyle = dataGridViewCellStyle11;
            this.id_column.HeaderText = "ID";
            this.id_column.MinimumWidth = 6;
            this.id_column.Name = "id_column";
            this.id_column.Width = 125;
            // 
            // nama_column
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Maroon;
            this.nama_column.DefaultCellStyle = dataGridViewCellStyle12;
            this.nama_column.HeaderText = "Nama";
            this.nama_column.MinimumWidth = 6;
            this.nama_column.Name = "nama_column";
            this.nama_column.Width = 125;
            // 
            // email_column
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Maroon;
            this.email_column.DefaultCellStyle = dataGridViewCellStyle13;
            this.email_column.HeaderText = "Email";
            this.email_column.MinimumWidth = 6;
            this.email_column.Name = "email_column";
            this.email_column.Width = 125;
            // 
            // no_hp_column
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Maroon;
            this.no_hp_column.DefaultCellStyle = dataGridViewCellStyle14;
            this.no_hp_column.HeaderText = "No_Hp";
            this.no_hp_column.MinimumWidth = 6;
            this.no_hp_column.Name = "no_hp_column";
            this.no_hp_column.Width = 125;
            // 
            // gender_column
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Maroon;
            this.gender_column.DefaultCellStyle = dataGridViewCellStyle15;
            this.gender_column.HeaderText = "Gender";
            this.gender_column.MinimumWidth = 6;
            this.gender_column.Name = "gender_column";
            this.gender_column.Width = 125;
            // 
            // tgl_lahir_column
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Maroon;
            this.tgl_lahir_column.DefaultCellStyle = dataGridViewCellStyle16;
            this.tgl_lahir_column.HeaderText = "Tgl_Lahir";
            this.tgl_lahir_column.MinimumWidth = 6;
            this.tgl_lahir_column.Name = "tgl_lahir_column";
            this.tgl_lahir_column.Width = 125;
            // 
            // saldo_column
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Maroon;
            this.saldo_column.DefaultCellStyle = dataGridViewCellStyle17;
            this.saldo_column.HeaderText = "Saldo";
            this.saldo_column.MinimumWidth = 6;
            this.saldo_column.Name = "saldo_column";
            this.saldo_column.Width = 125;
            // 
            // username_column
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Maroon;
            this.username_column.DefaultCellStyle = dataGridViewCellStyle18;
            this.username_column.HeaderText = "Username";
            this.username_column.MinimumWidth = 6;
            this.username_column.Name = "username_column";
            this.username_column.Width = 125;
            // 
            // password_column
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Maroon;
            this.password_column.DefaultCellStyle = dataGridViewCellStyle19;
            this.password_column.HeaderText = "Password";
            this.password_column.MinimumWidth = 6;
            this.password_column.Name = "password_column";
            this.password_column.Width = 125;
            // 
            // hapus_column
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Maroon;
            this.hapus_column.DefaultCellStyle = dataGridViewCellStyle20;
            this.hapus_column.HeaderText = "Aksi";
            this.hapus_column.MinimumWidth = 6;
            this.hapus_column.Name = "hapus_column";
            this.hapus_column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hapus_column.Width = 125;
            // 
            // FormMasterKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1517, 1033);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMasterKonsumen";
            this.Text = "FormMasterKonsumen";
            this.Load += new System.EventHandler(this.FormMasterKonsumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_hp_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_lahir_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn username_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_column;
        private System.Windows.Forms.DataGridViewButtonColumn hapus_column;
    }
}