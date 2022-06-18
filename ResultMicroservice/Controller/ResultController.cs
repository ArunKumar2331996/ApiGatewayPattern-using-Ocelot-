using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResultMicroservice.Repo;
using StudentMicroservice.Repo;
using System.Linq;
using System.Net.Http;

namespace ResultMicroservice.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly IResultRepo resultRepo;
        private readonly IStudentRepository studentRepository;
        public ResultController(IResultRepo _resultRepo, IStudentRepository _studentRepository)
        {
            resultRepo = _resultRepo;
            studentRepository = _studentRepository;
        }

        [HttpGet("{id}")]
        public ActionResult GetResult(int id)
        {
            var student = studentRepository.GetAllStudent().Where(x => x.Id == id).FirstOrDefault();
            var result = resultRepo.GetResults().Where(x => x.StudentId == id).FirstOrDefault();

            if (student != null && result != null)
            {

                var finalResult = new
                {
                    student.Name,
                    student.Department,
                    student.Id,
                    result.result
                };
                return new ObjectResult(finalResult);
            }
            else return new NotFoundObjectResult("Not Found");
        }
    }
}
