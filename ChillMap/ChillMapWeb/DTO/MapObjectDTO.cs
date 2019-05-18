using Newtonsoft.Json;

namespace ChillMapWeb.Controllers
{
    public class MapObjectDTO
    {
        public MapObjectDTO(string resourcePath, string xPercents, string yPercents)
        {
            ResourcePath = resourcePath;
            XPercents = xPercents;
            YPercents = yPercents;
        }

        [JsonProperty("path")] public string ResourcePath { get; }
        [JsonProperty("x")] public string XPercents { get; }
        [JsonProperty("y")] public string YPercents { get; }
    }
}