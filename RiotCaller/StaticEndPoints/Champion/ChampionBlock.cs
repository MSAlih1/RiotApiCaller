using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionBlock
    {
        [JsonProperty("recMath")]
        public bool RecMath { get; set; }

        [JsonProperty("items")]
        public List<Items> Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
