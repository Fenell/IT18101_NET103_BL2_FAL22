namespace LAB1
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
            this.txt_Son = new System.Windows.Forms.TextBox();
            this.txt_Som = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cong = new System.Windows.Forms.Button();
            this.btn_Tru = new System.Windows.Forms.Button();
            this.btn_Nhan = new System.Windows.Forms.Button();
            this.btn_Chia = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Son
            // 
            this.txt_Son.Location = new System.Drawing.Point(337, 109);
            this.txt_Son.Name = "txt_Son";
            this.txt_Son.Size = new System.Drawing.Size(186, 23);
            this.txt_Son.TabIndex = 1;
            // 
            // txt_Som
            // 
            this.txt_Som.Location = new System.Drawing.Point(337, 175);
            this.txt_Som.Name = "txt_Som";
            this.txt_Som.Size = new System.Drawing.Size(186, 23);
            this.txt_Som.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập số n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập số m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(232, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // btn_Cong
            // 
            this.btn_Cong.Location = new System.Drawing.Point(49, 302);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(75, 23);
            this.btn_Cong.TabIndex = 6;
            this.btn_Cong.Text = "+";
            this.btn_Cong.UseVisualStyleBackColor = true;
            this.btn_Cong.Click += new System.EventHandler(this.btn_Cong_Click);
            // 
            // btn_Tru
            // 
            this.btn_Tru.Location = new System.Drawing.Point(155, 302);
            this.btn_Tru.Name = "btn_Tru";
            this.btn_Tru.Size = new System.Drawing.Size(75, 23);
            this.btn_Tru.TabIndex = 7;
            this.btn_Tru.Text = "-";
            this.btn_Tru.UseVisualStyleBackColor = true;
            this.btn_Tru.Click += new System.EventHandler(this.btn_Tru_Click);
            // 
            // btn_Nhan
            // 
            this.btn_Nhan.Location = new System.Drawing.Point(255, 302);
            this.btn_Nhan.Name = "btn_Nhan";
            this.btn_Nhan.Size = new System.Drawing.Size(75, 23);
            this.btn_Nhan.TabIndex = 8;
            this.btn_Nhan.Text = "*";
            this.btn_Nhan.UseVisualStyleBackColor = true;
            this.btn_Nhan.Click += new System.EventHandler(this.btn_Nhan_Click);
            // 
            // btn_Chia
            // 
            this.btn_Chia.Location = new System.Drawing.Point(366, 302);
            this.btn_Chia.Name = "btn_Chia";
            this.btn_Chia.Size = new System.Drawing.Size(75, 23);
            this.btn_Chia.TabIndex = 9;
            this.btn_Chia.Text = "/";
            this.btn_Chia.UseVisualStyleBackColor = true;
            this.btn_Chia.Click += new System.EventHandler(this.btn_Chia_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(484, 302);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(596, 302);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 11;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kết quả";
            // 
            // txt_Ketqua
            // 
            this.txt_Ketqua.Enabled = false;
            this.txt_Ketqua.Location = new System.Drawing.Point(337, 245);
            this.txt_Ketqua.Name = "txt_Ketqua";
            this.txt_Ketqua.Size = new System.Drawing.Size(186, 23);
            this.txt_Ketqua.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 374);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Ketqua);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Chia);
            this.Controls.Add(this.btn_Nhan);
            this.Controls.Add(this.btn_Tru);
            this.Controls.Add(this.btn_Cong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Som);
            this.Controls.Add(this.txt_Son);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Son;
        private TextBox txt_Som;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Cong;
        private Button btn_Tru;
        private Button btn_Nhan;
        private Button btn_Chia;
        private Button btn_Xoa;
        private Button btn_Thoat;
        private Label label4;
        private TextBox txt_Ketqua;
    }
}