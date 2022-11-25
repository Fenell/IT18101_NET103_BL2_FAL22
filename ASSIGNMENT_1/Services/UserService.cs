using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASSIGNMENT_1.Context;
using ASSIGNMENT_1.Models;

namespace ASSIGNMENT_1.Services
{
    internal class UserService
    {
        DaoTaoContext _daoTaoContext;
        public UserService()
        {
            _daoTaoContext = new DaoTaoContext();
        }

        public List<Role> GetAllRoles()
        {
            return _daoTaoContext.Roles.ToList();
        }

        public List<User> GetAllUsers()
        {
            return _daoTaoContext.Users.ToList();
        }

        public bool Login(string acc, string pass)
        {
            return  GetAllUsers().Any(c => c.UserName == acc && c.Password == pass);
        }

        public string CheckAcces(string acc)
        {
            var user = GetAllUsers().FirstOrDefault(c=>c.UserName == acc);
            var name = GetAllRoles().FirstOrDefault(c => c.RoleId == user.RoleId).RoleName;
            return name;
        }

    }
}
