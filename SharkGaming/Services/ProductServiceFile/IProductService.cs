using SharkGaming.Products;
using SharkGaming.Products.Components;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CaseFan;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CPUCooling;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CPUCooling.CPUAirCooling;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CPUCooling.CPUWaterCooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.Components.ComponentTypes.Storage.Mdot2;
using SharkGaming.Products.Components.ComponentTypes.Storage.SolidStateDrive;
using SharkGaming.Products.CustomPc;
using SharkGaming.Products.PreBuilds;

namespace SharkGaming.Services.ProductServiceFile
{
    public interface IProductService
    {
        #region Get
        List<ProductsClass> GetAllProducts();
        List<ComponentsClass> GetAllComponents();
        List<PreBuildsClass> GetPreBuilds();
        List<CustomPcClass> GetCustomPc();
        List<Cases> GetCases();
        List<CoolingClass> GetAllCooling();
        List<CaseFan> GetCaseFans();
        List<CPUCooling> GetCPUCooling();
        List<CPUAirCooling> GetCPUAirCooling();
        List<CPUWaterCooling> GetCPUWaterCooling();
        List<CPU> GetCPUs();
        List<GPU> GetGPUs();
        List<Motherboard> GetMotherboards();
        List<PowerSupply> GetPowerSupply();
        List<RAM> GetRAM();
        List<StorageClass> GetStorage();
        List<Mdot2> GetMdot2();
        List<SolidStateDrive> GetSolidStateDrives();
        #endregion

        #region Add
        void AddProduct();
        void AddComponent();
        void AddPreBuild();
        void AddCustomPc();
        void AddCase();
        void AddCooling();
        void AddCaseFan();
        void AddCPUCooling();
        void AddCPUAirCooling();
        void AddCPUWaterCooling();
        void AddCPU();
        void AddGPU();
        void AddMotherboard();
        void AddPowerSupply();
        void AddRAM();
        void AddStorage();
        void AddMdot2();
        void AddSolidStateDrive();
        #endregion

        IEnumerable<ProductsClass> NameSearch(string str);
        IEnumerable<ProductsClass> PriceFilter(double maxPrice, double minPrice = 0);
    }
}
