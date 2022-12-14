using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class RamPage2Model : PageModel
    {
        private IProductService _productService;

        public RamPage2Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<RAM>? rams { get; set; }

        public void OnGet()
        {
            rams = _productService.GetRAM();
        }
    }
}
