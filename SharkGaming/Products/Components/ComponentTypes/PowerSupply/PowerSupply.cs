namespace SharkGaming.Products.Components.ComponentTypes.PowerSupply
{
    public class PowerSupply
    {
        public string PSUFormFactor { get; set; }
        public string ColourCategory { get; set; }
        public string ClassType { get; set; }
        public double PowerCapacity { get; set; }
        public bool Molex { get; set; }
        public string CoolingSystem { get; set; }

        public PowerSupply()
        {

        }
    }
}
