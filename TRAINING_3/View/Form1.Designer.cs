namespace TRAINING_3.View
{
    partial class Form1
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
            this.lbl_NameAcc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_TypeAcc = new System.Windows.Forms.Label();
            this.btn_QLNhanVien = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào";
            // 
            // lbl_NameAcc
            // 
            this.lbl_NameAcc.AutoSize = true;
            this.lbl_NameAcc.Location = new System.Drawing.Point(172, 42);
            this.lbl_NameAcc.Name = "lbl_NameAcc";
            this.lbl_NameAcc.Size = new System.Drawing.Size(0, 15);
            this.lbl_NameAcc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại tài khoản";
            // 
            // lbl_TypeAcc
            // 
            this.lbl_TypeAcc.AutoSize = true;
            this.lbl_TypeAcc.Location = new System.Drawing.Point(172, 90);
            this.lbl_TypeAcc.Name = "lbl_TypeAcc";
            this.lbl_TypeAcc.Size = new System.Drawing.Size(0, 15);
            this.lbl_TypeAcc.TabIndex = 3;
            // 
            // btn_QLNhanVien
            // 
            this.btn_QLNhanVien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_QLNhanVien.Location = new System.Drawing.Point(426, 24);
            this.btn_QLNhanVien.Name = "btn_QLNhanVien";
            this.btn_QLNhanVien.Size = new System.Drawing.Size(143, 33);
            this.btn_QLNhanVien.TabIndex = 4;
            this.btn_QLNhanVien.Text = "Quản lý nhân viên";
            this.btn_QLNhanVien.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(471, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(426, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Lên đơn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(426, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thêm mặt hàng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(426, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "Xóa mặt hàng";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 383);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_QLNhanVien);
            this.Controls.Add(this.lbl_TypeAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_NameAcc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_NameAcc;
        private Label label3;
        private Label lbl_TypeAcc;
        private Button btn_QLNhanVien;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}