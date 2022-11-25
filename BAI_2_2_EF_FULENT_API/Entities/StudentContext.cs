using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_EF_FULENT_API.Entities
{
    internal class StudentContext:DbContext
    {
        public StudentContext(): base()
        {

        }

        // Entity Config
        ///     + ToTable: set table name trong DB
        ///     + haskey: set Primary key
        ///     + hasForeignKey: set ForeignKey
        ///     + HasMany()
        ///     withRequired()
        ///     +hasOptional()
        ///     withOptional()
        ///Properties Config
        /// + HasColumnName: set Column name
        /// + hasColumnOrder: set thứ tự cho cột trong table
        /// + hasColumnType: set datatype cho cột
        /// + hasDatageneratedType: set kiểu gen data cho cột
        /// + hasMaxLength():
        /// + IsOptional()
        /// + IsRequired()
        /// </summary>
        /// <param name="modelBuilder"></param>

        public DbSet<Course> courses { get; set; }
        public DbSet<Student> student { get; set; }
        public DbSet<StudentContact> StudentContacts;
    }
}
