namespace BAI_1_5_MENUSTRIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ContextMenuStrip: là menu chuột phải, vào prop contextMenuStrip = menustrip đã tạo
        //Có thể tạo shortcut thông qua prop Shortcut
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            this.Hide();
            infoForm.ShowDialog();
            this.Show();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}