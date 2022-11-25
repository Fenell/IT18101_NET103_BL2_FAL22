namespace GioiThieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cong = new System.Windows.Forms.Button();
            this.lbl_tong = new System.Windows.Forms.Label();
            this.rtbn_Cong = new System.Windows.Forms.RadioButton();
            this.rbtn_Tru = new System.Windows.Forms.RadioButton();
            this.rbtn_Chia = new System.Windows.Forms.RadioButton();
            this.rbtn_Nhan = new System.Windows.Forms.RadioButton();
            this.cbx_tuoi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            // 
            // txt_so1
            // 
            this.txt_so1.Location = new System.Drawing.Point(146, 41);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(349, 23);
            this.txt_so1.TabIndex = 1;
            // 
            // txt_so2
            // 
            this.txt_so2.Location = new System.Drawing.Point(146, 111);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(349, 23);
            this.txt_so2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số 2";
            // 
            // btn_Cong
            // 
            this.btn_Cong.Location = new System.Drawing.Point(185, 194);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(75, 23);
            this.btn_Cong.TabIndex = 4;
            this.btn_Cong.Text = "Tính";
            this.btn_Cong.UseVisualStyleBackColor = true;
            this.btn_Cong.Click += new System.EventHandler(this.btn_Cong_Click);
            // 
            // lbl_tong
            // 
            this.lbl_tong.AutoSize = true;
            this.lbl_tong.Location = new System.Drawing.Point(422, 175);
            this.lbl_tong.Name = "lbl_tong";
            this.lbl_tong.Size = new System.Drawing.Size(38, 15);
            this.lbl_tong.TabIndex = 5;
            this.lbl_tong.Text = "label3";
            // 
            // rtbn_Cong
            // 
            this.rtbn_Cong.AutoSize = true;
            this.rtbn_Cong.Location = new System.Drawing.Point(710, 59);
            this.rtbn_Cong.Name = "rtbn_Cong";
            this.rtbn_Cong.Size = new System.Drawing.Size(54, 19);
            this.rtbn_Cong.TabIndex = 6;
            this.rtbn_Cong.TabStop = true;
            this.rtbn_Cong.Text = "Cộng";
            this.rtbn_Cong.UseVisualStyleBackColor = true;
            // 
            // rbtn_Tru
            // 
            this.rbtn_Tru.AutoSize = true;
            this.rbtn_Tru.Location = new System.Drawing.Point(710, 110);
            this.rbtn_Tru.Name = "rbtn_Tru";
            this.rbtn_Tru.Size = new System.Drawing.Size(41, 19);
            this.rbtn_Tru.TabIndex = 7;
            this.rbtn_Tru.TabStop = true;
            this.rbtn_Tru.Text = "Trừ";
            this.rbtn_Tru.UseVisualStyleBackColor = true;
            // 
            // rbtn_Chia
            // 
            this.rbtn_Chia.AutoSize = true;
            this.rbtn_Chia.Location = new System.Drawing.Point(819, 115);
            this.rbtn_Chia.Name = "rbtn_Chia";
            this.rbtn_Chia.Size = new System.Drawing.Size(49, 19);
            this.rbtn_Chia.TabIndex = 8;
            this.rbtn_Chia.TabStop = true;
            this.rbtn_Chia.Text = "Chia";
            this.rbtn_Chia.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nhan
            // 
            this.rbtn_Nhan.AutoSize = true;
            this.rbtn_Nhan.Location = new System.Drawing.Point(819, 59);
            this.rbtn_Nhan.Name = "rbtn_Nhan";
            this.rbtn_Nhan.Size = new System.Drawing.Size(54, 19);
            this.rbtn_Nhan.TabIndex = 9;
            this.rbtn_Nhan.TabStop = true;
            this.rbtn_Nhan.Text = "Nhân";
            this.rbtn_Nhan.UseVisualStyleBackColor = true;
            // 
            // cbx_tuoi
            // 
            this.cbx_tuoi.FormattingEnabled = true;
            this.cbx_tuoi.Location = new System.Drawing.Point(778, 221);
            this.cbx_tuoi.Name = "cbx_tuoi";
            this.cbx_tuoi.Size = new System.Drawing.Size(121, 23);
            this.cbx_tuoi.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 663);
            this.Controls.Add(this.cbx_tuoi);
            this.Controls.Add(this.rbtn_Nhan);
            this.Controls.Add(this.rbtn_Chia);
            this.Controls.Add(this.rbtn_Tru);
            this.Controls.Add(this.rtbn_Cong);
            this.Controls.Add(this.lbl_tong);
            this.Controls.Add(this.btn_Cong);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_so1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính Toán";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_so1;
        private TextBox txt_so2;
        private Label label2;
        private Button btn_Cong;
        private Label lbl_tong;
        private RadioButton rtbn_Cong;
        private RadioButton rbtn_Tru;
        private RadioButton rbtn_Chia;
        private RadioButton rbtn_Nhan;
        private ComboBox cbx_tuoi;
    }
}