using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.MockData.MProducts.MComponents.MComponentTypes;
using SharkGaming.OrderFile;
using SharkGaming.Products;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CasePage1Model : PageModel
    {

        private IProductService _productService;
        private IOrderRepositoryService _orderService;

        public CasePage1Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<Cases> components { get; set; }
        public List<ProductsClass> orderItemList { get; set; }

        public void OnGet()
        {
            components = _productService.GetCases();
        }

        public void OnPost()
        {
            _orderService.AddToOrderItems(orderItemList);

        }
    }
}
