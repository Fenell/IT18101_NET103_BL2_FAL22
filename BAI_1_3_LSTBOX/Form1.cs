namespace BAI_1_3_LSTBOX
{
    public partial class Form1 : Form
    {
        private List<Item> _lstItems;
        public Form1()
        {
            InitializeComponent();
            addListItem();
        }

        void addListItem()
        {
            _lstItems = new List<Item>()
            {
                new Item(){Name = "Iphone 14", Price = 14000},
                new Item(){Name = "Iphone 15", Price = 15000},
                new Item(){Name = "Iphone 16", Price = 16000},
                new Item(){Name = "Iphone 17", Price = 17000},
                new Item(){Name = "Iphone 18", Price = 18000},
            };
            //set thuộc tính Display menber của lstbox
            lstItem.DisplayMember = "Name";
            //lstItem.DisplayMember = "Price";
            lstItem.ValueMember = "Price";
            lstItem.DataSource = _lstItems;
        }

        

        private void lstItem_SelectedValueChanged(object sender, EventArgs e)
        {
            //selectedvalue: mặc định = selectedItem, nếu set valuemember của listbox(combo box...) thì sẽ mang giá trị của thuộc tính được set là value member của item
            var item = lstItem.SelectedItem as Item;
            MessageBox.Show($"Bạn đã chọn sản phẩm {item.Name} có giá là {lstItem.SelectedValue}");

        }
    }
}