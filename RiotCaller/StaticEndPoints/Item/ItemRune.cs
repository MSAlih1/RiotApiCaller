using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Item
{
    public class ItemRune
    {
        [JsonProperty("isRune")]
        public bool IsRune { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}