using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SharkGaming.Products.Components.ComponentTypes.RAM
{
    public class RAM : ComponentsClass
    {
        public int Capacity { get; set; }
        public string Technology { get; set; }
        public string FormFactor { get; set; }
        public double Speed { get; set; }
        public string LatencyTimings { get; set; }
        public double Voltage { get; set; }
        public string ColourCategory { get; set; }

        public RAM(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, int capacity, string technology, string formFactor, double speed, string latencyTimings, double voltage, string colourCategory)
            : base(name, price, amdCompatible, intelCompatible, specInfo)
        {
            Capacity = capacity;
            Technology = technology;
            FormFactor = formFactor;
            Speed = speed;
            LatencyTimings = latencyTimings;
            Voltage = voltage;
            ColourCategory = colourCategory;
            Id = nextId++;
        }

        public RAM()
        {

        }

        
    }
}
