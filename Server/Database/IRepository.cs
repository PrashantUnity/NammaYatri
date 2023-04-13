using NammaYatri.Shared;
using System.Collections.Generic;

namespace NammaYatri.Server.Database
{
    public interface IRepository
    {
        void AddCustomer(Customer customer);
        Customer GetCurrentCustomer();
		SearchVehicle LastSearch { get; set; }
        IEnumerable<AvailableVehicle> GetAvailableVehicle();
        Order AddOrder(Order order);
        bool UpdateOrder(Order order);
        Order GetOrder(string id);
        IEnumerable<Order> GetAllOrders(string id);

    }
}
