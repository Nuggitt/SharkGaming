using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CpuPage3Model : PageModel
    {
        private IProductService _productService;

        public CpuPage3Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<CPU>? components { get; private set; }

        public void OnGet()
        {
            components = _productService.GetCPUs();
        }
    }
}
