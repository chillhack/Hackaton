using Newtonsoft.Json;

namespace ChillMapWeb.Controllers
{
    public class PositionDTO
    {
        public PositionDTO(int x, int y)
        {
            XPercents = x;
            YPercents = y;
        }

        [JsonProperty("x")] public int XPercents { get; }
        [JsonProperty("y")] public int YPercents { get; }
    }
}