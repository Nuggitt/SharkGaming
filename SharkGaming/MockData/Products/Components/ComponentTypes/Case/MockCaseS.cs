using SharkGaming.Products.Components.ComponentTypes.Storage.Case;

namespace SharkGaming.MockData.Products.Components.ComponentTypes.Case
{
    public class MockCaseS
    {
        public static List<Cases> _cases = new List<Cases>()
        {
            new Cases("Shark Gaming Aquarium", 999, true, true, "A case with tempered glass", "MidTower (ATX)", "Black", 10, true, 280, 415, 427, "ATX", "2xUSB 3.0 & 1x USB 2.0 & HD Audio" ),
            new Cases("Shark Gaming MaelStrom", 599, true, true, "A RGB flow case", "MiniTower (m-ATX)", "Black", 4, true, 210, 405, 425, "ATX", "2xUSB 3.0 & 1x USB 2.0 & HD Audio" ),
            new Cases("Phanteks Enthoo Evolv X Satin Black Kabinet", 1749, true, true, "A case made of aluminium panels and powder coated steel", "MidTower (ATX)", "White", 7, true, 240, 520, 520, "ATX", "1 x USB 3.1 gen 2 Type-C (Needs Front USB-C Supported Motherboard), 2xUSB 3.0, Power button, Microphone, Headphone, D-RGB Mode button, D-RGB Color button" )

        };

        public static List<Cases> GetMockCases()
        {
            return _cases;
        }
    }
}
