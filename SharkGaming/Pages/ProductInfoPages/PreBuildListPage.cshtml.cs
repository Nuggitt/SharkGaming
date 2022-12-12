using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages
{
    public class PreBuildListPageModel : PageModel
    {
        public string img = "/Images/Components/Case1.png";
        private IProductService _productService;

        public PreBuildListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<PreBuildsClass>? preBuilds { get; private set; }


        public void OnGet()
        {
            preBuilds = _productService.GetPreBuilds();
        }
    }
}
