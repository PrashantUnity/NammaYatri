using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NammaYatri.Server.Database;
using NammaYatri.Shared;

namespace NammaYatri.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly IRepository repository;

        public TicketsController(IRepository repository)
        {
            this.repository = repository;
        }
        // GET api/<TicketsController>/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Order>> Get( string id)
        {
            var ls = repository.GetAllOrders(id);
            return Ok(ls);
        }
    }
}
