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
		[HttpGet]
		public ActionResult<IEnumerable<AvailableVehicle>> Get()
		{
			if(repository.LastSearch==null) return Ok(new List<AvailableVehicle>());
			return Ok(repository.GetAvailableVehicle());
		}
		// GET api/Search/
		[HttpPost]
		public IActionResult Post(SearchVehicle searchVehicle)
		{
			repository.LastSearch = searchVehicle;
			return Ok();
		}
	}
}
