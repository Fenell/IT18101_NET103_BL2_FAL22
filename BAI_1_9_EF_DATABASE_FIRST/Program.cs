using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_9_EF_DATABASE_FIRST
{
    internal class Program
    {
        public static void Vidu1()
        {
            List<Sanpham> lsSanphams;
            //QlbhContext context = new QlbhContext();
            //sanphams = context.Sanphams.ToList();
            using (var context = new QlbhContext())
            {
                lsSanphams = context.Sanphams.ToList();
                //  Qua EF API => select * from ...
            }

            foreach (var x in lsSanphams)
            {
                Console.WriteLine(string.Format("{0, -55} {1, -10} {2, -10} {3, -10} {4, -10}", x.TenSanpham, x.DanhmucID, x.CungcapID, x.Donvi, x.Gia));
            }
        }

        public static void Vidu2()
        {
            var rs = new List<SanPhamViewDto>();
            using (var context = new QlbhContext())
            {
                rs = context.Sanphams
                    .Join(context.Cungcaps, sanpham => sanpham.CungcapID, cungcap => cungcap.CungcapID, (sanpham, cungcap) => new { sanpham, cungcap }).Join(
                        context.Danhmucs, a => a.sanpham.DanhmucID, danhmuc => danhmuc.DanhmucID, (a, b) => new SanPhamViewDto
                        {
                            TenSanpham = a.sanpham.TenSanpham,
                            Tendaydu = a.cungcap.Tendaydu,
                            TenDanhMuc = b.TenDanhMuc,
                            Gia = a.sanpham.Gia,
                            Donvi = a.sanpham.Donvi
                        }).ToList();
            }

            foreach (var x in rs)
            {
                Console.WriteLine(string.Format("{0, -55} {1, -25} {2, -20} {3, -10} {4, -10}", x.TenSanpham, x.Tendaydu, x.TenDanhMuc, x.Donvi, x.Gia));
            }
        }

        public static void Vidu3()
        {
            //Thêm mới sản phẩm
            using (var  context = new QlbhContext())
            {
                //Lay nha cung cap
                var cungCapId = context.Cungcaps.Where(c => c.Tendaydu.Contains("Trần Chí Kha")).Select(c=>c.CungcapID).FirstOrDefault();
                //Lay Id danh muc
                var danhMucId = context.Danhmucs.Where(c => c.TenDanhMuc.Equals("Ngũ cốc")).Select(c => c.DanhmucID)
                    .FirstOrDefault();
                //Tạo mới 1 entity
                Sanpham sp = new Sanpham()
                {
                    //San phẩm ID lad primary key database tự gen không set data
                    TenSanpham = "Gạo lứt",
                    CungcapID = cungCapId,
                    DanhmucID = danhMucId,
                    Donvi = "Gói",
                    Gia = 12000
                };
                //add vào db set
                context.Sanphams.Add(sp);
                //Lưu vào database
                context.SaveChanges();
            }
        }

        public static void Vidu4()
        {
            using (var context = new QlbhContext())
            {
                var sanpham = context.Sanphams.FirstOrDefault();
                sanpham.TenSanpham = "Sửa tên này";
               //Lưu vào database
                context.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Vidu2();
        }
    }
}
