using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_2_0_CODE_FIRST.Entities;

namespace BAI_2_0_CODE_FIRST
{
    internal class Program
    {
        public static void AdLopHoc()
        {
            LopHoc lopHoc = new LopHoc()
            {
                MaLop = "NET103",
                TenLop = "Lập trình C# 3"
            };
            using (var ctx = new LopHocContext())
            {
                ctx.lopHocs.Add(lopHoc);
                ctx.SaveChanges();          //Save database
            }

        }

        public static void AdSinhVien()
        {
            
            using (var ctx = new LopHocContext())
            {
                var lopHoc = ctx.lopHocs.FirstOrDefault();
                if (lopHoc != null)
                {
                    var sinhVien = new List<SinhVien>()
                    {
                        new SinhVien()
                        {
                            TenDayDu = "Sinh Vien 1",
                            GioiTinh = 1,
                            LopHocId = lopHoc.LopHocId,
                            DiaChi = "Thái BÌnh",
                            Tuoi = 20
                        },
                        new SinhVien()
                        {
                            TenDayDu = "Sinh Vien 2",
                            GioiTinh = 1,
                            LopHocId = lopHoc.LopHocId,
                            DiaChi = "Nam Định",
                            Tuoi = 19
                        },
                        new SinhVien()
                        {
                            TenDayDu = "Sinh Vien 3",
                            GioiTinh = 0,
                            LopHocId = lopHoc.LopHocId,
                            DiaChi = "Hà Nội",
                            Tuoi = 22
                        }
                    };
                    //Nếu add 1 object thì gọi method Add()
                    //Nếu add 1 conlection thì dùng method AddRange()
                    ctx.sinhViens.AddRange(sinhVien);
                }
                ctx.SaveChanges();

            }
        }

        public static void ShowData()
        {
            var lopHoc = new List<LopHoc>();
            var sinhViens = new List<SinhVien>();
            using (var ctx = new LopHocContext())
            {
                //Lazy loading
                //Dynamic Proxies
                lopHoc = ctx.lopHocs.ToList();
                sinhViens = ctx.sinhViens.ToList();
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            //AdLopHoc();
            //AdSinhVien();
        }
    }
}
