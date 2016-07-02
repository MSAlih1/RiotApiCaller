using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class SpellVar
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("coeff")]
        public List<double> Coeff { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
