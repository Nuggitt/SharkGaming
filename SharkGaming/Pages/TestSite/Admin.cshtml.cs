using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Services.ProductServiceFile;
using System.Reflection;

namespace SharkGaming.Pages.TestSite
{
    public class AdminModel : PageModel
    {

        private ProductService _productService;
        [BindProperty] public Products.Components.ComponentTypes.GPU.GPU GPU { get; set; }

        public AdminModel(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)
        
        {
            GPU = _productService.GetGPUs(id);
            if (GPU == null)
            {
                return RedirectToPage("/NotFound"); //Not found ikke defineret endnu

            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _productService.UpdateProduct(GPU);
            return RedirectToPage("GetAllItems");
        }






    }




}


        


    


    
    


