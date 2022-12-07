using SharkGaming.Products.Components.ComponentTypes.Storage;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes.MStorage
{
    public class MockMdot
    {
        public static List<Mdot2> _Mdot2 = new List<Mdot2>
        {
            new Mdot2("Samsung 980 PRO 2TB M.2-2280", 2276.92, true, true, "High-end", 2000, "M.2", 7000, 4.0),
            new Mdot2("Samsung 980 PRO 2TB M.2-2280", 1346.40, true, true, "Mid-end", 1000, "M.2", 7000, 4.0),
            new Mdot2("Crucial P2 500GB 3D NAND", 319.03, true, true, "Low-end", 500, "M.2", 2300, 3.0)
        };

        public static List<Mdot2> GetMockMdot2s() { return _Mdot2; }


    }
}
