using Microsoft.AspNetCore.Components;
using NammaYatri.Shared;

namespace NammaYatri.Client.Components
{
	public partial class VehicleComponent
	{
		#region Parameter
		[Parameter, EditorRequired]
		public AvailableVehicle availableVehicle { get; set; }

		[Parameter, EditorRequired]
		public SearchVehicle searchVechile { get; set; }

		[Parameter, EditorRequired]
		public EventCallback<Order> OrderedVehicle { get; set; } 

		#endregion



		protected override void OnInitialized()
		{
			context.DebugPurpose(availableVehicle);
			
		}
		private async void BookTicket()
		{
			var order = new Order()
			{
				Id = context.GenerateNumber(10),
				CustomerId = context.Customers.Id,
				SearchVehicleId = availableVehicle.Id,
				CustomerData = context.Customers,
				SearchVehicles = searchVechile,
				IsCancelled = false,
				AvailableVehicles = availableVehicle
			};
			await OrderedVehicle.InvokeAsync(order);
			SendMessage();
			//navigation.NavigateTo("/orders");
		}
		async void SendMessage()
		{
			// for calling external Api like twilio for implemention of sending message
		}
	}
}
