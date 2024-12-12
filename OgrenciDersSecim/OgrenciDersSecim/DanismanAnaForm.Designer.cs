namespace OgrenciDersSecim
{
    partial class DanismanAnaForm
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
            dataGridViewOgrenciDersleri = new DataGridView();
            btnOnayla = new Button();
            btnReddet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciDersleri).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOgrenciDersleri
            // 
            dataGridViewOgrenciDersleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciDersleri.Location = new Point(229, 12);
            dataGridViewOgrenciDersleri.Name = "dataGridViewOgrenciDersleri";
            dataGridViewOgrenciDersleri.RowHeadersWidth = 51;
            dataGridViewOgrenciDersleri.RowTemplate.Height = 24;
            dataGridViewOgrenciDersleri.Size = new Size(679, 375);
            dataGridViewOgrenciDersleri.TabIndex = 0;
            // 
            // btnOnayla
            // 
            btnOnayla.Location = new Point(432, 474);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(88, 28);
            btnOnayla.TabIndex = 1;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnReddet
            // 
            btnReddet.Location = new Point(606, 474);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(88, 28);
            btnReddet.TabIndex = 2;
            btnReddet.Text = "Reddet";
            btnReddet.UseVisualStyleBackColor = true;
            btnReddet.Click += btnReddet_Click;
            // 
            // DanismanAnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 605);
            Controls.Add(btnReddet);
            Controls.Add(btnOnayla);
            Controls.Add(dataGridViewOgrenciDersleri);
            Name = "DanismanAnaForm";
            Text = "Danışman Ana Ekran";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciDersleri).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewOgrenciDersleri;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
    }
}
