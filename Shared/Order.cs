using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NammaYatri.Shared
{
	public class Order
	{
		[Key]
		public string Id { get; set; }
		public string CustomerId { get; set; }
		public string SearchVehicleId { get; set; }

		[ForeignKey("CustomerId")]
		public Customer CustomerData { get; set; }

		[ForeignKey("SearchVehicleId")]
		public SearchVehicle SearchVehicles { get; set; }
		public bool IsCancelled { get; set; } = false;

		public AvailableVehicle AvailableVehicles { get; set; }

	}
}
