using NammaYatri.Shared;

namespace NammaYatri.Client.Components
{
    public partial class CustomersComponent
    {
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
        public void HandleSubmit()
        {
            context.Customers = context.GetCustomer(customer);
        }
    }
}
