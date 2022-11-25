using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TRAINING_3.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("Role")]
        [StringLength(50)]
        public string? Role1 { get; set; }

        [InverseProperty("Role")]
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
