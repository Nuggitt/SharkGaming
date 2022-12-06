using SharkGaming.Products;
using SharkGaming.Products.Components;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CaseFan;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CPUCooling;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CPUCooling.CPUAirCooling;
using SharkGaming.Products.Components.ComponentTypes.Cooling.CPUCooling.CPUWaterCooling;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.PreBuilds;

namespace SharkGaming.Services.ProductServiceFile
{
    public interface IProductService
    {
        List<ProductsClass> GetAllProducts();
        List<ComponentsClass> GetAllComponents();
        List<PreBuildsClass> GetPreBuilds();
        List<Cases> GetCases();
        List<CoolingClass> GetAllCooling();
        List<CaseFan> GetCaseFans();
        List<CPUCooling> GetCPUCooling();
        List<CPUAirCooling> GetCPUAirCooling();
        List<CPUWaterCooling> GetCPUWaterCooling();



    }
}
