using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING_4
{
    internal class Company
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Sex { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }

        public Company()
        {
            
        }
    }
}
