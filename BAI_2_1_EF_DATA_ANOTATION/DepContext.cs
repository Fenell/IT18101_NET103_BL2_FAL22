using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_2_1_EF_DATA_ANOTATION.Entity;

namespace BAI_2_1_EF_DATA_ANOTATION
{
    internal class DepContext : DbContext
    {
        public DepContext() : base("DepartmentDB")
        {
            
        }

        public DbSet<Departmant> Departmants { get; set; }
        public DbSet<Employess> Employesses { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddress { get; set;}
        public DbSet<Team> Team { get; set; }
    }
}
