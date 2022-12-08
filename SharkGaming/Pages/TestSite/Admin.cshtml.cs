using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;
using System.Reflection;

namespace SharkGaming.Pages.TestSite
{
    public class AdminModel : PageModel
    {

        private IProductService _productService;
        [BindProperty] public RAM ram { get; set; }

        public AdminModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            ram = _productService.GetRAMs(id);
            if (ram == null)
            {
                return RedirectToPage("TestRoom"); //Not found ikke defineret endnu

            }
            return Page();
        }

        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            _productService.UpdateRAM(ram);
            return RedirectToPage("AdminRAMPage");
        }






    }




}


        


    


    
    


