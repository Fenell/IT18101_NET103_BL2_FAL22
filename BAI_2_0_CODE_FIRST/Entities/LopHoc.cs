using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_CODE_FIRST.Entities
{
    public class LopHoc
    {
        public int LopHocId { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }

        public virtual List<SinhVien> SinhViens { get; set; }
    }
}
