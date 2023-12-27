namespace Celikoor_FunnyTix
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pictureBoxPegawai = new System.Windows.Forms.PictureBox();
            this.pictureBoxKonsumen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPegawai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonsumen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPegawai
            // 
            this.pictureBoxPegawai.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPegawai.Location = new System.Drawing.Point(630, 461);
            this.pictureBoxPegawai.Name = "pictureBoxPegawai";
            this.pictureBoxPegawai.Size = new System.Drawing.Size(335, 314);
            this.pictureBoxPegawai.TabIndex = 8;
            this.pictureBoxPegawai.TabStop = false;
            this.pictureBoxPegawai.Click += new System.EventHandler(this.pictureBoxPegawai_Click);
            // 
            // pictureBoxKonsumen
            // 
            this.pictureBoxKonsumen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKonsumen.Location = new System.Drawing.Point(1075, 461);
            this.pictureBoxKonsumen.Name = "pictureBoxKonsumen";
            this.pictureBoxKonsumen.Size = new System.Drawing.Size(335, 314);
            this.pictureBoxKonsumen.TabIndex = 9;
            this.pictureBoxKonsumen.TabStop = false;
            this.pictureBoxKonsumen.Click += new System.EventHandler(this.pictureBoxKonsumen_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::Celikoor_FunnyTix.Properties.Resources.FormAwal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBoxKonsumen);
            this.Controls.Add(this.pictureBoxPegawai);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "FunnyTix";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPegawai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonsumen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPegawai;
        private System.Windows.Forms.PictureBox pictureBoxKonsumen;
    }
}

