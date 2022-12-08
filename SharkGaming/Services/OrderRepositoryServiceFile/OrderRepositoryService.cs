using SharkGaming.Order;
using SharkGaming.OrderFile;
using SharkGaming.Products;
using SharkGaming.Users.Customer;

namespace SharkGaming.Services.OrderRepositoryServiceFile
{
    public class OrderRepositoryService : IOrderRepositoryService
    {
        private List<OrderClass> _orders;
        
        public List<OrderClass> GetOrders();

        public void AddOrder(OrderClass order);

        public void UpdateOrder(OrderClass order);

        public OrderClass GetItem(int id);

        public IEnumerable<CustomerClass> CustomerNameSearch(CustomerClass name);

        public OrderClass DeleteOrder(int? orderId);

        public double CalculateTotalPrice();
    }
}
