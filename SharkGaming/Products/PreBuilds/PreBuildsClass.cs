namespace SharkGaming.Products.PreBuilds
{
    public class PreBuildsClass : ProductsClass
    {
        public string Specs { get; set; }
        public bool Discount { get; set; }

        public PreBuildsClass(string name, double price, string specs, bool discount)
            : base(name, price)
        {
            Specs = specs;
            Discount = discount;

        }


    }
}
