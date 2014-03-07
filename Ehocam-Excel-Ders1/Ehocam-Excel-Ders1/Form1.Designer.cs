namespace Ehocam_Excel_Ders1
{
    partial class Form1
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
            this.linkAsama1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.cbSifreVarMi = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.linkAsama2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkAsama1
            // 
            this.linkAsama1.AutoSize = true;
            this.linkAsama1.Location = new System.Drawing.Point(27, 62);
            this.linkAsama1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAsama1.Name = "linkAsama1";
            this.linkAsama1.Size = new System.Drawing.Size(200, 15);
            this.linkAsama1.TabIndex = 0;
            this.linkAsama1.TabStop = true;
            this.linkAsama1.Text = "İlgili Makaleyi Açmak İçin Tıklayınız";
            this.linkAsama1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAsama1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOlustur);
            this.groupBox1.Controls.Add(this.linkAsama1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(234, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aşama 1 - Excel Dosyası Oluştur";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(7, 22);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(220, 26);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSifre);
            this.groupBox2.Controls.Add(this.cbSifreVarMi);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.linkAsama2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(253, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(234, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aşama 2 - Excel Dosyasını Kaydetme";
            // 
            // txtSifre
            // 
            this.txtSifre.Enabled = false;
            this.txtSifre.Location = new System.Drawing.Point(7, 86);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(219, 23);
            this.txtSifre.TabIndex = 7;
            this.txtSifre.Text = "12345";
            // 
            // cbSifreVarMi
            // 
            this.cbSifreVarMi.AutoSize = true;
            this.cbSifreVarMi.Location = new System.Drawing.Point(7, 58);
            this.cbSifreVarMi.Name = "cbSifreVarMi";
            this.cbSifreVarMi.Size = new System.Drawing.Size(197, 19);
            this.cbSifreVarMi.TabIndex = 6;
            this.cbSifreVarMi.Text = "Şifre Koymak İstiyor musunuz?";
            this.cbSifreVarMi.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(7, 22);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(220, 26);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // linkAsama2
            // 
            this.linkAsama2.AutoSize = true;
            this.linkAsama2.Location = new System.Drawing.Point(27, 126);
            this.linkAsama2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAsama2.Name = "linkAsama2";
            this.linkAsama2.Size = new System.Drawing.Size(200, 15);
            this.linkAsama2.TabIndex = 1;
            this.linkAsama2.TabStop = true;
            this.linkAsama2.Text = "İlgili Makaleyi Açmak İçin Tıklayınız";
            this.linkAsama2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAsama2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 172);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ehocam.Com - Excel Dosyasını Kaydetme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkAsama1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.CheckBox cbSifreVarMi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.LinkLabel linkAsama2;
    }
}

