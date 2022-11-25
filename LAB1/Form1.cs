namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_Son.Text);
            int m = int.Parse(txt_Som.Text);
            txt_Ketqua.Text = (n+m).ToString();
        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_Son.Text);
            int m = int.Parse(txt_Som.Text);
            txt_Ketqua.Text = (n - m).ToString();
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_Son.Text);
            int m = int.Parse(txt_Som.Text);
            txt_Ketqua.Text = (n * m).ToString();
        }

        private void btn_Chia_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_Son.Text);
            int m = int.Parse(txt_Som.Text);
            txt_Ketqua.Text = (n / m).ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txt_Ketqua.Text = "";
            txt_Som.Text = "";
            txt_Son.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}