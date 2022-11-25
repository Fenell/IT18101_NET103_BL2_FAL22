using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace TRAINING_3.Models
{
    [Table("Account")]
    public partial class Account
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Acc { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        [Required]
        public string Pass { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Column("RoleID")]
        public Guid? RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("Accounts")]
        public virtual Role? Role { get; set; }
    }
}
