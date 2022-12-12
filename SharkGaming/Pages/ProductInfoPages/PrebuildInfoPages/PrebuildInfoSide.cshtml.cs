using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.PrebuildInfoPages
{
    public class PrebuildInfoSideModel : PageModel
    {
        private IProductService _productService;

        public PrebuildInfoSideModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<ProductsClass>? components { get; private set; }


        public void OnGet()
        {
            components = _productService.GetPreBuilds();
        }
    }
}
