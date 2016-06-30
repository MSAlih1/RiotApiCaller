using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Stats
{
    public class Champion
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }
}
