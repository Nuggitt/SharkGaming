using SharkGaming.OrderFile;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;

namespace SharkGaming.MockData.MProducts.MOrders
{
    public class MockOrderItems
    {
        public static List<OrderItemsClass> _mockOrderItems = new List<OrderItemsClass>()
        {
            new OrderItemsClass(new RAM("Corsair Vengeance RGB Black Pro 16GB", 543, true, true, "Mid-end ram", 16, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),1,543),
            new OrderItemsClass(new Cases("Shark Gaming Aquarium", 999, true, true, "A case with tempered glass", "MidTower (ATX)", "Black", 10, true, 280, 415, 427, "ATX", "2xUSB 3.0 & 1x USB 2.0 & HD Audio" ),1,999)
        };

        public static List<OrderItemsClass> GetMockRam() { return _mockOrderItems; }
    }
}
