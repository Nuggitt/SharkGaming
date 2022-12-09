using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
        public class CasePage2Model : PageModel
        {

            private IProductService _productService;

            public CasePage2Model(IProductService iproductervice)
            {
                _productService = iproductervice;
            }
            public List<Cases>? components { get; private set; }


            public void OnGet()
            {
                components = _productService.GetCases();
            }
        }
}
