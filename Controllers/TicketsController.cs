using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        [Route("api/tickets")]
        public IActionResult Get()
        {
            return Ok("Reading all Tickets");
        }

        [HttpGet]
        [Route("api/tickets/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading tickets #{id}");
        }

        [HttpPut]
        [Route("api/tickets/{id}")]
        public IActionResult Put(int id)
        {
            return Ok($"Updating Ticket #{id}");
        }

        [HttpPost]
        [Route("api/tickets")]
        public IActionResult Post()
        {
            return Ok("Create the tickets");
        }

        [HttpDelete]
        [Route("api/tickets/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Ticket {id} was deleted");
        }
    }
}