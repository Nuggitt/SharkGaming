using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class GpuPage3Model : PageModel
    {
        private IProductService _productService;

        public GpuPage3Model(IProductService iproductervice)
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
