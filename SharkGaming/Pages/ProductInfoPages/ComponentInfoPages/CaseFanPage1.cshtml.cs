using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;
using SharkGaming.Products.Components.ComponentTypes.Cooling;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CaseFanPage1Model : PageModel
    {

        private IProductService _productService;
        private IOrderRepositoryService _orderService;

        public CaseFanPage1Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<CaseFan> components { get; set; }
        public List<ProductsClass> orderItemList { get; set; }

        public void OnGet()
        {
            components = _productService.GetCaseFan();
        }

        public void OnPost()
        {
            _orderService.AddToOrderItems(orderItemList);

        }
    }
}
