using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all Tickets");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading tickets #{id}");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, string author)
        {
            return Ok($"Updating Ticket #{id} by {author}");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Create the tickets");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Ticket {id} was deleted");
        }
    }
}