using Microsoft.AspNetCore.Mvc;
using SchoolAPI.ViewModel;

namespace SchoolAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolController : ControllerBase
    {

        [HttpGet("students")]
        public IActionResult GerStudens()
        {
            return Ok(GetMockStudents());
        }

        [HttpGet("teachers")]
        public IActionResult GerTeachers()
        {
            return Ok(GetMockTeachers());
        }

        private IEnumerable<StudentVM> GetMockStudents()
        {
            return new List<StudentVM>
                   {
                       new StudentVM { Id = Guid.NewGuid(), Name = "João Silva", Age = 20, Course = "Engenharia", Score = 85 },
                       new StudentVM { Id = Guid.NewGuid(), Name = "Maria Oliveira", Age = 22, Course = "Direito", Score = 91 },
                       new StudentVM { Id = Guid.NewGuid(), Name = "Carlos Santos", Age = 19, Course = "Administração", Score = 76 },
                       new StudentVM { Id = Guid.NewGuid(), Name = "Ana Souza", Age = 21, Course = "Medicina", Score = 89 },
                       new StudentVM { Id = Guid.NewGuid(), Name = "Pedro Lima", Age = 23, Course = "Arquitetura", Score = 68 },
                       new StudentVM { Id = Guid.NewGuid(), Name = "Pedro Lima", Age = 23, Course = "Arquitetura", Score = 68 }
                   };
        }

        private IEnumerable<TeacherVM> GetMockTeachers()
        {
            return new List<TeacherVM>
                   {
                       new TeacherVM { Id = Guid.NewGuid(), Name = "Professor Marcos", Course = "Matemática", Salary = 8000.50m },
                       new TeacherVM { Id = Guid.NewGuid(), Name = "Dra. Helena", Course = "Biologia", Salary = 9500.00m },
                       new TeacherVM { Id = Guid.NewGuid(), Name = "Sr. Ricardo", Course = "História", Salary = 7200.75m },
                       new TeacherVM { Id = Guid.NewGuid(), Name = "Profa. Juliana", Course = "Física", Salary = 8800.00m },
                       new TeacherVM { Id = Guid.NewGuid(), Name = "Dr. Eduardo", Course = "Química", Salary = 9100.25m }
                   };
        }
    }
}