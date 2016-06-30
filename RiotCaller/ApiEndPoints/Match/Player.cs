using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{
    public class Player
    {
        [JsonProperty("profileIcon")]
        public int ProfileIcon { get; set; }

        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
