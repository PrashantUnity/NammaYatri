using System.ComponentModel.DataAnnotations;

namespace NammaYatri.Shared
{
	public class Customer
	{
		[Key]
		[Required]
		public string Id { get; set; } = string.Empty;
		[Required, MaxLength(30), MinLength(1)]
		public string FirstName { get; set; } = "Prashant";

		[MaxLength(30)]
		public string LastName { get; set; } = "Priyadarshi";
		[Required, MaxLength(10)]
		public string PhoneNumber { get; set; }
		[Required]
		public string CountryCode { get; set; }
	}
}
