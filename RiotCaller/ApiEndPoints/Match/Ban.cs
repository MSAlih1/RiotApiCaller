using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{
    public class Ban
    {
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }
    }
}
