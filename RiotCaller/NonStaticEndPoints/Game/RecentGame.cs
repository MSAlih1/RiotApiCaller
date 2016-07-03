using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.Game
{
    public class RecentGames
    {
        [JsonProperty("games")]
        public List<Game> Games { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }
}