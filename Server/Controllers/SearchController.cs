using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NammaYatri.Server.Database;
using NammaYatri.Shared;

namespace NammaYatri.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IRepository repository;

        public SearchController(IRepository repository)
        {
            this.repository = repository;
        }

        // GET api/Search/
        [HttpGet]
        public ActionResult<IEnumerable<AvailableVehicle>> Get([FromQuery] SearchVehicle searchVehicle)
        {
            return Ok(repository.GetAvailableVehicle(searchVehicle));
        }
    }
}
