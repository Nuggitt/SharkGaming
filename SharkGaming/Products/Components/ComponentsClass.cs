namespace SharkGaming.Products.Components
{
    public class ComponentsClass : ProductsClass
    {
        protected bool AmdCompatible { get; set; }
        protected bool IntelCompatible { get; set; }
        protected string SpecInfo { get; set; }

        public ComponentsClass(string name,double price, bool amdCompatible, bool intelCompatible, string specInfo)
            : base(name,price)
        {
            AmdCompatible = amdCompatible;
            IntelCompatible = intelCompatible;
            SpecInfo = specInfo;

        }

        public ComponentsClass()
        {

        }
    }
}
