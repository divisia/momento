namespace diary
{
    partial class yenientry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yenientry));
            this.txtEntry = new System.Windows.Forms.RichTextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblbilgi = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(12, 12);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(775, 298);
            this.txtEntry.TabIndex = 0;
            this.txtEntry.Text = "";
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(712, 316);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 1;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(631, 316);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Text = "Geri gel";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(52, 316);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(129, 20);
            this.txtTarih.TabIndex = 3;
            this.txtTarih.Tag = "";
            this.toolTip1.SetToolTip(this.txtTarih, "Tarihi keyfinize göre el ile de girebilirsiniz.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tarih:";
            // 
            // lblbilgi
            // 
            this.lblbilgi.AutoSize = true;
            this.lblbilgi.Location = new System.Drawing.Point(187, 321);
            this.lblbilgi.Name = "lblbilgi";
            this.lblbilgi.Size = new System.Drawing.Size(35, 13);
            this.lblbilgi.TabIndex = 6;
            this.lblbilgi.Text = "label3";
            this.lblbilgi.Visible = false;
            // 
            // yenientry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(803, 360);
            this.Controls.Add(this.lblbilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtEntry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "yenientry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diary ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yenientry_FormClosing);
            this.Load += new System.EventHandler(this.yenientry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtEntry;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbilgi;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}