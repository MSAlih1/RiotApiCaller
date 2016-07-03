using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Realm
{
    public class RealmData
    {
        [JsonProperty("champion")]
        public string Champion { get; set; }

        [JsonProperty("profileicon")]
        public string Profileicon { get; set; }

        [JsonProperty("item")]
        public string İtem { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }

        [JsonProperty("mastery")]
        public string Mastery { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("summoner")]
        public string Summoner { get; set; }

        [JsonProperty("rune")]
        public string Rune { get; set; }
    }
}