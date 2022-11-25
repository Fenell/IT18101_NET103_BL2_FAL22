using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASSIGNMENT_1.Context;
using ASSIGNMENT_1.Models;
using Microsoft.EntityFrameworkCore;

namespace ASSIGNMENT_1.Services
{
    internal class StudentService
    {
        public StudentService()
        {
            GetAll();
        }

        public List<Student> GetAll()
        {
            using (var context = new DaoTaoContext())
            {
                return context.Students.ToList();
            }
        }

        public bool AddStudent(Student student)
        {
            if (student == null) return false;
            using (var context = new DaoTaoContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
            return true;
        }

        public bool UpdateStudent(Student student)
        {
            using (var context = new DaoTaoContext())
            {
                context.Students.Update(student);
                context.SaveChanges();
            }
            return true;
        }

        public bool DeleteStudent(Student student)
        {
            using (var context = new DaoTaoContext())
            {
                var scores = context.Scores.FirstOrDefault(c => c.MaSv == student.MaSv);
                if (scores != null)
                {
                    context.Scores.Remove(scores); 
                }
                context.Students.Remove(student);
                context.SaveChanges();
            }
            return true;
        }

        public bool HasStudent(string value)
        {
            using (DaoTaoContext dbContext = new DaoTaoContext())
            {
                return dbContext.Students.Any(c => c.MaSv.ToLower() == value.ToLower());
            }
        }
    }
}
