namespace SharkGaming.Products
{
    public class ProductsClass
    {
        protected static int nextId = 0;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }

        public ProductsClass(string name, double price)
        {
            Price = price;
            Name = name;
            Id = nextId++;
        }

        public ProductsClass()
        {

        }
    }
}
