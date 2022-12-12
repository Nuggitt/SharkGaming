using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Pages.Login;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages
{
    public class SearchProductsPageModel : PageModel
    {
       
        public ProductService _productService;


        [BindProperty] public string SearchString { get; set; }
       
        
        public List<Products.ProductsClass> Items { get; private set; } = new List<Products.ProductsClass>();
        

        public SearchProductsPageModel( )
        {
            

        }

        public void OnGet()
        {
            
        }
        public IActionResult OnPostNameSearch()
        {
            Items = _productService.ProductNameSearch(SearchString).ToList();
            return Page();
        }
    }
}
