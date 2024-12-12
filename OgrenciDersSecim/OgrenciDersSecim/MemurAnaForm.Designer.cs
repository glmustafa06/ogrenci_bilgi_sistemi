namespace OgrenciDersSecim
{
    partial class MemurAnaForm
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
            btnOgrenciKayit = new Button();
            btnDersDuzenle = new Button();
            btnOgrenciRaporu = new Button();
            btnCikisYap = new Button();
            btnOgrenciSil = new Button();
            SuspendLayout();
            // 
            // btnOgrenciKayit
            // 
            btnOgrenciKayit.Location = new Point(44, 28);
            btnOgrenciKayit.Name = "btnOgrenciKayit";
            btnOgrenciKayit.Size = new Size(175, 400);
            btnOgrenciKayit.TabIndex = 0;
            btnOgrenciKayit.Text = "Öğrenci Kayıt";
            btnOgrenciKayit.UseVisualStyleBackColor = true;
            btnOgrenciKayit.Click += btnOgrenciKayit_Click;
            // 
            // btnDersDuzenle
            // 
            btnDersDuzenle.Location = new Point(629, 28);
            btnDersDuzenle.Name = "btnDersDuzenle";
            btnDersDuzenle.Size = new Size(173, 400);
            btnDersDuzenle.TabIndex = 1;
            btnDersDuzenle.Text = "Dersleri Düzenle";
            btnDersDuzenle.UseVisualStyleBackColor = true;
            btnDersDuzenle.Click += btnDersDuzenle_Click;
            // 
            // btnOgrenciRaporu
            // 
            btnOgrenciRaporu.Location = new Point(910, 28);
            btnOgrenciRaporu.Name = "btnOgrenciRaporu";
            btnOgrenciRaporu.Size = new Size(173, 400);
            btnOgrenciRaporu.TabIndex = 2;
            btnOgrenciRaporu.Text = "Kayıtlı Öğrenci Raporu";
            btnOgrenciRaporu.UseVisualStyleBackColor = true;
            btnOgrenciRaporu.Click += btnOgrenciRaporu_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.Location = new Point(223, 535);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(696, 28);
            btnCikisYap.TabIndex = 3;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = true;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // btnOgrenciSil
            // 
            btnOgrenciSil.Location = new Point(328, 28);
            btnOgrenciSil.Name = "btnOgrenciSil";
            btnOgrenciSil.Size = new Size(173, 400);
            btnOgrenciSil.TabIndex = 4;
            btnOgrenciSil.Text = "Öğrenci Sil";
            btnOgrenciSil.UseVisualStyleBackColor = true;
            btnOgrenciSil.Click += btnOgrenciSil_Click;
            // 
            // MemurAnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 605);
            Controls.Add(btnOgrenciSil);
            Controls.Add(btnCikisYap);
            Controls.Add(btnOgrenciRaporu);
            Controls.Add(btnDersDuzenle);
            Controls.Add(btnOgrenciKayit);
            Name = "MemurAnaForm";
            Text = "Öğrenci İşleri Memuru";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnOgrenciKayit;
        private System.Windows.Forms.Button btnDersDuzenle;
        private System.Windows.Forms.Button btnOgrenciRaporu;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button btnOgrenciSil;
    }
}
