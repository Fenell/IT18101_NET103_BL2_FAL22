namespace LAB2
{
    partial class Menu_Strip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mstripCn1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripCn2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripCn3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripCn1,
            this.mstripCn2,
            this.mstripCn3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mstripCn1
            // 
            this.mstripCn1.Name = "mstripCn1";
            this.mstripCn1.Size = new System.Drawing.Size(91, 20);
            this.mstripCn1.Text = "Tính tiền điện";
            this.mstripCn1.Click += new System.EventHandler(this.mstripCn1_Click);
            // 
            // mstripCn2
            // 
            this.mstripCn2.Name = "mstripCn2";
            this.mstripCn2.Size = new System.Drawing.Size(121, 20);
            this.mstripCn2.Text = "Danh sách thể thao";
            this.mstripCn2.Click += new System.EventHandler(this.mstripCn2_Click);
            // 
            // mstripCn3
            // 
            this.mstripCn3.Name = "mstripCn3";
            this.mstripCn3.Size = new System.Drawing.Size(124, 20);
            this.mstripCn3.Text = "Truyền dữ liệu Form";
            this.mstripCn3.Click += new System.EventHandler(this.mstripCn3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 362);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mstripCn1;
        private ToolStripMenuItem mstripCn2;
        private ToolStripMenuItem mstripCn3;
    }
}