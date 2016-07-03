using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Mastery
{
    public class MasteryData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("data")]
        public Dictionary<int, Mastery> Data { get; set; }

        [JsonProperty("tree")]
        public MasteryTrees Tree { get; set; }
    }
}