namespace LAB2
{
    partial class Danh_Sach_The_Thao
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
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.cbb_Name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Time2 = new System.Windows.Forms.TextBox();
            this.lstb_Check = new System.Windows.Forms.ListBox();
            this.lstb_Checked = new System.Windows.Forms.ListBox();
            this.btn_CheckAll = new System.Windows.Forms.Button();
            this.btn_CheckOne = new System.Windows.Forms.Button();
            this.btn_UnCheckAll = new System.Windows.Forms.Button();
            this.btn_UnCheckOne = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.bnt_Reset = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Thể Thao";
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(100, 161);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(100, 23);
            this.txt_Time.TabIndex = 1;
            // 
            // cbb_Name
            // 
            this.cbb_Name.FormattingEnabled = true;
            this.cbb_Name.Location = new System.Drawing.Point(207, 89);
            this.cbb_Name.Name = "cbb_Name";
            this.cbb_Name.Size = new System.Drawing.Size(197, 23);
            this.cbb_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Time";
            // 
            // txt_Time2
            // 
            this.txt_Time2.Location = new System.Drawing.Point(326, 161);
            this.txt_Time2.Name = "txt_Time2";
            this.txt_Time2.Size = new System.Drawing.Size(100, 23);
            this.txt_Time2.TabIndex = 1;
            // 
            // lstb_Check
            // 
            this.lstb_Check.FormattingEnabled = true;
            this.lstb_Check.ItemHeight = 15;
            this.lstb_Check.Location = new System.Drawing.Point(12, 240);
            this.lstb_Check.Name = "lstb_Check";
            this.lstb_Check.Size = new System.Drawing.Size(153, 154);
            this.lstb_Check.TabIndex = 3;
            // 
            // lstb_Checked
            // 
            this.lstb_Checked.FormattingEnabled = true;
            this.lstb_Checked.ItemHeight = 15;
            this.lstb_Checked.Location = new System.Drawing.Point(287, 240);
            this.lstb_Checked.Name = "lstb_Checked";
            this.lstb_Checked.Size = new System.Drawing.Size(149, 154);
            this.lstb_Checked.TabIndex = 3;
            // 
            // btn_CheckAll
            // 
            this.btn_CheckAll.Location = new System.Drawing.Point(190, 266);
            this.btn_CheckAll.Name = "btn_CheckAll";
            this.btn_CheckAll.Size = new System.Drawing.Size(75, 23);
            this.btn_CheckAll.TabIndex = 4;
            this.btn_CheckAll.Text = ">>";
            this.btn_CheckAll.UseVisualStyleBackColor = true;
            this.btn_CheckAll.Click += new System.EventHandler(this.btn_CheckAll_Click);
            // 
            // btn_CheckOne
            // 
            this.btn_CheckOne.Location = new System.Drawing.Point(190, 295);
            this.btn_CheckOne.Name = "btn_CheckOne";
            this.btn_CheckOne.Size = new System.Drawing.Size(75, 23);
            this.btn_CheckOne.TabIndex = 4;
            this.btn_CheckOne.Text = ">";
            this.btn_CheckOne.UseVisualStyleBackColor = true;
            this.btn_CheckOne.Click += new System.EventHandler(this.btn_CheckOne_Click);
            // 
            // btn_UnCheckAll
            // 
            this.btn_UnCheckAll.Location = new System.Drawing.Point(190, 324);
            this.btn_UnCheckAll.Name = "btn_UnCheckAll";
            this.btn_UnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btn_UnCheckAll.TabIndex = 4;
            this.btn_UnCheckAll.Text = "<<";
            this.btn_UnCheckAll.UseVisualStyleBackColor = true;
            this.btn_UnCheckAll.Click += new System.EventHandler(this.btn_UnCheckAll_Click);
            // 
            // btn_UnCheckOne
            // 
            this.btn_UnCheckOne.Location = new System.Drawing.Point(190, 353);
            this.btn_UnCheckOne.Name = "btn_UnCheckOne";
            this.btn_UnCheckOne.Size = new System.Drawing.Size(75, 23);
            this.btn_UnCheckOne.TabIndex = 4;
            this.btn_UnCheckOne.Text = "<";
            this.btn_UnCheckOne.UseVisualStyleBackColor = true;
            this.btn_UnCheckOne.Click += new System.EventHandler(this.btn_UnCheckOne_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.AutoSize = true;
            this.btn_Insert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Insert.Location = new System.Drawing.Point(342, 432);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 30);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.Text = "Nhập";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // bnt_Reset
            // 
            this.bnt_Reset.AutoSize = true;
            this.bnt_Reset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnt_Reset.Location = new System.Drawing.Point(342, 478);
            this.bnt_Reset.Name = "bnt_Reset";
            this.bnt_Reset.Size = new System.Drawing.Size(75, 30);
            this.bnt_Reset.TabIndex = 6;
            this.bnt_Reset.Text = "Reset";
            this.bnt_Reset.UseVisualStyleBackColor = true;
            this.bnt_Reset.Click += new System.EventHandler(this.bnt_Reset_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(342, 527);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 30);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh sách đã chọn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Danh sách các môn";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(12, 438);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(297, 124);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 574);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.bnt_Reset);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_UnCheckOne);
            this.Controls.Add(this.btn_UnCheckAll);
            this.Controls.Add(this.btn_CheckOne);
            this.Controls.Add(this.btn_CheckAll);
            this.Controls.Add(this.lstb_Checked);
            this.Controls.Add(this.lstb_Check);
            this.Controls.Add(this.cbb_Name);
            this.Controls.Add(this.txt_Time2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_Time;
        private ComboBox cbb_Name;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_Time2;
        private ListBox lstb_Check;
        private ListBox lstb_Checked;
        private Button btn_CheckAll;
        private Button btn_CheckOne;
        private Button btn_UnCheckAll;
        private Button btn_UnCheckOne;
        private Button btn_Insert;
        private Button bnt_Reset;
        private Button btn_Exit;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox richTextBox1;
    }
}