using SharkGaming.Products.Components.ComponentTypes.Cooling;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockCPUWaterCooling
    {
        public static List<CPUWaterCooling> cPUWaterCooling = new List<CPUWaterCooling>()
        {
            new CPUWaterCooling("ARCTIC LIQUID FREEZER II 240 CPU KØLER - VANDKØLER", 649, true, true, "OUTSTANDING PERFORMANCE",   "Copper, Micro-Skived-Fins", true, "Intel® LGA2066 / LGA 2011-3 / 2011 / 1366 / 1156 / 1155 / 1151 / 1150 / 775 socket , AMD® AM4 / AM3+ / AM3 / AM2+ / FM2+ / FM2 / FM1 socket", 2, 2.7, 240, "4-pin", "48.8", 1800,"0", "1.85", "NO RGP" ),
            new CPUWaterCooling("NZXT KRAKEN X53 CPU KØLER - VANDKØLER", 999, true, true, "Cam control very nice",   "Heatsink: Aluminum", true, "Intel Socket LGA 1200, 1151, 1150, 1155, 1156, 1366, 2011, 2011-3, 2066 , AMD Socket AM4, sTRX4*, TR4*(*Threadripper bracket not included)", 2, 2.7, 240, "4-pin", "48.8", 1800,"0", "1.85", "ONLY PUMP SOCKET RGP" ),
            new CPUWaterCooling("ARCTIC LIQUID FREEZER II 360 A-RGB COOLER", 999, true, true, "Radiator full for rgp fans", "Copper, Micro-Skived-Fins", true, "1700, 1200, 115X, 2011-3*, 2066* *Square ILM, AM5, AM4", 3, 2.7, 240, "4-pin", "48.8", 2000,"0", "1.85", "NO RGP" ),
        };

        public static List<CPUWaterCooling> GetMockCPUWaterCooling()
        {
            return cPUWaterCooling;
        }
    }
}
