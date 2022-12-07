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

        public void SaveJsonItems(List<RAM> _rAMs)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<RAM[]>(jsonWriter, _rAMs.ToArray());
            }
        }

        public IEnumerable<RAM> GetJsonItems()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<RAM[]>(jsonFileReader.ReadToEnd());
            }
        }

    }
}
