using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class GpuPage1Model : PageModel
    {
        private IProductService _productService;

        public GpuPage1Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<GPU>? gpus { get; private set; }

        public void OnGet()
        {
            gpus = _productService.GetGPUs();
        }
    }
}
