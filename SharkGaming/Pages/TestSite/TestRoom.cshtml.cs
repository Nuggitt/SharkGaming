using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.MockData.MProducts.MComponents.MComponentTypes;
using SharkGaming.MockData.Products.PreBuilds;
using SharkGaming.Products;
using SharkGaming.Products.Components;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
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



        public List<ProductsClass> Products { get; set; }
        public List<Cases> cases { get; set; }
        public List<CaseFan> caseFan { get; set; }
        public List<CPUAirCooling> cPUAirCoolings { get; set; }
        public List<CPUWaterCooling> cPUWaterCoolings { get; set; }
        public List<CPU> cPU { get; set; }
        public List<GPU> gPU { get; set; }
        public List<Motherboard> motherboards { get; set; }
        public List<PowerSupply> powerSupplies { get; set; }
        public List<RAM>? ram { get; set; }
        public List<Mdot2> mdot2s { get; set; }
        public List<SolidStateDrive> solidStateDrives { get; set; }


        public void OnGet()
        {
            //Products = MockPreBuilds.GetMockPreBuilds();
            cases = MockCaseS.GetMockCases();
            caseFan = MockCaseFan.GetMockCaseFans();
            cPUAirCoolings = MockCPUAirCooling.GetMockCPUAirCoolings();
            cPUWaterCoolings = MockCPUWaterCooling.GetMockCPUWaterCooling();
            cPU = MockCPU.GetMockCPUs();
            gPU = MockGPU.GetMockGPUs();
            motherboards = MockMotherboard.GetMockMotherboards();
            powerSupplies = MockPowerSupply.GetMockPowerSupplies();
            ram = MockRam.GetMockRam();
            mdot2s = MockMdot.GetMockMdot2s();
            solidStateDrives = MockSolidStateDrive.GetMockSoildSateDrives();

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
