using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CpuWaterCoolingPage1Model : PageModel
    {

        private IProductService _productService;

        public CpuWaterCoolingPage1Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<Products.Components.ComponentTypes.Cooling.CPUWaterCooling>? cpuWaterCoolings { get; private set; }

        public void OnGet()
        {
            cpuWaterCoolings = _productService.GetCPUWaterCooling();
        }
    }
}
