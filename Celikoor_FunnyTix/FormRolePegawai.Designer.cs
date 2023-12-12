namespace Celikoor_FunnyTix
{
    partial class FormRolePegawai
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
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelOperator = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.panelAdmin.Location = new System.Drawing.Point(424, 433);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(348, 387);
            this.panelAdmin.TabIndex = 0;
            // 
            // panelOperator
            // 
            this.panelOperator.BackColor = System.Drawing.Color.Transparent;
            this.panelOperator.Location = new System.Drawing.Point(820, 433);
            this.panelOperator.Name = "panelOperator";
            this.panelOperator.Size = new System.Drawing.Size(348, 387);
            this.panelOperator.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(1210, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 387);
            this.panel3.TabIndex = 1;
            // 
            // FormRolePegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Celikoor_FunnyTix.Properties.Resources.formPegawai;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelOperator);
            this.Controls.Add(this.panelAdmin);
            this.DoubleBuffered = true;
            this.Name = "FormRolePegawai";
            this.Text = "FormRolePegawai";
            this.Load += new System.EventHandler(this.FormRolePegawai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelOperator;
        private System.Windows.Forms.Panel panel3;
    }
}