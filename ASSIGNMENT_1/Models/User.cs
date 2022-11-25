using System;
using System.Collections.Generic;

namespace ASSIGNMENT_1.Models
{
    public partial class User
    {
        public string UserName { get; set; } = null!;
        public string? Password { get; set; }
        public string? Email { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
    }
}
