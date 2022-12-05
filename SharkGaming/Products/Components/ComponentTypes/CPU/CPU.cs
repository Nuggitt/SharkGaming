namespace SharkGaming.Products.Components.ComponentTypes.CPU
{
    public class CPU : ComponentsClass
    {
        public double ClockSpeed { get; set; }
        public double BoostClock { get; set; }
        public int Gen { get; set; }
        public int Threads { get; set; }
        public string Socket { get; set; }
        public bool UnlockForOC { get; set; }
        public double PCIExpress { get; set; }
        public int ThermalDesignPower { get; set; }
        public int PowerDraw { get; set; }


        public CPU()
        {

        }

    }
}
