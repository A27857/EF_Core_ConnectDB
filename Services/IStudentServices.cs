using System.Collections.Generic;
using EF_Core_1v7v21.Models;

public interface IStudentServices
{
    List<Student> GetStudents();
    Student GetStudent(int id);
    List<Student> CreateStudent(Student student);
    List<Student> EditStudent(Student student);
    List<Student> Delete(int id);
}