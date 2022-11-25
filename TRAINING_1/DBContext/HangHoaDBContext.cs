using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRAINING_1.Models;

namespace TRAINING_1.DBContext
{
    internal class HangHoaDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CFK23F4\SQLEXPRESS;Initial Catalog=QL_HANG_HOA;User ID=dat09;Password=123");
        }

        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<Loai> Loais { get; set; }

    }
}
