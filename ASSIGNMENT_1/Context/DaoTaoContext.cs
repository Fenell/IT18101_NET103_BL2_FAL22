using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ASSIGNMENT_1.Models;

namespace ASSIGNMENT_1.Context
{
    public partial class DaoTaoContext : DbContext
    {
        public DaoTaoContext()
        {
        }

        public DaoTaoContext(DbContextOptions<DaoTaoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Scores> Scores { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CFK23F4\\SQLEXPRESS;Initial Catalog=FPL_DAOTAO;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLES");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<Scores>(entity =>
            {
                entity.ToTable("SCORES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Agile).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.Csharp3)
                    .HasColumnType("decimal(3, 1)")
                    .HasColumnName("CSharp3");

                entity.Property(e => e.English).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.MaSv).HasMaxLength(50);

                entity.Property(e => e.SqlServer).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.MaSvNavigation)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.MaSv)
                    .HasConstraintName("FK__SCORES__MaSv__5AEE82B9");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.MaSv);

                entity.ToTable("STUDENTS");

                entity.Property(e => e.MaSv).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("USERS");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__USERS__RoleID__534D60F1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
