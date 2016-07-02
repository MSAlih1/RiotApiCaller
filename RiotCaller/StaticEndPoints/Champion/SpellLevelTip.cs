using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class SpellLeveltip
    {
        [JsonProperty("effect")]
        public List<string> Effect { get; set; }

        [JsonProperty("label")]
        public List<string> Label { get; set; }
    }
}
