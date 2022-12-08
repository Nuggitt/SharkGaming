using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SharkGaming.Products
{
    public class ProductsClass
    {
        protected static int nextId = 0;

        public ProductsClass(string name, double price)
        {
            Price = price;
            Name = name;
            
        }

        public ProductsClass()
        {

        }

        [Display(Name = "Item ID")]
        [Required(ErrorMessage = "Der skal angives et ID til item")]
        [Range(typeof(int), "0", "10000", ErrorMessage = "ID skal være mellem {1} og {2}")]
        public int? Id { get; set; }

        [Display(Name = "Item Navn")]
        [Required(ErrorMessage = "Item skal have et navn"), MaxLength(20)]
        public string Name { get; set; }

        [Display(Name = "Pris")]
        [Required(ErrorMessage = "Der skal angives en pris")]
        [Range(typeof(double), "0", "10000", ErrorMessage = "Prisen skal være mellem {1} og {2}")]
        public double? Price { get; set; }
    }
}
