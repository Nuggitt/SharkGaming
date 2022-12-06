namespace SharkGaming.Products.Components.ComponentTypes.Cooling
{
    public class CaseFan : CoolingClass
    {
        public string BearingType { get; set; }

        public CaseFan()
        {

        }

        public CaseFan(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, string bearingType, double thermalDesignPower, double size, string powerConnector, string airFlow, double rpm, string squareMetersPerHour, string mmH20, string colourCatagory)
        : base(thermalDesignPower, size, powerConnector, airFlow, rpm, squareMetersPerHour, mmH20, colourCatagory, name, price, amdCompatible, intelCompatible, specInfo)
        {
            BearingType = bearingType;
        }
    }
}
