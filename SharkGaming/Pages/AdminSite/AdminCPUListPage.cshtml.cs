using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminCPUListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminCPUListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<CPU> cPUs { get; private set; }


        public void OnGet()
        {
            cPUs = _productService.GetCPUs();
        }
    }
}
