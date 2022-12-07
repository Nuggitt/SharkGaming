using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.Storage;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes.MCooling
{
    public class MockCooling
    {
        public static List<CoolingClass> _cooling = new List<CoolingClass>();

        public static List<CoolingClass> GetMockCooling()
        {
            return _cooling;
        }
    }
}
