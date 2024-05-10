using Core_Web_App_MVC.Models;

namespace Core_Web_App_MVC.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrderById(int orderId);
        void PlaceOrder(Order order);
        // Other methods as needed
    }

    public interface ICustomerRepository
    {
        Customer GetCustomerById(int customerId);
        // Other methods as needed
    }

}
