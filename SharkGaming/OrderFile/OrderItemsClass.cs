using SharkGaming.Order;
using SharkGaming.Products;
using SharkGaming.Products.Components;
using SharkGaming.Users.Customer;

namespace SharkGaming.OrderFile
{
    public class OrderItemsClass
    {
        public int Amount { get; set; }
        public double Price { get; set; }
        public ProductsClass Product { get; set; }

        public OrderItemsClass(ProductsClass product, int amount, double price )
        {
            Product = product;
            Amount = amount;
            Price = price;
        }

        public static List<ProductsClass> orderItemList = new List<ProductsClass>()
        {

        };

        public static List<ProductsClass> GetOrderList()
        {
            return orderItemList;
        }


    }
}
