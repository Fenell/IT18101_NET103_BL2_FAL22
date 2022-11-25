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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ASSIGNMENT_1.View
{
    public partial class FrmScores : Form
    {
        private ScoresService _scoresService;
        private StudentService _studentService;
        private ErrorProvider _errorProvider;
        private string _maSvWhenClick;
        public FrmScores()
        {
            InitializeComponent();
            _scoresService = new ScoresService();
            _studentService = new StudentService();
            _errorProvider = new ErrorProvider();
            LoadData(null);
            DisableForm();
            this.CenterToScreen();
        }

        private void LoadData(string value)
        {
            dgridScores.ColumnCount = 5;
            dgridScores.Columns[0].Name = "Mã sinh viên";
            dgridScores.Columns[1].Name = "C#3";
            dgridScores.Columns[2].Name = "Sql Server";
            dgridScores.Columns[3].Name = "Agile";
            dgridScores.Columns[4].Name = "English";
            dgridScores.Rows.Clear();
            if (value == "orderby")
            {
                foreach (var x in _scoresService.OrderBy())
                {
                    dgridScores.Rows.Add(x.MaSv, x.Csharp3, x.SqlServer, x.Agile, x.English);
                }
                return;
            }
            foreach (var x in _scoresService.GetAll(value))
            {
                dgridScores.Rows.Add(x.MaSv, x.Csharp3, x.SqlServer, x.Agile, x.English);
            }
        }

        private Scores GetDataFromGui()
        {
            return new Scores()
            {
                MaSv = lblMaSv.Text,
                Csharp3 = Utilities.NullIfEmpty(txtScoresCSharp3.Text),
                SqlServer = Utilities.NullIfEmpty(txtScoresSql.Text),
                Agile = Utilities.NullIfEmpty(txtScoresAgile.Text),
                English = Utilities.NullIfEmpty(txtScoresEnglish.Text)
            };
        }

        private void txtSearchMaSv_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearchMaSv.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!_studentService.HasStudent(txtSearchMaSv.Text))
            {
                MessageBox.Show("Không tìm thấy sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblNameStudent.Text = _studentService.GetAll().FirstOrDefault(c => c.MaSv.ToLower() == txtSearchMaSv.Text.ToLower()).Name;

            lblMaSv.Text = _studentService.GetAll().FirstOrDefault(c => c.MaSv.ToLower() == txtSearchMaSv.Text.ToLower()).MaSv;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Utilities.ResetForm(this);
            if (!ValidationFrom())
            {
                MessageBox.Show("Kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (_scoresService.HasScores(lblMaSv.Text))
            {
                MessageBox.Show("Sinh viên đã có điểm", "Thông báo");
                return;
            }
            var scores = GetDataFromGui();
            MessageBox.Show(_scoresService.AddScores(scores), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData(null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var scores = GetDataFromGui();
            scores.Id = _scoresService.GetAll(null).Where(c => c.MaSv == _maSvWhenClick).Select(c => c.Id).FirstOrDefault();

            if (MessageBox.Show("Bạn có muốn sửa điểm sinh viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_scoresService.UpdateScores(scores), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData("orderby");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var scores = GetDataFromGui();
            scores.Id = _scoresService.GetAll(null).Where(c => c.MaSv == _maSvWhenClick).Select(c => c.Id).FirstOrDefault();

            if (MessageBox.Show("Bạn có muốn xóa điểm sinh viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_scoresService.RemoveScores(scores), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(null);
            }
        }

        private void dgridScores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index == -1 || index == dgridScores.Rows.Count - 1)
            {
                return;
            }

            _maSvWhenClick = dgridScores.Rows[index].Cells[0].Value.ToString();
            var scores = _scoresService.GetAll(null).FirstOrDefault(c => c.MaSv == _maSvWhenClick);
            txtScoresCSharp3.Text = scores.Csharp3.ToString();
            txtScoresSql.Text = scores.SqlServer.ToString();
            txtScoresAgile.Text = scores.Agile.ToString();
            txtScoresEnglish.Text = scores.English.ToString();
            lblMaSv.Text = scores.MaSv;
            lblNameStudent.Text = _studentService.GetAll().FirstOrDefault(c => c.MaSv == _maSvWhenClick).Name;
            lblScores.Text = AverageScores().ToString();
        }

        private double AverageScores()
        {
            var num1 = Utilities.ZeroIfNull(txtScoresCSharp3.Text);
            var num2 = Utilities.ZeroIfNull(txtScoresSql.Text);
            var num3 = Utilities.ZeroIfNull(txtScoresAgile.Text);
            var num4 = Utilities.ZeroIfNull(txtScoresEnglish.Text);
            return Math.Round((num1 + num2 + num3 + num4) / 4, 1);
        }

        private bool ValidationFrom()
        {
            bool isTrue = true;
            foreach (Control crt in this.grboxScores.Controls)
            {
                if (crt is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(crt.Text))
                    {
                    }
                    else
                    {
                        if (!Validation.IsScores(crt.Text))
                        {
                            isTrue = false;
                            _errorProvider.SetError(crt, "Chỉ được nhập ký tự số");
                        }
                        else
                        {
                            if (0 > double.Parse(crt.Text) || double.Parse(crt.Text) > 10)
                            {
                                isTrue = false;
                                _errorProvider.SetError(crt, "Nhập điểm trong khoảng 0 - 10");
                            }
                        }
                    }
                }
            }

            return isTrue;
        }

        private void DisableForm()
        {
            foreach (Control crt in grboxScores.Controls)
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
            lblMaSv.Text = "";
            Utilities.ResetForm(this);
            LoadData(null);
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            Utilities.ResetForm(this);
        }

        private void FrmScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmScores_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FrmLogin().Show();
            this.Close();
        }
    }
}
