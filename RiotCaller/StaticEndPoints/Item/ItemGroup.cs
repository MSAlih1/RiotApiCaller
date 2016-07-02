using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Item
{
    public class ItemGroup
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }
    }
}