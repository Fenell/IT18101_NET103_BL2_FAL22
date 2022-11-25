using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT.Models
{
    internal class StudentService
    {
        List<Student> _lstStudents;
        public StudentService()
        {
            _lstStudents = new List<Student>()
            {
                new Student("PH1234", "Nguyễn Thành Vinh", "vinhntph1234@fpt.edu.vn", "093812345", 0, "Phú Thọ"),
                new Student("PH29375", "Mai Tuấn Đạt", "datmtph29475@fpt.edu.vn", "0392132059", 0, " Thái Bình"),
                new Student("PH29321", "Nguyễn Thị Hương", "huongntph29321@fpt.edu.vn", "0293842123", 1, "Nam Định"),
                new Student("PH27934", "Lê Minh Chiến", "chienlmph27934@fpt.edu.vn", "0392134565", 0, "Hà Nam"),
                new Student("PH28032", "Ngô Thùy Linh", "linhntph28032@fpt.edu.vn", "0921345367", 1, "Hà Nội"),
                new Student("PH24319", "Đặng Thái Sơn", "sondtph24319@fpt.edu.vn", "092483234", 0, "Thái Bình"),
                new Student("PH25432", "Phạm Mai Anh", "anhpmph25432@fpt.edu.vn", "0349212345", 1, "Hà Nội"),
            };
        }

        public List<Student> GetlstStudents()
        {
            return _lstStudents;
        }

        public string AddStudent(Student student)
        {
            if (student == null)
            {
                return "Thêm thất bại";
            }
            _lstStudents.Add(student);
            return "Thêm thành công";
        }

        public string UpdateStudent(Student student)
        {
            int index = _lstStudents.FindIndex(c => c.ID == student.ID);
            _lstStudents[index] = student;
            return "Sửa thành công";
        }

        public string DeleteSudent(Student student)
        {
            int index = _lstStudents.FindIndex(c => c.ID == student.ID);
            _lstStudents.RemoveAt(index);
            return "Xóa thành công";
        }

        public Student FindStudent (string str)
        {
            var student = _lstStudents.FirstOrDefault(c => c.ID.ToLower() == str.ToLower());
            return student;
        }

        public bool HasStudent(string studentId)
        {
            return _lstStudents.Any(c => c.ID == studentId);
        }
    }
}
