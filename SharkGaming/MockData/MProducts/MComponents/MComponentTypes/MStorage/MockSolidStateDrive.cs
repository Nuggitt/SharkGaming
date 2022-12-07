using SharkGaming.Products.Components.ComponentTypes.Storage;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes.MStorage
{
    public class MockSolidStateDrive
    {
        public static List<SolidStateDrive> _SoildSateDrives = new List<SolidStateDrive>
        {
            new SolidStateDrive("Samsung 870 QVO 2.5¨ SSD - 1TB", 618, true, true, "Low power DDR4 SDRAM", 1000, "2.5¨", 560, 530, 11000, 35000, "Quad-niveau celle"),
            new SolidStateDrive("Samsung 870 QVO 2.5¨ SSD - 2TB", 1249, true, true, "Low power DDR4 SDRAM", 2000, "2.5¨", 560, 530, 11000, 35000, "Quad-niveau celle"),
            new SolidStateDrive("Crucial BX500 1TB 3D NAND 2.5¨", 576, true, true, "Multistep data integrity algorithm", 500, "2.5¨", 540, 500, 8000, 24000, "Sata")
        };

        public static List<SolidStateDrive> GetMockSoildSateDrives() { return _SoildSateDrives; }

    }
}
