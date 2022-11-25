using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_EF_FULENT_API.Entities
{
    internal class EduCenter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        //nav

        public virtual ICollection<Student> Students { get; set; }
    }
}
