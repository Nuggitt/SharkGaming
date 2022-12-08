using SharkGaming.Order;
using SharkGaming.Products;
using SharkGaming.Users.Customer;

namespace SharkGaming.Services.OrderRepositoryServiceFile
{
    public interface IOrderRepositoryService
    {

        List<OrderClass> GetOrders();
        
        void AddOrder(OrderClass order);
        
        void UpdateOrder(OrderClass order);
        
        OrderClass GetItem(int id);

        IEnumerable<CustomerClass> CustomerNameSearch(CustomerClass name);

        OrderClass DeleteOrder(int? orderId);

        double CalculateTotalPrice();




    }
}
