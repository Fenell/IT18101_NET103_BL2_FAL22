namespace LAB2
{
    partial class Tinh_Tien_Dien
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
            this.cbb_Person = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_OldScocce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NewSocces = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_InDinhMuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_OnDinhMuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TotalMoney = new System.Windows.Forms.TextBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lstb_Print = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbb_Person
            // 
            this.cbb_Person.FormattingEnabled = true;
            this.cbb_Person.Location = new System.Drawing.Point(282, 89);
            this.cbb_Person.Name = "cbb_Person";
            this.cbb_Person.Size = new System.Drawing.Size(121, 23);
            this.cbb_Person.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(175, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Tính Tiền Điện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên khách hàng";
            // 
            // txt_OldScocce
            // 
            this.txt_OldScocce.Location = new System.Drawing.Point(153, 162);
            this.txt_OldScocce.Name = "txt_OldScocce";
            this.txt_OldScocce.Size = new System.Drawing.Size(51, 23);
            this.txt_OldScocce.TabIndex = 2;
            this.txt_OldScocce.TextChanged += new System.EventHandler(this.txt_NewSocces_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chỉ số cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chỉ số mới";
            // 
            // txt_NewSocces
            // 
            this.txt_NewSocces.Location = new System.Drawing.Point(153, 210);
            this.txt_NewSocces.Name = "txt_NewSocces";
            this.txt_NewSocces.Size = new System.Drawing.Size(51, 23);
            this.txt_NewSocces.TabIndex = 2;
            this.txt_NewSocces.TextChanged += new System.EventHandler(this.txt_NewSocces_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số kw tiêu thụ";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(153, 264);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(51, 23);
            this.txt_Total.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(319, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số kw trong định mức";
            // 
            // txt_InDinhMuc
            // 
            this.txt_InDinhMuc.Location = new System.Drawing.Point(509, 174);
            this.txt_InDinhMuc.Name = "txt_InDinhMuc";
            this.txt_InDinhMuc.Size = new System.Drawing.Size(59, 23);
            this.txt_InDinhMuc.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(319, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số kw vượt định mức";
            // 
            // txt_OnDinhMuc
            // 
            this.txt_OnDinhMuc.Location = new System.Drawing.Point(510, 215);
            this.txt_OnDinhMuc.Name = "txt_OnDinhMuc";
            this.txt_OnDinhMuc.Size = new System.Drawing.Size(59, 23);
            this.txt_OnDinhMuc.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(57, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tổng tiền phải trả";
            // 
            // txt_TotalMoney
            // 
            this.txt_TotalMoney.Enabled = false;
            this.txt_TotalMoney.Location = new System.Drawing.Point(42, 364);
            this.txt_TotalMoney.Name = "txt_TotalMoney";
            this.txt_TotalMoney.Size = new System.Drawing.Size(162, 23);
            this.txt_TotalMoney.TabIndex = 2;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(119, 409);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 3;
            this.btn_Print.Text = "In";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Total
            // 
            this.btn_Total.Location = new System.Drawing.Point(22, 409);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(75, 23);
            this.btn_Total.TabIndex = 3;
            this.btn_Total.Text = "Tính";
            this.btn_Total.UseVisualStyleBackColor = true;
            this.btn_Total.Click += new System.EventHandler(this.btn_Total_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(67, 459);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lstb_Print
            // 
            this.lstb_Print.FormattingEnabled = true;
            this.lstb_Print.ItemHeight = 15;
            this.lstb_Print.Location = new System.Drawing.Point(319, 340);
            this.lstb_Print.Name = "lstb_Print";
            this.lstb_Print.Size = new System.Drawing.Size(250, 124);
            this.lstb_Print.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(319, 264);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Size = new System.Drawing.Size(193, 54);
            this.label9.TabIndex = 1;
            this.label9.Text = "Định mức là 50 kw\r\nTrong định mức là 500đ/kw\r\nVượt định mức là 1000đ/kw";
            // 
            // Tinh_Tien_Dien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 508);
            this.Controls.Add(this.lstb_Print);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Total);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.txt_TotalMoney);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_NewSocces);
            this.Controls.Add(this.txt_OnDinhMuc);
            this.Controls.Add(this.txt_InDinhMuc);
            this.Controls.Add(this.txt_OldScocce);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_Person);
            this.Name = "Tinh_Tien_Dien";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbb_Person;
        private Label label1;
        private Label label2;
        private TextBox txt_OldScocce;
        private Label label3;
        private Label label4;
        private TextBox txt_NewSocces;
        private Label label5;
        private TextBox txt_Total;
        private Label label6;
        private TextBox txt_InDinhMuc;
        private Label label7;
        private TextBox txt_OnDinhMuc;
        private Label label8;
        private TextBox txt_TotalMoney;
        private Button btn_Print;
        private Button btn_Total;
        private Button btn_Exit;
        private ListBox lstb_Print;
        private Label label9;
    }
}