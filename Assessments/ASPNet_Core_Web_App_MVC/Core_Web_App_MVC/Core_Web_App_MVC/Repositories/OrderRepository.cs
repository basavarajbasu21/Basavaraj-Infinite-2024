using Core_Web_App_MVC.Models;

namespace Core_Web_App_MVC.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly EkartContext _dbContext;

        public OrderRepository(EkartContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Order GetOrderById(int orderId)
        {
            return _dbContext.Orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        public void PlaceOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }
        // Implement other methods
    }

    public class CustomerRepository : ICustomerRepository
    {
        private readonly EkartContext _dbContext;

        public CustomerRepository(EkartContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Customer GetCustomerById(int customerId)
        {
            return _dbContext.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        }
        // Implement other methods
    }

}
