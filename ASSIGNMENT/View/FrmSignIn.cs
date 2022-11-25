using ASSIGNMENT.View;

namespace ASSIGNMENT;

public partial class FrmSignIn : Form
{
    public FrmSignIn()
    {
        InitializeComponent();
        this.CenterToScreen();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtAcc.Text == "giangvien" && txtPass.Text == "123")
        {
            FrmScoresService fsm = new FrmScoresService();
            fsm.Show();
            this.Hide();
        }
        else if (txtAcc.Text == "daotao" && txtPass.Text == "123")
        {
            FrmStudentService fsm = new FrmStudentService();
            fsm.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo");
        }

    }



    private void btnExit_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            this.Close();
        }
    }

    private void txtAcc_MouseClick(object sender, MouseEventArgs e)
    {
        panel1.BackColor = Color.White;
        txtAcc.BackColor = Color.White;
        panel2.BackColor = SystemColors.Control;
        txtPass.BackColor = SystemColors.Control;
    }

    private void txtPass_MouseClick(object sender, MouseEventArgs e)
    {
        panel1.BackColor = SystemColors.Control;
        txtAcc.BackColor = SystemColors.Control;
        txtPass.BackColor = Color.White;
        panel2.BackColor = Color.White;
    }

    private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
    {
        txtPass.UseSystemPasswordChar = false;
    }

    private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
    {
        txtPass.UseSystemPasswordChar = true;
    }
}
