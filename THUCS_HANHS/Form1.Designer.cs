namespace THUCS_HANHS
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
            this.txt_So1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_So2 = new System.Windows.Forms.TextBox();
            this.lb_KetQua = new System.Windows.Forms.Label();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.cmb_Tinh = new System.Windows.Forms.ComboBox();
            this.lstb_Ketqua = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máy Tính";
            // 
            // txt_So1
            // 
            this.txt_So1.Location = new System.Drawing.Point(136, 94);
            this.txt_So1.Name = "txt_So1";
            this.txt_So1.Size = new System.Drawing.Size(100, 23);
            this.txt_So1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số 2";
            // 
            // txt_So2
            // 
            this.txt_So2.Location = new System.Drawing.Point(136, 167);
            this.txt_So2.Name = "txt_So2";
            this.txt_So2.Size = new System.Drawing.Size(100, 23);
            this.txt_So2.TabIndex = 3;
            // 
            // lb_KetQua
            // 
            this.lb_KetQua.AutoSize = true;
            this.lb_KetQua.Location = new System.Drawing.Point(647, 167);
            this.lb_KetQua.Name = "lb_KetQua";
            this.lb_KetQua.Size = new System.Drawing.Size(38, 15);
            this.lb_KetQua.TabIndex = 5;
            this.lb_KetQua.Text = "label4";
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Location = new System.Drawing.Point(100, 252);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(75, 23);
            this.btn_Tinh.TabIndex = 6;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = true;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // cmb_Tinh
            // 
            this.cmb_Tinh.FormattingEnabled = true;
            this.cmb_Tinh.Location = new System.Drawing.Point(421, 94);
            this.cmb_Tinh.Name = "cmb_Tinh";
            this.cmb_Tinh.Size = new System.Drawing.Size(121, 23);
            this.cmb_Tinh.TabIndex = 7;
            // 
            // lstb_Ketqua
            // 
            this.lstb_Ketqua.FormattingEnabled = true;
            this.lstb_Ketqua.ItemHeight = 15;
            this.lstb_Ketqua.Location = new System.Drawing.Point(421, 194);
            this.lstb_Ketqua.Name = "lstb_Ketqua";
            this.lstb_Ketqua.Size = new System.Drawing.Size(134, 124);
            this.lstb_Ketqua.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xóa lịch sử";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstb_Ketqua);
            this.Controls.Add(this.cmb_Tinh);
            this.Controls.Add(this.btn_Tinh);
            this.Controls.Add(this.lb_KetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_So2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_So1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_So1;
        private Label label2;
        private Label label3;
        private TextBox txt_So2;
        private Label lb_KetQua;
        private Button btn_Tinh;
        private ComboBox cmb_Tinh;
        private ListBox lstb_Ketqua;
        private Button button1;
    }
}