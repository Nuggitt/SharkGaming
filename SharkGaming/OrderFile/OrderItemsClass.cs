using SharkGaming.Order;
using SharkGaming.Products;
using SharkGaming.Products.Components;
using SharkGaming.Users.Customer;

namespace SharkGaming.OrderFile
{
    public class OrderItemsClass
    {
        public static int nextId = 0;
        public int OrderItemId { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public ProductsClass Product { get; set; }

        public OrderItemsClass(ProductsClass product, int amount, double price )
        {
            Product = product;
            Amount = amount;
            Price = price;
            OrderItemId = nextId++;
        }

        public static List<OrderItemsClass> orderItemList = new List<OrderItemsClass>()
        {

        };

        public static List<OrderItemsClass> GetOrderList()
        {
            return orderItemList;
        }


    }
}
