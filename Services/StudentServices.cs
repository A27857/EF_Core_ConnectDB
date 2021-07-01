using System.Collections.Generic;
using System.Linq;

namespace EF_Core_1v7v21.Models
{
    public class StudentServices : IStudentServices
    {
        public StudentContext _student;
        public StudentServices(StudentContext student)
        {
            _student = student;
        }
        public Student GetStudent(int id)
        {
            return _student.Student.FirstOrDefault(s => s.StudentId == id);
        }

        public List<Student> GetStudents()
        {
            return _student.Student.ToList();
        }

        public List<Student> CreateStudent(Student student)
        {
            _student.Add(student);
            _student.SaveChanges();
            return GetStudents();
        }
        public List<Student> EditStudent(Student student)
        {
            _student.Update(student);
            //_student.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return GetStudents();
        }

        public List<Student> Delete(int id)
        {
            var studenTemp = GetStudent(id);
            _student.Remove(studenTemp);
            _student.SaveChanges();
            return GetStudents();
        }
    }
}