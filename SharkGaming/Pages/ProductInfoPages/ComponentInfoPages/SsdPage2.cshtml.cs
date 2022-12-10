using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class SsdPage2Model : PageModel
    {
        private IProductService _productService;

        public SsdPage2Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<SolidStateDrive>? components { get; private set; }

        public void OnGet()
        {
            components = _productService.GetSolidStateDrives();
        }
    }
}
