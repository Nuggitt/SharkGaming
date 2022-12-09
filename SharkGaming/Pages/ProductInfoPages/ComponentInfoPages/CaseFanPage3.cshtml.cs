using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CaseFanPage3Model : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;

        public CaseFanPage3Model(IProductService iproductervice)
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
            //_orderService.AddToOrderItems(orderItemList);

        }
    }
}
