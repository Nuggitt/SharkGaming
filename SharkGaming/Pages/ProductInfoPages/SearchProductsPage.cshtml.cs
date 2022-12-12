using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Pages.Login;
using SharkGaming.Services.ProductServiceFile;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Products;

namespace SharkGaming.Pages.ProductInfoPages
{
    public class SearchProductsPageModel : PageModel
    {
       
        public IProductService _productService;
        public IOrderRepositoryService _orderService;


        [BindProperty] public string SearchString { get; set; }
        [BindProperty] public ProductsClass product { get; set; }
        [BindProperty] public int amount { get; set; }


        public List<Products.ProductsClass> Items { get; private set; } = new List<Products.ProductsClass>();
        

        public SearchProductsPageModel(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }

        public void OnGet()
        {
            
        }
        public IActionResult OnPostNameSearch()
        {
            Items = _productService.ProductNameSearch(SearchString).ToList();
            return Page();
        }
        public IActionResult OnPostAddToCart()
        {
            _orderService.AddToCart(product, amount);
            return Page();
        }
    }
}
