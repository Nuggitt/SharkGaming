namespace SharkGaming.Products
{
    public class ProductsClass
    {
        protected static int nextId = 0;
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected int Id { get; set; }

        public ProductsClass(string name, double price)
        {
            Price = price;
            Name = name;
            Id = nextId++;
        }
    }
}
