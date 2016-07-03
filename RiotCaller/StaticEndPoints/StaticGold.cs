using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Item
{
    public class StaticGold
    {
        [JsonProperty("base")]
        public int Base { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("sell")]
        public int Sell { get; set; }

        [JsonProperty("purchasable")]
        public bool Purchasable { get; set; }
    }
}