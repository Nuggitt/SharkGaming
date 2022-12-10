using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class MotherBoardPage1Model : PageModel
    {
        private IProductService _productService;

        public MotherBoardPage1Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<Motherboard>? components { get; private set; }

        public void OnGet()
        {
            components = _productService.GetMotherboards();
        }
    }
}
