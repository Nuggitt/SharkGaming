using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.MockData.MProducts.MComponents.MComponentTypes;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CasePage1Model : PageModel
    {

        private IProductService _productService;

        public CasePage1Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<Cases> components { get; set; }

        public void OnGet()
        {
            components = _productService.GetCases();
        }
    }
}
