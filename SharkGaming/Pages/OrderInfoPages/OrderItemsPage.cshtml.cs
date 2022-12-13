using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;
using System.Reflection;

namespace SharkGaming.Pages.OrderInfoPages
{
    public class OrderItemsPageModel : PageModel
    {
        private IOrderRepositoryService _orderService;
        private IProductService _productService;


        public OrderItemsPageModel(OrderRepositoryService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
        }

        //public List<> _productsadded { get; private set; }

        //public void OnGet()
        //{
        //    _productsadded = _productService.GetOrderItems();
        //}



    }
}
