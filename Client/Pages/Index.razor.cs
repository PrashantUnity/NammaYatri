using NammaYatri.Shared;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text.Json;
using System.Text;

namespace NammaYatri.Client.Pages
{
	public partial class Index
	{
		private IEnumerable<AvailableVehicle>? availableVehicles;
		private SearchVehicle search;

		public async void FetchAvailableVehicle(SearchVehicle searchVehicle)
		{
			search = searchVehicle; 
			var tempPatch = $"https://localhost:7237/api/Search";

			await http.PostAsJsonAsync(tempPatch, searchVehicle);
			availableVehicles = await http.GetFromJsonAsync<AvailableVehicle[]>(tempPatch);
			StateHasChanged();

			//context.DebugPurpose(availableVehicles);
		}


		public async void ReserveVehicle(Order order)
		{
			var tempPatch = "https://localhost:7237/api/Orders";
			var result = await http.PostAsJsonAsync(tempPatch, order);
		}

		//reduntant or Experimental 
		IEnumerable<AvailableVehicle> GetHelper(SearchVehicle searchVehicle)
		{
			var json = JsonSerializer.Serialize(searchVehicle);
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://localhost:7237/api/SearchVehicle"),

				Content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json)
			};

			var response = http.SendAsync(request).ConfigureAwait(false);

			var responseInfo = response.GetAwaiter().GetResult();
			return null;
		}
	}
}
