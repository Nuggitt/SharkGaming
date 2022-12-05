namespace SharkGaming.Products.Components.ComponentTypes.RAM
{
    public class RAM : ComponentsClass
    {
        public int Capacity { get; set; }
        public string Technology { get; set; }
        public string FormFactor { get; set; }
        public double Speed { get; set; }
        public string LatencyTimings { get; set; }
        public double Voltage { get; set; }
        public string ColourCategory { get; set; }

        public RAM()
        {

        }
    }
}
