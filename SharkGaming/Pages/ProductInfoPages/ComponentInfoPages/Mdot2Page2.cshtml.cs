using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class Mdot2Page2Model : PageModel
    {
        private IProductService _productService;

        public Mdot2Page2Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<Mdot2>? components { get; private set; }

        public void OnGet()
        {
            components = _productService.GetMdot2();
        }
    }
}
