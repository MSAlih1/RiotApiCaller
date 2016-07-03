using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionSkin
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}