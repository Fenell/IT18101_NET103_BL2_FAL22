using ASSIGNMENT_1.Models;
using ASSIGNMENT_1.Services;
using MessageBox = System.Windows.Forms.MessageBox;

namespace ASSIGNMENT_1.View
{
    public partial class FrmLogin : Form
    {
        UserService _userService;
        public FrmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            _userService = new UserService();
        }

        private User GetDataFromGui()
        {
            return new User()
            {
                UserName = txtAcc.Text,
                Password = txtPass.Text
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = GetDataFromGui();
            if (!_userService.Login(txtAcc.Text, txtPass.Text))
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo");
                return;
            }

            switch (_userService.CheckAcces(txtAcc.Text))
            {
                case "Giảng viên":
                    new FrmScores().ShowDialog();
                    this.Close();
                    break;
                case "Cán bộ đào tạo":
                    new FrmStudent().ShowDialog();
                    this.Close();
                    break;
            }

        }

        private void txtAcc_MouseClick(object sender, MouseEventArgs e)
        {
            txtAcc.BackColor = Color.White;
            panel1.BackColor = Color.White;
            txtPass.BackColor = SystemColors.Control;
            panel2.BackColor = SystemColors.Control;
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass.BackColor = Color.White;
            panel2.BackColor = Color.White;
            txtAcc.BackColor = SystemColors.Control;
            panel1.BackColor = SystemColors.Control;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}