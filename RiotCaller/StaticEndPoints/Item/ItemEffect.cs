using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Item
{
    public class ItemEffect
    {
        [JsonProperty("Effect8Amount")]
        public string Effect8Amount { get; set; }

        [JsonProperty("Effect3Amount")]
        public string Effect3Amount { get; set; }

        [JsonProperty("Effect7Amount")]
        public string Effect7Amount { get; set; }

        [JsonProperty("Effect6Amount")]
        public string Effect6Amount { get; set; }

        [JsonProperty("Effect5Amount")]
        public string Effect5Amount { get; set; }

        [JsonProperty("Effect4Amount")]
        public string Effect4Amount { get; set; }

        [JsonProperty("Effect2Amount")]
        public string Effect2Amount { get; set; }

        [JsonProperty("Effect1Amount")]
        public string Effect1Amount { get; set; }
    }
}