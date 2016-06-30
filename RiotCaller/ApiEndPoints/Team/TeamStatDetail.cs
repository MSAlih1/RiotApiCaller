using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Team
{
    public class TeamStatDetail
    {
        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }
        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
