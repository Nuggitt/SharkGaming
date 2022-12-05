namespace SharkGaming.Order
{
    public class OrderClass
    {
        public int id { get; set; }
        public string deliveryAddress { get; set; }
        public DateOnly date { get; set; }
        public DateTime time { get; set; }

        public OrderClass()
        {

        }
    }
}
