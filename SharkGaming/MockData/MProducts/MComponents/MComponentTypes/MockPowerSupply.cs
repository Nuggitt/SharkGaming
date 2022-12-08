namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockPowerSupply
    {

        public static List<SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply> _PowerSupply = new List<SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply>()
        {
            new SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply("Corsair AX1600I Modular Titanium", 4139.77, true, true, "High-end", "ATX", "Black", "Titanium", 1600, true, "Passiv"),
            new SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply("NZXT C550", 784.76, true, true, "Low-end", "ATX", "Black", "Bronze", 550, false, "Aktive"),
            new SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply("Asus ROG Strix 750 Modular", 1130.61, true, true, "Mid-end", "ATX", "Black", "Gold", 750, true, "Aktive")
        };

        public static List<SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply> GetMockPowerSupplies() { return _PowerSupply; }


    }
}
