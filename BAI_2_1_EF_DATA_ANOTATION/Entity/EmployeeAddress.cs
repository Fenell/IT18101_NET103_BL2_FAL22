using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_EF_DATA_ANOTATION.Entity
{
    internal class EmployeeAddress
    {
        //Mỗi Employess chỉ có 1 địa chỉ
        [Key, ForeignKey("Employee")]
        public int EmployessId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }

        //Navigation Properties
    }
}
