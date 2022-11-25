namespace TRAINING_4
{
    public partial class Form1 : Form
    {
        private Service _sv;
        private Guid _idWhenClick;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _sv = new Service();
                int stt = 1;
                dgrid_Company.ColumnCount = 6;
                dgrid_Company.Columns[0].Name = "STT";
                dgrid_Company.Columns[1].Name = "Họ tên";
                dgrid_Company.Columns[2].Name = "Giới tính";
                dgrid_Company.Columns[3].Name = "Ngày sinh";
                dgrid_Company.Columns[4].Name = "Địa chỉ";
                dgrid_Company.Columns[5].Name = "Số điện thoại";
                dgrid_Company.Rows.Clear();
                foreach (var company in _sv.DtToList())
                {
                    dgrid_Company.Rows.Add(stt++, company.Name, company.Sex == 0 ? "Nam" : "Nữ", company.DayOfBirth.ToString("dd/MM/yyyy", null), company.Address, company.Phone);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Id = Guid.NewGuid();
            company.Name = txt_Name.Text;
            company.Sex = rbtn_Male.Checked ? 0 : 1;
            company.DayOfBirth = dtpk_Birthday.Value;
            company.Address = txt_Address.Text;
            company.Phone = txt_Phone.Text;
            if (_sv.IsAdd(company))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadData();
                return;
            }

            MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void dgrid_Company_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == dgrid_Company.Rows.Count)
                return;
            txt_Name.Text = dgrid_Company.Rows[rowIndex].Cells[0].Value.ToString();
            dtpk_Birthday.Text = dgrid_Company.Rows[rowIndex].Cells[2].Value.ToString();

        }
    }
}