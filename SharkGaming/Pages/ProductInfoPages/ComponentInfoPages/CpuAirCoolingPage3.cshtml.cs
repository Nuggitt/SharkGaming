using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CpuAirCoolingPage3Model : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;

        public CpuAirCoolingPage3Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<CPUAirCooling> cpuAirCoolings { get; set; }
        public List<ProductsClass> orderItemList { get; set; }

        public void OnGet()
        {
            cpuAirCoolings = _productService.GetCPUAirCooling();
        }

        public void OnPost()
        {
            //_orderService.AddToOrderItems(orderItemList);

        }
    }
}
