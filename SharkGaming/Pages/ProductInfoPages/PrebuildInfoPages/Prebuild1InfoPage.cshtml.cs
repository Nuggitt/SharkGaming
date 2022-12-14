using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.PrebuildInfoPages
{
    public class Prebuild1InfoPageModel : PageModel
    {
        private IProductService _productService;

        public Prebuild1InfoPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<PreBuildsClass>? preBuids { get; private set; }


        public void OnGet()
        {
            preBuilds = _productService.GetPreBuilds();
        }
    }
}
