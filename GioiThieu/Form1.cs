namespace GioiThieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTuoi();
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            var so1 = Int32.Parse(txt_so1.Text);
            var so2 = Int32.Parse(txt_so2.Text);
            if (rtbn_Cong.Checked == true)
            {
                lbl_tong.Text = $"{so1 + so2}";
            }
            if (rbtn_Tru.Checked == true)
            {
                lbl_tong.Text = $"{so1 - so2}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadTuoi()
        {
            for (int i = 1600; i < 2005; i++)
            {
                cbx_tuoi.Items.Add(i);
            }
        }
    }
}