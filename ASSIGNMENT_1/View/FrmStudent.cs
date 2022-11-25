using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASSIGNMENT_1.Models;
using ASSIGNMENT_1.Services;
using ASSIGNMENT_1.Utility;
using ImageConverter = System.Drawing.ImageConverter;

namespace ASSIGNMENT_1.View
{
    public partial class FrmStudent : Form
    {
        private StudentService _studentService;
        private ErrorProvider _errorProvider;
        public FrmStudent()
        {
            InitializeComponent();
            this.CenterToScreen();
            _studentService = new StudentService();
            _errorProvider = new ErrorProvider();
            LoadData();
        }

        void LoadData()
        {
            dgridStudent.ColumnCount = 6;
            dgridStudent.Columns[0].Name = "Mã sinh viên";
            dgridStudent.Columns[1].Name = "Họ tên";
            dgridStudent.Columns[2].Name = "Email";
            dgridStudent.Columns[3].Name = "SĐT";
            dgridStudent.Columns[4].Name = "Giới tính";
            dgridStudent.Columns[5].Name = "Địa chỉ";
            dgridStudent.Rows.Clear();
            foreach (var student in _studentService.GetAll())
            {
                dgridStudent.Rows.Add(student.MaSv, student.Name, student.Email, student.PhoneNumber,
                    (student.Sex) == true ? "Nam" : (student.Sex) == false ? "Nữ" : "Không xác định", student.Address);
            }
        }

        private Student GetDataFromGui()
        {
            return new Student()
            {
                MaSv = txtMaSv.Text,
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Sex = ((rbtnMale.Checked == true) ? true : (rbtnFemale.Checked) == true ? false : null),
                Address = txtAddress.Text,
                Picture = ImageToBytes(ptboxStudent.Image)
            };
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = GetDataFromGui();
            if (!ValidationForm())
            {
                MessageBox.Show("Kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (_studentService.HasStudent(student.MaSv))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo");
                return;
            }

            if (_studentService.AddStudent(student))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var student = GetDataFromGui();
            if (MessageBox.Show("Bạn có muốn sửa thông tin sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!ValidationForm())
                {
                    MessageBox.Show("Kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (_studentService.UpdateStudent(student))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var student = GetDataFromGui();
            if (MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_studentService.DeleteStudent(student))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            string filelocation = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.JPG; *.GIF; *.PNG)| *.JPG; *.GIF; *.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filelocation = ofd.FileName;
                ptboxStudent.Image = Image.FromFile(filelocation);
            }
        }

        private void dgridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //BindingSource bSource = new BindingSource();
            //bSource.DataSource = _studentService.GetAll();
            txtMaSv.Enabled = false;
            int index = e.RowIndex;
            if (index == -1 || index == dgridStudent.Rows.Count - 1) return;
            var maSvWhenClick = dgridStudent.Rows[index].Cells[0].Value.ToString();
            var student = _studentService.GetAll().FirstOrDefault(c => c.MaSv == maSvWhenClick);
            txtMaSv.Text = student.MaSv;
            txtName.Text = student.Name;
            txtPhone.Text = student.PhoneNumber;
            txtEmail.Text = student.Email;
            txtAddress.Text = student.Address;
            ptboxStudent.Image = BytesToImage(student.Picture);
            student.Sex = true ? rbtnMale.Checked = true : student.Sex == false ? rbtnFemale.Checked == true : null;

        }

        private bool ValidationForm()
        {
            bool isTrue = true;
            foreach (Control crt in this.panInfo.Controls)
            {
                if (crt is TextBox)
                {
                    switch (crt.Name)
                    {
                        case "txtMaSv":

                            if (crt.Enabled)
                            {
                                if (!Validation.IsMaSv(crt.Text))
                                {
                                    _errorProvider.SetError(crt, "Bắt đầu bằng PH và có 5 chữ số");
                                    isTrue = false;
                                }
                                if (_studentService.HasStudent(crt.Text))
                                {
                                    _errorProvider.SetError(crt, "Mã sinh viên đã tồn tại");
                                }
                            }
                            break;

                        case "txtName":
                            if (!Validation.IsAlpabetic(crt.Text))
                            {
                                _errorProvider.SetError(crt, "Không nhập số và ký tự đặc biệt");
                                isTrue = false;
                            }
                            break;

                        case "txtPhone":
                            if (!Validation.IsPhoneNumber(crt.Text))
                            {
                                _errorProvider.SetError(crt, "Sai định dạng");
                                isTrue = false;
                            }
                            break;

                        case "txtEmail":
                            if (!Validation.IsEmail(crt.Text))
                            {
                                _errorProvider.SetError(crt, "Sai định dạng");
                                isTrue = false;
                            }
                            break;
                    }

                    if (string.IsNullOrEmpty(crt.Text))
                    {
                        _errorProvider.SetError(crt, "Không để trống dữ liệu");
                        isTrue = false;
                    }
                }
            }

            return isTrue;
        }

        private byte[] ImageToBytes(Image img)
        {
            if (img == null) return null;

            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private Image BytesToImage(byte[] bytes)
        {
            if (bytes == null) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void txt_MouseClick(object sender, MouseEventArgs e)
        {
            _errorProvider.SetError((TextBox)sender, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Utilities.ResetForm(this);
        }

        private void FrmStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FrmLogin().Show();
            this.Close();
        }
    }
}
