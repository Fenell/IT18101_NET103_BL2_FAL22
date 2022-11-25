namespace TRAINING_3.View
{
    partial class FrmQuenPass
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
            this.lbl_ForgetPass = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_RecoverPass = new System.Windows.Forms.Button();
            this.lbl_PassRecover = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ForgetPass
            // 
            this.lbl_ForgetPass.AutoSize = true;
            this.lbl_ForgetPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ForgetPass.Location = new System.Drawing.Point(53, 82);
            this.lbl_ForgetPass.Name = "lbl_ForgetPass";
            this.lbl_ForgetPass.Size = new System.Drawing.Size(46, 20);
            this.lbl_ForgetPass.TabIndex = 0;
            this.lbl_ForgetPass.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(166, 83);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(150, 23);
            this.txt_Email.TabIndex = 1;
            // 
            // btn_RecoverPass
            // 
            this.btn_RecoverPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RecoverPass.Location = new System.Drawing.Point(101, 202);
            this.btn_RecoverPass.Name = "btn_RecoverPass";
            this.btn_RecoverPass.Size = new System.Drawing.Size(145, 37);
            this.btn_RecoverPass.TabIndex = 2;
            this.btn_RecoverPass.Text = "Lấy lại mật khẩu";
            this.btn_RecoverPass.UseVisualStyleBackColor = true;
            this.btn_RecoverPass.Click += new System.EventHandler(this.btn_RecoverPass_Click);
            // 
            // lbl_PassRecover
            // 
            this.lbl_PassRecover.AutoSize = true;
            this.lbl_PassRecover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PassRecover.ForeColor = System.Drawing.Color.Red;
            this.lbl_PassRecover.Location = new System.Drawing.Point(145, 151);
            this.lbl_PassRecover.Name = "lbl_PassRecover";
            this.lbl_PassRecover.Size = new System.Drawing.Size(0, 21);
            this.lbl_PassRecover.TabIndex = 3;
            // 
            // FrmQuenPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 293);
            this.Controls.Add(this.lbl_PassRecover);
            this.Controls.Add(this.btn_RecoverPass);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_ForgetPass);
            this.Name = "FrmQuenPass";
            this.Text = "FrmQuenPass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmQuenPass_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_ForgetPass;
        private TextBox txt_Email;
        private Button btn_RecoverPass;
        private Label lbl_PassRecover;
    }
}