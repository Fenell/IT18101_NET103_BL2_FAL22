namespace BAI_1_2_COLLECTION_CONTROL
{
    public partial class Form1 : Form
    {
        private List<string> lstCountry;
        public Form1()
        {
            InitializeComponent();
            addLstBox();
            lstCountry = new List<string>()
            {
                "Mỹ", "Anh", "Việt Nam", "Đức"
            };
            adddCbx();
        }


        private void addLstBox()
        {
            lstBox.Items.Clear();
            lstBox.Items.Add("Van");
            lstBox.Items.Add("Su");
            lstBox.Items.Add("Dia");
        }

        private void adddCbx()
        {
            foreach (var item in lstCountry)
            {
                cmb_Country.Items.Add(item);
            }
        }
        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmb_Country.Text);
        }
    }
}