using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CasePage1Model : PageModel
    {

        private IProductService _productService;

        public CasePage1Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<RAM>? components { get; set; }

        public void OnGet()
        {
            components = _productService.GetRAM();
        }
    }
}
