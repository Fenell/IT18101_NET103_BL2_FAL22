using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT.Models
{
    internal class ScoresService
    {
        private List<ScoresStudent> _lsScoresStudents;
        private StudentService _studentService;
        public ScoresService()
        {
            FakeData();
            _studentService = new StudentService();
        }

        public void FakeData()
        {
            _lsScoresStudents = new List<ScoresStudent>()
            {
                new ScoresStudent("PH1234", "Nguyễn Thành Vinh", "8.7", "7.5", "5.7", "4.4", 8),
                new ScoresStudent("PH24319", "Đặng Thái Sơn", "5.4", "7.6", "8", "5", 7.3),
                new ScoresStudent("PH25432", "Phạm Mai Anh", "7", "6.6", "7", "8.4", 8.9),
                new ScoresStudent("PH29375", "Mai Tuấn Đạt", "9.4", "9", "8.9", "8.5", 9.4),

            };
        }

        public List<ScoresStudent> GetlstScoresStudents()
        {
            return _lsScoresStudents;
        }

        public List<ScoresStudent> GetlstScoresStudents(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return _lsScoresStudents;
            }

            var lstTemp = _lsScoresStudents.Where(c => c.StudentId.ToLower().StartsWith(value.ToLower()) ||
                                                       c.StudentName.ToLower().StartsWith(value.ToLower())).ToList();
            return lstTemp;
        }
        public string AddScores(ScoresStudent scores)
        {
            if (scores == null)
            {
                return "Thêm không thành công";
            }
            _lsScoresStudents.Add(scores);
            return "Thêm thành công";
        }

        public string UpdateScores(ScoresStudent scores)
        {
            int index = _lsScoresStudents.FindIndex(c => c.StudentId == scores.StudentId);
            if (index == -1)
            {
                return "Sửa không thành công";
            }
            _lsScoresStudents[index] = scores;
            return "Sửa thành công";
        }

        public string DeleteScores(ScoresStudent scores)
        {
            int index = _lsScoresStudents.FindIndex(c => c.StudentId == scores.StudentId);
            if (index == -1)
            {
                return "Xóa không thành công";
            }
            _lsScoresStudents.RemoveAt(index);
            return "Xóa thành công";
        }

        public bool HasStudent(string studentId)
        {
            return _studentService.GetlstStudents().Any(c => c.ID.ToLower() == studentId.ToLower());
        }

        public bool HasScores(string studentId)
        {
            return _lsScoresStudents.Any(c => c.StudentId.ToLower() == studentId.ToLower());
        }

        public List<ScoresStudent> OrderByScores()
        {
            _lsScoresStudents.Sort();
            return _lsScoresStudents.OrderByDescending(c => c.ScoresCSharp2).ThenByDescending(c => c.ScoresSql2)
                .ThenByDescending(c => c.ScoresAgile).ToList();
        }
    }
}
