using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentMicroservice.Model;
using StudentMicroservice.Repo;
using System.Collections;
using System.Linq;

namespace StudentMicroservice.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        public StudentController(IStudentRepository _studentRepository)
        {
            studentRepository = _studentRepository;
        }

        [HttpGet]
        public IEnumerable Get()
        {
            return studentRepository.GetAllStudent();
        }

        [HttpGet("{id}")]
        public ActionResult GetStudent(int id)
        {
            var student = studentRepository.GetAllStudent().Where(x => x.Id == id);
            return student.Any() ? new ObjectResult(student)
                : new NotFoundObjectResult("Not found");
        }
    }
}
