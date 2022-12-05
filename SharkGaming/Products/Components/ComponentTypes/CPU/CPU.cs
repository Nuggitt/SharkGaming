namespace SharkGaming.Products.Components.ComponentTypes.CPU
{
    public class CPU
    {
        public double clockSpeed { get; set; }
        public double boostClock { get; set; }
        public int Gen { get; set; }
        public int threads { get; set; }
        public string socket { get; set; }
        public bool unlockForOC { get; set; }
        public double pCIExpress { get; set; }
        public int thermalDesignPower { get; set; }
        public int powerDraw { get; set; }


        public CPU()
        {

        }

    }
}
