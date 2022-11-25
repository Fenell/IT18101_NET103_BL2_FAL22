namespace LAB1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_pt2 = new System.Windows.Forms.RadioButton();
            this.rbtn_pt1 = new System.Windows.Forms.RadioButton();
            this.txt_Soa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Sob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Soc = new System.Windows.Forms.TextBox();
            this.btn_Ketqua = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Ketqua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(128, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải phương trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_pt2);
            this.groupBox1.Controls.Add(this.rbtn_pt1);
            this.groupBox1.Location = new System.Drawing.Point(51, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // rbtn_pt2
            // 
            this.rbtn_pt2.AutoCheck = false;
            this.rbtn_pt2.AutoSize = true;
            this.rbtn_pt2.Location = new System.Drawing.Point(59, 80);
            this.rbtn_pt2.Name = "rbtn_pt2";
            this.rbtn_pt2.Size = new System.Drawing.Size(149, 19);
            this.rbtn_pt2.TabIndex = 0;
            this.rbtn_pt2.TabStop = true;
            this.rbtn_pt2.Text = "Giải phương trình bậc 2";
            this.rbtn_pt2.UseVisualStyleBackColor = true;
            // 
            // rbtn_pt1
            // 
            this.rbtn_pt1.AutoSize = true;
            this.rbtn_pt1.Location = new System.Drawing.Point(59, 45);
            this.rbtn_pt1.Name = "rbtn_pt1";
            this.rbtn_pt1.Size = new System.Drawing.Size(149, 19);
            this.rbtn_pt1.TabIndex = 0;
            this.rbtn_pt1.TabStop = true;
            this.rbtn_pt1.Text = "Giải phương trình bậc 1";
            this.rbtn_pt1.UseVisualStyleBackColor = true;
            this.rbtn_pt1.CheckedChanged += new System.EventHandler(this.rbtn_pt1_CheckedChanged);
            // 
            // txt_Soa
            // 
            this.txt_Soa.Location = new System.Drawing.Point(143, 256);
            this.txt_Soa.Name = "txt_Soa";
            this.txt_Soa.Size = new System.Drawing.Size(194, 23);
            this.txt_Soa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập b";
            // 
            // txt_Sob
            // 
            this.txt_Sob.Location = new System.Drawing.Point(143, 290);
            this.txt_Sob.Name = "txt_Sob";
            this.txt_Sob.Size = new System.Drawing.Size(194, 23);
            this.txt_Sob.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập c";
            // 
            // txt_Soc
            // 
            this.txt_Soc.Location = new System.Drawing.Point(143, 329);
            this.txt_Soc.Name = "txt_Soc";
            this.txt_Soc.Size = new System.Drawing.Size(194, 23);
            this.txt_Soc.TabIndex = 2;
            // 
            // btn_Ketqua
            // 
            this.btn_Ketqua.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Ketqua.Location = new System.Drawing.Point(363, 252);
            this.btn_Ketqua.Name = "btn_Ketqua";
            this.btn_Ketqua.Size = new System.Drawing.Size(87, 62);
            this.btn_Ketqua.TabIndex = 3;
            this.btn_Ketqua.Text = "Giải";
            this.btn_Ketqua.UseVisualStyleBackColor = true;
            this.btn_Ketqua.Click += new System.EventHandler(this.btn_Ketqua_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(363, 332);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(87, 25);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kết quả";
            // 
            // txt_Ketqua
            // 
            this.txt_Ketqua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Ketqua.Location = new System.Drawing.Point(143, 370);
            this.txt_Ketqua.Name = "txt_Ketqua";
            this.txt_Ketqua.Size = new System.Drawing.Size(307, 27);
            this.txt_Ketqua.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 434);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Ketqua);
            this.Controls.Add(this.txt_Ketqua);
            this.Controls.Add(this.txt_Soc);
            this.Controls.Add(this.txt_Sob);
            this.Controls.Add(this.txt_Soa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtn_pt2;
        private RadioButton rbtn_pt1;
        private TextBox txt_Soa;
        private Label label2;
        private Label label3;
        private TextBox txt_Sob;
        private Label label4;
        private TextBox txt_Soc;
        private Button btn_Ketqua;
        private Button btn_Thoat;
        private Label label5;
        private TextBox txt_Ketqua;
    }
}