using ASSIGNMENT.Models;
using ASSIGNMENT.Utility;

namespace ASSIGNMENT.View
{
    public partial class FrmScoresService : Form
    {
        private ScoresService _scoresService;
        private StudentService _studentService;
        private string _studentIdWhenClick;
        private ErrorProvider _errorProvider;

        public FrmScoresService()
        {
            InitializeComponent();
            this.CenterToScreen();
            _scoresService = new ScoresService();
            _studentService = new StudentService();
            _errorProvider = new ErrorProvider();
            DisableForm();
            LoadData(null);
        }

        private void LoadData(string value)
        {
            

            dgridScores.ColumnCount = 7;
            dgridScores.Columns[0].Name = "Mã SV";
            dgridScores.Columns[1].Name = "Họ tên";
            dgridScores.Columns[1].Width = 120;
            dgridScores.Columns[2].Name = "C#2";
            dgridScores.Columns[3].Name = "Sql Server";
            dgridScores.Columns[4].Name = "Agile";
            dgridScores.Columns[5].Name = "Tiếng Anh";
            dgridScores.Columns[6].Name = "Điểm TB";
            dgridScores.Rows.Clear();

            if (value == "Orderby")
            {
                lblOrderby.Visible = true;
                foreach (var x in _scoresService.OrderByScores())
                {
                    dgridScores.Rows.Add(x.StudentId, x.StudentName, x.ScoresCSharp2, x.ScoresSql2, x.ScoresAgile,
                        x.ScoresEnglish21, x.AverageScore);
                }
            }

            foreach (var t in _scoresService.GetlstScoresStudents(value))
            {
                dgridScores.Rows.Add(t.StudentId, t.StudentName, t.ScoresCSharp2, t.ScoresSql2, t.ScoresAgile, t.ScoresEnglish21, t.AverageScore);
            }

        }

        private ScoresStudent GetDataFromGui()
        {
            return new ScoresStudent(txtMaSv.Text, lblNameStudent.Text, txtScoresCSharp2.Text, txtScoresSql.Text, txtScoresAgile.Text, txtScoresEnglish.Text, AverageToTxtValue());
        }

        private void txtSearchMaSv_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearchMaSv.Text);
        }

        private void dgridScores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == _scoresService.GetlstScoresStudents().Count || index == -1)
                return;
            _studentIdWhenClick = dgridScores.Rows[index].Cells[0].Value.ToString();
            var student = _scoresService.GetlstScoresStudents().FirstOrDefault(c => c.StudentId == _studentIdWhenClick);
            lblNameStudent.Text = student.StudentName;
            txtMaSv.Text = student.StudentId;
            txtScoresCSharp2.Text = student.ScoresCSharp2.ToString();
            txtScoresSql.Text = student.ScoresSql2.ToString();
            txtScoresAgile.Text = student.ScoresAgile.ToString();
            txtScoresEnglish.Text = student.ScoresEnglish21.ToString();
            lblScores.Text = student.AverageScore.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!(_scoresService.HasStudent(txtSearchMaSv.Text)))
            {
                MessageBox.Show("Không tìm thấy sinh viên", "Thông báo");
                return;
            }
            var student = _studentService.FindStudent(txtSearchMaSv.Text);
            Utilities.ResetAllControl(this);
            lblNameStudent.Text = student.Name;
            txtMaSv.Text = student.ID;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidationForm())
            {
                MessageBox.Show("Kiểm tra lại dữ liệu", "Thông báo");
                return;
            }
            var student = GetDataFromGui();
            if (_scoresService.HasScores(student.StudentId))
            {
                MessageBox.Show("Sinh viên đã có điểm", "Thông báo");
                return;
            }
            lblScores.Text = AverageToTxtValue().ToString();
            MessageBox.Show(_scoresService.AddScores(student), "Thông báo");
            LoadData(null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidationForm())
            {
                MessageBox.Show("Kiểm tra lại dữ liệu", "Thông báo");
                return;
            }
            var scores = GetDataFromGui();
            lblScores.Text = AverageToTxtValue().ToString();
            MessageBox.Show(_scoresService.UpdateScores(scores), "Thông báo");
            LoadData("Orderby");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ValidationForm())
            {
                MessageBox.Show("Kiểm tra lại dữ liệu", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa sinh viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var scores = GetDataFromGui();
                MessageBox.Show(_scoresService.DeleteScores(scores), "Thông báo");
                LoadData(null);
            }
        }

        private bool ValidationForm()
        {
            bool isTrue = true;
            foreach (Control crt in this.groupBox2.Controls)
            {
                if (crt is TextBox)
                {
                    if (crt == txtScoresAgile || crt == txtScoresCSharp2 || crt == txtScoresSql || crt == txtScoresEnglish)
                    {
                        if (string.IsNullOrEmpty(crt.Text))
                        {
                            crt.Text = "";
                        }
                        else
                        {
                            if (!Validation.isScores(crt.Text))
                            {
                                _errorProvider.SetError(crt, "Nhập ký tự số");
                                isTrue = false;
                            }
                            else if (0 > Convert.ToDouble(crt.Text) || Convert.ToDouble(crt.Text) > 10)
                            {
                                _errorProvider.SetError(crt, "Nhập điểm trong khoảng 0-10");
                                isTrue = false;
                            }
                        }
                    }
                }
            }

            return isTrue;
        }

        private double AverageToTxtValue()
        {
            double scoresCsharp, scoresAgile, scoresSql, scoresEnglish;
            double.TryParse(txtScoresCSharp2.Text, out scoresCsharp);
            double.TryParse(txtScoresAgile.Text, out scoresAgile);
            double.TryParse(txtScoresSql.Text, out scoresSql);
            double.TryParse(txtScoresEnglish.Text, out scoresEnglish);

            return Math.Round((scoresCsharp + scoresAgile + scoresSql + scoresEnglish) / 4, 1);
        }

        private void txtScores_Changed(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            _errorProvider.SetError(txt, null);
        }

        private void DisableForm()
        {
            foreach (Control crt in groupBox2.Controls)
            {
                if (crt is TextBox)
                {
                    crt.Enabled = false;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblScores.Text = "";
            lblNameStudent.Text = "";
            Utilities.ResetAllControl(this);
            LoadData(null);
        }
    }
}
