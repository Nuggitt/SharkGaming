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
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Componets.json"); }
        }


    }
}
