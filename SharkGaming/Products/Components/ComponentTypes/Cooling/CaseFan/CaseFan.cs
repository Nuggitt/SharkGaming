namespace SharkGaming.Products.Components.ComponentTypes.Cooling.CaseFan
{
    public class CaseFan : CoolingClass
    {
        public string BearingType { get; set; }

        public CaseFan()
        {

        }

        public CaseFan(string bearingType,double thermalDesignPower, double size, string powerConnector, string airFlow, double rpm, string squareMetersPerHour, string mmH20, string colourCatagory, string name, double price, bool amdCompatible, bool intelCompatible, string specInfo)
        : base( thermalDesignPower, size, powerConnector, airFlow, rpm, squareMetersPerHour, mmH20, colourCatagory, name, price, amdCompatible, intelCompatible, specInfo)
        {
            BearingType = bearingType;
        }
    }
    
}
