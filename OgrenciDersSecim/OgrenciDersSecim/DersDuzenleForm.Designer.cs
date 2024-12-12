namespace OgrenciDersSecim
{
    partial class DersDuzenleForm
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
            txtDersID = new TextBox();
            txtDersAdi = new TextBox();
            txtKredi = new TextBox();
            txtKontenjan = new TextBox();
            chkAktif = new CheckBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            lblDersID = new Label();
            lblDersAdi = new Label();
            lblKredi = new Label();
            lblKontenjan = new Label();
            lblAktif = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDersler
            // 
            dataGridViewDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDersler.Location = new Point(10, 11);
            dataGridViewDersler.Name = "dataGridViewDersler";
            dataGridViewDersler.RowHeadersWidth = 51;
            dataGridViewDersler.RowTemplate.Height = 24;
            dataGridViewDersler.Size = new Size(1094, 188);
            dataGridViewDersler.TabIndex = 0;
            dataGridViewDersler.CellClick += dataGridViewDersler_CellClick;
            // 
            // txtDersID
            // 
            txtDersID.Location = new Point(293, 231);
            txtDersID.Name = "txtDersID";
            txtDersID.ReadOnly = true;
            txtDersID.Size = new Size(158, 23);
            txtDersID.TabIndex = 1;
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(295, 283);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(158, 23);
            txtDersAdi.TabIndex = 2;
            // 
            // txtKredi
            // 
            txtKredi.Location = new Point(295, 332);
            txtKredi.Name = "txtKredi";
            txtKredi.Size = new Size(158, 23);
            txtKredi.TabIndex = 3;
            // 
            // txtKontenjan
            // 
            txtKontenjan.Location = new Point(295, 375);
            txtKontenjan.Name = "txtKontenjan";
            txtKontenjan.Size = new Size(158, 23);
            txtKontenjan.TabIndex = 4;
            // 
            // chkAktif
            // 
            chkAktif.AutoSize = true;
            chkAktif.Location = new Point(295, 422);
            chkAktif.Name = "chkAktif";
            chkAktif.Size = new Size(51, 19);
            chkAktif.TabIndex = 5;
            chkAktif.Text = "Aktif";
            chkAktif.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(718, 231);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(158, 28);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(718, 299);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(158, 28);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(718, 362);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(158, 28);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblDersID
            // 
            lblDersID.AutoSize = true;
            lblDersID.Location = new Point(178, 231);
            lblDersID.Name = "lblDersID";
            lblDersID.Size = new Size(47, 15);
            lblDersID.TabIndex = 9;
            lblDersID.Text = "Ders ID:";
            // 
            // lblDersAdi
            // 
            lblDersAdi.AutoSize = true;
            lblDersAdi.Location = new Point(178, 283);
            lblDersAdi.Name = "lblDersAdi";
            lblDersAdi.Size = new Size(54, 15);
            lblDersAdi.TabIndex = 10;
            lblDersAdi.Text = "Ders Adı:";
            // 
            // lblKredi
            // 
            lblKredi.AutoSize = true;
            lblKredi.Location = new Point(178, 332);
            lblKredi.Name = "lblKredi";
            lblKredi.Size = new Size(37, 15);
            lblKredi.TabIndex = 11;
            lblKredi.Text = "Kredi:";
            // 
            // lblKontenjan
            // 
            lblKontenjan.AutoSize = true;
            lblKontenjan.Location = new Point(178, 375);
            lblKontenjan.Name = "lblKontenjan";
            lblKontenjan.Size = new Size(64, 15);
            lblKontenjan.TabIndex = 12;
            lblKontenjan.Text = "Kontenjan:";
            // 
            // lblAktif
            // 
            lblAktif.AutoSize = true;
            lblAktif.Location = new Point(207, 426);
            lblAktif.Name = "lblAktif";
            lblAktif.Size = new Size(35, 15);
            lblAktif.TabIndex = 13;
            lblAktif.Text = "Aktif:";
            // 
            // DersDuzenleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 601);
            Controls.Add(lblAktif);
            Controls.Add(lblKontenjan);
            Controls.Add(lblKredi);
            Controls.Add(lblDersAdi);
            Controls.Add(lblDersID);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(chkAktif);
            Controls.Add(txtKontenjan);
            Controls.Add(txtKredi);
            Controls.Add(txtDersAdi);
            Controls.Add(txtDersID);
            Controls.Add(dataGridViewDersler);
            Name = "DersDuzenleForm";
            Text = "Ders Düzenle";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewDersler;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.TextBox txtKontenjan;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblDersID;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.Label lblKredi;
        private System.Windows.Forms.Label lblKontenjan;
        private System.Windows.Forms.Label lblAktif;
    }
}
