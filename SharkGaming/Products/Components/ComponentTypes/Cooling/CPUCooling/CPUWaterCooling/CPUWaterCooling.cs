namespace SharkGaming.Products.Components.ComponentTypes.Cooling.CPUCooling.CPUWaterCooling
{
    public class CPUWaterCooling : CPUCooling
    {
        public string RadiatorMaterial { get; set; }

        public CPUWaterCooling(string radiatorMaterial, bool type, string socket, int fanAmount, double thermalDesignPower, double size, string powerConnector, string airFlow, double rpm, string squareMetersPerHour, string mmH20, string colourCatagory, string name, double price, bool amdCompatible, bool intelCompatible, string specInfo)
        : base(type, socket, fanAmount, thermalDesignPower,  size, powerConnector, airFlow, rpm, squareMetersPerHour, mmH20, colourCatagory, name, price, amdCompatible, intelCompatible, specInfo)
        {
            RadiatorMaterial = radiatorMaterial;
        }

        public CPUWaterCooling()
        {

        }
    }
}
