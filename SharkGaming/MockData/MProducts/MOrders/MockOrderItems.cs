using SharkGaming.OrderFile;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;

namespace SharkGaming.MockData.MProducts.MOrders
{
    public class MockOrderItems
    {
        public static List<OrderItemsClass> _mockOrderItems = new List<OrderItemsClass>()
        {
            new OrderItemsClass(10,1),
            new OrderItemsClass(3,1)
        };

        public static List<OrderItemsClass> GetMockOrderItems() { return _mockOrderItems; }
    }
}
