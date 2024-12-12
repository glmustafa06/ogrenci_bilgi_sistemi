namespace OgrenciDersSecim
{
    partial class Form1
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
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            lblRol = new Label();
            cmbRol = new ComboBox();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(330, 196);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(76, 15);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(498, 196);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(251, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(330, 273);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(498, 273);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(251, 23);
            txtSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(390, 470);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(281, 28);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(330, 351);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 5;
            lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Ogrenci", "Memur", "Danisman" });
            cmbRol.Location = new Point(498, 351);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(251, 23);
            cmbRol.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 603);
            Controls.Add(cmbRol);
            Controls.Add(lblRol);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Name = "Form1";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
    }
}
