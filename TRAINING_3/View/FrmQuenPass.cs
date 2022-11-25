using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAINING_3.Utilities;

namespace TRAINING_3.View
{
    public partial class FrmQuenPass : Form
    {
        private ServiceAccount _serviceAccount;
        public FrmQuenPass()
        {
            _serviceAccount = new ServiceAccount();
            InitializeComponent();
        }

        private void btn_RecoverPass_Click(object sender, EventArgs e)
        {
            if (Utility.CheckNullLabe(txt_Email))
            {
                MessageBox.Show("Nhập email");
                return;
            }
            if (_serviceAccount.GetAllAccount().FindIndex(c => c.Email == txt_Email.Text) == -1)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo");
                return;
            }
            lbl_PassRecover.Text = _serviceAccount.GetAllAccount().FirstOrDefault(c => c.Email == txt_Email.Text).Pass;
        }

        

        private void FrmQuenPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
        }
    }
}
