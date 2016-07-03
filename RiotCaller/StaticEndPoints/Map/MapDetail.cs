using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Map
{
    public class MapDetail
    {
        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("image")]
        public MapImage Image { get; set; }

        [JsonProperty("mapName")]
        public string MapName { get; set; }

        public override string ToString()
        {
            return MapName;
        }
    }
}