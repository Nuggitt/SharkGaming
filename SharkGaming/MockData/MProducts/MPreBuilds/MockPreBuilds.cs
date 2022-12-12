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
            //new Cases("Phanteks Enthoo Evolv X Satin Black Kabinet", 1749, true, true, "A case made of aluminium panels and powder coated steel", "MidTower (ATX)", "White", 7, true, 240, 520, 520, "ATX", "1 x USB 3.1 gen 2 Type-C (Needs Front USB-C Supported Motherboard), 2xUSB 3.0, Power button, Microphone, Headphone, D-RGB Mode button, D-RGB Color button" ),
            //new Motherboard("Gigabyte X570S AORUS Master", 2932.32, true, false, "High-end", true, 128, "DDR4", 5400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0),
            //new CPU("Ryzen 9 5950X", 4657.26, true, false, "High-end", 3.4, 4.9, 16, 32, "AM4", true, 4.0, 105),
            //new CPUWaterCooling("ARCTIC LIQUID FREEZER II 360 A-RGB COOLER", 999, true, true, "Radiator full for rgp fans", "Copper, Micro-Skived-Fins", true, "1700, 1200, 115X, 2011-3*, 2066* *Square ILM, AM5, AM4", 3, 2.7, 240, "4-pin", "48.8", 2000,"0", "1.85", "NO RGP" ),
            //new RAM("G.SKILL TridentZ RGB Series 32GB", 1177, true, true, "High-end ram", 32, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),
            //new GPU("ASUS GeForce RTX 3090 TI", 13799.45, true, true, "Top of the line PCI4 GPU", "NVIDIA GeForce RTX 3090 TI", 10752, true, "7680 x 4320", 24000, "GDDR6X SDRAM", 384, 1000, 32.59, 4.0),
            //new Mdot2("Samsung 980 PRO 2TB M.2-2280", 2276.92, true, true, "High-end", 2000, "M.2", 7000, 4.0),
            //new PowerSupply("Corsair AX1600I Modular Titanium", 4139.77, true, true, "High-end", "ATX", "Black", "Titanium", 1600, true, "Passiv"),
            //new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            //new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            //new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            //new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            //new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" )
        };


        public static List<PreBuildsClass> _prebuilds = new List<PreBuildsClass>()
        {
            new PreBuildsClass("Boob tank", 25999, "do you think i well get som puss if i show her that?", false, 
                new Cases("Phanteks Enthoo Evolv X Satin Black Kabinet", 1749, true, true, "A case made of aluminium panels and powder coated steel", "MidTower (ATX)", "White", 7, true, 240, 520, 520, "ATX", "1 x USB 3.1 gen 2 Type-C (Needs Front USB-C Supported Motherboard), 2xUSB 3.0, Power button, Microphone, Headphone, D-RGB Mode button, D-RGB Color button" ),
                new Motherboard("Gigabyte X570S AORUS Master", 2932.32, true, false, "High-end", true, 128, "DDR4", 5400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0),
                new CPU("Ryzen 9 5950X", 4657.26, true, false, "High-end", 3.4, 4.9, 16, 32, "AM4", true, 4.0, 105),
                new CPUWaterCooling("ARCTIC LIQUID FREEZER II 360 A-RGB COOLER", 999, true, true, "Radiator full for rgp fans", "Copper, Micro-Skived-Fins", true, "1700, 1200, 115X, 2011-3*, 2066* *Square ILM, AM5, AM4", 3, 2.7, 240, "4-pin", "48.8", 2000,"0", "1.85", "NO RGP" ),
                new RAM("G.SKILL TridentZ RGB Series 32GB", 1177, true, true, "High-end ram", 32, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),
                new GPU("ASUS GeForce RTX 3090 TI", 13799.45, true, true, "Top of the line PCI4 GPU", "NVIDIA GeForce RTX 3090 TI", 10752, true, "7680 x 4320", 24000, "GDDR6X SDRAM", 384, 1000, 32.59, 4.0),
                new Mdot2("Samsung 980 PRO 2TB M.2-2280", 2276.92, true, true, "High-end", 2000, "M.2", 7000, 4.0),
                new PowerSupply("Corsair AX1600I Modular Titanium", 4139.77, true, true, "High-end", "ATX", "Black", "Titanium", 1600, true, "Passiv"),
                new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" )
                ),
            new PreBuildsClass("Cockharhinus", 17999, "do you think i well get som puss if i show her that?", false,
                new Cases("Shark Gaming Aquarium", 999, true, true, "A case with tempered glass", "MidTower (ATX)", "Black", 10, true, 280, 415, 427, "ATX", "2xUSB 3.0 & 1x USB 2.0 & HD Audio" ),
                new Motherboard("EXDISPLAY MSI X570", 1200.21, true, false, "Low-end", true, 128, "DDR4", 4400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0),
                new CPU("Ryzen 7 5800X", 1858.60, true, false, "Mid-end", 3.8, 4.7, 8, 16, "AM4", true, 4.0, 105),
                new CPUWaterCooling("ARCTIC LIQUID FREEZER II 360 A-RGB COOLER", 999, true, true, "Radiator full for rgp fans", "Copper, Micro-Skived-Fins", true, "1700, 1200, 115X, 2011-3*, 2066* *Square ILM, AM5, AM4", 3, 2.7, 240, "4-pin", "48.8", 2000,"0", "1.85", "NO RGP" ),
                new RAM("Corsair Vengeance RGB Black Pro 16GB", 543, true, true, "Mid-end ram", 16, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),
                new GPU("Gigabyte GeForce RTX 3070 TI", 5605.89, true, true, "Mid-end GPU", "NVIDIA GeForce RTX 3070 TI", 6144, true, "7680 x 4320", 8000, "GDDR6X SDRAM", 256, 850, 29.49, 4.0),
                new Mdot2("Samsung 980 PRO 2TB M.2-2280", 1346.40, true, true, "Mid-end", 1000, "M.2", 7000, 4.0),
                new PowerSupply("Asus ROG Strix 750 Modular", 1130.61, true, true, "Mid-end", "ATX", "Black", "Gold", 750, true, "Aktive"),
                new CaseFan("Arctic P12 PWM PST BLACK 120mm Fan", 59, true, true, "Black Airflow Fan which has a low noice level","Fluid Dynamic", 1.44, 120, "120" ,"3-pin", 56.3 , "200-1800", "1.79 m2/h","NO RGB")
                ),
            new PreBuildsClass("boll shark", 9999, "do you think i well get som puss if i show her that?", false,
                new Cases("Shark Gaming MaelStrom", 599, true, true, "A RGB flow case", "MiniTower (m-ATX)", "Black", 4, true, 210, 405, 425, "ATX", "2xUSB 3.0 & 1x USB 2.0 & HD Audio" ),
                new Motherboard("ASRock Z590 Extreme", 1681.73, false, true, "Mid-end", true, 128, "DDR4", 4800, "Motherboard - ATX", "Z590", "LGA 1200", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0),
                new CPU("Intel i5 11400 11th", 1164.72, false, true, "Low-end", 2.6, 4.4, 6, 12, "Socket 1200", false, 4.0, 65),
                new CPUWaterCooling("ARCTIC LIQUID FREEZER II 240 CPU KØLER - VANDKØLER", 649, true, true, "OUTSTANDING PERFORMANCE",   "Copper, Micro-Skived-Fins", true, "Intel® LGA2066 / LGA 2011-3 / 2011 / 1366 / 1156 / 1155 / 1151 / 1150 / 775 socket , AMD® AM4 / AM3+ / AM3 / AM2+ / FM2+ / FM2 / FM1 socket", 2, 2.7, 240, "4-pin", "48.8", 1800,"0", "1.85", "NO RGP" ),
                new RAM("Kingston FURY Beast 16GB", 262.88, true, true, "Low-end ram", 16, "DDR4", "DIMM 288-pin", 3200, "CL 18", 1.35, "RGB"),
                new GPU("MSI GeForce RTX 3060 TI Ventus", 3881.03, true, true, "Low-end GPU", "NVIDIA GeForce RTX 3060 TI", 4864, true, "7680 x 4320", 8000, "GDDR6X SDRAM", 256, 600, 21.31, 4.0),
                new SolidStateDrive("Samsung 870 QVO 2.5¨ SSD - 1TB", 618, true, true, "Low power DDR4 SDRAM", 1000, "2.5¨", 560, 530, 11000, 35000, "Quad-niveau celle"),
                new PowerSupply("NZXT C550", 784.76, true, true, "Low-end", "ATX", "Black", "Bronze", 550, false, "Aktive"),
                new CaseFan("ThermalTake Riing Plus 12 RGB SYNC Edition 3 Pack", 59, true, true, "Patented LED Design","Hydraulic bearing", 2.01, 120 ,"120","3-pin", 56.3 , "1800", "1.79 m2/h","RGB")
                )
        };


        public static List<PreBuildsClass> GetMockPreBuilds()
        {
            return _prebuilds;
        }

    }
}
