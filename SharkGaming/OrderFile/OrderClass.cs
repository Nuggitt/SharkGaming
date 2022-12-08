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

        public double TotalPrice { get; set; }

        private static List<OrderItemsClass> _orderItems = new List<OrderItemsClass>();

        public OrderClass(CustomerClass customer, string deliveryAdress, DateOnly date, DateTime time, List<OrderItemsClass> orderitems)
        {
            Id = nextId++;
            Customer = customer;
            DeliveryAddress = deliveryAdress;
            Date = date;
            Time = time;
            _orderItems = orderitems;
            TotalPrice = CalculateTotalPrice();
        }

        public OrderClass()
        {

        }

        public static List<OrderItemsClass> GetOrders()
        {
            return _orderItems;
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;

            if (_orderItems != null)
            {
                foreach (OrderItemsClass item in _orderItems)
                {
                    totalPrice = totalPrice + item.Price;
                }
                return totalPrice;
            }
            return 0;
        }

    }
}
