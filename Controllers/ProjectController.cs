using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all projects");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading project with #{id}");
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok("Create the project");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id)
        {
            return Ok($"Updating the project #{id}");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting project #{id}");
        }

        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectTicket(int pid, [FromQuery] int tid)
        {
            return Ok($"Reading tickets #{tid}, in project #{pid}");
        }
    }
}