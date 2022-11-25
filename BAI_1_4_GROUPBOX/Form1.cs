namespace BAI_1_4_GROUPBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //sender là conttrol kích hoạt sự kiện ở đây là RadioButton
            var rb = (RadioButton)sender;
            label1.Text = rb.Text;
        }
    }
}