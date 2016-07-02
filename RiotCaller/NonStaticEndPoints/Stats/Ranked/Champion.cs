using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Stats
{
    public class Champion
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }
}