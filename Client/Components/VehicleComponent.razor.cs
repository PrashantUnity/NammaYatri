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

				AvailableVehicles = availableVehicle,
				CustomerData = context.Customers,
				Id = context.GenerateNumber(10),
				SearchVehicles = searchVechile,
				IsCancelled = false
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
