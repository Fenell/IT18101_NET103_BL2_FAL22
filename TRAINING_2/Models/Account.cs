using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TRAINING_2.Models
{
    [Table("Account")]
    public partial class Account
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Acc { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Pass { get; set; }
        [Column("RoleID")]
        public Guid? RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("Accounts")]
        public virtual Role? Role { get; set; }
    }
}
