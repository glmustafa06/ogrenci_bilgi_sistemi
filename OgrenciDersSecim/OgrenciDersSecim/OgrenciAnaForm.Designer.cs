namespace OgrenciDersSecim
{
    partial class OgrenciAnaForm
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
            dataGridViewDersler = new DataGridView();
            dataGridViewOgrenciDersleri = new DataGridView();
            btnDersEkle = new Button();
            btnDersSil = new Button();
            lblKrediToplam = new Label();
            btnDanismanaGonder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciDersleri).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDersler
            // 
            dataGridViewDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDersler.Location = new Point(10, 11);
            dataGridViewDersler.Name = "dataGridViewDersler";
            dataGridViewDersler.RowHeadersWidth = 51;
            dataGridViewDersler.RowTemplate.Height = 24;
            dataGridViewDersler.Size = new Size(1095, 234);
            dataGridViewDersler.TabIndex = 0;
            // 
            // dataGridViewOgrenciDersleri
            // 
            dataGridViewOgrenciDersleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciDersleri.Location = new Point(10, 262);
            dataGridViewOgrenciDersleri.Name = "dataGridViewOgrenciDersleri";
            dataGridViewOgrenciDersleri.RowHeadersWidth = 51;
            dataGridViewOgrenciDersleri.RowTemplate.Height = 24;
            dataGridViewOgrenciDersleri.Size = new Size(1095, 141);
            dataGridViewOgrenciDersleri.TabIndex = 1;
            // 
            // btnDersEkle
            // 
            btnDersEkle.Location = new Point(10, 422);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(88, 28);
            btnDersEkle.TabIndex = 2;
            btnDersEkle.Text = "Ders Ekle";
            btnDersEkle.UseVisualStyleBackColor = true;
            btnDersEkle.Click += btnDersEkle_Click;
            // 
            // btnDersSil
            // 
            btnDersSil.Location = new Point(114, 422);
            btnDersSil.Name = "btnDersSil";
            btnDersSil.Size = new Size(88, 28);
            btnDersSil.TabIndex = 3;
            btnDersSil.Text = "Ders Sil";
            btnDersSil.UseVisualStyleBackColor = true;
            btnDersSil.Click += btnDersSil_Click;
            // 
            // lblKrediToplam
            // 
            lblKrediToplam.AutoSize = true;
            lblKrediToplam.Location = new Point(219, 422);
            lblKrediToplam.Name = "lblKrediToplam";
            lblKrediToplam.Size = new Size(88, 15);
            lblKrediToplam.TabIndex = 4;
            lblKrediToplam.Text = "Toplam Kredi: 0";
            // 
            // btnDanismanaGonder
            // 
            btnDanismanaGonder.Location = new Point(324, 422);
            btnDanismanaGonder.Name = "btnDanismanaGonder";
            btnDanismanaGonder.Size = new Size(131, 28);
            btnDanismanaGonder.TabIndex = 5;
            btnDanismanaGonder.Text = "Danışmana Gönder";
            btnDanismanaGonder.UseVisualStyleBackColor = true;
            btnDanismanaGonder.Click += btnDanismanaGonder_Click;
            // 
            // OgrenciAnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 602);
            Controls.Add(btnDanismanaGonder);
            Controls.Add(lblKrediToplam);
            Controls.Add(btnDersSil);
            Controls.Add(btnDersEkle);
            Controls.Add(dataGridViewOgrenciDersleri);
            Controls.Add(dataGridViewDersler);
            Name = "OgrenciAnaForm";
            Text = "Öğrenci Ana Ekran";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciDersleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewDersler;
        private System.Windows.Forms.DataGridView dataGridViewOgrenciDersleri;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Label lblKrediToplam;
        private System.Windows.Forms.Button btnDanismanaGonder;
    }
}
