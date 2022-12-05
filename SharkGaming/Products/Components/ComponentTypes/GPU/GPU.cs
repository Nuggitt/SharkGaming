namespace SharkGaming.Products.Components.ComponentTypes.GPU
{
    public class GPU : ComponentsClass
    {
        public double busType { get; set; }
        public string graphicsEngine { get; set; }
        public int cUDACore { get; set; }
        public bool vRReady { get; set; }
        public string maxResolution { get; set; }
        public int memorySize { get; set; }
        public string memoryTechnology { get; set; }
        public int memoryBusWidth { get; set; }
        public int requriedPowerSupply { get; set; }
        public double width { get; set; }


        public GPU()
        {

        }


    }
}
