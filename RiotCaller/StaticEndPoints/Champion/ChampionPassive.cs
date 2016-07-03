using Newtonsoft.Json;
using RiotCaller.StaticEndPoints.Item;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionPassive
    {
        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }
    }
}