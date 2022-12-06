using SharkGaming.Products.Components.ComponentTypes.CPU;

namespace SharkGaming.MockData.Products.Components.ComponentTypes.CPU
{
    public class MockCPU
    {
        public static List<SharkGaming.Products.Components.ComponentTypes.CPU.CPU> _CPU = new List<SharkGaming.Products.Components.ComponentTypes.CPU.CPU>
        {
            //new SharkGaming.Products.Components.ComponentTypes.CPU.CPU("Ryzen 9 5950X", 4657.26, true, false, "High-end", 3.4, 4.9, 16, 32, "AM4", true, 4.0, 105, ),
        };

        public static List<SharkGaming.Products.Components.ComponentTypes.CPU.CPU> GetMockCPUs()
        {
            return _CPU;
        }
    }
}
