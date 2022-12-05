namespace SharkGaming.Products.Components.ComponentTypes.Storage.Case
{
    public class Cases : ComponentsClass
    {
        public string SizeType { get; set; }
        public string Colour { get; set; }
        public int AmountOfFans { get; set; }
        public bool RGB { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Height { get; set; }
        public string SupportMotherboard { get; set; }
        public string  BuildInInterface { get; set; }

        

        public Cases(string sizeType, string colour, int amountOfFans, bool rGB, double width, double depth, double height, string supportMotherboard, string buildInInterface, string name, double price, bool amdCompatible, bool intelCompatible, string specInfo)
            : base(name, price, amdCompatible, intelCompatible, specInfo)
        {
            SizeType = sizeType;
            Colour = colour;
            AmountOfFans = amountOfFans;
            RGB = rGB;
            Width = width;
            Depth = depth;
            Height = height;
            SupportMotherboard = supportMotherboard;
            BuildInInterface = buildInInterface;
        }
        public Cases()
        {

        }
    }
}
