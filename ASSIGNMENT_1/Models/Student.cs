using System;
using System.Collections.Generic;

namespace ASSIGNMENT_1.Models
{
    public partial class Student
    {
        public Student()
        {
            Scores = new HashSet<Scores>();
        }

        public string MaSv { get; set; } = null!;
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? Sex { get; set; }
        public string? Address { get; set; }
        public byte[]? Picture { get; set; }

        public virtual ICollection<Scores> Scores { get; set; }
    }
}
