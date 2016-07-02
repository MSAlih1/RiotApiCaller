using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionPassive
    {
        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public ChampionImage Image { get; set; }
    }
}
