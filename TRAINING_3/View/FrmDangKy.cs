using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAINING_3.Models;
using TRAINING_3.Utilities;

namespace TRAINING_3.View
{
    public partial class FrmDangKy : Form
    {
        private ServiceAccount _serviceAccount;
        public FrmDangKy()
        {
            InitializeComponent();
            _serviceAccount = new ServiceAccount();
            LoadRole();
        }

        void LoadRole()
        {
            foreach (var item in _serviceAccount.GetAllRoles())
            {
                cbb_Role.Items.Add(item.Role1);
            }
            cbb_Role.SelectedIndex = 0;
        }

        

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Form FrmDangNhap = new FrmDangNhap();
            FrmDangNhap.Show();
            this.Close();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (Utility.CheckNumber(txt_Phone.Text))
            {
                MessageBox.Show("Nhập sai định dạng ký tự", "Thông báo");
                return;
            }
            if (txt_PassVerify.Text != txt_Pass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo");
                return;
            }

            if (Utility.CheckNullLabe(txt_Acc) || Utility.CheckNullLabe(txt_Pass) || Utility.CheckNullLabe(txt_Email) || Utility.CheckNullLabe(txt_Address) || Utility.CheckNullLabe(txt_Phone))
            {
                MessageBox.Show("Không được để trống dữ liệu", "Thông báo");
                return;
            }

            Account account = new Account();
            account.Acc = txt_Acc.Text;
            account.Pass = txt_Pass.Text;
            account.Email = txt_Email.Text;
            account.Address = txt_Address.Text;
            account.Phone = txt_Phone.Text;
            account.RoleId = _serviceAccount.GetAllRoles().Where(c=>c.Role1 == cbb_Role.Text).Select(c=>c.Id).FirstOrDefault();
            MessageBox.Show(_serviceAccount.AddAccount(account), "Thông báo");
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        void ClearForm()
        {
            txt_Acc.Text = txt_Pass.Text = txt_PassVerify.Text = "";
            cbb_Role.SelectedIndex = 0;
        }
    }
}
