using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentWebApplication.Models
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
        {
        }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StudentInfo> StudentInfo { get; set; }

        // Unable to generate entity type for table 'dbo.Table_1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Table_bootcamp'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Student;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentInfo>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("student_info");

                entity.Property(e => e.StudentId).HasColumnName("student_id");

                entity.Property(e => e.StudentAge).HasColumnName("student_age");

                entity.Property(e => e.StudentGender)
                    .HasColumnName("student_gender")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasColumnName("student_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
