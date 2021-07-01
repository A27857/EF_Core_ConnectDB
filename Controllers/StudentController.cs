using System.Collections.Generic;
using System.Linq;
using EF_Core_1v7v21.Models;
using Microsoft.AspNetCore.Mvc;
namespace EF_Core_1v7v21.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentServices _students;
        public StudentController(IStudentServices student)
        {
            _students = student;
        }

        [HttpGet("listStudent")]
        public List<Student> GetStudents()
        {
            var list = _students.GetStudents();
            return list;
        }

        [HttpGet("{id}")]
        public Student GetStudent(int id)
        {
            return _students.GetStudent(id);
        }

        [HttpPost]
        public List<Student> CreateStudent(Student student)
        {
            return _students.CreateStudent(student);
        }

        [HttpPut]
        public List<Student> EditStudent(Student student)
        {
            return _students.EditStudent(student);
        }

        [HttpDelete("{id}")]
        public List<Student> Delete(int id)
        {
            return _students.Delete(id);
        }
    }
}