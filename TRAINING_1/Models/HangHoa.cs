using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING_1.Models
{
    [Table("HangHoa")]
    internal class HangHoa
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(100)]
        [Required]
        public string TenHH { get; set; }
        public string MoTa { get; set; }
        public double DonGia { get; set; }

        public Guid? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; }
    }
}
