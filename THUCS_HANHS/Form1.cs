using System.Text.RegularExpressions;

namespace THUCS_HANHS
{
    public partial class Form1 : Form
    {
        private List<string> lstPhepTinh;
        public Form1()
        {
            InitializeComponent();
            lstPhepTinh = new List<string>() { "Cộng", "Trừ", "Nhân", "Chia" };
           // LoadCmbPhepTinh();
            cmb_Tinh.DataSource = lstPhepTinh;
        }
        //private void LoadCmbPhepTinh()
        //{
        //    foreach (var item in lstPhepTinh)
        //    {
        //        cmb_Tinh.Items.Add(item);
        //    }
        //    cmb_Tinh.SelectedIndex = 1;
        //}

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            double ketQua;
            if (!Checkso(txt_So1.Text) || !Checkso(txt_So2.Text))
            {
                MessageBox.Show("Nhập số vào");
                return;
            }
            var so1 = double.Parse(txt_So1.Text);
            var so2 = double.Parse(txt_So2.Text);

            if (cmb_Tinh.Text == "Cộng")
            {
                ketQua = so1 + so2;
                lb_KetQua.Text = ketQua.ToString();
                lstb_Ketqua.Items.Add($"{so1} + {so2} = {ketQua}");
            }

            if (cmb_Tinh.Text == "Trừ")
            {
                ketQua = so1 - so2;
                lb_KetQua.Text = ketQua.ToString();
                lstb_Ketqua.Items.Add($"{so1} - {so2} = {ketQua}");
            }

            if (cmb_Tinh.Text == "Nhân")
            {
                ketQua = so1 * so2;
                lb_KetQua.Text = ketQua.ToString();
                lstb_Ketqua.Items.Add($"{so1} x {so2} = {ketQua}");
            }

            if (cmb_Tinh.Text == "Chia")
            {
                if (so2 == 0)
                {
                    MessageBox.Show("Éo chia cho 0 được đâu");
                    return;
                }
                ketQua = so1 / so2;
                lb_KetQua.Text = ketQua.ToString();
                lstb_Ketqua.Items.Add($"{so1} : {so2} = {ketQua,0:0.00}");
            }
        }

        private bool Checkso(string so)
        {
            return Regex.IsMatch(so, @"^[0-9]$");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lstb_Ketqua.Items.Clear();
        }
    }
}