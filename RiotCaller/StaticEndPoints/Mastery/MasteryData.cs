using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Mastery
{
    public class MasteryData
    {
        [JsonProperty("data")]
        public Dictionary<int, Mastery> Data { get; set; }

        [JsonProperty("tree")]
        public MasteryTrees Tree { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}