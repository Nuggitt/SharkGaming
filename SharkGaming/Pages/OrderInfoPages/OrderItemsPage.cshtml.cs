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
        [BindProperty] public int productId { get; set; }
        
        
        


        public OrderItemsPageModel(IOrderRepositoryService orderService, IProductService productService)
        {
            
            _orderService = orderService;
            _productService = productService;
        }

        public List<OrderItemsClass> _orderItems { get; set; }
        

        public IActionResult OnGet()
        {
            _orderItems = _orderService.GetFromCart();
            return Page();
        }

        public IActionResult OnPostDeleteFromCart(int productId)
        {
            if (productId != null)
            {
                _orderService.DeleteFromCart(productId);
                return RedirectToPage("OrderItemsPage");
            }
            return Page();
            
        }



    }
}
