using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components;
using System.Runtime.CompilerServices;

namespace SharkGaming.Pages.TestSite
{
    public class TestRoomModel : PageModel
    {


        public static List<ComponentsClass> components = new List<ComponentsClass>()
        {
            new ComponentsClass("Asus 570XX", 12999, true, false, "Very gut"),
            new ComponentsClass("Asus 590XX", 15999, true, false, "Very gut")
        };

        //TESTING NEXT ID NEVER TOUCH IT AGAIN

        public void OnGet()
        {

        }


    }
        
}
