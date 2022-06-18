using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaffMicroservice.Model;
using StaffMicroservice.Repo;
using System.Collections;
using System.Linq;

namespace StaffMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffRepository staffRepository;
        public StaffController(IStaffRepository _staffRepository)
        {
            staffRepository = _staffRepository;
        }

        [HttpGet]
        public IEnumerable Get()
        {
            return staffRepository.GetAllStaffs();
        }

        [HttpGet("{id}")]
        public ActionResult GetStaff(int id)
        {
            var staff = staffRepository.GetAllStaffs().Where(x => x.StaffId == id);
            return staff.Any() ? new ObjectResult(staff)
                : new NotFoundObjectResult("Not found");
        }
    }
}
