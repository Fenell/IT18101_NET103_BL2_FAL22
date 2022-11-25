namespace LAB2
{
    public partial class Tinh_Tien_Dien : Form
    {
        public Tinh_Tien_Dien()
        {
            InitializeComponent();
            LoadLstBox();
        }

        private void LoadLstBox()
        {
            List<string> name = new List<string>() { "Nam", "Quốc", "Sơn", "Hà", "Đế" };
            cbb_Person.DataSource = name;
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            int newSocces = int.Parse(txt_OldScocce.Text);
            int oldSocces = int.Parse(txt_NewSocces.Text);
            int total = oldSocces - newSocces;
            if (total <= 50)
            {
                txt_TotalMoney.Text = $"{total * 500}";
                txt_Total.Text = total.ToString();
                txt_InDinhMuc.Text = total.ToString();
                txt_OnDinhMuc.Text = "0";
                return;
            }
            txt_TotalMoney.Text = $"{50 * 500 + (total - 50) * 1000}";
            txt_Total.Text = total.ToString();
            txt_InDinhMuc.Text = "50";
            txt_OnDinhMuc.Text = $"{total - 50}";
            return;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            lstb_Print.Items.Add(cbb_Person.Text);
            lstb_Print.Items.Add($"Số kw tiêu thụ {txt_Total.Text}");
            lstb_Print.Items.Add($"Tổng tiền: {txt_TotalMoney.Text}");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_NewSocces_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_OldScocce.Text) || string.IsNullOrEmpty(txt_NewSocces.Text))
            {
                txt_Total.Text = "0";
                return;
            }
            int newSocces = int.Parse(txt_OldScocce.Text);
            int oldSocces = int.Parse(txt_NewSocces.Text);
            txt_Total.Text = (oldSocces - newSocces).ToString();
            return;
        }
    }
}