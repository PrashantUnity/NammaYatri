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

        private int orderIdLength = 5;
        string start = "", startDate = "", end = "", endDate = "", diff = "";
        #endregion

        protected override void OnInitialized()
        {
            var startTime = DateTime.Parse(availableVehicle.StartTime);
            var reachTime = DateTime.Parse(availableVehicle.ReachTime);

            start = startTime.ToString("HH mm");
            end = reachTime.ToString("HH mm");

            startDate = startTime.ToString("MMMM dd yyyy");
            endDate = reachTime.ToString("MMMM dd yyyy");

            diff = (reachTime - startTime).ToString();
        }
        private async void BookTicket()
        {
            var order = new Order()
            {

                AvailableVehicles = availableVehicle,
                CustomerData = currentContextData.Customers,
                Id = currentContextData.GenerateNumber(10),
                SearchVehicles = searchVechile,
                IsCancelled = false
            };
            await OrderedVehicle.InvokeAsync(order);
            SendMessage();
            navigation.NavigateTo("/orders");
        }
        async void SendMessage()
        {
            // for calling external Api like twilio for implemention of sending message
        }
    }
}
