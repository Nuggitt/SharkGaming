using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products;
using SharkGaming.Products.Components;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;
using System.Runtime.CompilerServices;

namespace SharkGaming.Pages.TestSite
{
    public class TestRoomModel : PageModel
    {
        private IProductService _productService;

        public TestRoomModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        //public List<RAM>? components { get; set; }

        public List<ProductsClass> Products { get; set; }


        public void OnGet()
        {
            //components = _productService.GetRAM();
            //Products = _productService.GetPreBuilds();
        }


        //public List<CaseFan> component { get; private set; }

        //public List<ProductsClass> ? products { get; private set; }

        //public List<CPU> componen { get; private set; }

        ////TESTING NEXT ID NEVER TOUCH IT AGAIN

        //public void OnGet()
        //{
        //    component = MockData.MProducts.MComponents.MComponentTypes.MCooling.MockCaseFan.GetMockCaseFans();
        //    components = MockRam.GetMockRam();
        //    componen = MockCPU.GetMockCPUs();

        //}


    }

}
