using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class MotherBoardPage3Model : PageModel
    {
        private IProductService _productService;

        public MotherBoardPage3Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<Motherboard>? motherboards { get; private set; }

        public void OnGet()
        {
            motherboards = _productService.GetMotherboards();
        }
    }
}
