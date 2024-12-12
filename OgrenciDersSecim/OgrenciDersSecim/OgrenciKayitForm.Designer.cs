namespace OgrenciDersSecim
{
    partial class OgrenciKayitForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtGano = new TextBox();
            btnKaydet = new Button();
            lblAd = new Label();
            lblSoyad = new Label();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            lblGano = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(131, 19);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(467, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(131, 56);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(467, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(131, 94);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(467, 23);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(131, 131);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(467, 23);
            txtSifre.TabIndex = 3;
            // 
            // txtGano
            // 
            txtGano.Location = new Point(131, 169);
            txtGano.Name = "txtGano";
            txtGano.Size = new Size(467, 23);
            txtGano.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(451, 285);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(225, 131);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(44, 19);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(25, 15);
            lblAd.TabIndex = 6;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(44, 56);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(42, 15);
            lblSoyad.TabIndex = 7;
            lblSoyad.Text = "Soyad:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(44, 94);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(76, 15);
            lblKullaniciAdi.TabIndex = 8;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(44, 131);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 9;
            lblSifre.Text = "Şifre:";
            // 
            // lblGano
            // 
            lblGano.AutoSize = true;
            lblGano.Location = new Point(44, 169);
            lblGano.Name = "lblGano";
            lblGano.Size = new Size(44, 15);
            lblGano.TabIndex = 10;
            lblGano.Text = "GANO:";
            // 
            // OgrenciKayitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 605);
            Controls.Add(lblGano);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(btnKaydet);
            Controls.Add(txtGano);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "OgrenciKayitForm";
            Text = "Öğrenci Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtGano;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblGano;
    }
}
