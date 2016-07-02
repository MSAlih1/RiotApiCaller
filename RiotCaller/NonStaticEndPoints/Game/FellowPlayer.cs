using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.EndPoints.Game
{
    public class FellowPlayer
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

}
