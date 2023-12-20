namespace Celikoor_FunnyTix
{
    partial class FormUpdateInvoice
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
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.textBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxNoInv = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNama
            // 
            this.textBoxNama.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNama.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(978, 242);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(249, 29);
            this.textBoxNama.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(284, 242);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(312, 28);
            this.dateTimePicker.TabIndex = 1;
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxDiskon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiskon.Enabled = false;
            this.textBoxDiskon.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiskon.Location = new System.Drawing.Point(141, 468);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(238, 29);
            this.textBoxDiskon.TabIndex = 2;
            // 
            // textBoxGrandTotal
            // 
            this.textBoxGrandTotal.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGrandTotal.Enabled = false;
            this.textBoxGrandTotal.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrandTotal.Location = new System.Drawing.Point(141, 607);
            this.textBoxGrandTotal.Name = "textBoxGrandTotal";
            this.textBoxGrandTotal.Size = new System.Drawing.Size(238, 29);
            this.textBoxGrandTotal.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.NavajoWhite;
            this.comboBoxStatus.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "PENDING",
            "VALIDASI",
            "TERBAYAR"});
            this.comboBoxStatus.Location = new System.Drawing.Point(515, 444);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(272, 40);
            this.comboBoxStatus.TabIndex = 4;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.buttonUpdate.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonUpdate.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.buttonUpdate.Location = new System.Drawing.Point(957, 627);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(448, 77);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // textBoxNoInv
            // 
            this.textBoxNoInv.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxNoInv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNoInv.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoInv.Location = new System.Drawing.Point(1142, 113);
            this.textBoxNoInv.Name = "textBoxNoInv";
            this.textBoxNoInv.Size = new System.Drawing.Size(249, 29);
            this.textBoxNoInv.TabIndex = 6;
            this.textBoxNoInv.TextChanged += new System.EventHandler(this.textBoxNoInv_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(310, 121);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(85, 29);
            this.textBoxId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(102, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Operator Id";
            // 
            // FormUpdateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Celikoor_FunnyTix.Properties.Resources.formInvoiceKasirValidasi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1508, 792);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxNoInv);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxGrandTotal);
            this.Controls.Add(this.textBoxDiskon);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxNama);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdateInvoice";
            this.Text = "FormInvoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.TextBox textBoxGrandTotal;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNoInv;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
    }
}