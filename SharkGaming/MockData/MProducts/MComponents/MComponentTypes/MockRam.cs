using SharkGaming.Products.Components.ComponentTypes.RAM;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockRam
    {

        public static List<RAM> _RAM = new List<RAM>()
        {
            new RAM("Corsair Vengeance RGB Black Pro 16GB", 543, true, true, "Mid-end ram", 16, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),
            new RAM("G.SKILL TridentZ RGB Series 32GB", 1177, true, true, "High-end ram", 32, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),
            new RAM("Kingston FURY Beast 16GB", 262.88, true, true, "Low-end ram", 16, "DDR4", "DIMM 288-pin", 3200, "CL 18", 1.35, "RGB")

        };

        public static List<RAM> GetMockRam() { return _RAM; }
    }
}
