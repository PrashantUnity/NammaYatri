using Microsoft.AspNetCore.Components;
using NammaYatri.Shared;

namespace NammaYatri.Client.Components
{
    public partial class SearchComponent
    {
        private DateTime OnWhichDate = DateTime.Now;
        private string LocationFrom { get; set; } = "";
        private string LocationTo { get; set; } = "";
        [Parameter]
        public EventCallback<SearchVehicle> ParentCaller { get; set; }

        private async void OnHandleSubmit()
        {
            var forinspection = 0;
            var data = new SearchVehicle()
            {
                Id = context.GenerateNumber(10),
                LocationFrom = LocationFrom,
                LocationTo = LocationTo,
                OnWhichDate = OnWhichDate
            };
            await ParentCaller.InvokeAsync(data);
        }
    }
}
