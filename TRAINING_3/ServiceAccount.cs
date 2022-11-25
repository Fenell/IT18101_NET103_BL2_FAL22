using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAINING_3.Context;
using TRAINING_3.Models;

namespace TRAINING_3
{
    internal class ServiceAccount
    {
        private DBContext _dbContext;
        private List<Account> _lsAccounts;
        List<Role> _lsRoles;

        public ServiceAccount()
        {
            _dbContext = new DBContext();
            _lsAccounts = new List<Account>();
            _lsRoles = new List<Role>();
            GetDataFromDb();
            GetAllRolesFromDb();
        }

        public List<Account> GetAllAccount()
        {
            return _lsAccounts;
        }

        public void GetDataFromDb()
        {
            _lsAccounts = _dbContext.Accounts.ToList();
        }

        public List<Role> GetAllRoles()
        {
            return _lsRoles;
        }

        public void GetAllRolesFromDb()
        {
            _lsRoles = _dbContext.Roles.ToList();
        }

        public string AddAccount(Account acc)
        {
            acc.Id = Guid.NewGuid();
            _dbContext.Accounts.Add(acc);
            _dbContext.SaveChanges();
            return "Đăng ký thành công";
        }

    }
}
