namespace Celikoor_FunnyTix
{
    partial class FormIsiSaldo
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
            this.buttonBayar = new System.Windows.Forms.Button();
            this.textBoxNominal = new System.Windows.Forms.TextBox();
            this.comboBoxMetode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBayar
            // 
            this.buttonBayar.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonBayar.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBayar.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBayar.Location = new System.Drawing.Point(69, 447);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(382, 62);
            this.buttonBayar.TabIndex = 31;
            this.buttonBayar.Text = "BAYAR";
            this.buttonBayar.UseVisualStyleBackColor = false;
            this.buttonBayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // textBoxNominal
            // 
            this.textBoxNominal.BackColor = System.Drawing.Color.Maroon;
            this.textBoxNominal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNominal.Font = new System.Drawing.Font("Montserrat SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNominal.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNominal.Location = new System.Drawing.Point(95, 232);
            this.textBoxNominal.Name = "textBoxNominal";
            this.textBoxNominal.Size = new System.Drawing.Size(343, 29);
            this.textBoxNominal.TabIndex = 30;
            this.textBoxNominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxMetode
            // 
            this.comboBoxMetode.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxMetode.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxMetode.FormattingEnabled = true;
            this.comboBoxMetode.Items.AddRange(new object[] {
            "OVO",
            "Go-Pay",
            "Virtual Account"});
            this.comboBoxMetode.Location = new System.Drawing.Point(93, 354);
            this.comboBoxMetode.Name = "comboBoxMetode";
            this.comboBoxMetode.Size = new System.Drawing.Size(343, 32);
            this.comboBoxMetode.TabIndex = 32;
            // 
            // FormIsiSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Celikoor_FunnyTix.Properties.Resources.formIsiSaldo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 565);
            this.Controls.Add(this.comboBoxMetode);
            this.Controls.Add(this.buttonBayar);
            this.Controls.Add(this.textBoxNominal);
            this.Name = "FormIsiSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIsiSaldo";
            this.Load += new System.EventHandler(this.FormIsiSaldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBayar;
        private System.Windows.Forms.TextBox textBoxNominal;
        private System.Windows.Forms.ComboBox comboBoxMetode;
    }
}