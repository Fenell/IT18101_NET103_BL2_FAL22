using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_CODE_FIRST.Entities
{
    public class LopHocContext : DbContext
    {
        //Ctor truyền vào base class "name=[Tên connection string]"
        //Tên connection string sẽ khai báo trong App.Config

        public LopHocContext() : base("name=LopHocConnection")
        {
            // Tọa ra database nếu như chưa tồn tại
            Database.SetInitializer<LopHocContext>(new CreateDatabaseIfNotExists<LopHocContext>());
        }

        public DbSet<LopHoc> lopHocs { get; set; }
        public DbSet<SinhVien> sinhViens { get; set; }
    }
}
