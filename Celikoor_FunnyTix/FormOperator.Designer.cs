namespace Celikoor_FunnyTix
{
    partial class FormOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperator));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.textBoxKursi = new System.Windows.Forms.TextBox();
            this.textBoxStudio = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNoTiket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Maroon;
            this.buttonUpdate.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.NavajoWhite;
            this.buttonUpdate.Location = new System.Drawing.Point(800, 708);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(538, 94);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Check In";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(639, 372);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(420, 36);
            this.dateTimePicker.TabIndex = 9;
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxJudul.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxJudul.Font = new System.Drawing.Font("Montserrat SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.textBoxJudul.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxJudul.Location = new System.Drawing.Point(204, 564);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(529, 33);
            this.textBoxJudul.TabIndex = 10;
            // 
            // textBoxKursi
            // 
            this.textBoxKursi.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxKursi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKursi.Font = new System.Drawing.Font("Montserrat SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.textBoxKursi.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxKursi.Location = new System.Drawing.Point(810, 561);
            this.textBoxKursi.Name = "textBoxKursi";
            this.textBoxKursi.Size = new System.Drawing.Size(180, 33);
            this.textBoxKursi.TabIndex = 11;
            // 
            // textBoxStudio
            // 
            this.textBoxStudio.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxStudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStudio.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudio.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxStudio.Location = new System.Drawing.Point(1091, 571);
            this.textBoxStudio.Name = "textBoxStudio";
            this.textBoxStudio.Size = new System.Drawing.Size(212, 22);
            this.textBoxStudio.TabIndex = 12;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTime.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxTime.Location = new System.Drawing.Point(201, 754);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(212, 29);
            this.textBoxTime.TabIndex = 13;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHarga.Font = new System.Drawing.Font("Montserrat SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.textBoxHarga.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxHarga.Location = new System.Drawing.Point(495, 749);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(225, 33);
            this.textBoxHarga.TabIndex = 15;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStatus.Font = new System.Drawing.Font("Montserrat SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.textBoxStatus.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxStatus.Location = new System.Drawing.Point(1133, 367);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(225, 33);
            this.textBoxStatus.TabIndex = 16;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxID.Location = new System.Drawing.Point(375, 200);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(140, 37);
            this.textBoxID.TabIndex = 17;
            // 
            // textBoxNoTiket
            // 
            this.textBoxNoTiket.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxNoTiket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNoTiket.Font = new System.Drawing.Font("Montserrat SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.textBoxNoTiket.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxNoTiket.Location = new System.Drawing.Point(213, 375);
            this.textBoxNoTiket.Name = "textBoxNoTiket";
            this.textBoxNoTiket.Size = new System.Drawing.Size(288, 33);
            this.textBoxNoTiket.TabIndex = 1;
            this.textBoxNoTiket.TextChanged += new System.EventHandler(this.textBoxNoTiket_TextChanged);
            this.textBoxNoTiket.MouseLeave += new System.EventHandler(this.textBoxNoTiket_MouseLeave);
            // 
            // FormOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Celikoor_FunnyTix.Properties.Resources.operatorForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1520, 1029);
            this.Controls.Add(this.textBoxNoTiket);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxStudio);
            this.Controls.Add(this.textBoxKursi);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonUpdate);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOperator";
            this.Text = "FormOperator";
            this.Load += new System.EventHandler(this.FormOperator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.TextBox textBoxKursi;
        private System.Windows.Forms.TextBox textBoxStudio;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNoTiket;
    }
}