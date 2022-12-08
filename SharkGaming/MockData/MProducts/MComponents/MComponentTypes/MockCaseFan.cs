using SharkGaming.Products.Components.ComponentTypes.Cooling;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockCaseFan
    {
        public static List<CaseFan> _caseFan = new List<CaseFan>()
        {
            new CaseFan("Arctic P12 PWM PST BLACK 120mm Fan", 59, true, true, "Black Airflow Fan which has a low noice level","Fluid Dynamic", 1.44, 120, "120" ,"3-pin", 56.3 , "200-1800", "1.79 m2/h","NO RGB"),
            new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            new CaseFan("ThermalTake Riing Plus 12 RGB SYNC Edition 3 Pack", 59, true, true, "Patented LED Design","Hydraulic bearing", 2.01, 120 ,"120","3-pin", 56.3 , "1800", "1.79 m2/h","RGB"),
        };

        public static List<CaseFan> GetMockCaseFans()
        {
            return _caseFan;
        }
    }
}
