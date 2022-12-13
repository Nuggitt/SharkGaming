using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class RamPage1Model : PageModel
    {

        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }

        public RamPage1Model(IProductService iproductervice, IOrderRepositoryService orderRepositoryService)
        {
            _productService = iproductervice;
            _orderService = orderRepositoryService;
        }
        public List<RAM>? components { get; private set; }

        public void OnGet()
        {
            components = _productService.GetRAM();
        }

        public IActionResult OnPostAddToCart()
        {

            _orderService.AddToCart(productId, amount);
            return Page();
        }
    }
}
