using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CpuWaterCoolingPage3Model : PageModel
    {
        private IProductService _productService;

        public CpuWaterCoolingPage3Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<Products.Components.ComponentTypes.Cooling.CPUWaterCooling>? components { get; private set; }

        public void OnGet()
        {
            components = _productService.GetCPUWaterCooling();
        }
    }
}
