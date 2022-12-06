using SharkGaming.Products.Components.ComponentTypes.Cooling;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes.MCooling
{
    public class MockCPUCooling
    {
        public static List<CPUCooling> _cPUCoolingList = new List<CPUCooling>();

        public static List<CPUCooling> GetMockCPUCooling()
        {
            return _cPUCoolingList;
        }
    }
}
