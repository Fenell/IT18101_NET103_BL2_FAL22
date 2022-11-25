using TRAINING_3.Utilities;
using TRAINING_3.View;

namespace TRAINING_3
{
    public partial class FrmDangNhap : Form
    {
        private ServiceAccount _serviceAccount;
        public FrmDangNhap()
        {
            InitializeComponent();
            _serviceAccount = new ServiceAccount();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Acc.Text)|| string.IsNullOrEmpty(txt_Pass.Text))
            {
                MessageBox.Show("Không để trống tài khoản hoặc mật khẩu", "Thông báo"); 
                return;
            }
            if (_serviceAccount.GetAllAccount().FirstOrDefault(c=>c.Acc == txt_Acc.Text).Pass != txt_Pass.Text)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo");
                return;
            }

            var RoleID = _serviceAccount.GetAllAccount().FirstOrDefault(c => c.Acc == txt_Acc.Text).RoleId;
            Utility.Role = _serviceAccount.GetAllRoles().FirstOrDefault(c => c.Id == RoleID);
            Utility.Account = _serviceAccount.GetAllAccount().FirstOrDefault(c => c.Acc == txt_Acc.Text);
            MessageBox.Show("Đăng nhập thành công");
            Form FrmMain = new Form1();
            FrmMain.Show();
            this.Hide();
        }

        private void lbl_Join_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form FrmDangKy = new FrmDangKy();
            FrmDangKy.Show();
            this.Hide();
        }

        private void lbl_ForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form FrmForgetPass = new FrmQuenPass();
            FrmForgetPass.Show();
            this.Hide();
        }
    }
}