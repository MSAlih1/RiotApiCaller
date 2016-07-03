using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.LanguageStrings
{
    public class LanguageStrings
    {
        [JsonProperty("data")]
        public Dictionary<string, string> Data { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}