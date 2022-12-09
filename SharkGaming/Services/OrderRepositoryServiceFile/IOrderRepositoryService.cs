using SharkGaming.Order;
using SharkGaming.OrderFile;
using SharkGaming.Products;
using SharkGaming.Users.Customer;

namespace SharkGaming.Services.OrderRepositoryServiceFile
{
    public interface IOrderRepositoryService
    {

        List<OrderClass> GetOrders();
        
        void AddOrder(OrderClass order);
        
        void UpdateOrder(OrderClass order);
        
        OrderClass GetOrderById(int id);

        IEnumerable<OrderClass> CustomerEmailSearch(OrderClass order);

        OrderClass DeleteOrder(int? orderId);

        //OrderItemsMethods:

        void AddOrderItems(OrderItemsClass orderItems);
        List<OrderItemsClass> GetOrderItems();

        OrderItemsClass DeleteOrderItem(int? itemId);




    }
}
