using System.ComponentModel.DataAnnotations;

namespace NammaYatri.Shared
{
	public class Customer
	{
		[Key]
		public string Id { get; set; }
		[Required, MaxLength(30), MinLength(5)]
		public string FirstName { get; set; } = "Prashant";

		[Required, MaxLength(30), MinLength(5)]
		public string LastName { get; set; } = "Priyadarshi";
		[Required, MaxLength(10)]
		public string PhoneNumber { get; set; }
		[Required]
		public string CountryCode { get; set; }
	}
}
