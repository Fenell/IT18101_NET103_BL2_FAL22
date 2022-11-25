namespace BAI_1_6_LISTVIEW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstView = new System.Windows.Forms.ListView();
            this.btn_Small = new System.Windows.Forms.Button();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.btn_LargeIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.Location = new System.Drawing.Point(12, 12);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(524, 426);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.lstView_SelectedIndexChanged);
            // 
            // btn_Small
            // 
            this.btn_Small.Location = new System.Drawing.Point(642, 74);
            this.btn_Small.Name = "btn_Small";
            this.btn_Small.Size = new System.Drawing.Size(75, 23);
            this.btn_Small.TabIndex = 1;
            this.btn_Small.Text = "SmallIcon";
            this.btn_Small.UseVisualStyleBackColor = true;
            this.btn_Small.Click += new System.EventHandler(this.btn_Small_Click);
            // 
            // btn_Detail
            // 
            this.btn_Detail.Location = new System.Drawing.Point(632, 143);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(75, 23);
            this.btn_Detail.TabIndex = 2;
            this.btn_Detail.Text = "Detail";
            this.btn_Detail.UseVisualStyleBackColor = true;
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // btn_LargeIcon
            // 
            this.btn_LargeIcon.Location = new System.Drawing.Point(622, 214);
            this.btn_LargeIcon.Name = "btn_LargeIcon";
            this.btn_LargeIcon.Size = new System.Drawing.Size(85, 30);
            this.btn_LargeIcon.TabIndex = 3;
            this.btn_LargeIcon.Text = "LargeIcon";
            this.btn_LargeIcon.UseVisualStyleBackColor = true;
            this.btn_LargeIcon.Click += new System.EventHandler(this.btn_LargeIcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_LargeIcon);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.btn_Small);
            this.Controls.Add(this.lstView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lstView;
        private Button btn_Small;
        private Button btn_Detail;
        private Button btn_LargeIcon;
    }
}