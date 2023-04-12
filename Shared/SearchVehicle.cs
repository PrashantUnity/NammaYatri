using System.ComponentModel.DataAnnotations;

namespace NammaYatri.Shared
{
	public class SearchVehicle
	{
		[Key]
		public string Id { get; set; }
		public DateTime OnWhichDate = DateTime.Now;

		[Required]
		public string LocationFrom { get; set; } = "";
		[Required]
		public string LocationTo { get; set; } = "";
	}
}
