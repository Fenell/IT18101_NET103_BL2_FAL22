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
    internal class ScoresService
    {
        DaoTaoContext _daoTaoContext;
        public ScoresService()
        {
            _daoTaoContext = new DaoTaoContext();
            GetAll();
        }

        public List<Scores> GetAll()
        {
            using (DaoTaoContext dbContext = new DaoTaoContext())
            {
                return dbContext.Scores.ToList();
            }
        }

        public List<Scores> GetAll(string value)
        {
            if (value == null)
            {
                return GetAll();
            }
            using (DaoTaoContext dbContext = new DaoTaoContext())
            {
                return dbContext.Scores.Where(c => c.MaSv.ToLower().StartsWith(value.ToLower())).ToList();
            }
        }

        public string AddScores(Scores scores)
        {
            if (scores == null)
            {
                return "Thêm không thành công";
            }

            using (DaoTaoContext context = new DaoTaoContext())
            {
                context.Scores.Add(scores);
                context.SaveChanges();
                return "Thêm thành công";
            }
        }

        public string RemoveScores(Scores scores)
        {
            if (scores == null)
            {
                return "Xóa không thành công";
            }

            using (DaoTaoContext context = new DaoTaoContext())
            {
                context.Scores.Remove(scores);
                context.SaveChanges();
                return "Xóa thành công";
            }
        }

        public string UpdateScores(Scores obj)
        {
            if (obj == null)
            {
                return "Sửa không thành công";
            }

            using (DaoTaoContext context = new DaoTaoContext())
            {
                 
                context.Scores.Update(obj);
                context.SaveChanges();
                return "Sửa thành công";
            }
        }


        public bool HasScores(string value)
        {
            return _daoTaoContext.Scores.Any(c => c.MaSv.ToLower() == value.ToLower());
        } 

        public List<Scores> OrderBy()
        {
            List<Scores> scores = new List<Scores>();
            List<Scores> temp = new List<Scores>();
            scores = _daoTaoContext.Scores.ToList();
            scores = scores.OrderByDescending(c => c.Csharp3).ToList();
            var scores1 = scores.FirstOrDefault();
            temp.Add(scores1);
            scores.RemoveAt(0);
            scores = scores.OrderByDescending(c => c.SqlServer).ToList();
            var  scores2 = scores.FirstOrDefault();
            temp.Add(scores2);
            scores.RemoveAt(0);
            scores = scores.OrderByDescending(c => c.Agile).ToList();
            var scores3 = scores.FirstOrDefault();
            temp.Add(scores3);
            return temp;
        }


    }
}
