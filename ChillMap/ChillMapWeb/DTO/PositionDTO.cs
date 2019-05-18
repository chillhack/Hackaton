using Newtonsoft.Json;

namespace ChillMapWeb.Controllers
{
    public class PositionDTO
    {
        public PositionDTO(string xPercents, string yPercents)
        {
            XPercents = xPercents;
            YPercents = yPercents;
        }

        [JsonProperty("x")] public string XPercents { get; }
        [JsonProperty("y")] public string YPercents { get; }
    }
}