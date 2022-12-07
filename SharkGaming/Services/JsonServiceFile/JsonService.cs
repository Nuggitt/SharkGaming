using SharkGaming.Products;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using System.Text.Json;

namespace SharkGaming.Services.JsonServiceFile
{
    public class JsonService
    {

        public IWebHostEnvironment WebHostEnvironment { get; }

        public JsonService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "ComponentsRAM.json"); }
        }

        public void SaveJsonRAM(List<RAM> rAMs)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<RAM[]>(jsonWriter, rAMs.ToArray());
            }
        }
        public void SaveJsonProducts(List<ProductsClass> products)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<ProductsClass[]>(jsonWriter,products.ToArray());
            }
        }

        public IEnumerable<RAM> GetJsonRAM()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<RAM[]>(jsonFileReader.ReadToEnd());
            }
        }
        public IEnumerable<ProductsClass> GetJsonProducts()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<ProductsClass[]>(jsonFileReader.ReadToEnd());
            }
        }

    }
}
