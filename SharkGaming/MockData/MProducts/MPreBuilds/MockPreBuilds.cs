using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products;
using SharkGaming.Products.PreBuilds;
using System.Text.RegularExpressions;

namespace SharkGaming.MockData.Products.PreBuilds
{
    public class MockPreBuilds
    {

        public List<ProductsClass> Products { get; private set; }
        public List<Cases> cases { get; }
        public List<CaseFan> caseFan { get; private set; }
        public List<CPUAirCooling> cPUAirCoolings { get; private set; }
        public List<CPUWaterCooling> cPUWaterCoolings { get; private set; }
        public List<CPU> cPU { get; private set; }
        public List<GPU> gPU { get; private set; }
        public List<Motherboard> motherboards { get; private set; }
        public List<PowerSupply> powerSupplies { get; private set; }
        public List<RAM>? ram { get; private set; }
        public List<Mdot2> mdot2s { get; private set; }
        public List<SolidStateDrive> solidStateDrives { get; private set; }

        public static List<ProductsClass> _prebuild = new List<ProductsClass>()
        {
            new Cases("Phanteks Enthoo Evolv X Satin Black Kabinet", 1749, true, true, "A case made of aluminium panels and powder coated steel", "MidTower (ATX)", "White", 7, true, 240, 520, 520, "ATX", "1 x USB 3.1 gen 2 Type-C (Needs Front USB-C Supported Motherboard), 2xUSB 3.0, Power button, Microphone, Headphone, D-RGB Mode button, D-RGB Color button" ),
            new Motherboard("Gigabyte X570S AORUS Master", 2932.32, true, false, "High-end", true, 128, "DDR4", 5400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0),
            new CPU("Ryzen 9 5950X", 4657.26, true, false, "High-end", 3.4, 4.9, 16, 32, "AM4", true, 4.0, 105),
            new CPUWaterCooling("ARCTIC LIQUID FREEZER II 360 A-RGB COOLER", 999, true, true, "Radiator full for rgp fans", "Copper, Micro-Skived-Fins", true, "1700, 1200, 115X, 2011-3*, 2066* *Square ILM, AM5, AM4", 3, 2.7, 240, "4-pin", "48.8", 2000,"0", "1.85", "NO RGP" ),
            new RAM("G.SKILL TridentZ RGB Series 32GB", 1177, true, true, "High-end ram", 32, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),
            new GPU("ASUS GeForce RTX 3090 TI", 13799.45, true, true, "Top of the line PCI4 GPU", "NVIDIA GeForce RTX 3090 TI", 10752, true, "7680 x 4320", 24000, "GDDR6X SDRAM", 384, 1000, 32.59, 4.0),
            new Mdot2("Samsung 980 PRO 2TB M.2-2280", 2276.92, true, true, "High-end", 2000, "M.2", 7000, 4.0),
            new PowerSupply("Corsair AX1600I Modular Titanium", 4139.77, true, true, "High-end", "ATX", "Black", "Titanium", 1600, true, "Passiv"),
            new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" )
        };


        public static List<PreBuildsClass> _prebuilds = new List<PreBuildsClass>()
        {
            new PreBuildsClass("Boob tank", 90000, "do you think i well get som puss if i show her that?", false, new Cases(
                "Phanteks Enthoo Evolv X Satin Black Kabinet", 1749, true, true, "A case made of aluminium panels and powder coated steel", "MidTower (ATX)", "White", 7, true, 240, 520, 520, "ATX", "1 x USB 3.1 gen 2 Type-C (Needs Front USB-C Supported Motherboard), 2xUSB 3.0, Power button, Microphone, Headphone, D-RGB Mode button, D-RGB Color button" ),
                new Motherboard("Gigabyte X570S AORUS Master", 2932.32, true, false, "High-end", true, 128, "DDR4", 5400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0),
                new CPU("Ryzen 9 5950X", 4657.26, true, false, "High-end", 3.4, 4.9, 16, 32, "AM4", true, 4.0, 105),
                new CPUWaterCooling("ARCTIC LIQUID FREEZER II 360 A-RGB COOLER", 999, true, true, "Radiator full for rgp fans", "Copper, Micro-Skived-Fins", true, "1700, 1200, 115X, 2011-3*, 2066* *Square ILM, AM5, AM4", 3, 2.7, 240, "4-pin", "48.8", 2000,"0", "1.85", "NO RGP" ),
                new RAM("G.SKILL TridentZ RGB Series 32GB", 1177, true, true, "High-end ram", 32, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),
                new GPU("ASUS GeForce RTX 3090 TI", 13799.45, true, true, "Top of the line PCI4 GPU", "NVIDIA GeForce RTX 3090 TI", 10752, true, "7680 x 4320", 24000, "GDDR6X SDRAM", 384, 1000, 32.59, 4.0),
                new Mdot2("Samsung 980 PRO 2TB M.2-2280", 2276.92, true, true, "High-end", 2000, "M.2", 7000, 4.0),
                new PowerSupply("Corsair AX1600I Modular Titanium", 4139.77, true, true, "High-end", "ATX", "Black", "Titanium", 1600, true, "Passiv"),
                new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" )
                ),
            new PreBuildsClass("Cockharhinus", 80000, "do you think i well get som puss if i show her that?", false, new Cases(
                "Phanteks Enthoo Evolv X Satin Black Kabinet", 1749, true, true, "A case made of aluminium panels and powder coated steel", "MidTower (ATX)", "White", 7, true, 240, 520, 520, "ATX", "1 x USB 3.1 gen 2 Type-C (Needs Front USB-C Supported Motherboard), 2xUSB 3.0, Power button, Microphone, Headphone, D-RGB Mode button, D-RGB Color button" ),
                new Motherboard("Gigabyte X570S AORUS Master", 2932.32, true, false, "High-end", true, 128, "DDR4", 5400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0),
                new CPU("Ryzen 9 5950X", 4657.26, true, false, "High-end", 3.4, 4.9, 16, 32, "AM4", true, 4.0, 105),
                new CPUWaterCooling("ARCTIC LIQUID FREEZER II 360 A-RGB COOLER", 999, true, true, "Radiator full for rgp fans", "Copper, Micro-Skived-Fins", true, "1700, 1200, 115X, 2011-3*, 2066* *Square ILM, AM5, AM4", 3, 2.7, 240, "4-pin", "48.8", 2000,"0", "1.85", "NO RGP" ),
                new RAM("G.SKILL TridentZ RGB Series 32GB", 1177, true, true, "High-end ram", 32, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),
                new GPU("ASUS GeForce RTX 3090 TI", 13799.45, true, true, "Top of the line PCI4 GPU", "NVIDIA GeForce RTX 3090 TI", 10752, true, "7680 x 4320", 24000, "GDDR6X SDRAM", 384, 1000, 32.59, 4.0),
                new Mdot2("Samsung 980 PRO 2TB M.2-2280", 2276.92, true, true, "High-end", 2000, "M.2", 7000, 4.0),
                new PowerSupply("Corsair AX1600I Modular Titanium", 4139.77, true, true, "High-end", "ATX", "Black", "Titanium", 1600, true, "Passiv"),
                new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" )
                ),
            new PreBuildsClass("boll shark", 70000, "do you think i well get som puss if i show her that?", false, new Cases(
                "Phanteks Enthoo Evolv X Satin Black Kabinet", 1749, true, true, "A case made of aluminium panels and powder coated steel", "MidTower (ATX)", "White", 7, true, 240, 520, 520, "ATX", "1 x USB 3.1 gen 2 Type-C (Needs Front USB-C Supported Motherboard), 2xUSB 3.0, Power button, Microphone, Headphone, D-RGB Mode button, D-RGB Color button" ),
                new Motherboard("Gigabyte X570S AORUS Master", 2932.32, true, false, "High-end", true, 128, "DDR4", 5400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0),
                new CPU("Ryzen 9 5950X", 4657.26, true, false, "High-end", 3.4, 4.9, 16, 32, "AM4", true, 4.0, 105),
                new CPUWaterCooling("ARCTIC LIQUID FREEZER II 360 A-RGB COOLER", 999, true, true, "Radiator full for rgp fans", "Copper, Micro-Skived-Fins", true, "1700, 1200, 115X, 2011-3*, 2066* *Square ILM, AM5, AM4", 3, 2.7, 240, "4-pin", "48.8", 2000,"0", "1.85", "NO RGP" ),
                new RAM("G.SKILL TridentZ RGB Series 32GB", 1177, true, true, "High-end ram", 32, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),
                new GPU("ASUS GeForce RTX 3090 TI", 13799.45, true, true, "Top of the line PCI4 GPU", "NVIDIA GeForce RTX 3090 TI", 10752, true, "7680 x 4320", 24000, "GDDR6X SDRAM", 384, 1000, 32.59, 4.0),
                new Mdot2("Samsung 980 PRO 2TB M.2-2280", 2276.92, true, true, "High-end", 2000, "M.2", 7000, 4.0),
                new PowerSupply("Corsair AX1600I Modular Titanium", 4139.77, true, true, "High-end", "ATX", "Black", "Titanium", 1600, true, "Passiv"),
                new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" )
                )
        };


        public static List<PreBuildsClass> GetMockPreBuilds()
        {
            return _prebuilds;
        }

    }
}
