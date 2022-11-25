using TRAINING_2.Models;

namespace TRAINING_2
{
    public partial class Form1 : Form
    {
        private Service service;
        private Guid _idWhenClick;
        public Form1()
        {
            service = new Service();
            InitializeComponent();
            LoadAccount(null);
            LoadRole();
        }

        void LoadAccount(string? acc)
        {
            dgrid_Account.ColumnCount = 4;
            dgrid_Account.Columns[0].Name = "STT";
            dgrid_Account.Columns[1].Name = "Tài khoản";
            dgrid_Account.Columns[2].Name = "Mật khẩu";
            dgrid_Account.Columns[3].Name = "Chức vụ";
            dgrid_Account.Rows.Clear();
            int stt = 1;
            foreach (var item in service.GetlstAccounts(acc))
            {
                dgrid_Account.Rows.Add(stt++, item.Acc, item.Pass, service.GetlstRoles().Where(c=>c.Id == item.RoleId)
                    .Select(c=>c.Role1).FirstOrDefault());
            }
        }

        void LoadRole()
        {
            foreach (var item in service.GetlstRoles())
            {
                cmb_Roles.Items.Add(item.Role1);
            }
            cmb_Roles.SelectedIndex = 0;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var acc = LoadDataFromGUI();
            acc.Id = Guid.NewGuid();
            if (service.CheckAcc(acc.Acc) == false)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                return;
            }
            MessageBox.Show(service.Add(acc), "Thông báo");
            service.GetlstAccountFromDb();
            LoadAccount(null);
            Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var acc = LoadDataFromGUI();
            acc.Id = _idWhenClick;
            MessageBox.Show(service.Update(acc), "Thông báo");
            service.GetlstAccountFromDb();
            LoadAccount(null); 
            Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var acc = LoadDataFromGUI();
            acc.Id = _idWhenClick;
            MessageBox.Show(service.Delete(acc), "Thông báo");
            service.GetlstAccountFromDb();
            LoadAccount(null);
            Clear();
        }
        private void dgrid_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if ((rowIndex < 0) || rowIndex == service.GetlstAccounts().Count) return;
            txt_Acc.Text = dgrid_Account.Rows[rowIndex].Cells[1].Value.ToString();
            _idWhenClick = service.GetlstAccounts().Where(c=>c.Acc == txt_Acc.Text).Select(c=>c.Id).FirstOrDefault();
            txt_Pass.Text = dgrid_Account.Rows[rowIndex].Cells[2].Value.ToString();
            cmb_Roles.Text = dgrid_Account.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Acc.Enabled = false;
        }

        Account LoadDataFromGUI()
        {
            return new Account()
            {
                Id = Guid.Empty, Acc = txt_Acc.Text, Pass = txt_Pass.Text,
                RoleId = service.GetlstRoles().Where(c => c.Role1 == cmb_Roles.Text).Select(a=>a.Id).FirstOrDefault()
            };
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Tìm kiếm...") return;
            service.GetlstAccountFromDb();
            LoadAccount(txt_Search.Text);
        }

        private void txt_Search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Search.Text = "";
        }
        private void txt_Search_Leave(object sender, EventArgs e)
        {
            txt_Search.Text = "Tìm kiếm...";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo)) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Clear()
        {
            txt_Acc.Text = txt_Pass.Text = "";
            txt_Acc.Enabled = true;
        }

    }
}