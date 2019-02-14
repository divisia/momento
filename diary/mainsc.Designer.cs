namespace diary
{
    partial class mainsc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainsc));
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnEskiler = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(12, 12);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(120, 23);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni entry yaz";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnEskiler
            // 
            this.btnEskiler.Location = new System.Drawing.Point(12, 41);
            this.btnEskiler.Name = "btnEskiler";
            this.btnEskiler.Size = new System.Drawing.Size(120, 23);
            this.btnEskiler.TabIndex = 1;
            this.btnEskiler.Text = "Eski entryler";
            this.btnEskiler.UseVisualStyleBackColor = true;
            this.btnEskiler.Click += new System.EventHandler(this.btnEskiler_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Location = new System.Drawing.Point(12, 114);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(120, 23);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // mainsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(150, 151);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnEskiler);
            this.Controls.Add(this.btnYeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainsc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diary ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainsc_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnEskiler;
        private System.Windows.Forms.Button btnCikis;
    }
}