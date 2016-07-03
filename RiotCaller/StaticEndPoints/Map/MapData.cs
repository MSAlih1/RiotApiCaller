using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Map
{
    public class MapData
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, MapDetail> Data { get; set; }
    }
}