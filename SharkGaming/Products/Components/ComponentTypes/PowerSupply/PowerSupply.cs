namespace SharkGaming.Products.Components.ComponentTypes.PowerSupply
{
    public class PowerSupply : ComponentsClass
    {

        public string PSUFormFactor { get; set; }
        public string ColourCategory { get; set; }
        public string ClassType { get; set; }
        public double PowerCapacity { get; set; }
        public bool Molex { get; set; }
        public string CoolingSystem { get; set; }


        public PowerSupply(string pSUFormFactor, string colourCategory, string classType, double powerCapacity, bool molex, string coolingSystem)
            : base()
        {
            PSUFormFactor = pSUFormFactor;
            ColourCategory = colourCategory;
            ClassType = classType;
            PowerCapacity = powerCapacity;
            Molex = molex;
            CoolingSystem = coolingSystem;
        }

        

        
    }
}
