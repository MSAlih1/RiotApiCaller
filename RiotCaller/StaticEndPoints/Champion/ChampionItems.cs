using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionItems
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}