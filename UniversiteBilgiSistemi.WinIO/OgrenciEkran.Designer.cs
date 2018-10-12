namespace UniversiteBilgiSistemi.WinIO
{
    partial class OgrenciEkran
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblSurname = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblTc = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblName,
            this.LblSurname,
            this.LblTc});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // LblName
            // 
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(39, 17);
            this.LblName.Text = "Name";
            // 
            // LblSurname
            // 
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(54, 17);
            this.LblSurname.Text = "Surname";
            // 
            // LblTc
            // 
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(17, 17);
            this.LblTc.Text = "tc";
            // 
            // OgrenciEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "OgrenciEkran";
            this.Text = "OgrenciEkran";
            this.Load += new System.EventHandler(this.OgrenciEkran_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblName;
        private System.Windows.Forms.ToolStripStatusLabel LblSurname;
        private System.Windows.Forms.ToolStripStatusLabel LblTc;
        private System.Windows.Forms.Label label1;
    }
}