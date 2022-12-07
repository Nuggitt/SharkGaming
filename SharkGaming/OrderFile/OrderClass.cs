using SharkGaming.OrderFile;
using SharkGaming.Users.Customer;

namespace SharkGaming.Order
{
    public class OrderClass
    {
        public static int nextId = 0;
        public int Id { get; set; }
        public string DeliveryAddress { get; set; }
        public DateOnly Date { get; set; }
        public DateTime Time { get; set; }
        public CustomerClass Customer { get; set; }

        private List<OrderItemsClass> OrderItems = new List<OrderItemsClass>();

        public OrderClass(CustomerClass customer, string deliveryAdress, DateOnly date, DateTime time, List<OrderItemsClass> orderitems)
        {
            Id = nextId++;
            Customer = customer;
            DeliveryAddress = deliveryAdress;
            Date = date;
            Time = time;
            OrderItems = orderitems;

        }

        public OrderClass()
        {

        }
    }
}
