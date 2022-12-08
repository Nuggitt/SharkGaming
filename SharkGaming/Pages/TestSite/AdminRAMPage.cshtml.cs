using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.TestSite
{
    public class AdminRAMPageModel : PageModel
    {
        private IProductService _productService;

        public AdminRAMPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<RAM> ram { get; private set; }


        public void OnGet()
        {
            ram = _productService.GetRAM();
        }
    }
}
