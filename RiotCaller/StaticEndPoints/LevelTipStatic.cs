using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class LevelTipStatic
    {
        [JsonProperty("effect")]
        public List<string> Effect { get; set; }

        [JsonProperty("label")]
        public List<string> Label { get; set; }
    }
}