using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class VarStatic
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("coeff")]
        public List<double> Coeff { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("ranksWith")]
        public string RanksWith { get; set; }

        [JsonProperty("dyn")]
        public string Dyn { get; set; }
    }
}