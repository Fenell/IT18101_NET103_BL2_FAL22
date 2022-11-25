using ASSIGNMENT.Models;
using ASSIGNMENT.Utility;

namespace ASSIGNMENT.View
{
    public partial class FrmStudentService : Form
    {
        private StudentService _studentService = new StudentService();
        private string _maSvWhenClick;
        private ErrorProvider _errorProvider = new ErrorProvider();

        public FrmStudentService()
        {
            InitializeComponent();
            this.CenterToScreen();
            LoadData();
        }

        private void LoadData()
        {
            dgridStudent.ColumnCount = 6;
            dgridStudent.Columns[0].Name = "Mã SV";
            dgridStudent.Columns[1].Name = "Họ và tên";
            dgridStudent.Columns[2].Name = "Email";
            dgridStudent.Columns[3].Name = "Số Đt";
            dgridStudent.Columns[4].Name = "Giới tính";
            dgridStudent.Columns[5].Name = "Địa chỉ";
            dgridStudent.Rows.Clear();
            foreach (var t in _studentService.GetlstStudents())
            {
                dgridStudent.Rows.Add(t.ID, t.Name, t.Email, t.Phone, t.Sex == 0 ? "Nam" : "Nữ", t.Address);
            }
        }

        private Student GetDataFromGui()
        {
            return new Student(txtMaSv.Text, txtName.Text, txtEmail.Text, txtPhone.Text, rbtnMale.Checked ? 0 : 1, txtAddress.Text);
        }

        private void dgridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSv.Enabled = false;
            int index = e.RowIndex;
            if (index == dgridStudent.Rows.Count || index == -1)
                return;
            _maSvWhenClick = dgridStudent.Rows[index].Cells[0].Value.ToString();
            var student = _studentService.GetlstStudents().FirstOrDefault(c => _maSvWhenClick == c.ID);
            txtMaSv.Text = student.ID;
            txtName.Text = student.Name;
            txtName.Text = student.Name;
            txtEmail.Text = student.Email;
            txtPhone.Text = student.Phone;
            txtAddress.Text = student.Address;
            if (student.Sex == 0)
            {
                rbtnMale.Checked = true;
                return;
            }
            rbtnFemale.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = GetDataFromGui();

            if (!ValidationForm())
            {
                MessageBox.Show("Kiểm tra lại dữ liệu ", "Thông báo");
                return;
            }
            else if (_studentService.HasStudent(student.ID))
            {
                MessageBox.Show("Trùng mã sinh viên", "Thông báo");
            }
            MessageBox.Show(_studentService.AddStudent(student), "Thông báo");
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var student = GetDataFromGui();
            if (!ValidationForm())
            {
                MessageBox.Show("Kiểm tra lại dữ liệu", "Thông báo");
                return;
            }
            MessageBox.Show(_studentService.UpdateStudent(student), "Thông báo");
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var student = GetDataFromGui();
            MessageBox.Show(_studentService.DeleteSudent(student), "Thông báo");
            LoadData();
        }

        private bool ValidationForm()
        {
            bool isTrue = true;
            List<RadioButton> listRbtn = new List<RadioButton>();
            foreach (Control crt in this.Controls)
            {
                if (crt is TextBox)
                {
                    switch (crt.Name)
                    {
                        case "txtMaSv":
                            if (!Validation.isMaSv(crt.Text))
                            {
                                _errorProvider.SetError(crt, "Sai định dạng");
                                isTrue = false;
                            }

                            if (crt.Enabled)
                            {
                                if (_studentService.GetlstStudents().Any(c => c.ID == crt.Text))
                                {
                                    _errorProvider.SetError(crt, "Mã sinh viên đã tồn tại");
                                    isTrue = false;
                                }
                            }
                            break;

                        case "txtName":
                            if (!Validation.isAlpabetic(crt.Text))
                            {
                                _errorProvider.SetError(crt, "Chỉ được nhập ký tự trong bảng chữ cái");
                                isTrue = false;
                            }
                            break;

                        case "txtPhone":
                            if (!Validation.isNumber(crt.Text))
                            {
                                _errorProvider.SetError(crt, "Chỉ được nhập ký tự số");
                                isTrue = false;
                            }
                            break;
                    }

                    if (string.IsNullOrEmpty(crt.Text))
                    {
                        _errorProvider.SetError(crt, "Không được để trống dữ liệu");
                        isTrue = false;
                    }
                }
            }

            return isTrue;
        }

        private void txt_Changed(object sender, EventArgs e)
        {
            _errorProvider.SetError((TextBox)sender, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControl(this);
        }
    }
}
