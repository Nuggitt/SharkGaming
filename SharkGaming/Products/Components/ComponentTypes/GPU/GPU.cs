namespace SharkGaming.Products.Components.ComponentTypes.GPU
{
    public class GPU : ComponentsClass
    {
        public double BusType { get; set; }
        public string GraphicsEngine { get; set; }
        public int CUDACore { get; set; }
        public bool VRReady { get; set; }
        public string MaxResolution { get; set; }
        public int MemorySize { get; set; }
        public string MemoryTechnology { get; set; }
        public int MemoryBusWidth { get; set; }
        public int RequriedPowerSupply { get; set; }
        public double Width { get; set; }


        public GPU()
        {

        }


    }
}
