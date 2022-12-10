using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class PowerSupplyPage2Model : PageModel
    {
        private IProductService _productService;

        public PowerSupplyPage1Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<PowerSupply>? components { get; private set; }

        public void OnGet()
        {
            components = _productService.GetPowerSupply();
        }
    }
}
