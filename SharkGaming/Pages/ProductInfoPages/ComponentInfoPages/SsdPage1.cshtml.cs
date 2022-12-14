using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class SsdPage1Model : PageModel
    {
        private IProductService _productService;

        public SsdPage1Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<SolidStateDrive>? ssds { get; private set; }

        public void OnGet()
        {
            ssds = _productService.GetSolidStateDrives();
        }
    }
}
