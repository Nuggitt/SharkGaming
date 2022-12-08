using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Services.ProductServiceFile;
using System.Reflection;

namespace SharkGaming.Pages.TestSite
{
    public class AdminModel : PageModel
    {

        private IProductService _productService;
        [BindProperty] public Products.ProductsClass products { get; set; }

        public AdminModel(IProductService productService)
        {
            _productService = productService;
        }

        //public IActionResult OnGet(int id)

        //{
        //    products = _productService.GetProduct(id);
        //    if (products == null)
        //    {
        //        return RedirectToPage("/NotFound"); //Not found ikke defineret endnu

        //    }
        //    return Page();
        //}

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _productService.UpdateProduct(products);
            return RedirectToPage("Index");
        }






    }




}


        


    


    
    


