using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.MockData.Products.Components.ComponentTypes.Ram;
using SharkGaming.Products.Components;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;
using System.Runtime.CompilerServices;

namespace SharkGaming.Pages.TestSite
{
    public class TestRoomModel : PageModel
    {


        public static List<CaseFan> component = new List<CaseFan>()
        {
        };

        public static List<RAM> components = new List<RAM>()
        {
        };

        //TESTING NEXT ID NEVER TOUCH IT AGAIN

        public void OnGet()
        {
            component = MockData.MProducts.MComponents.MComponentTypes.MCooling.MockCaseFan.GetMockCaseFans();
            components = MockRam.GetMockRam();

        }


    }
        
}
