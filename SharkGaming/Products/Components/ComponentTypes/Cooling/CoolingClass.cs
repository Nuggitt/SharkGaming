namespace SharkGaming.Products.Components.ComponentTypes.Cooling
{
    public class CoolingClass : ComponentsClass
    {
        public double ThermalDesignPower { get; set; }
        public double Size { get; set; }
        public string PowerConnector { get; set; }
        public string AirFlow { get; set; }
        public double Rpm { get; set; }
        public string SquareMetersPerHour { get; set; }
        public string MmH20 { get; set; }
        public string ColourCatagory { get; set; }

        public CoolingClass()
        {

        }
        
    }
}
