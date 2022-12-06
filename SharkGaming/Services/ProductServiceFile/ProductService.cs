using SharkGaming.Products.Components.ComponentTypes.Cooling.CaseFan;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CPUCooling.CPUAirCooling;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CPUCooling.CPUWaterCooling;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CPUCooling;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.Components.ComponentTypes.Storage.Mdot2;
using SharkGaming.Products.Components.ComponentTypes.Storage.SolidStateDrive;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products.Components;
using SharkGaming.Products.CustomPc;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Products;
using SharkGaming.MockData;

namespace SharkGaming.Services.ProductServiceFile
{
    public class ProductService
    {
        private List<ProductsClass> _products;
        private List<ComponentsClass> _components;
        private List<PreBuildsClass> _preBuilds;
        private List<CustomPcClass> _customPcs;
        private List<Cases> _cases;
        private List<CoolingClass> _cooling;
        private List<CaseFan> _caseFans;
        private List<CPUCooling> _cPUCooling;
        private List<CPUAirCooling> _cPUAirCooling;
        private List<CPUWaterCooling> _cPUWaterCooling;
        private List<CPU> _cPUs;
        private List<GPU> _gPUs;
        private List<Motherboard> _motherboards;
        private List<PowerSupply> _powerSupplies;
        private List<RAM> _rAMs;
        private List<StorageClass> _storage;
        private List<Mdot2> _mdot2s;
        private List<SolidStateDrive> _solidStateDrives;

        //public ProductService() 
        //{
        //    _products = MockItems.GetMockProducts();
        //    _components = MockItems.GetMockComponents();
        //    _preBuilds = MockItems.GetMockPreBuilds();
        //    _customPcs = MockItems.GetMockCustomPcs();
        //    _cases = MockItems.GetMockCases();
        //    _cooling = MockItems.GetMockCooling();
        //    _caseFans = MockItems.GetMockCaseFans();
        //    _cPUCooling = MockItems.GetMockCPUCooling();
        //    _cPUAirCooling = MockItems.GetMockCPUAirCooling();
        //    _cPUWaterCooling = MockItems.GetMockCPUWaterCooling();
        //    _cPUs = MockItems.GetMockCPUs();
        //    _gPUs = MockItems.GetMockGPUs();
        //    _motherboards = MockItems.GetMockMotherboards();
        //    _powerSupplies = MockItems.GetMockPowerSupplies();
        //    _storage = MockItems.GetMockStorage();
        //    _mdot2s = MockItems.GetMockMdot2s();
        //    _solidStateDrives = MockItems.GetMockSolidStateDrives();
        //}

        public void AddItem(ProductsClass product)
        {
            _products.Add(product);
        }
    }
}
