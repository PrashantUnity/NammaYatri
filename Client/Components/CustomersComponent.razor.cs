using Microsoft.AspNetCore.Components;
using NammaYatri.Shared;
using System.Text;

namespace NammaYatri.Client.Components
{
    public partial class CustomersComponent
    {
        [Parameter]
        public EventCallback<bool> Clicked { get; set; }
        public Customer customer = new Customer();
        public (string, string) country = ("India", "91");
        private List<(string, string)> countryCode = new List<(string, string)>
            {
                ("United States","1"),
                ("Egypt","20"),
                ("United Kingdom","44"),
                ("Poland","48"),
                ("Germany","49"),
                ("India","91")
            };

        protected override void OnInitialized()
        {
            customer = context.Customers;
        }
        public async void HandleSubmit()
        {
            context.Customers = context.GetCustomer(customer);
            context.ShowProfile = false;
            await Clicked.InvokeAsync(true);

		}
    }
}
