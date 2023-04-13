using NammaYatri.Shared; 
using System.Text;
using System.Text.Json;

namespace NammaYatri.Client.Service
{
	public class CurrentContextData
	{ 
		public Customer Customers { get; set; } =
			new Customer()
			{
				FirstName = "Prashant",
				LastName = "Priyadarshi",
				CountryCode = "91",
				PhoneNumber = "1234567890"
			};
		public Customer GetCustomer(Customer customer)
		{
			if (customer.PhoneNumber == Customers.PhoneNumber)
			{
				return customer;
			}
			else
			{
				customer.Id = GenerateNumber(10);
				return customer;
			}
		} 
		 
		public string GenerateNumber(int length)
		{
			const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
			StringBuilder res = new StringBuilder();
			Random rnd = new Random();
			while (0 < length--)
			{
				res.Append(valid[rnd.Next(valid.Length)]);
			}
			return res.ToString();
		}
		public void DebugPurpose<T>(T data)
		{
			Console.WriteLine(JsonSerializer.Serialize(data));
		}
	}
}
