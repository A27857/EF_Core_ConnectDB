using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_1v7v21.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        // Identity Columns
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string City { set; get; }
        public string State { set; get; }
    }
}