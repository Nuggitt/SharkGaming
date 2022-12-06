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

        private List<OrderItemsClass> orderItems = new List<OrderItemsClass>();

        public OrderClass(string deliveryAdress, DateOnly date, DateTime time, CustomerClass customer)
        {
            Id = nextId++;
            DeliveryAddress = deliveryAdress;
            Date = date;
            Time = time;
            Customer = customer;
        }

        public OrderClass()
        {

        }
    }
}
