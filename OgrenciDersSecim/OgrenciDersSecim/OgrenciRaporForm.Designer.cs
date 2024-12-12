namespace OgrenciDersSecim
{
    partial class OgrenciRaporForm
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
            dataGridViewOgrenciler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOgrenciler
            // 
            dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciler.Location = new Point(10, 11);
            dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            dataGridViewOgrenciler.RowHeadersWidth = 51;
            dataGridViewOgrenciler.RowTemplate.Height = 24;
            dataGridViewOgrenciler.Size = new Size(1095, 583);
            dataGridViewOgrenciler.TabIndex = 0;
            // 
            // OgrenciRaporForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 606);
            Controls.Add(dataGridViewOgrenciler);
            Name = "OgrenciRaporForm";
            Text = "Kayıtlı Öğrenci Raporu";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewOgrenciler;
    }
}
