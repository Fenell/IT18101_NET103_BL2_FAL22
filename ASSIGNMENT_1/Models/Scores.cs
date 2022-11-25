using System;
using System.Collections.Generic;

namespace ASSIGNMENT_1.Models
{
    public partial class Scores
    {
        public int Id { get; set; }
        public string? MaSv { get; set; }
        public decimal? Csharp3 { get; set; }
        public decimal? SqlServer { get; set; }
        public decimal? Agile { get; set; }
        public decimal? English { get; set; }

        public virtual Student? MaSvNavigation { get; set; }
    }
}
