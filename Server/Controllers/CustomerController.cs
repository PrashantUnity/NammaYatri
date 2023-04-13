using Microsoft.AspNetCore.Mvc;
using NammaYatri.Server.Database;
using NammaYatri.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NammaYatri.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly IRepository repository;

		public CustomerController(IRepository repository)
		{
			this.repository = repository;
		}  
		// POST api/<CustomerController>
		[HttpPost]
		public void Post(Customer customer)
		{
			repository.AddCustomer(customer);
		}

	}
}
