using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages
{
    public class PreBuildListPageModel : PageModel
    {
        private IProductService _productService;

        public PreBuildListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<ProductsClass>? preBuilds { get; private set; }


        public void OnGet()
        {
            preBuilds = _productService.GetPreBuilds();
        }
    }
}
