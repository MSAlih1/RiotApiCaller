using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionSkin
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
