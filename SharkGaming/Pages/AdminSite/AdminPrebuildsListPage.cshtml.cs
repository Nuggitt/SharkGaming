using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminPrebuildsListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminPrebuildsListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<ProductsClass> preBuildsClasses { get; private set; }


        public void OnGet()
        {
            preBuildsClasses = _productService.GetPreBuilds();
        }
    }
}
