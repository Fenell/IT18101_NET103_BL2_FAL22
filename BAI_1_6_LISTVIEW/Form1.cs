namespace BAI_1_6_LISTVIEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadViewList();
        }
        private ImageList smallIcon;
        private ImageList largeIcon;

        private void LoadViewList()
        {
            smallIcon = new ImageList()
            {
                ImageSize = new Size(32,32)
            };
            largeIcon = new ImageList()
            {
                ImageSize = new Size(68, 68)
            };
            //add imgae vào list
            //Application.StartupPath: Đường dẫn đến thư mục khởi chạy chương trình
            smallIcon.Images.Add(new Bitmap($"{Application.StartupPath}/Image/1.png"));
            smallIcon.Images.Add(new Bitmap($"{Application.StartupPath}/Image/2.png"));
            smallIcon.Images.Add(new Bitmap($"{Application.StartupPath}/Image/3.png"));
            largeIcon.Images.Add(new Bitmap($"{Application.StartupPath}/Imgae/1.png"));
            largeIcon.Images.Add(new Bitmap($"{Application.StartupPath}/Imgae/2.png"));
            largeIcon.Images.Add(new Bitmap($"{Application.StartupPath}/Imgae/3.png"));
            //set Image cho lstView
            lstView.SmallImageList = smallIcon;
            lstView.LargeImageList = largeIcon;

            //add cột cho lstVIew
            lstView.Items.Add("Cột 1");
            lstView.Items.Add("Cột 2");
            lstView.Items.Add("Cột 3");

            //adđ Item vào lstView
            ListViewItem item1 = new ListViewItem();
            item1.Text = "Item 1";
            item1.ImageIndex = 0; //set icon là imgae có thứ tự đầu tiên trong image list

            item1.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 1 1"
            }); 
            item1.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 1 2"
            });  
            item1.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 1 3"
            });
            lstView.Items.Add(item1);
            ListViewItem item2 = new ListViewItem();
            item2.Text = "Item 2";
            item2.ImageIndex = 0; //set icon là imgae có thứ tự đầu tiên trong image list

            item2.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 2 1"
            });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 2 2"
            });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = "sub 2 3"
            });

            lstView.Items.Add(item2);
        }

        private void btn_Small_Click(object sender, EventArgs e)
        {

        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {

        }

        private void btn_LargeIcon_Click(object sender, EventArgs e)
        {

        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstView.SelectedItems;
            var text = item[0].Text;
            var sText1 = item[0].SubItems[0].Text;
            var sText2 = item[0].SubItems[1].Text;
            MessageBox.Show($"{text} {sText2}{sText2}");
        }
    }
}