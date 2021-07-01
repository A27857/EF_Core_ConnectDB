using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_1v7v21.Models
{
    [Table("Student")]
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { set; get; }
    }
}