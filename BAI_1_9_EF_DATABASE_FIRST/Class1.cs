using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_9_EF_DATABASE_FIRST
{
    internal class SanPhamViewDto
    {
        public string TenSanpham { get; set; }
        public string Tendaydu { get; set; }
        public string TenDanhMuc { get; set; }
        public decimal? Gia { get; set; }
        public string Donvi { get; set; }
    }
}
