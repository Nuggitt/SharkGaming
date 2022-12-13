using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.OrderFile;
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
        


        public OrderItemsPageModel(IOrderRepositoryService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
        }

        public List<OrderItemsClass> orderItemList { get; set; }

        public IActionResult OnGet()
        {
            orderItemList = _orderService.GetFromCart();
            return Page();
        }

        public IActionResult OnPostDeleteFromCart(int? itemId)
        {
            if (itemId != null)
            {
                _orderService.DeleteFromCart(itemId);
                return Page();
            }
            return Page();
            
        }



    }
}
