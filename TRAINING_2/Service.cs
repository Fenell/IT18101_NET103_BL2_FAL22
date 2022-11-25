using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRAINING_2.Context;
using TRAINING_2.Models;

namespace TRAINING_2
{
    internal class Service
    {
        private List<Account> _lstAccounts;
        private List<Role> _lstRoles;
        DBContext _dbContext;
        public Service()
        {
            _dbContext = new DBContext();
            _lstAccounts = new List<Account>();
            _lstRoles = new List<Role>();
            GetlstAccountFromDb();
            GetlstRoleFromDb();
        }

        public void GetlstRoleFromDb()
        {
            _lstRoles = _dbContext.Roles.AsNoTracking().ToList();
        }

        public List<Role> GetlstRoles()
        {
            return _lstRoles;
        }

        public void GetlstAccountFromDb()
        {
            _lstAccounts = _dbContext.Accounts.AsNoTracking().ToList();
        }

        public List<Account> GetlstAccounts()
        {
            return _lstAccounts;
        }

        public List<Account> GetlstAccounts(string? acc)
        {
            if (acc == null)
            {
                return GetlstAccounts();
            }
            return _lstAccounts.Where(c => c.Acc.StartsWith(acc)).ToList();
        }

        public string Add(Account acc)
        {
            _dbContext.Accounts.Add(acc);
            _dbContext.SaveChanges();
            return "Thêm thành công";
        }

        public string Update(Account acc)
        {
            _dbContext.Accounts.Update(acc);
            _dbContext.SaveChanges();
            return "Sửa thành công";
        }

        public string Delete(Account acc)
        {
            _dbContext.Accounts.Remove(acc);
            _dbContext.SaveChanges();
            return "Xóa thành công";
        }

        public bool CheckAcc(string acc)
        {
            int index = _lstAccounts.FindIndex(c => c.Acc == acc);
            if (index == -1) return true;
            return false;
        }
       
    }
}
