namespace OgrenciDersSecim
{
    partial class OgrenciSilForm
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
            txtOgrenciID = new TextBox();
            btnSil = new Button();
            lblOgrenciID = new Label();
            SuspendLayout();
            // 
            // txtOgrenciID
            // 
            txtOgrenciID.Location = new Point(528, 144);
            txtOgrenciID.Name = "txtOgrenciID";
            txtOgrenciID.Size = new Size(231, 23);
            txtOgrenciID.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(436, 336);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(223, 206);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lblOgrenciID
            // 
            lblOgrenciID.AutoSize = true;
            lblOgrenciID.Location = new Point(392, 144);
            lblOgrenciID.Name = "lblOgrenciID";
            lblOgrenciID.Size = new Size(66, 15);
            lblOgrenciID.TabIndex = 2;
            lblOgrenciID.Text = "Öğrenci ID:";
            // 
            // OgrenciSilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 605);
            Controls.Add(lblOgrenciID);
            Controls.Add(btnSil);
            Controls.Add(txtOgrenciID);
            Name = "OgrenciSilForm";
            Text = "Öğrenci Sil";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblOgrenciID;
    }
}
