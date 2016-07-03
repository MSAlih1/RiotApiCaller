using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.ChampionRotation
{
    public class ChampionRotation
    {
        [JsonProperty("champions")]
        public List<ChampionStatus> Champions { get; set; }
    }
}